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

public class SWIGTYPE_p_ExpectedAttributes {
  private HandleRef swigCPtr;

  internal SWIGTYPE_p_ExpectedAttributes(IntPtr cPtr, bool futureUse) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  protected SWIGTYPE_p_ExpectedAttributes() {
    swigCPtr = new HandleRef(null, IntPtr.Zero);
  }

  internal static HandleRef getCPtr(SWIGTYPE_p_ExpectedAttributes obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
}

}
