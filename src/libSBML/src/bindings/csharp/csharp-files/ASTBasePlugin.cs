using System;
using System.Runtime.InteropServices;


/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbmlcs {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html Base class for extensions that plug into AST classes.
 * @internal
 */

public class ASTBasePlugin : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ASTBasePlugin(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ASTBasePlugin obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ASTBasePlugin obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ASTBasePlugin() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ASTBasePlugin(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Creates and returns a deep copy of this ASTBasePlugin object.
   *
   * @return the (deep) copy of this ASTBasePlugin object.
   */ /* libsbml-internal */ public new
 ASTBasePlugin clone() {
    IntPtr cPtr = libsbmlPINVOKE.ASTBasePlugin_clone(swigCPtr);
    ASTBasePlugin ret = (cPtr == IntPtr.Zero) ? null : new ASTBasePlugin(cPtr, true);
    return ret;
  }

  
/**
   * Returns the XML namespace (URI) of the package extension
   * of this plugin object.
   *
   * @return the URI of the package extension of this plugin object.
   */ /* libsbml-internal */ public
 string getElementNamespace() {
    string ret = libsbmlPINVOKE.ASTBasePlugin_getElementNamespace(swigCPtr);
    return ret;
  }

  
/**
   * Returns the prefix of the package extension of this plugin object.
   *
   * @return the prefix of the package extension of this plugin object.
   */ /* libsbml-internal */ public new
 string getPrefix() {
    string ret = libsbmlPINVOKE.ASTBasePlugin_getPrefix(swigCPtr);
    return ret;
  }

  
/**
   * Returns the package name of this plugin object.
   *
   * @return the package name of this plugin object.
   */ /* libsbml-internal */ public new
 string getPackageName() {
    string ret = libsbmlPINVOKE.ASTBasePlugin_getPackageName(swigCPtr);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int setSBMLExtension(SBMLExtension ext) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_setSBMLExtension(swigCPtr, SBMLExtension.getCPtr(ext));
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int setPrefix(string prefix) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_setPrefix(swigCPtr, prefix);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the parent SBML object of this plugin object to
   * this object and child elements (if any).
   * (Creates a child-parent relationship by this plugin object)
   *
   * This function is called when this object is created by
   * the parent element.
   * Subclasses must override this this function if they have one
   * or more child elements. Also, ASTBasePlugin::connectToParent(@if java SBase@endif)
   * must be called in the overridden function.
   *
   * @param sbase the SBase object to use
   *
   * @see setSBMLDocument
   * @see enablePackageInternal
   */ /* libsbml-internal */ public new
 void connectToParent(ASTBase astbase) {
    libsbmlPINVOKE.ASTBasePlugin_connectToParent(swigCPtr, ASTBase.getCPtr(astbase));
  }

  
/**
   * Enables/Disables the given package with child elements in this plugin 
   * object (if any).
   * (This is an internal implementation invoked from 
   *  SBase::enablePackageInternal() function)
   *
   * Subclasses which contain one or more SBase derived elements should 
   * override this function if elements defined in them can be extended by
   * some other package extension.
   *
   * @see setSBMLDocument
   * @see connectToParent
   */ /* libsbml-internal */ public new
 void enablePackageInternal(string pkgURI, string pkgPrefix, bool flag) {
    libsbmlPINVOKE.ASTBasePlugin_enablePackageInternal(swigCPtr, pkgURI, pkgPrefix, flag);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** */ /* libsbml-internal */ public new
 bool stripPackage(string pkgPrefix, bool flag) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_stripPackage(swigCPtr, pkgPrefix, flag);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Gets the URI to which this element belongs to.
   * For example, all elements that belong to SBML Level 3 Version 1 Core
   * must would have the URI 'http://www.sbml.org/sbml/level3/version1/core'; 
   * all elements that belong to Layout Extension Version 1 for SBML Level 3
   * Version 1 Core must would have the URI
   * 'http://www.sbml.org/sbml/level3/version1/layout/version1/'
   *
   * Unlike getElementNamespace, this function first returns the URI for this 
   * element by looking into the SBMLNamespaces object of the document with 
   * the its package name. if not found it will return the result of 
   * getElementNamespace
   *
   * @return the URI this elements  
   *
   * @see getPackageName
   * @see getElementNamespace
   * @see SBMLDocument::getSBMLNamespaces
   * @see getSBMLDocument
   */ /* libsbml-internal */ public
 string getURI() {
    string ret = libsbmlPINVOKE.ASTBasePlugin_getURI(swigCPtr);
    return ret;
  }

  
/**
   * Returns the parent ASTNode object to which this plugin 
   * object connected.
   *
   * @return the parent ASTNode object to which this plugin 
   * object connected.
   */ /* libsbml-internal */ public
 ASTBase getParentASTObject() {
	ASTBase ret = (ASTBase) libsbml.DowncastASTBase(libsbmlPINVOKE.ASTBasePlugin_getParentASTObject__SWIG_0(swigCPtr), false);
	return ret;
}

  
/**
   * Sets the XML namespace to which this element belongs to.
   * For example, all elements that belong to SBML Level 3 Version 1 Core
   * must set the namespace to 'http://www.sbml.org/sbml/level3/version1/core'; 
   * all elements that belong to Layout Extension Version 1 for SBML Level 3
   * Version 1 Core must set the namespace to 
   * 'http://www.sbml.org/sbml/level3/version1/layout/version1/'
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_INVALID_ATTRIBUTE_VALUE LIBSBML_INVALID_ATTRIBUTE_VALUE@endlink
   */ /* libsbml-internal */ public
 int setElementNamespace(string uri) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_setElementNamespace(swigCPtr, uri);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the SBML level of the package extension of 
   * this plugin object.
   *
   * @return the SBML level of the package extension of
   * this plugin object.
   */ /* libsbml-internal */ public
 long getLevel() { return (long)libsbmlPINVOKE.ASTBasePlugin_getLevel(swigCPtr); }

  
/**
   * Returns the SBML version of the package extension of
   * this plugin object.
   *
   * @return the SBML version of the package extension of
   * this plugin object.
   */ /* libsbml-internal */ public
 long getVersion() { return (long)libsbmlPINVOKE.ASTBasePlugin_getVersion(swigCPtr); }

  
/**
   * Returns the package version of the package extension of
   * this plugin object.
   *
   * @return the package version of the package extension of
   * this plugin object.
   */ /* libsbml-internal */ public
 long getPackageVersion() { return (long)libsbmlPINVOKE.ASTBasePlugin_getPackageVersion(swigCPtr); }

  
/** */ /* libsbml-internal */ public new
 SBMLNamespaces getSBMLNamespaces() {
	SBMLNamespaces ret
	    = (SBMLNamespaces) libsbml.DowncastSBMLNamespaces(libsbmlPINVOKE.ASTBasePlugin_getSBMLNamespaces(swigCPtr), false);
	return ret;
}

  
/** */ /* libsbml-internal */ public new
 bool isSetMath() {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isSetMath(swigCPtr);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 ASTBase getMath() {
	ASTBase ret = (ASTBase) libsbml.DowncastASTBase(libsbmlPINVOKE.ASTBasePlugin_getMath(swigCPtr), false);
	return ret;
}

  
/** */ /* libsbml-internal */ public new
 void createMath(int type) {
    libsbmlPINVOKE.ASTBasePlugin_createMath(swigCPtr, type);
  }

  
/** */ /* libsbml-internal */ public new
 int addChild(ASTBase child) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_addChild(swigCPtr, ASTBase.getCPtr(child));
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 ASTBase getChild(long n) {
	ASTBase ret = (ASTBase) libsbml.DowncastASTBase(libsbmlPINVOKE.ASTBasePlugin_getChild(swigCPtr, n), false);
	return ret;
}

  
/** */ /* libsbml-internal */ public new
 long getNumChildren() { return (long)libsbmlPINVOKE.ASTBasePlugin_getNumChildren(swigCPtr); }

  
/** */ /* libsbml-internal */ public new
 int insertChild(long n, ASTBase newChild) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_insertChild(swigCPtr, n, ASTBase.getCPtr(newChild));
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int prependChild(ASTBase newChild) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_prependChild(swigCPtr, ASTBase.getCPtr(newChild));
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int removeChild(long n) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_removeChild(swigCPtr, n);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int replaceChild(long n, ASTBase newChild) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_replaceChild(swigCPtr, n, ASTBase.getCPtr(newChild));
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int swapChildren(SWIGTYPE_p_ASTFunction that) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_swapChildren(swigCPtr, SWIGTYPE_p_ASTFunction.getCPtr(that));
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool read(XMLInputStream stream, string reqd_prefix, XMLToken currentElement) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_read(swigCPtr, XMLInputStream.getCPtr(stream), reqd_prefix, XMLToken.getCPtr(currentElement));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 void addExpectedAttributes(SWIGTYPE_p_ExpectedAttributes attributes, XMLInputStream stream, int type) {
    libsbmlPINVOKE.ASTBasePlugin_addExpectedAttributes(swigCPtr, SWIGTYPE_p_ExpectedAttributes.getCPtr(attributes), XMLInputStream.getCPtr(stream), type);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** */ /* libsbml-internal */ public new
 bool readAttributes(XMLAttributes attributes, SWIGTYPE_p_ExpectedAttributes expectedAttributes, XMLInputStream stream, XMLToken element, int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_readAttributes(swigCPtr, XMLAttributes.getCPtr(attributes), SWIGTYPE_p_ExpectedAttributes.getCPtr(expectedAttributes), XMLInputStream.getCPtr(stream), XMLToken.getCPtr(element), type);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 void writeAttributes(XMLOutputStream stream, int type) {
    libsbmlPINVOKE.ASTBasePlugin_writeAttributes(swigCPtr, XMLOutputStream.getCPtr(stream), type);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** */ /* libsbml-internal */ public new
 void writeXMLNS(XMLOutputStream stream) {
    libsbmlPINVOKE.ASTBasePlugin_writeXMLNS(swigCPtr, XMLOutputStream.getCPtr(stream));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** */ /* libsbml-internal */ public new
 bool isNumberNode(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isNumberNode(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isFunctionNode(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isFunctionNode(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isLogical(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isLogical(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isConstantNumber(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isConstantNumber(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isCSymbolFunction(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isCSymbolFunction(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isCSymbolNumber(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isCSymbolNumber(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isName(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isName(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isNumber(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isNumber(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isOperator(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isOperator(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isRelational(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isRelational(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool representsQualifier(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_representsQualifier(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isFunction(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isFunction(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool representsUnaryFunction(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_representsUnaryFunction(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool representsBinaryFunction(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_representsBinaryFunction(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool representsNaryFunction(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_representsNaryFunction(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool hasCorrectNumberArguments(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_hasCorrectNumberArguments(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isWellFormedNode(int type) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isWellFormedNode(swigCPtr, type);
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isTopLevelMathMLFunctionNodeTag(string name) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isTopLevelMathMLFunctionNodeTag(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 bool isTopLevelMathMLNumberNodeTag(string name) {
    bool ret = libsbmlPINVOKE.ASTBasePlugin_isTopLevelMathMLNumberNodeTag(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int getTypeFromName(string name) {
    int ret = libsbmlPINVOKE.ASTBasePlugin_getTypeFromName(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 string getNameFromType(int type) {
    string ret = libsbmlPINVOKE.ASTBasePlugin_getNameFromType(swigCPtr, type);
    return ret;
  }

}

}
