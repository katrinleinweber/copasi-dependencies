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
@htmlinclude pkg-marker-core.html Converter to expand user-defined functions in-line.
 *
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * This converter manipulates user-defined functions in an SBML file.  When
 * invoked on a model, it performs the following operations:
 *
 * @li Reads the list of user-defined functions in the model (i.e., the list
 * of FunctionDefinition objects);
 * @li Looks for invocations of the function in mathematical expressions
 * throughout the model; and
 * @li For each invocation found, replaces the invocation with a in-line copy
 * of the function's body, similar to how macro expansions might be performed
 * in scripting and programming languages.
 *
 * For example, suppose the model contains a function definition
 * representing the function <code>f(x, y) = x * y</code>.  Further
 * suppose this functions invoked somewhere else in the model, in
 * a mathematical formula, as <code>f(s, p)</code>.  The outcome of running
 * SBMLFunctionDefinitionConverter on the model will be to replace
 * the call to <code>f</code> with the expression <code>s * p</code>.
 *
 * @section usage Configuration and use of SBMLFunctionDefinitionConverter
 *
 * SBMLFunctionDefinitionConverter is enabled by creating a
 * ConversionProperties object with the option @c
 * 'expandFunctionDefinitions', and passing this properties object to
 * SBMLDocument::convert(@if java ConversionProperties@endif).
 * The converter accepts one option:
 *
 * @li @c 'skipIds': if set, it should be a string containing a
 * comma-separated list of identifiers (SBML 'id' values) that are to be
 * skipped during function conversion.  Functions whose identifiers are
 * found in this list will not be converted.
 *
 * *
 * @section using-converters General information about the use of SBML converters
 *
 * The use of all the converters follows a similar approach.  First, one
 * creates a ConversionProperties object and calls
 * ConversionProperties::addOption(@if java ConversionOption@endif)
 * on this object with one arguments: a text string that identifies the desired
 * converter.  (The text string is specific to each converter; consult the
 * documentation for a given converter to find out how it should be enabled.)
 *
 * Next, for some converters, the caller can optionally set some
 * converter-specific properties using additional calls to
 * ConversionProperties::addOption(@if java ConversionOption@endif).
 * Many converters provide the ability to
 * configure their behavior to some extent; this is realized through the use
 * of properties that offer different options.  The default property values
 * for each converter can be interrogated using the method
 * SBMLConverter::getDefaultProperties() on the converter class in question .
 *
 * Finally, the caller should invoke the method
 * SBMLDocument::convert(@if java ConversionProperties@endif)
 * with the ConversionProperties object as an argument.
 *
 * @subsection converter-example Example of invoking an SBML converter
 *
 * The following code fragment illustrates an example using
 * SBMLReactionConverter, which is invoked using the option string @c
 * 'replaceReactions':
 *
 * @if cpp
 * @code{.cpp}
ConversionProperties props;
props.addOption('replaceReactions');
@endcode
@endif
@if python
@code{.py}
config = ConversionProperties()
if config != None:
  config.addOption('replaceReactions')
@endcode
@endif
@if java
@code{.java}
ConversionProperties props = new ConversionProperties();
if (props != null) {
  props.addOption('replaceReactions');
} else {
  // Deal with error.
}
@endcode
@endif
 *
 * In the case of SBMLReactionConverter, there are no options to affect
 * its behavior, so the next step is simply to invoke the converter on
 * an SBMLDocument object.  Continuing the example code:
 *
 * @if cpp
 * @code{.cpp}
// Assume that the variable 'document' has been set to an SBMLDocument object.
int status = document->convert(props);
if (status != LIBSBML_OPERATION_SUCCESS)
{
  cerr << 'Unable to perform conversion due to the following:' << endl;
  document->printErrors(cerr);
}
@endcode
@endif
@if python
@code{.py}
  # Assume that the variable 'document' has been set to an SBMLDocument object.
  status = document.convert(config)
  if status != LIBSBML_OPERATION_SUCCESS:
    # Handle error somehow.
    print('Error: conversion failed due to the following:')
    document.printErrors()
@endcode
@endif
@if java
@code{.java}
  // Assume that the variable 'document' has been set to an SBMLDocument object.
  status = document.convert(config);
  if (status != libsbml.LIBSBML_OPERATION_SUCCESS)
  {
    // Handle error somehow.
    System.out.println('Error: conversion failed due to the following:');
    document.printErrors();
  }
@endcode
@endif
 *
 * Here is an example of using a converter that offers an option. The
 * following code invokes SBMLStripPackageConverter to remove the
 * SBML Level&nbsp;3 @em %Layout package from a model.  It sets the name
 * of the package to be removed by adding a value for the option named
 * @c 'package' defined by that converter:
 *
 * @if cpp
 * @code{.cpp}
ConversionProperties props;
props.addOption('stripPackage');
props.addOption('package', 'layout');

int status = document->convert(props);
if (status != LIBSBML_OPERATION_SUCCESS)
{
    cerr << 'Unable to strip the Layout package from the model';
    cerr << 'Error returned: ' << status;
}
@endcode
@endif
@if python
@code{.py}
def strip_layout_example(document):
  config = ConversionProperties()
  if config != None:
    config.addOption('stripPackage')
    config.addOption('package', 'layout')
    status = document.convert(config)
    if status != LIBSBML_OPERATION_SUCCESS:
      # Handle error somehow.
      print('Error: unable to strip the Layout package.')
      print('LibSBML returned error: ' + OperationReturnValue_toString(status).strip())
  else:
    # Handle error somehow.
    print('Error: unable to create ConversionProperties object')
@endcode
@endif
@if java
@code{.java}
ConversionProperties config = new ConversionProperties();
if (config != None) {
  config.addOption('stripPackage');
  config.addOption('package', 'layout');
  status = document.convert(config);
  if (status != LIBSBML_OPERATION_SUCCESS) {
    // Handle error somehow.
    System.out.println('Error: unable to strip the Layout package');
    document.printErrors();
  }
} else {
  // Handle error somehow.
  System.out.println('Error: unable to create ConversionProperties object');
}
@endcode
@endif
 *
 * @subsection available-converters Available SBML converters in libSBML
 *
 * LibSBML provides a number of built-in converters; by convention, their
 * names end in @em Converter. The following are the built-in converters
 * provided by libSBML @htmlinclude libsbml-version.html:
 *
 * @copydetails doc_list_of_libsbml_converters
 *
 *
 */

public class SBMLFunctionDefinitionConverter : SBMLConverter {
	private HandleRef swigCPtr;
	
	internal SBMLFunctionDefinitionConverter(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SBMLFunctionDefinitionConverter_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SBMLFunctionDefinitionConverterUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLFunctionDefinitionConverter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLFunctionDefinitionConverter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLFunctionDefinitionConverter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLFunctionDefinitionConverter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/** */ /* libsbml-internal */ public
 static void init() {
    libsbmlPINVOKE.SBMLFunctionDefinitionConverter_init();
  }

  
/**
   * Creates a new SBMLFunctionDefinitionConverter object.
   */ public
 SBMLFunctionDefinitionConverter() : this(libsbmlPINVOKE.new_SBMLFunctionDefinitionConverter__SWIG_0(), true) {
  }

  
/**
   * Copy constructor; creates a copy of an SBMLFunctionDefinitionConverter
   * object.
   *
   * @param obj the SBMLFunctionDefinitionConverter object to copy.
   */ public
 SBMLFunctionDefinitionConverter(SBMLFunctionDefinitionConverter obj) : this(libsbmlPINVOKE.new_SBMLFunctionDefinitionConverter__SWIG_1(SBMLFunctionDefinitionConverter.getCPtr(obj)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SBMLFunctionDefinitionConverter
   * object.
   *
   * @return a (deep) copy of this converter.
   */ public new
 SBMLConverter clone() {
    IntPtr cPtr = libsbmlPINVOKE.SBMLFunctionDefinitionConverter_clone(swigCPtr);
    SBMLFunctionDefinitionConverter ret = (cPtr == IntPtr.Zero) ? null : new SBMLFunctionDefinitionConverter(cPtr, true);
    return ret;
  }

  
/**
   * Returns @c true if this converter object's properties match the given
   * properties.
   *
   * A typical use of this method involves creating a ConversionProperties
   * object, setting the options desired, and then calling this method on
   * an SBMLFunctionDefinitionConverter object to find out if the object's
   * property values match the given ones.  This method is also used by
   * SBMLConverterRegistry::getConverterFor(@if java ConversionProperties@endif)
   * to search across all registered converters for one matching particular
   * properties.
   *
   * @param props the properties to match.
   *
   * @return @c true if this converter's properties match, @c false
   * otherwise.
   */ public new
 bool matchesProperties(ConversionProperties props) {
    bool ret = libsbmlPINVOKE.SBMLFunctionDefinitionConverter_matchesProperties(swigCPtr, ConversionProperties.getCPtr(props));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Perform the conversion.
   *
   * This method causes the converter to do the actual conversion work,
   * that is, to convert the SBMLDocument object set by
   * SBMLConverter::setDocument(@if java SBMLDocument@endif) and
   * with the configuration options set by
   * SBMLConverter::setProperties(@if java ConversionProperties@endif).
   *
   * *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 *
 *
   * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   * @li @link libsbml#LIBSBML_INVALID_OBJECT LIBSBML_INVALID_OBJECT@endlink
   * @li @link libsbml#LIBSBML_CONV_INVALID_SRC_DOCUMENT LIBSBML_CONV_INVALID_SRC_DOCUMENT@endlink
   */ public new
 int convert() {
    int ret = libsbmlPINVOKE.SBMLFunctionDefinitionConverter_convert(swigCPtr);
    return ret;
  }

  
/**
   * Returns the default properties of this converter.
   *
   * A given converter exposes one or more properties that can be adjusted
   * in order to influence the behavior of the converter.  This method
   * returns the @em default property settings for this converter.  It is
   * meant to be called in order to discover all the settings for the
   * converter object.
   *
   * @return the ConversionProperties object describing the default properties
   * for this converter.
   */ public new
 ConversionProperties getDefaultProperties() {
    ConversionProperties ret = new ConversionProperties(libsbmlPINVOKE.SBMLFunctionDefinitionConverter_getDefaultProperties(swigCPtr), true);
    return ret;
  }

}

}
