/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 *  Exception used by package extensions
 <p>
 * <p style='color: #777; font-style: italic'>
This class of objects is defined by libSBML only and has no direct
equivalent in terms of SBML components.  This class is not prescribed by
the SBML specifications, although it is used to implement features
defined in SBML.
</p>

 <p>
 * <p>
 * Certain situations can result in an exception being thrown by libSBML
 * package extensions.  A prominent example involves the constructor for
 * {@link SBMLNamespaces} (and its subclasses), which will throw
 * {@link SBMLExtensionException} if the arguments it is given refer to an unknown
 * SBML Level&nbsp;3 package.  The situation can arise for legitimate SBML
 * files if the necessary package extension has not been registered with
 * a given copy of libSBML.
 <p>
 * @see SBMLNamespaces
 */

public class SBMLExtensionException {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected SBMLExtensionException(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(SBMLExtensionException obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (SBMLExtensionException obj)
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
        libsbmlJNI.delete_SBMLExtensionException(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  
/**
   * Creates a new {@link SBMLExtensionException} object with a given message.
   <p>
   * @param errmsg a string, the text of the error message to store
   * with this exception
   */ public
 SBMLExtensionException(String errmsg) {
    this(libsbmlJNI.new_SBMLExtensionException(errmsg), true);
  }

}
