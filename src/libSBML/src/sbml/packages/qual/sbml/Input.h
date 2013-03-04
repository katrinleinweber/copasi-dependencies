/**
 * @file:   Input.h
 * @brief:  Implementation of the Input class
 * @author: Generated by autocreate code
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
 * ------------------------------------------------------------------------ -->
 */


#ifndef Input_H__
#define Input_H__


#include <sbml/common/extern.h>
#include <sbml/common/sbmlfwd.h>
#include <sbml/packages/qual/common/qualfwd.h>

LIBSBML_CPP_NAMESPACE_BEGIN

typedef enum
{
    INPUT_TRANSITION_EFFECT_NONE
  , INPUT_TRANSITION_EFFECT_CONSUMPTION
  , INPUT_TRANSITION_EFFECT_UNKNOWN
} InputTransitionEffect_t;

typedef enum
{
    INPUT_SIGN_POSITIVE
  , INPUT_SIGN_NEGATIVE
  , INPUT_SIGN_DUAL
  , INPUT_SIGN_UNKNOWN
  , INPUT_SIGN_VALUE_NOTSET
} InputSign_t;

LIBSBML_CPP_NAMESPACE_END


#ifdef __cplusplus


#include <string>


#include <sbml/SBase.h>
#include <sbml/ListOf.h>
#include <sbml/packages/qual/extension/QualExtension.h>


LIBSBML_CPP_NAMESPACE_BEGIN


class LIBSBML_EXTERN Input : public SBase
{

protected:

	std::string   mId;
	std::string   mQualitativeSpecies;
	InputTransitionEffect_t   mTransitionEffect;
	std::string   mName;
	InputSign_t   mSign;
	int           mThresholdLevel;
	bool          mIsSetThresholdLevel;


public:

	/**
	 * Creates a new Input with the given level, version, and package version.
	 *
	 * @param level an unsigned int, the SBML Level to assign to this Input
	 *
	 * @param version an unsigned int, the SBML Version to assign to this Input
	 *
	 * @param pkgVersion an unsigned int, the SBML Qual Version to assign to this Input
	 */
	Input(unsigned int level      = QualExtension::getDefaultLevel(),
	      unsigned int version    = QualExtension::getDefaultVersion(),
	      unsigned int pkgVersion = QualExtension::getDefaultPackageVersion());


	/**
	 * Creates a new Input with the given QualPkgNamespaces object.
	 *
	 * @param qualns the QualPkgNamespaces object
	 */
	Input(QualPkgNamespaces* qualns);


 	/**
	 * Copy constructor for Input.
	 *
	 * @param orig; the Input instance to copy.
	 */
	Input(const Input& orig);


 	/**
	 * Assignment operator for Input.
	 *
	 * @param rhs; the object whose values are used as the basis
	 * of the assignment
	 */
	Input& operator=(const Input& rhs);


 	/**
	 * Creates and returns a deep copy of this Input object.
	 *
	 * @return a (deep) copy of this Input object.
	 */
	virtual Input* clone () const;


 	/**
	 * Destructor for Input.
	 */
	virtual ~Input();


 	/**
	 * Returns the value of the "id" attribute of this Input.
	 *
	 * @return the value of the "id" attribute of this Input as a string.
	 */
	virtual const std::string& getId() const;


	/**
	 * Returns the value of the "qualitativeSpecies" attribute of this Input.
	 *
	 * @return the value of the "qualitativeSpecies" attribute of this Input as a string.
	 */
	virtual const std::string& getQualitativeSpecies() const;


	/**
	 * Returns the value of the "transitionEffect" attribute of this Input.
	 *
	 * @return the value of the "transitionEffect" attribute of this Input as a string.
	 */
	const InputTransitionEffect_t getTransitionEffect() const;


	/**
	 * Returns the value of the "name" attribute of this Input.
	 *
	 * @return the value of the "name" attribute of this Input as a string.
	 */
	virtual const std::string& getName() const;


	/**
	 * Returns the value of the "sign" attribute of this Input.
	 *
	 * @return the value of the "sign" attribute of this Input as a string.
	 */
	const InputSign_t getSign() const;


	/**
	 * Returns the value of the "thresholdLevel" attribute of this Input.
	 *
	 * @return the value of the "thresholdLevel" attribute of this Input as a integer.
	 */
	virtual const int getThresholdLevel() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * Input's "id" attribute has been set.
	 *
	 * @return @c true if this Input's "id" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetId() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * Input's "qualitativeSpecies" attribute has been set.
	 *
	 * @return @c true if this Input's "qualitativeSpecies" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetQualitativeSpecies() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * Input's "transitionEffect" attribute has been set.
	 *
	 * @return @c true if this Input's "transitionEffect" attribute has been set,
	 * otherwise @c false is returned.
	 */
	bool isSetTransitionEffect() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * Input's "name" attribute has been set.
	 *
	 * @return @c true if this Input's "name" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetName() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * Input's "sign" attribute has been set.
	 *
	 * @return @c true if this Input's "sign" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetSign() const;


	/**
	 * Predicate returning @c true or @c false depending on whether this
	 * Input's "thresholdLevel" attribute has been set.
	 *
	 * @return @c true if this Input's "thresholdLevel" attribute has been set,
	 * otherwise @c false is returned.
	 */
	virtual bool isSetThresholdLevel() const;


	/**
	 * Sets the value of the "id" attribute of this Input.
	 *
	 * @param id; const std::string& value of the "id" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setId(const std::string& id);


	/**
	 * Sets the value of the "qualitativeSpecies" attribute of this Input.
	 *
	 * @param qualitativeSpecies; const std::string& value of the "qualitativeSpecies" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setQualitativeSpecies(const std::string& qualitativeSpecies);


	/**
	 * Sets the value of the "transitionEffect" attribute of this Input.
	 *
	 * @param transitionEffect; const std::string& value of the "transitionEffect" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	int setTransitionEffect(const InputTransitionEffect_t transitionEffect);


	/**
	 * Sets the value of the "name" attribute of this Input.
	 *
	 * @param name; const std::string& value of the "name" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setName(const std::string& name);


	/**
	 * Sets the value of the "sign" attribute of this Input.
	 *
	 * @param sign; const std::string& value of the "sign" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	int setSign(const InputSign_t sign);


	/**
	 * Sets the value of the "thresholdLevel" attribute of this Input.
	 *
	 * @param thresholdLevel; int value of the "thresholdLevel" attribute to be set
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_INVALID_ATTRIBUTE_VALUE
	 */
	virtual int setThresholdLevel(int thresholdLevel);


	/**
	 * Unsets the value of the "id" attribute of this Input.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	virtual int unsetId();


	/**
	 * Unsets the value of the "qualitativeSpecies" attribute of this Input.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	virtual int unsetQualitativeSpecies();


	/**
	 * Unsets the value of the "transitionEffect" attribute of this Input.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	int unsetTransitionEffect();


	/**
	 * Unsets the value of the "name" attribute of this Input.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	virtual int unsetName();


	/**
	 * Unsets the value of the "sign" attribute of this Input.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	virtual int unsetSign();


	/**
	 * Unsets the value of the "thresholdLevel" attribute of this Input.
	 *
	 * @return integer value indicating success/failure of the
	 * function.  @if clike The value is drawn from the
	 * enumeration #OperationReturnValues_t. @endif The possible values
	 * returned by this function are:
	 * @li LIBSBML_OPERATION_SUCCESS
	 * @li LIBSBML_OPERATION_FAILED
	 */
	virtual int unsetThresholdLevel();


	/**
	 * Returns the XML element name of this object, which for Input, is
	 * always @c "input".
	 *
	 * @return the name of this element, i.e. @c "input".
	 */
	virtual const std::string& getElementName () const;


	/**
	 * Returns the libSBML type code for this SBML object.
	 * 
	 * @if clike LibSBML attaches an identifying code to every kind of SBML
	 * object.  These are known as <em>SBML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SBMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SBML_. @endif@if java LibSBML attaches an identifying code to every
	 * kind of SBML object.  These are known as <em>SBML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSBML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if python LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the Python language interface for libSBML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if csharp LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the C# language interface for libSBML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SBML_. @endif
	 *
	 * @return the SBML type code for this object, or
	 * @link SBMLTypeCode_t#SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getTypeCode () const;


	/**
	 * Predicate returning @c true if all the required attributes
	 * for this Input object have been set.
	 *
	 * @note The required attributes for a Input object are:
	 * @li "qualitativeSpecies"
	 * @li "transitionEffect"
	 *
	 * @return a boolean value indicating whether all the required
	 * attributes for this object have been defined.
	 */
	virtual bool hasRequiredAttributes() const;


	/** @cond doxygen-libsbml-internal */

	/**
	 * Subclasses should override this method to write out their contained
	 * SBML objects as XML elements.  Be sure to call your parents
	 * implementation of this method as well.
	 */
	virtual void writeElements (XMLOutputStream& stream) const;


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Accepts the given SBMLVisitor.
	 */
	virtual bool accept (SBMLVisitor& v) const;


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Sets the parent SBMLDocument.
	 */
	virtual void setSBMLDocument (SBMLDocument* d);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Enables/Disables the given package with this element.
	 */
	virtual void enablePackageInternal(const std::string& pkgURI,
	             const std::string& pkgPrefix, bool flag);


	/** @endcond doxygen-libsbml-internal */


protected:

	/** @cond doxygen-libsbml-internal */

	/**
	 * Get the list of expected attributes for this element.
	 */
	virtual void addExpectedAttributes(ExpectedAttributes& attributes);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Read values from the given XMLAttributes set into their specific fields.
	 */
	virtual void readAttributes (const XMLAttributes& attributes,
	                             const ExpectedAttributes& expectedAttributes);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Write values of XMLAttributes to the output stream.
	 */
	virtual void writeAttributes (XMLOutputStream& stream) const;


	/** @endcond doxygen-libsbml-internal */



};

class LIBSBML_EXTERN ListOfInputs : public ListOf
{

public:

	/**
	 * Creates a new ListOfInputs with the given level, version, and package version.
	 *
	 * @param level an unsigned int, the SBML Level to assign to this ListOfInputs
	 *
	 * @param version an unsigned int, the SBML Version to assign to this ListOfInputs
	 *
	 * @param pkgVersion an unsigned int, the SBML Qual Version to assign to this ListOfInputs
	 */
	ListOfInputs(unsigned int level      = QualExtension::getDefaultLevel(),
	             unsigned int version    = QualExtension::getDefaultVersion(),
	             unsigned int pkgVersion = QualExtension::getDefaultPackageVersion());


	/**
	 * Creates a new ListOfInputs with the given QualPkgNamespaces object.
	 *
	 * @param qualns the QualPkgNamespaces object
	 */
	ListOfInputs(QualPkgNamespaces* qualns);


 	/**
	 * Creates and returns a deep copy of this ListOfInputs object.
	 *
	 * @return a (deep) copy of this ListOfInputs object.
	 */
	virtual ListOfInputs* clone () const;


 	/**
	 * Get a Input from the ListOfInputs.
	 *
	 * @param n the index number of the Input to get.
	 *
	 * @return the nth Input in this ListOfInputs.
	 *
	 * @see size()
	 */
	virtual Input* get(unsigned int n);


	/**
	 * Get a Input from the ListOfInputs.
	 *
	 * @param n the index number of the Input to get.
	 *
	 * @return the nth Input in this ListOfInputs.
	 *
	 * @see size()
	 */
	virtual const Input* get(unsigned int n) const;


	/**
	 * Get a Input from the ListOfInputs
	 * based on its identifier.
	 *
	 * @param sid a string representing the identifier
	 * of the Input to get.
	 *
	 * @return Input in this ListOfInputs
	 * with the given id or NULL if no such
	 * Input exists.
	 *
	 * @see get(unsigned int n)	 *
	 * @see size()
	 */
	virtual Input* get(const std::string& sid);


	/**
	 * Get a Input from the ListOfInputs
	 * based on its identifier.
	 *
	 * @param sid a string representing the identifier
	 * of the Input to get.
	 *
	 * @return Input in this ListOfInputs
	 * with the given id or NULL if no such
	 * Input exists.
	 *
	 * @see get(unsigned int n)	 *
	 * @see size()
	 */
	virtual const Input* get(const std::string& sid) const;


	/**
	 * Get a Input from the ListOfInputs
	 * based on the qualitativeSpecies to which it refers.
	 *
	 * @param sid a string representing the qualitativeSpecies attribute
	 * of the Input to get.
	 *
	 * @return the first Input in this ListOfInputs
	 * with the given qualitativeSpecies or NULL if no such
	 * Input exists.
	 *
	 * @see get(unsigned int n)	 *
	 * @see size()
	 */
	const Input* getBySpecies(const std::string& sid) const;


	/**
	 * Get a Input from the ListOfInputs
	 * based on the qualitativeSpecies to which it refers.
	 *
	 * @param sid a string representing the qualitativeSpecies attribute
	 * of the Input to get.
	 *
	 * @return the first Input in this ListOfInputs
	 * with the given qualitativeSpecies or NULL if no such
	 * Input exists.
	 *
	 * @see get(unsigned int n)	 *
	 * @see size()
	 */
	Input* getBySpecies(const std::string& sid);


	/**
	 * Removes the nth Input from this ListOfInputs
	 * and returns a pointer to it.
	 *
	 * The caller owns the returned item and is responsible for deleting it.
	 *
	 * @param n the index of the Input to remove.
	 *
	 * @see size()
	 */
	virtual Input* remove(unsigned int n);


	/**
	 * Removes the Input from this ListOfInputs with the given identifier
	 * and returns a pointer to it.
	 *
	 * The caller owns the returned item and is responsible for deleting it.
	 * If none of the items in this list have the identifier @p sid, then
	 * @c NULL is returned.
	 *
	 * @param sid the identifier of the Input to remove.
	 *
	 * @return the Input removed. As mentioned above, the caller owns the
	 * returned item.
	 */
	virtual Input* remove(const std::string& sid);


	/**
	 * Returns the XML element name of this object, which for ListOfInputs, is
	 * always @c "listOfInputs".
	 *
	 * @return the name of this element, i.e. @c "listOfInputs".
	 */
	virtual const std::string& getElementName () const;


	/**
	 * Returns the libSBML type code for this SBML object.
	 * 
	 * @if clike LibSBML attaches an identifying code to every kind of SBML
	 * object.  These are known as <em>SBML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SBMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SBML_. @endif@if java LibSBML attaches an identifying code to every
	 * kind of SBML object.  These are known as <em>SBML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSBML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if python LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the Python language interface for libSBML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if csharp LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the C# language interface for libSBML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SBML_. @endif
	 *
	 * @return the SBML type code for this object, or
	 * @link SBMLTypeCode_t#SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getTypeCode () const;


	/**
	 * Returns the libSBML type code for the SBML objects
	 * contained in this ListOf object
	 * 
	 * @if clike LibSBML attaches an identifying code to every kind of SBML
	 * object.  These are known as <em>SBML type codes</em>.  The set of
	 * possible type codes is defined in the enumeration #SBMLTypeCode_t.
	 * The names of the type codes all begin with the characters @c
	 * SBML_. @endif@if java LibSBML attaches an identifying code to every
	 * kind of SBML object.  These are known as <em>SBML type codes</em>.  In
	 * other languages, the set of type codes is stored in an enumeration; in
	 * the Java language interface for libSBML, the type codes are defined as
	 * static integer constants in the interface class {@link
	 * libsbmlConstants}.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if python LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the Python language interface for libSBML, the type
	 * codes are defined as static integer constants in the interface class
	 * @link libsbml@endlink.  The names of the type codes all begin with the
	 * characters @c SBML_. @endif@if csharp LibSBML attaches an identifying
	 * code to every kind of SBML object.  These are known as <em>SBML type
	 * codes</em>.  In the C# language interface for libSBML, the type codes
	 * are defined as static integer constants in the interface class @link
	 * libsbmlcs.libsbml@endlink.  The names of the type codes all begin with
	 * the characters @c SBML_. @endif
	 *
	 * @return the SBML type code for the objects in this ListOf instance, or
	 * @link SBMLTypeCode_t#SBML_UNKNOWN SBML_UNKNOWN@endlink (default).
	 *
	 * @see getElementName()
	 */
	virtual int getItemTypeCode () const;


protected:

	/** @cond doxygen-libsbml-internal */

	/**
	 * Creates a new Input in this ListOfInputs
	 */
	virtual SBase* createObject(XMLInputStream& stream);


	/** @endcond doxygen-libsbml-internal */


	/** @cond doxygen-libsbml-internal */

	/**
	 * Write the namespace for the Qual package.
	 */
	virtual void writeXMLNS(XMLOutputStream& stream) const;


	/** @endcond doxygen-libsbml-internal */



};



LIBSBML_CPP_NAMESPACE_END

#endif  /*  __cplusplus  */

#ifndef SWIG

LIBSBML_CPP_NAMESPACE_BEGIN
BEGIN_C_DECLS

LIBSBML_EXTERN
Input_t *
Input_create(unsigned int level, unsigned int version,
             unsigned int pkgVersion);


LIBSBML_EXTERN
void
Input_free(Input_t * i);


LIBSBML_EXTERN
Input_t *
Input_clone(Input_t * i);


LIBSBML_EXTERN
char *
Input_getId(Input_t * i);


LIBSBML_EXTERN
char *
Input_getQualitativeSpecies(Input_t * i);


LIBSBML_EXTERN
InputTransitionEffect_t
Input_getTransitionEffect(Input_t * i);


LIBSBML_EXTERN
char *
Input_getName(Input_t * i);


LIBSBML_EXTERN
InputSign_t
Input_getSign(Input_t * i);


LIBSBML_EXTERN
int
Input_getThresholdLevel(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetId(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetQualitativeSpecies(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetTransitionEffect(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetName(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetSign(Input_t * i);


LIBSBML_EXTERN
int
Input_isSetThresholdLevel(Input_t * i);


LIBSBML_EXTERN
int
Input_setId(Input_t * i, const char * id);


LIBSBML_EXTERN
int
Input_setQualitativeSpecies(Input_t * i, const char * qualitativeSpecies);


LIBSBML_EXTERN
int
Input_setTransitionEffect(Input_t * i, InputTransitionEffect_t transitionEffect);


LIBSBML_EXTERN
int
Input_setName(Input_t * i, const char * name);


LIBSBML_EXTERN
int
Input_setSign(Input_t * i, InputSign_t sign);


LIBSBML_EXTERN
int
Input_setThresholdLevel(Input_t * i, int thresholdLevel);


LIBSBML_EXTERN
int
Input_unsetId(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetQualitativeSpecies(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetTransitionEffect(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetName(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetSign(Input_t * i);


LIBSBML_EXTERN
int
Input_unsetThresholdLevel(Input_t * i);


LIBSBML_EXTERN
int
Input_hasRequiredAttributes(Input_t * i);


LIBSBML_EXTERN
Input_t *
ListOfInputs_getById(ListOf_t * lo, const char * sid);


LIBSBML_EXTERN
Input_t *
ListOfInputs_removeById(ListOf_t * lo, const char * sid);


LIBSBML_EXTERN
const char* 
InputTransitionEffect_toString(InputTransitionEffect_t effect);


LIBSBML_EXTERN
InputTransitionEffect_t 
InputTransitionEffect_fromString(const char* s);


LIBSBML_EXTERN
int 
InputTransitionEffect_isValidInputTransitionEffect(InputTransitionEffect_t effect);


LIBSBML_EXTERN
int 
InputTransitionEffect_isValidInputTransitionEffectString(const char* s);


LIBSBML_EXTERN
const char* 
InputSign_toString(InputSign_t effect);

LIBSBML_EXTERN
InputSign_t 
InputSign_fromString(const char* s);


LIBSBML_EXTERN
int 
InputSign_isValidInputSign(InputSign_t effect);


LIBSBML_EXTERN
int 
InputSign_isValidInputSignString(const char* s);


END_C_DECLS
LIBSBML_CPP_NAMESPACE_END

#endif  /*  !SWIG  */

#endif /*  Input_H__  */