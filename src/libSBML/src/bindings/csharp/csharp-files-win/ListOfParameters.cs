/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html A list of Parameter objects.
 * 
 * *
 * 
 * The various ListOf___ @if conly structures @else classes@endif in SBML
 * are merely containers used for organizing the main components of an SBML
 * model.  In libSBML's implementation, ListOf___
 * @if conly data structures @else classes@endif are derived from the
 * intermediate utility @if conly structure @else class@endif ListOf, which
 * is not defined by the SBML specifications but serves as a useful
 * programmatic construct.  ListOf is itself is in turn derived from SBase,
 * which provides all of the various ListOf___
 * @if conly data structures @else classes@endif with common features
 * defined by the SBML specification, such as 'metaid' attributes and
 * annotations.
 *
 * The relationship between the lists and the rest of an SBML model is
 * illustrated by the following (for SBML Level&nbsp;2 Version&nbsp;4):
 *
 * @htmlinclude listof-illustration.html
 *
 * Readers may wonder about the motivations for using the ListOf___
 * containers in SBML.  A simpler approach in XML might be to place the
 * components all directly at the top level of the model definition.  The
 * choice made in SBML is to group them within XML elements named after
 * %ListOf<em>Classname</em>, in part because it helps organize the
 * components.  More importantly, the fact that the container classes are
 * derived from SBase means that software tools can add information @em about
 * the lists themselves into each list container's 'annotation'.
 *
 * @see ListOfFunctionDefinitions
 * @see ListOfUnitDefinitions
 * @see ListOfCompartmentTypes
 * @see ListOfSpeciesTypes
 * @see ListOfCompartments
 * @see ListOfSpecies
 * @see ListOfParameters
 * @see ListOfInitialAssignments
 * @see ListOfRules
 * @see ListOfConstraints
 * @see ListOfReactions
 * @see ListOfEvents
 *
 * @if conly
 * @note In the C API for libSBML, functions that in other language APIs
 * would be inherited by the various ListOf___ structures not shown in the
 * pages for the individual ListOf___'s.  Instead, the functions are defined
 * on ListOf_t.  <strong>Please consult the documentation for ListOf_t for
 * the many common functions available for manipulating ListOf___
 * structures</strong>.  The documentation for the individual ListOf___
 * structures (ListOfCompartments_t, ListOfReactions_t, etc.) does not reveal
 * all of the functionality available. @endif
 *
 *
 */

public class ListOfParameters : ListOf {
	private HandleRef swigCPtr;
	
	internal ListOfParameters(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.ListOfParameters_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.ListOfParametersUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ListOfParameters obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ListOfParameters obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ListOfParameters() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ListOfParameters(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/**
   * Creates a new ListOfParameters object.
   *
   * The object is constructed such that it is valid for the given SBML
   * Level and Version combination.
   *
   * @param level the SBML Level
   * 
   * @param version the Version within the SBML Level
   */ public
 ListOfParameters(long level, long version) : this(libsbmlPINVOKE.new_ListOfParameters__SWIG_0(level, version), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new ListOfParameters object.
   * 
   * The object is constructed such that it is valid for the SBML Level and
   * Version combination determined by the SBMLNamespaces object in @p
   * sbmlns.
   *
   * @param sbmlns an SBMLNamespaces object that is used to determine the
   * characteristics of the ListOfParameters object to be created.
   */ public
 ListOfParameters(SBMLNamespaces sbmlns) : this(libsbmlPINVOKE.new_ListOfParameters__SWIG_1(SBMLNamespaces.getCPtr(sbmlns)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ListOfParameters object.
   *
   * @return the (deep) copy of this ListOfParameters object.
   */ public new
 ListOfParameters clone() {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_clone(swigCPtr);
    ListOfParameters ret = (cPtr == IntPtr.Zero) ? null : new ListOfParameters(cPtr, true);
    return ret;
  }

  
/**
   * Returns the libSBML type code for the objects contained in this ListOf
   * (i.e., Parameter objects, if the list is non-empty).
   * 
   * *
 * 
 * LibSBML attaches an identifying code to every kind of SBML object.  These
 * are integer constants known as <em>SBML type codes</em>.  The names of all
 * the codes begin with the characters &ldquo;<code>SBML_</code>&rdquo;.
 * @if clike The set of possible type codes for core elements is defined in
 * the enumeration #SBMLTypeCode_t, and in addition, libSBML plug-ins for
 * SBML Level&nbsp;3 packages define their own extra enumerations of type
 * codes (e.g., #SBMLLayoutTypeCode_t for the Level&nbsp;3 Layout
 * package).@endif@if java In the Java language interface for libSBML, the
 * type codes are defined as static integer constants in the interface class
 * {@link libsbmlConstants}.  @endif@if python In the Python language
 * interface for libSBML, the type codes are defined as static integer
 * constants in the interface class @link libsbml@endlink.@endif@if csharp In
 * the C# language interface for libSBML, the type codes are defined as
 * static integer constants in the interface class
 * @link libsbmlcs.libsbml@endlink.@endif  Note that different Level&nbsp;3
 * package plug-ins may use overlapping type codes; to identify the package
 * to which a given object belongs, call the <code>getPackageName()</code>
 * method on the object.
 *
 *
   *
   * @return the SBML type code for this objects contained in this list:
   * @link libsbml#SBML_PARAMETER SBML_PARAMETER@endlink (default).
   *
   * @see getElementName()
   * @see getPackageName()
   */ public new
 int getItemTypeCode() {
    int ret = libsbmlPINVOKE.ListOfParameters_getItemTypeCode(swigCPtr);
    return ret;
  }

  
/**
   * Returns the XML element name of this object.
   *
   * For ListOfParameters, the XML element name is @c 'listOfParameters'.
   * 
   * @return the name of this element, i.e., @c 'listOfParameters'.
   */ public new
 string getElementName() {
    string ret = libsbmlPINVOKE.ListOfParameters_getElementName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the Parameter object located at position @p n within this
   * ListOfParameters instance.
   *
   * @param n the index number of the Parameter to get.
   * 
   * @return the nth Parameter in this ListOfParameters.  If the index @p n
   * is out of bounds for the length of the list, then @c null is returned.
   *
   * @see size()
   * @see get(string sid)
   */ public new
 Parameter get(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_get__SWIG_0(swigCPtr, n);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, false);
    return ret;
  }

  
/**
   * Returns the first Parameter object matching the given identifier.
   *
   * @param sid a string, the identifier of the Parameter to get.
   * 
   * @return the Parameter object found.  The caller owns the returned
   * object and is responsible for deleting it.  If none of the items have
   * an identifier matching @p sid, then @c null is returned.
   *
   * @see get(long n)
   * @see size()
   */ public new
 Parameter get(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_get__SWIG_2(swigCPtr, sid);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, false);
    return ret;
  }

  
/**
   * Removes the nth item from this ListOfParameters, and returns a pointer
   * to it.
   *
   * @param n the index of the item to remove
   *
   * @return the item removed.  The caller owns the returned object and is
   * responsible for deleting it.  If the index number @p n is out of
   * bounds for the length of the list, then @c null is returned.
   *
   * @see size()
   */ public new
 Parameter remove(long n) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_remove__SWIG_0(swigCPtr, n);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, true);
    return ret;
  }

  
/**
   * Removes the first Parameter object in this ListOfParameters
   * matching the given identifier, and returns a pointer to it.
   *
   * @param sid the identifier of the item to remove.
   *
   * @return the item removed.  The caller owns the returned object and is
   * responsible for deleting it.  If none of the items have an identifier
   * matching @p sid, then @c null is returned.
   */ public new
 Parameter remove(string sid) {
    IntPtr cPtr = libsbmlPINVOKE.ListOfParameters_remove__SWIG_1(swigCPtr, sid);
    Parameter ret = (cPtr == IntPtr.Zero) ? null : new Parameter(cPtr, true);
    return ret;
  }

}

}
