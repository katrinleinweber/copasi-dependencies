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
@htmlinclude pkg-marker-core.html Extension of an element by an SBML Level 3 package.
 * 
 * @ifnot clike @internal @endif
 *
 * SBaseExtensionPoint represents an element to be extended (extension point) and the
 * extension point is identified by a combination of a package name and a typecode of the 
 * element.
 * 
 * <p>
 * For example, an SBaseExtensionPoint object which represents an extension point of the model
 * element defined in the <em>core</em> package can be created as follows:
 *
@verbatim
      SBaseExtensionPoint  modelextp('core', SBML_MODEL);
@endverbatim
 * 
 * Similarly, an SBaseExtensionPoint object which represents an extension point of
 * the layout element defined in the layout extension can be created as follows:
 * 
@verbatim
      SBaseExtensionPoint  layoutextp('layout', SBML_LAYOUT_LAYOUT);
@endverbatim
 * 
 * SBaseExtensionPoint object is required as one of arguments of the constructor 
 * of SBasePluginCreator&lt;class SBasePluginType, class SBMLExtensionType&gt;
 * template class to identify an extension poitnt to which the plugin object created
 * by the creator class is plugged in.
 * For example, the SBasePluginCreator class which creates a LayoutModelPlugin object
 * of the layout extension which is plugged in to the model element of the <em>core</em>
 * package can be created with the corresponding SBaseExtensionPoint object as follows:
 *
@verbatim
  // std::vector object that contains a list of URI (package versions) supported 
  // by the plugin object.
  std::vector<string> packageURIs;
  packageURIs.push_back(getXmlnsL3V1V1());
  packageURIs.push_back(getXmlnsL2());  

  // creates an extension point (model element of the 'core' package)
  SBaseExtensionPoint  modelExtPoint('core',SBML_MODEL);
   
  // creates an SBasePluginCreator object 
  SBasePluginCreator<LayoutModelPlugin, LayoutExtension>  modelPluginCreator(modelExtPoint,packageURIs);
@endverbatim
 *
 * This kind of code is implemented in init() function of each SBMLExtension derived classes.
 */

public class SBaseExtensionPoint : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal SBaseExtensionPoint(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBaseExtensionPoint obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBaseExtensionPoint obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBaseExtensionPoint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBaseExtensionPoint(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * constructor
   */ public
 SBaseExtensionPoint(string pkgName, int typeCode) : this(libsbmlPINVOKE.new_SBaseExtensionPoint__SWIG_0(pkgName, typeCode), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * copy constructor
   */ public
 SBaseExtensionPoint(SBaseExtensionPoint rhs) : this(libsbmlPINVOKE.new_SBaseExtensionPoint__SWIG_1(SBaseExtensionPoint.getCPtr(rhs)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SBaseExtensionPoint object.
   *
   * @return the (deep) copy of this SBaseExtensionPoint object.
   */ public
 SBaseExtensionPoint clone() {
    IntPtr cPtr = libsbmlPINVOKE.SBaseExtensionPoint_clone(swigCPtr);
    SBaseExtensionPoint ret = (cPtr == IntPtr.Zero) ? null : new SBaseExtensionPoint(cPtr, true);
    return ret;
  }

  
/**
   * Returns the package name of this extension point.
   */ public
 string getPackageName() {
    string ret = libsbmlPINVOKE.SBaseExtensionPoint_getPackageName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the typecode of this extension point.
   */ public new
 int getTypeCode() {
    int ret = libsbmlPINVOKE.SBaseExtensionPoint_getTypeCode(swigCPtr);
    return ret;
  }

}

}