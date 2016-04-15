/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
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
@htmlinclude pkg-marker-core.html Whole-document SBML Level/Version converter.
 *
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * This SBML converter takes an SBML document having one SBML Level+Version
 * combination, and attempts to convert it to an SBML document having a
 * different Level+Version combination.  This converter
 * (SBMLLevel1Version1Converter) converts models to SBML Level&nbsp;1
 * Version&nbsp;1, to the extent possible by the limited features of
 * that Level/Version combination of SBML.
 *
 * @section SBMLLevel1Version1Converter-usage Configuration and use of SBMLLevel1Version1Converter
 *
 * SBMLLevel1Version1Converter is enabled by creating a ConversionProperties
 * object with the option @c 'convertToL1V1', and passing this
 * properties object to SBMLDocument::convert(@if java
 * ConversionProperties@endif).  The target SBML Level and Version
 * combination are determined by the value of the SBML namespace set on the
 * ConversionProperties object (using
 * ConversionProperties::setTargetNamespaces(SBMLNamespaces targetNS)).
 *
 * In addition, this converter offers the following options:
 *
 * @li @c 'changePow': Mathematical expressions for exponentiation of
 * the form <code>pow(s1, 2)</code> will be converted to the expression
 * <code>s1^2</code>.
 *
 * @li @c 'inlineCompartmentSizes': Back in the days of SBML Level&nbsp;1
 * Version&nbsp;1, many software tools assumed that the 'kinetic laws' of
 * SBML were written in terms of units of
 * <em>concentration</em>/<em>time</em>.  These tools would not expect (and
 * thus not handle) rate expressions such as
 * <code>CompartmentOfS1 * k * S1</code>.
 * When the option @c 'inlineCompartmentSizes' is enabled, libSBML will
 * replace the references to compartments (such as @c 'CompartmentOfS1' in
 * this example) with their initial sizes.  This is not strictly correct in
 * all cases; in particular, if the compartment volume varies during
 * simulation, this conversion will not reflect the expected behavior.
 * However, many models do not have time-varying compartment sizes, so this
 * option makes it easy to get modern SBML rate expressions into a form that
 * old software tools may better understand.
 *
 *
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

public class SBMLLevel1Version1Converter : SBMLConverter {
	private HandleRef swigCPtr;
	
	internal SBMLLevel1Version1Converter(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.SBMLLevel1Version1Converter_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.SBMLLevel1Version1ConverterUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SBMLLevel1Version1Converter obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SBMLLevel1Version1Converter obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SBMLLevel1Version1Converter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SBMLLevel1Version1Converter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
/** */ /* libsbml-internal */ public
 static void init() {
    libsbmlPINVOKE.SBMLLevel1Version1Converter_init();
  }

  
/**
   * Creates a new SBMLLevel1Version1Converter object.
   */ public
 SBMLLevel1Version1Converter() : this(libsbmlPINVOKE.new_SBMLLevel1Version1Converter__SWIG_0(), true) {
  }

  
/**
   * Copy constructor; creates a copy of an SBMLLevel1Version1Converter
   * object.
   *
   * @param obj the SBMLLevel1Version1Converter object to copy.
   */ public
 SBMLLevel1Version1Converter(SBMLLevel1Version1Converter obj) : this(libsbmlPINVOKE.new_SBMLLevel1Version1Converter__SWIG_1(SBMLLevel1Version1Converter.getCPtr(obj)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this SBMLLevel1Version1Converter
   * object.
   *
   * @return a (deep) copy of this converter.
   */ public new
 SBMLConverter clone() {
    IntPtr cPtr = libsbmlPINVOKE.SBMLLevel1Version1Converter_clone(swigCPtr);
    SBMLLevel1Version1Converter ret = (cPtr == IntPtr.Zero) ? null : new SBMLLevel1Version1Converter(cPtr, true);
    return ret;
  }

  
/**
   * Returns @c true if this converter object's properties match the given
   * properties.
   *
   * A typical use of this method involves creating a ConversionProperties
   * object, setting the options desired, and then calling this method on
   * an SBMLLevel1Version1Converter object to find out if the object's
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
    bool ret = libsbmlPINVOKE.SBMLLevel1Version1Converter_matchesProperties(swigCPtr, ConversionProperties.getCPtr(props));
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
   *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   * @li @link libsbml#LIBSBML_CONV_INVALID_TARGET_NAMESPACE LIBSBML_CONV_INVALID_TARGET_NAMESPACE@endlink
   * @li @link libsbml#LIBSBML_CONV_PKG_CONVERSION_NOT_AVAILABLE LIBSBML_CONV_PKG_CONVERSION_NOT_AVAILABLE@endlink
   * @li @link libsbml#LIBSBML_CONV_INVALID_SRC_DOCUMENT LIBSBML_CONV_INVALID_SRC_DOCUMENT@endlink
   */ public new
 int convert() {
    int ret = libsbmlPINVOKE.SBMLLevel1Version1Converter_convert(swigCPtr);
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
    ConversionProperties ret = new ConversionProperties(libsbmlPINVOKE.SBMLLevel1Version1Converter_getDefaultProperties(swigCPtr), true);
    return ret;
  }

}

}
