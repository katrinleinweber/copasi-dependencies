/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 *  Base class for extending SBML objects in packages.
 <p>
 * <p style='color: #777; font-style: italic'>
This class of objects is defined by libSBML only and has no direct
equivalent in terms of SBML components.  This class is not prescribed by
the SBML specifications, although it is used to implement features
defined in SBML.
</p>

 <p>
 * The {@link SBasePlugin} class is libSBML's base class for extensions of core SBML
 * component objects.  {@link SBasePlugin} defines basic virtual methods for
 * reading/writing/checking additional attributes and/or subobjects; these
 * methods should be overridden by subclasses to implement the necessary
 * features of an extended SBML object.
 <p>
 * <p>
 * <h2>Basic principles of SBML package extensions in libSBML</h2>
 <p>
 * SBML Level&nbsp;3's package structure permits modular extensions to the
 * core SBML format.  In libSBML, support for SBML Level&nbsp;3 packages is
 * provided through optional <em>package extensions</em> that can be plugged
 * into libSBML at the time it is built/compiled.  Users of libSBML can thus
 * choose which extensions are enabled in their software applications.
 <p>
 * LibSBML defines a number of classes that developers of package extensions
 * can use to implement support for an SBML Level&nbsp;3 package.  These
 * classes make it easier to extend libSBML objects with new attributes
 * and/or subobjects as needed by a particular Level&nbsp;3 package.
 * Three overall categories of classes make up libSBML's facilities for
 * implementing package extensions.  There are (1) classes that serve as base
 * classes meant to be subclassed, (2) template classes meant to be
 * instantiated rather than subclassed, and (3) support classes that provide
 * utility features. A given package implementation for libSBML will take
 * the form of code using these and other libSBML classes, placed in a
 * subdirectory of <code>src/sbml/packages/</code>.
 <p>
 * The basic libSBML distribution includes a number of package extensions
 * implementing support for officially-endorsed SBML Level&nbsp;3 packages;
 * among these are <em>Flux Balance Constraints</em> ('fbc'),
 * <em>Hierarchical Model Composition</em> ('comp'), <em>Layout</em>
 * ('layout'), and <em>Qualitative Models</em> ('qual').  They can serve as
 * working examples for developers working to implement other packages.
 <p>
 * Extensions in libSBML can currently only be implemented in C++ or C;
 * there is no mechanism to implement them first in languages such as
 * Java or Python.  However, once implemented in C++ or C, language
 * interfaces can be generated semi-automatically using the framework in
 * place in libSBML.  (The approach is based on using <a target='_blank'
 * href='http://www.swig.org'>SWIG</a> and facilities in libSBML's build
 * system.)
 */

public class SBasePlugin {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected SBasePlugin(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(SBasePlugin obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SBasePlugin obj)
   {
     long ptr = 0;

     if (obj != null)
     {
       ptr             = obj.swigCPtr;
       obj.swigCMemOwn = false;
     }

     return ptr;
   }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libsbmlJNI.delete_SBasePlugin(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  
/**
   * Returns the namespace URI of the package to which this plugin object
   * belongs.
   <p>
   * @return the XML namespace URI of the SBML Level&nbsp;3 package
   * implemented by this libSBML package extension.
   */ public
 String getElementNamespace() {
    return libsbmlJNI.SBasePlugin_getElementNamespace(swigCPtr, this);
  }

  
/**
   * Returns the XML namespace prefix of the package to which this plugin
   * object belongs.
   <p>
   * @return the XML namespace prefix of the SBML Level&nbsp;3 package
   * implemented by this libSBML package extension.
   */ public
 String getPrefix() {
    return libsbmlJNI.SBasePlugin_getPrefix(swigCPtr, this);
  }

  
/**
   * Returns the short-form name of the package to which this plugin
   * object belongs.
   <p>
   * @return the short-form package name (or nickname) of the SBML package
   * implemented by this package extension.
   */ public
 String getPackageName() {
    return libsbmlJNI.SBasePlugin_getPackageName(swigCPtr, this);
  }

  
/**
   * Creates and returns a deep copy of this {@link SBasePlugin} object.
   <p>
   * @return the (deep) copy of this {@link SBasePlugin} object.
   */ public
 SBasePlugin cloneObject() {
	return libsbml.DowncastSBasePlugin(libsbmlJNI.SBasePlugin_cloneObject(swigCPtr, this), true);
}

  
/**
   * Return the first child object found with a given identifier.
   <p>
   * This method searches all the subobjects under this one, compares their
   * identifiers to <code>id</code>, and returns the first one that machines.
   <p>
   * Normally, <code>SId</code> type identifier values are unique across
   * a model in SBML.  However, in some circumstances they may not be, such
   * as if a model is invalid because of multiple objects having the same
   * identifier.
   <p>
   * @param id string representing the identifier of the object to find
   <p>
   * @return pointer to the first object with the given <code>id</code>.
   */ public
 SBase getElementBySId(String id) {
  return libsbml.DowncastSBase(libsbmlJNI.SBasePlugin_getElementBySId(swigCPtr, this, id), false);
}

  
/**
   * Return the first child object found with a given meta identifier.
   <p>
   * This method searches all the subobjects under this one, compares their
   * meta identifiers to <code>metaid</code>, and returns the first one that machines.
   <p>
   * @param metaid string, the metaid of the object to find.
   <p>
   * @return pointer to the first object found with the given <code>metaid</code>.
   */ public
 SBase getElementByMetaId(String metaid) {
  return libsbml.DowncastSBase(libsbmlJNI.SBasePlugin_getElementByMetaId(swigCPtr, this, metaid), false);
}

  
/** * @internal */ public
 void connectToParent(SBase sbase) {
    libsbmlJNI.SBasePlugin_connectToParent(swigCPtr, this, SBase.getCPtr(sbase), sbase);
  }

  
/** * @internal */ public
 void enablePackageInternal(String pkgURI, String pkgPrefix, boolean flag) {
    libsbmlJNI.SBasePlugin_enablePackageInternal(swigCPtr, this, pkgURI, pkgPrefix, flag);
  }

  
/** * @internal */ public
 boolean stripPackage(String pkgPrefix, boolean flag) {
    return libsbmlJNI.SBasePlugin_stripPackage(swigCPtr, this, pkgPrefix, flag);
  }

  
/**
   * Returns the {@link SBMLDocument} object containing this object instance.
   <p>
   * <p>
 * LibSBML uses the class {@link SBMLDocument} as a top-level container for
 * storing SBML content and data associated with it (such as warnings and
 * error messages).  An SBML model in libSBML is contained inside an
 * {@link SBMLDocument} object.  {@link SBMLDocument} corresponds roughly to the class
 * <i>SBML</i> defined in the SBML Level&nbsp;3 and Level&nbsp;2
 * specifications, but it does not have a direct correspondence in SBML
 * Level&nbsp;1.  (But, it is created by libSBML no matter whether the
 * model is Level&nbsp;1, Level&nbsp;2 or Level&nbsp;3.)
   <p>
   * This method allows the caller to obtain the {@link SBMLDocument} for the
   * current object.
   <p>
   * @return the parent {@link SBMLDocument} object of this plugin object.
   <p>
   * @see #getParentSBMLObject()
   */ public
 SBMLDocument getSBMLDocument() {
    long cPtr = libsbmlJNI.SBasePlugin_getSBMLDocument__SWIG_0(swigCPtr, this);
    return (cPtr == 0) ? null : new SBMLDocument(cPtr, false);
  }

  
/**
   * Returns the XML namespace URI for the package to which this object belongs.
   <p>
   * <p>
 * In the XML representation of an SBML document, XML namespaces are used to
 * identify the origin of each XML construct used.  XML namespaces are
 * identified by their unique resource identifiers (URIs).  The core SBML
 * specifications stipulate the namespaces that must be used for core SBML
 * constructs; for example, all XML elements that belong to SBML Level&nbsp;3
 * Version&nbsp;1 Core must be placed in the XML namespace identified by the URI
 * <code>'http://www.sbml.org/sbml/level3/version1/core'</code>.  Individual
 * SBML Level&nbsp;3 packages define their own XML namespaces; for example,
 * all elements belonging to the SBML Level&nbsp;3 Layout Version&nbsp;1
 * package must be placed in the XML namespace
 * <code>'http://www.sbml.org/sbml/level3/version1/layout/version1/'</code>.
   <p>
   * This method first looks into the {@link SBMLNamespaces} object possessed by the
   * parent {@link SBMLDocument} object of the current object.  If this cannot be
   * found, this method returns the result of getElementNamespace().
   <p>
   * @return a string, the URI of the XML namespace to which this object belongs.
   <p>
   * @see #getPackageName()
   * @see #getElementNamespace()
   * @see SBMLDocument#getSBMLNamespaces()
   * @see #getSBMLDocument()
   */ public
 String getURI() {
    return libsbmlJNI.SBasePlugin_getURI(swigCPtr, this);
  }

  
/**
   * Returns the parent object to which this plugin object is connected.
   <p>
   * @return the parent object of this object.
   */ public
 SBase getParentSBMLObject() {
  return libsbml.DowncastSBase(libsbmlJNI.SBasePlugin_getParentSBMLObject__SWIG_0(swigCPtr, this), false);
}

  
/**
   * Sets the XML namespace to which this object belongs.
   <p>
   * <p>
 * In the XML representation of an SBML document, XML namespaces are used to
 * identify the origin of each XML construct used.  XML namespaces are
 * identified by their unique resource identifiers (URIs).  The core SBML
 * specifications stipulate the namespaces that must be used for core SBML
 * constructs; for example, all XML elements that belong to SBML Level&nbsp;3
 * Version&nbsp;1 Core must be placed in the XML namespace identified by the URI
 * <code>'http://www.sbml.org/sbml/level3/version1/core'</code>.  Individual
 * SBML Level&nbsp;3 packages define their own XML namespaces; for example,
 * all elements belonging to the SBML Level&nbsp;3 Layout Version&nbsp;1
 * package must be placed in the XML namespace
 * <code>'http://www.sbml.org/sbml/level3/version1/layout/version1/'</code>.
   <p>
   * @param uri the URI to assign to this object.
   <p>
   * <p>
 * @return integer value indicating success/failure of the
 * function.   The possible values
 * returned by this function are:
   * <ul>
   * <li> {@link libsbmlConstants#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS}
   *
   * </ul> <p>
   * @see #getElementNamespace()
   */ public
 int setElementNamespace(String uri) {
    return libsbmlJNI.SBasePlugin_setElementNamespace(swigCPtr, this, uri);
  }

  
/**
   * Returns the SBML Level of the package extension of this plugin object.
   <p>
   * @return the SBML Level.
   <p>
   * @see #getVersion()
   */ public
 long getLevel() {
    return libsbmlJNI.SBasePlugin_getLevel(swigCPtr, this);
  }

  
/**
   * Returns the Version within the SBML Level of the package extension of
   * this plugin object.
   <p>
   * @return the SBML Version.
   <p>
   * @see #getLevel()
   */ public
 long getVersion() {
    return libsbmlJNI.SBasePlugin_getVersion(swigCPtr, this);
  }

  
/**
   * Returns the package version of the package extension of this plugin
   * object.
   <p>
   * @return the package version of the package extension of this plugin
   * object.
   <p>
   * @see #getLevel()
   * @see #getVersion()
   */ public
 long getPackageVersion() {
    return libsbmlJNI.SBasePlugin_getPackageVersion(swigCPtr, this);
  }

  
/** * @internal */ public
 void replaceSIDWithFunction(String id, ASTNode function) {
    libsbmlJNI.SBasePlugin_replaceSIDWithFunction(swigCPtr, this, id, ASTNode.getCPtr(function), function);
  }

  
/** * @internal */ public
 void divideAssignmentsToSIdByFunction(String id, ASTNode function) {
    libsbmlJNI.SBasePlugin_divideAssignmentsToSIdByFunction(swigCPtr, this, id, ASTNode.getCPtr(function), function);
  }

  
/** * @internal */ public
 void multiplyAssignmentsToSIdByFunction(String id, ASTNode function) {
    libsbmlJNI.SBasePlugin_multiplyAssignmentsToSIdByFunction(swigCPtr, this, id, ASTNode.getCPtr(function), function);
  }

  
/** * @internal */ public
 boolean hasIdentifierBeginningWith(String prefix) {
    return libsbmlJNI.SBasePlugin_hasIdentifierBeginningWith(swigCPtr, this, prefix);
  }

  
/** * @internal */ public
 int prependStringToAllIdentifiers(String prefix) {
    return libsbmlJNI.SBasePlugin_prependStringToAllIdentifiers(swigCPtr, this, prefix);
  }

  
/** * @internal */ public
 int transformIdentifiers(IdentifierTransformer sidTransformer) {
    return libsbmlJNI.SBasePlugin_transformIdentifiers(swigCPtr, this, IdentifierTransformer.getCPtr(sidTransformer), sidTransformer);
  }

  
/** * @internal */ public
 long getLine() {
    return libsbmlJNI.SBasePlugin_getLine(swigCPtr, this);
  }

  
/** * @internal */ public
 long getColumn() {
    return libsbmlJNI.SBasePlugin_getColumn(swigCPtr, this);
  }

  
/** * @internal */ public
 SBMLNamespaces getSBMLNamespaces() {
  return libsbml.DowncastSBMLNamespaces(libsbmlJNI.SBasePlugin_getSBMLNamespaces(swigCPtr, this), false);
}

  
/** * @internal */ public
 void logUnknownElement(String element, long sbmlLevel, long sbmlVersion, long pkgVersion) {
    libsbmlJNI.SBasePlugin_logUnknownElement(swigCPtr, this, element, sbmlLevel, sbmlVersion, pkgVersion);
  }

  
  /**
   * Returns an {@link SBaseList} of all child {@link SBase} objects,
   * including those nested to an arbitrary depth.
   *
   * @return a pointer to an {@link SBaseList} of pointers to all children objects.
   */
 public SBaseList getListOfAllElements(ElementFilter filter) {
    long cPtr = libsbmlJNI.SBasePlugin_getListOfAllElements__SWIG_0(swigCPtr, this, ElementFilter.getCPtr(filter), filter);
    return (cPtr == 0) ? null : new SBaseList(cPtr, false);
  }

  
  /**
   * Returns an {@link SBaseList} of all child {@link SBase} objects,
   * including those nested to an arbitrary depth.
   *
   * @return a pointer to an {@link SBaseList} of pointers to all children objects.
   */
 public SBaseList getListOfAllElements() {
    long cPtr = libsbmlJNI.SBasePlugin_getListOfAllElements__SWIG_1(swigCPtr, this);
    return (cPtr == 0) ? null : new SBaseList(cPtr, false);
  }

}
