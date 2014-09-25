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
@htmlinclude pkg-marker-core.html A libSBML plug-in object for an SBML Level 3 package.
 * 
 * Additional attributes and/or elements of a package extension which are directly 
 * contained by some pre-defined element are contained/accessed by <a href='#SBasePlugin'> 
 * SBasePlugin </a> class which is extended by package developers for each extension point.
 * The extension point, which represents an element to be extended, is identified by a 
 * combination of a Package name and a typecode of the element, and is represented by
 * SBaseExtensionPoint class.
 * </p>
 *
 * <p>
 * For example, the layout extension defines <em>&lt;listOfLayouts&gt;</em> element which is 
 * directly contained in <em>&lt;model&gt;</em> element of the core package. 
 * In the layout package (provided as one of example packages in libSBML-5), the additional 
 * element for the model element is implemented as ListOfLayouts class (an SBase derived class) and 
 * the object is contained/accessed by a LayoutModelPlugin class (an SBasePlugin derived class). 
 * </p>
 *
 * <p>
 * SBasePlugin class defines basic virtual functions for reading/writing/checking 
 * additional attributes and/or top-level elements which should or must be overridden by 
 * subclasses like SBase class and its derived classes.
 * </p>
 *
 * <p>
 *  Package developers must implement an SBasePlugin exntended class for 
 *  each element to be extended (e.g. SBMLDocument, Model, ...) in which additional 
 *  attributes and/or top-level elements of the package extension are directly contained.
 *</p>
 *
 *  To implement reading/writing functions for attributes and/or top-level 
 *  elements of the SBsaePlugin extended class, package developers should or must
 *  override the corresponding virtual functions below provided in the SBasePlugin class:
 *
 *   <ul>
 *     <li> <p>reading elements : </p>
 *       <ol>
 *         <li> <code>virtual SBase createObject (XMLInputStream stream) </code>
 *         <p>This function must be overridden if one or more additional elements are defined.</p>
 *         </li>
 *         <li> <code>virtual bool readOtherXML (SBase parentObject, XMLInputStream stream)</code>
 *         <p>This function should be overridden if elements of annotation, notes, MathML, etc. need 
 *            to be directly parsed from the given XMLInputStream object @if clike instead of the
 *            SBase::readAnnotation(XMLInputStream stream)
 *            and/or SBase::readNotes(XMLInputStream stream) functions@endif.
 *         </p> 
 *         </li>
 *       </ol>
 *     </li>
 *     <li> <p>reading attributes (must be overridden if additional attributes are defined) :</p>
 *       <ol>
 *         <li><code>virtual void addExpectedAttributes(ExpectedAttributes& attributes) </code></li>
 *         <li><code>virtual void readAttributes (XMLAttributes attributes, ExpectedAttributes& expectedAttributes)</code></li>
 *       </ol>
 *     </li>
 *     <li> <p>writing elements (must be overridden if additional elements are defined) :</p>
 *       <ol>
 *         <li><code>virtual void writeElements (XMLOutputStream stream) </code></li>
 *       </ol>
 *     </li>
 *     <li> <p>writing attributes : </p>
 *       <ol>
 *        <li><code>virtual void writeAttributes (XMLOutputStream stream) </code>
 *         <p>This function must be overridden if one or more additional attributes are defined.</p>
 *        </li>
 *        <li><code>virtual void writeXMLNS (XMLOutputStream stream) </code>
 *         <p>This function must be overridden if one or more additional xmlns attributes are defined.</p>
 *        </li>
 *       </ol>
 *     </li>
 *
 *     <li> <p>checking elements (should be overridden) :</p>
 *       <ol>
 *         <li><code>virtual bool hasRequiredElements() </code></li>
 *       </ol>
 *     </li>
 *
 *     <li> <p>checking attributes (should be overridden) :</p>
 *       <ol>
 *         <li><code>virtual bool hasRequiredAttributes() </code></li>
 *       </ol>
 *     </li>
 *   </ul>
 *
 *<p>
 *   To implement package-specific creating/getting/manipulating functions of the
 *   SBasePlugin derived class (e.g., getListOfLayouts(), createLyout(), getLayout(),
 *   and etc are implemented in LayoutModelPlugin class of the layout package), package
 *   developers must newly implement such functions (as they like) in the derived class.
 *</p>
 *
 *<p>
 *   SBasePlugin class defines other virtual functions of internal implementations
 *   such as:
 *
 *   <ul>
 *    <li><code> virtual void setSBMLDocument(SBMLDocument d) </code>
 *    <li><code> virtual void connectToParent(SBase sbase) </code>
 *    <li><code> virtual void enablePackageInternal(string pkgURI, string pkgPrefix, bool flag) </code>
 *   </ul>
 *
 *   These functions must be overridden by subclasses in which one or more top-level elements are defined.
 *</p>
 *
 *<p>
 *   For example, the following three SBasePlugin extended classes are implemented in
 *   the layout extension:
 *</p>
 *
 *<ol>
 *
 *  <li> <p><a href='class_s_b_m_l_document_plugin.html'> SBMLDocumentPlugin </a> class for SBMLDocument element</p>
 *
 *    <ul>
 *         <li> <em> required </em> attribute is added to SBMLDocument object.
 *         </li>
 *    </ul>
 *
 *<p>
 *(<a href='class_s_b_m_l_document_plugin.html'> SBMLDocumentPlugin </a> class is a common SBasePlugin 
 *extended class for SBMLDocument class. Package developers can use this class as-is if no additional 
 *elements/attributes (except for <em> required </em> attribute) is needed for the SBMLDocument class 
 *in their packages, otherwise package developers must implement a new SBMLDocumentPlugin derived class.)
 *</p>
 *
 *  <li> <p>LayoutModelPlugin class for Model element</p>
 *    <ul>
 *       <li> &lt;listOfLayouts&gt; element is added to Model object.
 *       </li>
 *
 *       <li> <p>
 *            The following virtual functions for reading/writing/checking
 *            are overridden: (type of arguments and return values are omitted)
 *            </p>
 *           <ul>
 *              <li> <code> createObject() </code> : (read elements)
 *              </li>
 *              <li> <code> readOtherXML() </code> : (read elements in annotation of SBML L2)
 *              </li>
 *              <li> <code> writeElements() </code> : (write elements)
 *              </li>
 *           </ul>
 *       </li>
 *
 *        <li> <p>
 *             The following virtual functions of internal implementations
 *             are overridden: (type of arguments and return values are omitted)
 *            </p>  
 *            <ul>
 *              <li> <code> setSBMLDocument() </code> 
 *              </li>
 *              <li> <code> connectToParent() </code>
 *              </li>
 *              <li> <code> enablePackageInternal() </code>
 *              </li>
 *            </ul>
 *        </li>
 *
 *
 *        <li> <p>
 *             The following creating/getting/manipulating functions are newly 
 *             implemented: (type of arguments and return values are omitted)
 *            </p>
 *            <ul>
 *              <li> <code> getListOfLayouts() </code>
 *              </li>
 *              <li> <code> getLayout ()  </code>
 *              </li>
 *              <li> <code> addLayout() </code>
 *              </li>
 *              <li> <code> createLayout() </code>
 *              </li>
 *              <li> <code> removeLayout() </code>
 *              </li>	   
 *              <li> <code> getNumLayouts() </code>
 *              </li>
 *           </ul>
 *        </li>
 *
 *    </ul>
 *  </li>
 *
 *  <li> <p>LayoutSpeciesReferencePlugin class for SpeciesReference element (used only for SBML L2V1) </p>
 *
 *      <ul>
 *        <li>
 *         <em> id </em> attribute is internally added to SpeciesReference object
 *          only for SBML L2V1 
 *        </li>
 *
 *        <li>
 *         The following virtual functions for reading/writing/checking
 *          are overridden: (type of arguments and return values are omitted)
 *        </li>
 *
 *         <ul>
 *          <li>
 *          <code> readOtherXML() </code>
 *          </li>
 *          <li>
 *          <code> writeAttributes() </code>
 *          </li>
 *        </ul>
 *      </ul>
 *    </li>
 *
 * </ol>
 */

public class SBasePlugin : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal SBasePlugin(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBasePlugin obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBasePlugin obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBasePlugin() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBasePlugin(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Returns the XML namespace (URI) of the package extension
   * of this plugin object.
   *
   * @return the URI of the package extension of this plugin object.
   */ public
 string getElementNamespace() {
    string ret = libsbmlPINVOKE.SBasePlugin_getElementNamespace(swigCPtr);
    return ret;
  }

  
/**
   * Returns the prefix of the package extension of this plugin object.
   *
   * @return the prefix of the package extension of this plugin object.
   */ public
 string getPrefix() {
    string ret = libsbmlPINVOKE.SBasePlugin_getPrefix(swigCPtr);
    return ret;
  }

  
/**
   * Returns the package name of this plugin object.
   *
   * @return the package name of this plugin object.
   */ public
 string getPackageName() {
    string ret = libsbmlPINVOKE.SBasePlugin_getPackageName(swigCPtr);
    return ret;
  }

  
/**
   * Creates and returns a deep copy of this SBasePlugin object.
   *
   * @return the (deep) copy of this SBasePlugin object.
   */ public new
 SBasePlugin clone() {
        SBasePlugin ret = (SBasePlugin) libsbml.DowncastSBasePlugin(libsbmlPINVOKE.SBasePlugin_clone(swigCPtr), true);
        return ret;
}

  
/**
   * Returns the first child element found that has the given @p id in the model-wide SId namespace, or @c null if no such object is found.
   *
   * @param id string representing the id of objects to find
   *
   * @return pointer to the first element found with the given @p id.
   */ public new
 SBase getElementBySId(string id) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.SBasePlugin_getElementBySId(swigCPtr, id), false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
	return ret;
}

  
/**
   * Returns the first child element it can find with the given @p metaid, or @c null if no such object is found.
   *
   * @param metaid string representing the metaid of objects to find
   *
   * @return pointer to the first element found with the given @p metaid.
   */ public new
 SBase getElementByMetaId(string metaid) {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.SBasePlugin_getElementByMetaId(swigCPtr, metaid), false);
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
   * or more child elements. Also, SBasePlugin::connectToParent(@if java SBase@endif)
   * must be called in the overridden function.
   *
   * @param sbase the SBase object to use
   *
   * @if cpp 
   * @see setSBMLDocument()
   * @see enablePackageInternal()
   * @endif
   */ /* libsbml-internal */ public new
 void connectToParent(SBase sbase) {
    libsbmlPINVOKE.SBasePlugin_connectToParent(swigCPtr, SBase.getCPtr(sbase));
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
   * @if cpp 
   * @see setSBMLDocument()
   * @see connectToParent()
   * @endif
   */ /* libsbml-internal */ public new
 void enablePackageInternal(string pkgURI, string pkgPrefix, bool flag) {
    libsbmlPINVOKE.SBasePlugin_enablePackageInternal(swigCPtr, pkgURI, pkgPrefix, flag);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** */ /* libsbml-internal */ public new
 bool stripPackage(string pkgPrefix, bool flag) {
    bool ret = libsbmlPINVOKE.SBasePlugin_stripPackage(swigCPtr, pkgPrefix, flag);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the parent SBMLDocument of this plugin object.
   *
   * @return the parent SBMLDocument object of this plugin object.
   */ public
 SBMLDocument getSBMLDocument() {
    IntPtr cPtr = libsbmlPINVOKE.SBasePlugin_getSBMLDocument__SWIG_0(swigCPtr);
    SBMLDocument ret = (cPtr == IntPtr.Zero) ? null : new SBMLDocument(cPtr, false);
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
   * @see getPackageName()
   * @see getElementNamespace()
   * @see SBMLDocument::getSBMLNamespaces()
   * @see getSBMLDocument()
   */ public
 string getURI() {
    string ret = libsbmlPINVOKE.SBasePlugin_getURI(swigCPtr);
    return ret;
  }

  
/**
   * Returns the parent SBase object to which this plugin 
   * object connected.
   *
   * @return the parent SBase object to which this plugin 
   * object connected.
   */ public
 SBase getParentSBMLObject() {
	SBase ret = (SBase) libsbml.DowncastSBase(libsbmlPINVOKE.SBasePlugin_getParentSBMLObject__SWIG_0(swigCPtr), false);
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
   */ public
 int setElementNamespace(string uri) {
    int ret = libsbmlPINVOKE.SBasePlugin_setElementNamespace(swigCPtr, uri);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the SBML level of the package extension of 
   * this plugin object.
   *
   * @return the SBML level of the package extension of
   * this plugin object.
   */ public
 long getLevel() { return (long)libsbmlPINVOKE.SBasePlugin_getLevel(swigCPtr); }

  
/**
   * Returns the SBML version of the package extension of
   * this plugin object.
   *
   * @return the SBML version of the package extension of
   * this plugin object.
   */ public
 long getVersion() { return (long)libsbmlPINVOKE.SBasePlugin_getVersion(swigCPtr); }

  
/**
   * Returns the package version of the package extension of
   * this plugin object.
   *
   * @return the package version of the package extension of
   * this plugin object.
   */ public
 long getPackageVersion() { return (long)libsbmlPINVOKE.SBasePlugin_getPackageVersion(swigCPtr); }

  
/**
   * If this object has a child 'math' object (or anything with ASTNodes in general), replace all nodes with the name 'id' with the provided function. 
   *
   * @note This function does nothing itself--subclasses with ASTNode subelements must override this function.
   */ /* libsbml-internal */ public new
 void replaceSIDWithFunction(string id, ASTNode function) {
    libsbmlPINVOKE.SBasePlugin_replaceSIDWithFunction(swigCPtr, id, ASTNode.getCPtr(function));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * If the function of this object is to assign a value has a child 'math' object (or anything with ASTNodes in general), replace  the 'math' object with the function (existing/function).  
   *
   * @note This function does nothing itself--subclasses with ASTNode subelements must override this function.
   */ /* libsbml-internal */ public new
 void divideAssignmentsToSIdByFunction(string id, ASTNode function) {
    libsbmlPINVOKE.SBasePlugin_divideAssignmentsToSIdByFunction(swigCPtr, id, ASTNode.getCPtr(function));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * If this assignment assigns a value to the 'id' element, replace the 'math' object with the function (existing*function). 
   */ /* libsbml-internal */ public new
 void multiplyAssignmentsToSIdByFunction(string id, ASTNode function) {
    libsbmlPINVOKE.SBasePlugin_multiplyAssignmentsToSIdByFunction(swigCPtr, id, ASTNode.getCPtr(function));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Check to see if the given prefix is used by any of the IDs defined by extension elements.  A package that defines its own 'id' attribute for a core element would check that attribute here.
   */ /* libsbml-internal */ public new
 bool hasIdentifierBeginningWith(string prefix) {
    bool ret = libsbmlPINVOKE.SBasePlugin_hasIdentifierBeginningWith(swigCPtr, prefix);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Add the given string to all identifiers in the object.  If the string is added to anything other than an id or a metaid, this code is responsible for tracking down and renaming all *idRefs in the package extention that identifier comes from.
   */ /* libsbml-internal */ public new
 int prependStringToAllIdentifiers(string prefix) {
    int ret = libsbmlPINVOKE.SBasePlugin_prependStringToAllIdentifiers(swigCPtr, prefix);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public new
 int transformIdentifiers(IdentifierTransformer sidTransformer) {
    int ret = libsbmlPINVOKE.SBasePlugin_transformIdentifiers(swigCPtr, IdentifierTransformer.getCPtr(sidTransformer));
    return ret;
  }

  
/**
   * Returns the line number on which this object first appears in the XML
   * representation of the SBML document.
   * 
   * @return the line number of the underlying SBML object.
   *
   * @note The line number for each construct in an SBML model is set upon
   * reading the model.  The accuracy of the line number depends on the
   * correctness of the XML representation of the model, and on the
   * particular XML parser library being used.  The former limitation
   * relates to the following problem: if the model is actually invalid
   * XML, then the parser may not be able to interpret the data correctly
   * and consequently may not be able to establish the real line number.
   * The latter limitation is simply that different parsers seem to have
   * their own accuracy limitations, and out of all the parsers supported
   * by libSBML, none have been 100% accurate in all situations. (At this
   * time, libSBML supports the use of <a target='_blank'
   * href='http://xmlsoft.org'>libxml2</a>, <a target='_blank'
   * href='http://expat.sourceforge.net/'>Expat</a> and <a target='_blank'
   * href='http://xerces.apache.org/xerces-c/'>Xerces</a>.)
   *
   * @see getColumn()
   */ /* libsbml-internal */ public
 long getLine() { return (long)libsbmlPINVOKE.SBasePlugin_getLine(swigCPtr); }

  
/**
   * Returns the column number on which this object first appears in the XML
   * representation of the SBML document.
   * 
   * @return the column number of the underlying SBML object.
   * 
   * @note The column number for each construct in an SBML model is set
   * upon reading the model.  The accuracy of the column number depends on
   * the correctness of the XML representation of the model, and on the
   * particular XML parser library being used.  The former limitation
   * relates to the following problem: if the model is actually invalid
   * XML, then the parser may not be able to interpret the data correctly
   * and consequently may not be able to establish the real column number.
   * The latter limitation is simply that different parsers seem to have
   * their own accuracy limitations, and out of all the parsers supported
   * by libSBML, none have been 100% accurate in all situations. (At this
   * time, libSBML supports the use of <a target='_blank'
   * href='http://xmlsoft.org'>libxml2</a>, <a target='_blank'
   * href='http://expat.sourceforge.net/'>Expat</a> and <a target='_blank'
   * href='http://xerces.apache.org/xerces-c/'>Xerces</a>.)
   * 
   * @see getLine()
   */ /* libsbml-internal */ public
 long getColumn() { return (long)libsbmlPINVOKE.SBasePlugin_getColumn(swigCPtr); }

  
/** */ /* libsbml-internal */ public new
 SBMLNamespaces getSBMLNamespaces() {
	SBMLNamespaces ret
	    = (SBMLNamespaces) libsbml.DowncastSBMLNamespaces(libsbmlPINVOKE.SBasePlugin_getSBMLNamespaces(swigCPtr), false);
	return ret;
}

  
/**
   * Helper to log a common type of error for elements.
   */ /* libsbml-internal */ public new
 void logUnknownElement(string element, long sbmlLevel, long sbmlVersion, long pkgVersion) {
    libsbmlPINVOKE.SBasePlugin_logUnknownElement(swigCPtr, element, sbmlLevel, sbmlVersion, pkgVersion);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  public SBaseList getListOfAllElements(ElementFilter filter) {
    IntPtr cPtr = libsbmlPINVOKE.SBasePlugin_getListOfAllElements__SWIG_0(swigCPtr, ElementFilter.getCPtr(filter));
    SBaseList ret = (cPtr == IntPtr.Zero) ? null : new SBaseList(cPtr, false);
    return ret;
  }

  public SBaseList getListOfAllElements() {
    IntPtr cPtr = libsbmlPINVOKE.SBasePlugin_getListOfAllElements__SWIG_1(swigCPtr);
    SBaseList ret = (cPtr == IntPtr.Zero) ? null : new SBaseList(cPtr, false);
    return ret;
  }

}

}
