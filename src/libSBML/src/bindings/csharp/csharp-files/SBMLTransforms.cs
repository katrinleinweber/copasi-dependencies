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
@htmlinclude pkg-marker-core.html Methods for transform elements of SBML
 *
 * @internal
 */

public class SBMLTransforms : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal SBMLTransforms(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLTransforms obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLTransforms obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLTransforms() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLTransforms(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Expands the math represented by the ASTNode to implement the functionality
   * of the FunctionDefinition, if it occurs within the original
   * math.
   *
   * For example, an ASTNode represents the math expression: f(s, p) where
   * f is the id of a FunctionDefinition representing f(x, y) = x * y.
   * The outcome of the function is that the ASTNode now represents
   * the math expression: s * p
   *
   * @param math ASTNode representing the math to be transformed
   *
   * @param fd the FunctionDefinition to be expanded
   *
   * @param idsToExclude an optional list of function definition ids to exclude.
   *
   * *
 * @if python @note Because this is a static method on a class, the Python
 * language interface for libSBML will contain two variants.  One will be the
 * expected, normal static method on the class (i.e., a regular
 * <em>methodName</em>), and the other will be a standalone top-level
 * function with the name <em>ClassName_methodName()</em>. This is merely an
 * artifact of how the language interfaces are created in libSBML.  The
 * methods are functionally identical. @endif
 *
 *
   */ /* libsbml-internal */ public
 static void replaceFD(ASTNode math, FunctionDefinition fd, IdList idsToExclude) {
    libsbmlPINVOKE.SBMLTransforms_replaceFD__SWIG_0(ASTNode.getCPtr(math), FunctionDefinition.getCPtr(fd), IdList.getCPtr(idsToExclude));
  }

  
/**
   * Expands the math represented by the ASTNode to implement the functionality
   * of the FunctionDefinition, if it occurs within the original
   * math.
   *
   * For example, an ASTNode represents the math expression: f(s, p) where
   * f is the id of a FunctionDefinition representing f(x, y) = x * y.
   * The outcome of the function is that the ASTNode now represents
   * the math expression: s * p
   *
   * @param math ASTNode representing the math to be transformed
   *
   * @param fd the FunctionDefinition to be expanded
   *
   * @param idsToExclude an optional list of function definition ids to exclude.
   *
   * *
 * @if python @note Because this is a static method on a class, the Python
 * language interface for libSBML will contain two variants.  One will be the
 * expected, normal static method on the class (i.e., a regular
 * <em>methodName</em>), and the other will be a standalone top-level
 * function with the name <em>ClassName_methodName()</em>. This is merely an
 * artifact of how the language interfaces are created in libSBML.  The
 * methods are functionally identical. @endif
 *
 *
   */ /* libsbml-internal */ public
 static void replaceFD(ASTNode math, FunctionDefinition fd) {
    libsbmlPINVOKE.SBMLTransforms_replaceFD__SWIG_1(ASTNode.getCPtr(math), FunctionDefinition.getCPtr(fd));
  }

  
/**
   * Expands the math represented by the ASTNode to implement the functionality
   * of all the FunctionDefinitions in the list, if they occur within the 
   * original math.
   *
   * For example, an ASTNode represents the math expression: f(s, g(p, q)) where
   * f is the id of a FunctionDefinition representing f(x, y) = x * y
   * and g is the id of a FunctionDefinition representing f(x, y) = x/y
   * The outcome of the function is that the ASTNode now represents
   * the math expression: s * p/q
   *
   * @param math ASTNode representing the math to be transformed
   *
   * @param lofd the ListOfFunctionDefinitions to be expanded
   * 
   * @param idsToExclude an optional list of function definition ids to exclude.
   *
   * *
 * @if python @note Because this is a static method on a class, the Python
 * language interface for libSBML will contain two variants.  One will be the
 * expected, normal static method on the class (i.e., a regular
 * <em>methodName</em>), and the other will be a standalone top-level
 * function with the name <em>ClassName_methodName()</em>. This is merely an
 * artifact of how the language interfaces are created in libSBML.  The
 * methods are functionally identical. @endif
 *
 *
   */ /* libsbml-internal */ public
 static void replaceFD(ASTNode math, ListOfFunctionDefinitions lofd, IdList idsToExclude) {
    libsbmlPINVOKE.SBMLTransforms_replaceFD__SWIG_2(ASTNode.getCPtr(math), ListOfFunctionDefinitions.getCPtr(lofd), IdList.getCPtr(idsToExclude));
  }

  
/**
   * Expands the math represented by the ASTNode to implement the functionality
   * of all the FunctionDefinitions in the list, if they occur within the 
   * original math.
   *
   * For example, an ASTNode represents the math expression: f(s, g(p, q)) where
   * f is the id of a FunctionDefinition representing f(x, y) = x * y
   * and g is the id of a FunctionDefinition representing f(x, y) = x/y
   * The outcome of the function is that the ASTNode now represents
   * the math expression: s * p/q
   *
   * @param math ASTNode representing the math to be transformed
   *
   * @param lofd the ListOfFunctionDefinitions to be expanded
   * 
   * @param idsToExclude an optional list of function definition ids to exclude.
   *
   * *
 * @if python @note Because this is a static method on a class, the Python
 * language interface for libSBML will contain two variants.  One will be the
 * expected, normal static method on the class (i.e., a regular
 * <em>methodName</em>), and the other will be a standalone top-level
 * function with the name <em>ClassName_methodName()</em>. This is merely an
 * artifact of how the language interfaces are created in libSBML.  The
 * methods are functionally identical. @endif
 *
 *
   */ /* libsbml-internal */ public
 static void replaceFD(ASTNode math, ListOfFunctionDefinitions lofd) {
    libsbmlPINVOKE.SBMLTransforms_replaceFD__SWIG_3(ASTNode.getCPtr(math), ListOfFunctionDefinitions.getCPtr(lofd));
  }

  
/** */ /* libsbml-internal */ public
 static bool expandInitialAssignments(Model m) {
    bool ret = libsbmlPINVOKE.SBMLTransforms_expandInitialAssignments(Model.getCPtr(m));
    return ret;
  }

  
/** */ /* libsbml-internal */ public
 static double evaluateASTNode(ASTNode node, Model m) {
    double ret = libsbmlPINVOKE.SBMLTransforms_evaluateASTNode__SWIG_0(ASTNode.getCPtr(node), Model.getCPtr(m));
    return ret;
  }

  
/** */ /* libsbml-internal */ public
 static double evaluateASTNode(ASTNode node) {
    double ret = libsbmlPINVOKE.SBMLTransforms_evaluateASTNode__SWIG_1(ASTNode.getCPtr(node));
    return ret;
  }

  public static IdList mapComponentValues(Model m) {
    IdList ret = new IdList(libsbmlPINVOKE.SBMLTransforms_mapComponentValues(Model.getCPtr(m)), true);
    return ret;
  }

  public static void clearComponentValues() {
    libsbmlPINVOKE.SBMLTransforms_clearComponentValues();
  }

  public SBMLTransforms() : this(libsbmlPINVOKE.new_SBMLTransforms(), true) {
  }

}

}
