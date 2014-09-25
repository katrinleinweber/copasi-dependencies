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
@htmlinclude pkg-marker-core.html MIRIAM-compliant data about a model's creator.
 *
 * @htmlinclude not-sbml-warning.html
 *
 * The SBML specification beginning with Level&nbsp;2 Version&nbsp;2
 * defines a standard approach to recording model history and model creator
 * information in a form that complies with MIRIAM ('Minimum Information
 * Requested in the Annotation of biochemical Models', <i>Nature
 * Biotechnology</i>, vol. 23, no. 12, Dec. 2005).  For the model creator,
 * this form involves the use of parts of the <a target='_blank'
 * href='http://en.wikipedia.org/wiki/VCard'>vCard</a> representation.
 * LibSBML provides the ModelCreator class as a convenience high-level
 * interface for working with model creator data.  Objects of class
 * ModelCreator can be used to store and carry around creator data within a
 * program, and the various methods in this object class let callers
 * manipulate the different parts of the model creator representation.
 *
 * @section parts The different parts of a model creator definition
 *
 * The ModelCreator class mirrors the structure of the MIRIAM model creator
 * annotations in SBML.  The following template illustrates these different
 * fields when they are written in XML form:
 *
 <pre class='fragment'>
 &lt;vCard:N rdf:parseType='Resource'&gt;
   &lt;vCard:Family&gt;<span style='background-color: #bbb'>family name</span>&lt;/vCard:Family&gt;
   &lt;vCard:Given&gt;<span style='background-color: #bbb'>given name</span>&lt;/vCard:Given&gt;
 &lt;/vCard:N&gt;
 ...
 &lt;vCard:EMAIL&gt;<span style='background-color: #bbb'>email address</span>&lt;/vCard:EMAIL&gt;
 ...
 &lt;vCard:ORG rdf:parseType='Resource'&gt;
   &lt;vCard:Orgname&gt;<span style='background-color: #bbb'>organization</span>&lt;/vCard:Orgname&gt;
 &lt;/vCard:ORG&gt;
 </pre>
 *
 * Each of the separate data values
 * <span class='code' style='background-color: #bbb'>family name</span>,
 * <span class='code' style='background-color: #bbb'>given name</span>,
 * <span class='code' style='background-color: #bbb'>email address</span>, and
 * <span class='code' style='background-color: #bbb'>organization</span> can
 * be set and retrieved via corresponding methods in the ModelCreator 
 * class.  These methods are documented in more detail below.
 *
 * 
 */

public class ModelCreator : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ModelCreator(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ModelCreator obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ModelCreator obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ModelCreator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ModelCreator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static bool operator==(ModelCreator lhs, ModelCreator rhs)
  {
    if((Object)lhs == (Object)rhs)
    {
      return true;
    }

    if( ((Object)lhs == null) || ((Object)rhs == null) )
    {
      return false;
    }

    return (getCPtr(lhs).Handle.ToString() == getCPtr(rhs).Handle.ToString());
  }

  public static bool operator!=(ModelCreator lhs, ModelCreator rhs)
  {
    return !(lhs == rhs);
  }

  public override bool Equals(Object sb)
  {
    if ( ! (sb is ModelCreator) )
    {
      return false;
    }

    return this == (ModelCreator)sb;
  }

  public override int GetHashCode()
  {
    return swigCPtr.Handle.ToInt32();
  }

  
/**
   * Creates a new ModelCreator object.
   */ public
 ModelCreator() : this(libsbmlPINVOKE.new_ModelCreator__SWIG_0(), true) {
  }

  
/**
   * Creates a new ModelCreator from an XMLNode.
   *
   * @param creator the XMLNode from which to create the ModelCreator.
   */ public
 ModelCreator(XMLNode creator) : this(libsbmlPINVOKE.new_ModelCreator__SWIG_1(XMLNode.getCPtr(creator)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of the ModelCreator.
   *
   * @param orig the object to copy.
   * 
   * @throws SBMLConstructorException
   * Thrown if the argument @p orig is @c null.
   */ public
 ModelCreator(ModelCreator orig) : this(libsbmlPINVOKE.new_ModelCreator__SWIG_2(ModelCreator.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ModelCreator object.
   *
   * @return the (deep) copy of this ModelCreator object.
   */ public
 ModelCreator clone() {
    IntPtr cPtr = libsbmlPINVOKE.ModelCreator_clone(swigCPtr);
    ModelCreator ret = (cPtr == IntPtr.Zero) ? null : new ModelCreator(cPtr, true);
    return ret;
  }

  
/**
   * Returns the 'family name' stored in this ModelCreator object.
   *
   * @return the 'family name' portion of the ModelCreator object.
   */ public
 string getFamilyName() {
    string ret = libsbmlPINVOKE.ModelCreator_getFamilyName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the 'given name' stored in this ModelCreator object.
   *
   * @return the 'given name' portion of the ModelCreator object.
   */ public
 string getGivenName() {
    string ret = libsbmlPINVOKE.ModelCreator_getGivenName(swigCPtr);
    return ret;
  }

  
/**
   * Returns the 'email' stored in this ModelCreator object.
   *
   * @return email from the ModelCreator.
   */ public
 string getEmail() {
    string ret = libsbmlPINVOKE.ModelCreator_getEmail(swigCPtr);
    return ret;
  }

  
/**
   * Returns the 'organization' stored in this ModelCreator object.
   *
   * @return organization from the ModelCreator.
   */ public
 string getOrganization() {
    string ret = libsbmlPINVOKE.ModelCreator_getOrganization(swigCPtr);
    return ret;
  }

  
/**
   * (Alternate spelling) Returns the 'organization' stored in this
   * ModelCreator object.
   *
   * @note This function is an alias of getOrganization().
   *
   * @return organization from the ModelCreator.
   *
   * @see getOrganization()
   */ public
 string getOrganisation() {
    string ret = libsbmlPINVOKE.ModelCreator_getOrganisation(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether this
   * ModelCreator's 'family name' part is set.
   *
   * @return @c true if the familyName of this ModelCreator is set, @c false otherwise.
   */ public
 bool isSetFamilyName() {
    bool ret = libsbmlPINVOKE.ModelCreator_isSetFamilyName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether this
   * ModelCreator's 'given name' part is set.
   *
   * @return @c true if the givenName of this ModelCreator is set, @c false otherwise.
   */ public
 bool isSetGivenName() {
    bool ret = libsbmlPINVOKE.ModelCreator_isSetGivenName(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether this
   * ModelCreator's 'email' part is set.
   *
   * @return @c true if the email of this ModelCreator is set, @c false otherwise.
   */ public
 bool isSetEmail() {
    bool ret = libsbmlPINVOKE.ModelCreator_isSetEmail(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether this
   * ModelCreator's 'organization' part is set.
   *
   * @return @c true if the organization of this ModelCreator is set, @c false otherwise.
   */ public
 bool isSetOrganization() {
    bool ret = libsbmlPINVOKE.ModelCreator_isSetOrganization(swigCPtr);
    return ret;
  }

  
/**
   * (Alternate spelling) Predicate returning @c true or @c false depending
   * on whether this ModelCreator's 'organization' part is set.
   *
   * @note This function is an alias of isSetOrganization().
   *
   * @return @c true if the organization of this ModelCreator is set, @c false otherwise.
   *
   * @see isSetOrganization()
   */ public
 bool isSetOrganisation() {
    bool ret = libsbmlPINVOKE.ModelCreator_isSetOrganisation(swigCPtr);
    return ret;
  }

  
/**
   * Sets the 'family name' portion of this ModelCreator object.
   *  
   * @param familyName a string representing the familyName of the ModelCreator. 
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int setFamilyName(string familyName) {
    int ret = libsbmlPINVOKE.ModelCreator_setFamilyName(swigCPtr, familyName);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the 'given name' portion of this ModelCreator object.
   *  
   * @param givenName a string representing the givenName of the ModelCreator. 
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int setGivenName(string givenName) {
    int ret = libsbmlPINVOKE.ModelCreator_setGivenName(swigCPtr, givenName);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the 'email' portion of this ModelCreator object.
   *  
   * @param email a string representing the email of the ModelCreator. 
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int setEmail(string email) {
    int ret = libsbmlPINVOKE.ModelCreator_setEmail(swigCPtr, email);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Sets the 'organization' portion of this ModelCreator object.
   *  
   * @param organization a string representing the organization of the 
   * ModelCreator. 
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int setOrganization(string organization) {
    int ret = libsbmlPINVOKE.ModelCreator_setOrganization(swigCPtr, organization);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * (Alternate spelling) Sets the 'organization' portion of this
   * ModelCreator object.
   *
   * @param organization a string representing the organization of the
   * ModelCreator.
   *
   * @note This function is an alias of setOrganization(string organization).
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   *
   * @see setOrganization(string organization)
   */ public
 int setOrganisation(string organization) {
    int ret = libsbmlPINVOKE.ModelCreator_setOrganisation(swigCPtr, organization);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Unsets the 'family name' portion of this ModelCreator object.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   */ public
 int unsetFamilyName() {
    int ret = libsbmlPINVOKE.ModelCreator_unsetFamilyName(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the 'given name' portion of this ModelCreator object.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   */ public
 int unsetGivenName() {
    int ret = libsbmlPINVOKE.ModelCreator_unsetGivenName(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the 'email' portion of this ModelCreator object.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   */ public
 int unsetEmail() {
    int ret = libsbmlPINVOKE.ModelCreator_unsetEmail(swigCPtr);
    return ret;
  }

  
/**
   * Unsets the 'organization' portion of this ModelCreator object.
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   */ public
 int unsetOrganization() {
    int ret = libsbmlPINVOKE.ModelCreator_unsetOrganization(swigCPtr);
    return ret;
  }

  
/**
   * (Alternate spelling) Unsets the 'organization' portion of this ModelCreator object.
   *
   * @note This function is an alias of unsetOrganization().
   *
   * @return integer value indicating success/failure of the
   * function.  @if clike The value is drawn from the
   * enumeration #OperationReturnValues_t. @endif The possible values
   * returned by this function are:
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   *
   * @see unsetOrganization()
   */ public
 int unsetOrganisation() {
    int ret = libsbmlPINVOKE.ModelCreator_unsetOrganisation(swigCPtr);
    return ret;
  }

  
/**
   * Predicate returning @c true if all the required elements for this
   * ModelCreator object have been set.
   *
   * The only required elements for a ModelCreator object are the 'family
   * name' and 'given name'.
   *
   * @return a bool value indicating whether all the required
   * elements for this object have been defined.
   */ public
 bool hasRequiredAttributes() {
    bool ret = libsbmlPINVOKE.ModelCreator_hasRequiredAttributes(swigCPtr);
    return ret;
  }

  
/** */ /* libsbml-internal */ public
 bool hasBeenModified() {
    bool ret = libsbmlPINVOKE.ModelCreator_hasBeenModified(swigCPtr);
    return ret;
  }

  
/** */ /* libsbml-internal */ public
 void resetModifiedFlags() {
    libsbmlPINVOKE.ModelCreator_resetModifiedFlags(swigCPtr);
  }

}

}
