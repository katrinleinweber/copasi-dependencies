/**
 * @cond doxygenLibsbmlInternal
 *
 * @file    SubmodelReferenceCycles.cpp
 * @brief   Ensures unique variables assigned by rules and events
 * @author  Sarah Keating
 * 
 * <!--------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright (C) 2009-2013 jointly by the following organizations: 
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EBML-EBI), Hinxton, UK
 *  
 * Copyright (C) 2006-2008 by the California Institute of Technology,
 *     Pasadena, CA, USA 
 *  
 * Copyright (C) 2002-2005 jointly by the following organizations: 
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. Japan Science and Technology Agency, Japan
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * ---------------------------------------------------------------------- -->*/

#include <cstring>

#include <sbml/Model.h>
#include <sbml/packages/comp/extension/CompModelPlugin.h>
#include <sbml/packages/comp/extension/CompSBMLDocumentPlugin.h>
#include <sbml/packages/comp/util/SBMLResolverRegistry.h>

#include "SubmodelReferenceCycles.h"
#include <sbml/util/IdList.h>

/** @cond doxygenIgnored */

using namespace std;

/** @endcond */

LIBSBML_CPP_NAMESPACE_BEGIN

/**
 * Creates a new Constraint with the given constraint id.
 */
SubmodelReferenceCycles::SubmodelReferenceCycles (unsigned int id, Validator& v) :
  TConstraint<Model>(id, v)
{
}


/**
 * Destroys this Constraint.
 */
SubmodelReferenceCycles::~SubmodelReferenceCycles ()
{
}


/**
 * Checks that all ids on the following Model objects are unique:
 * event assignments and assignment rules.
 */
void
SubmodelReferenceCycles::check_ (const Model& m, const Model& object)
{
  mIdMap.clear();

  addAllReferences(&m);

  determineAllDependencies();

  determineCycles(m);
}

void
SubmodelReferenceCycles::addAllReferences(const Model* m)
{
  if (m == NULL)
  {
    return;
  }

  const CompSBMLDocumentPlugin* docPlug = (CompSBMLDocumentPlugin*)
      (m->getSBMLDocument()->getPlugin("comp"));
  const CompModelPlugin* modelPlug = (CompModelPlugin*)(m->getPlugin("comp"));

  if (docPlug == NULL || modelPlug == NULL)
  {
    return;
  }

  if (modelPlug->getNumSubmodels() == 0)
  {
    return;
  }

  std::string modelId = m->isSetId() ? m->getId() : "tempId";

  addModelReferences(modelId, modelPlug);
    
  for (unsigned int i = 0; i < docPlug->getNumModelDefinitions(); i++)
  {
    const Model * newModel = static_cast<const Model *>
                              (docPlug->getModelDefinition(i));
    const CompModelPlugin* newModelPlug = (CompModelPlugin*)
                              (newModel->getPlugin("comp"));

    addModelReferences(newModel->getId(), newModelPlug);
  }
}
 
void 
SubmodelReferenceCycles::addModelReferences(const std::string &id, 
                          const CompModelPlugin* modelPlug)
{
  for (unsigned int i = 0; i < modelPlug->getNumSubmodels(); i++)
  {
    std::string modelRef = modelPlug->getSubmodel(i)->getModelRef();
    mIdMap.insert(pair<const std::string, std::string>(id, modelRef));
  }
}


void 
SubmodelReferenceCycles::determineAllDependencies()
{
  IdIter iterator;
  IdIter inner_it;
  IdRange range;

  /* for each pair in the map (x, y)
   * retrieve all other pairs where y is first (e.g. (y, s))
   * and create pairs showing that x depends on these e.g. (x, s)
   * check whether the pair already exists in the map
   * and add it if not
   */
  for (iterator = mIdMap.begin(); iterator != mIdMap.end(); iterator++)
  {
    range = mIdMap.equal_range((*iterator).second);
    for (inner_it = range.first; inner_it != range.second; inner_it++)
    {
      const pair<const std::string, std::string> &depend = 
            pair<const std::string, std::string>((*iterator).first, (*inner_it).second);
      if (!alreadyExistsInMap(mIdMap, depend))
        mIdMap.insert(depend);
    }
  }
}


bool 
SubmodelReferenceCycles::alreadyExistsInMap(IdMap map, 
                                     pair<const std::string, std::string> dependency)
{
  bool exists = false;

  IdIter it;
  
  for (it = map.begin(); it != map.end(); it++)
  {
    if (((*it).first == dependency.first)
      && ((*it).second == dependency.second))
      exists = true;
  }

  return exists;
}

  
void 
SubmodelReferenceCycles::determineCycles(const Model& m)
{
  IdIter it;
  IdRange range;
  IdList variables;
  IdMap logged;
  std::string id;
  variables.clear();

  /* create a list of variables that are cycles ie (x, x) */
  for (it = mIdMap.begin(); it != mIdMap.end(); it++)
  {
    if ((*it).first == (*it).second)
    {
      id = (*it).first;
      if (!variables.contains(id))
      {
        variables.append(id);
      }
    }
  }

  /* loop thru other dependencies for each; if the dependent is also
   * in the list then this is the cycle
   * keep a record of logged dependencies to avoid logging twice
   */
   
  for (unsigned int n = 0; n < variables.size(); n++)
  {
    id = variables.at(n);
    range = mIdMap.equal_range(id);
    for (it = range.first; it != range.second; it++)
    {
      if (((*it).second != id)
        && (variables.contains((*it).second))
        && !alreadyExistsInMap(logged, pair<const std::string, std::string>(id, (*it).second))
        && !alreadyExistsInMap(logged, pair<const std::string, std::string>((*it).second, id)))
      {
        logCycle(m, id, (*it).second);
        logged.insert(pair<const std::string, std::string>(id, (*it).second));
      }
    }
  }
}
 

/**
  * Logs a message about an undefined <ci> element in the given
  * FunctionDefinition.
  */
void
SubmodelReferenceCycles::logCycle (const Model& m, std::string id,
                                std::string id1)
{
  msg = "Model with id '";
  msg += id;
  msg += "' is referenced by with the model with id '"; 
  msg += id1;
  msg += "'.";

  // want to log the error on a comp object
  COMP_CREATE_NS(compns, m.getSBMLNamespaces());
  Submodel *sub = new Submodel(compns);
  logFailure(*(sub));
}  


LIBSBML_CPP_NAMESPACE_END


/** @endcond */
