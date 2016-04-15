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
@htmlinclude pkg-marker-core.html Set of configuration option values for a converter.
 *
 * @htmlinclude libsbml-facility-only-warning.html
 *
 * LibSBML provides a number of converters that can perform transformations
 * on SBML documents. The properties of SBML converters are communicated
 * using objects of class ConversionProperties, and within such objects,
 * individual options are encapsulated using ConversionOption objects.  The
 * ConversionProperties class provides numerous methods for setting and
 * getting options.
 *
 * ConversionProperties objects are also used to determine the target SBML
 * namespace when an SBML converter's behavior depends on the intended
 * Level+Version combination of SBML.  In addition, it is conceivable that
 * conversions may be affected by SBML Level&nbsp;3 packages being used by an
 * SBML document; consequently, the packages in use are also communicated by
 * the values of the SBML namespaces set on a ConversionProperties object.
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
 *
 * @see ConversionOption
 * @see SBMLNamespaces
 */

public class ConversionProperties : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal ConversionProperties(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(ConversionProperties obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (ConversionProperties obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~ConversionProperties() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_ConversionProperties(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Constructor that initializes the conversion properties
   * with a specific SBML target namespace.
   *
   * @param targetNS the target namespace to convert to
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 ConversionProperties(SBMLNamespaces targetNS) : this(libsbmlPINVOKE.new_ConversionProperties__SWIG_0(SBMLNamespaces.getCPtr(targetNS)), true) {
  }

  
/**
   * Constructor that initializes the conversion properties
   * with a specific SBML target namespace.
   *
   * @param targetNS the target namespace to convert to
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 ConversionProperties() : this(libsbmlPINVOKE.new_ConversionProperties__SWIG_1(), true) {
  }

  
/**
   * Copy constructor.
   *
   * @param orig the object to copy.
   */ public
 ConversionProperties(ConversionProperties orig) : this(libsbmlPINVOKE.new_ConversionProperties__SWIG_2(ConversionProperties.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this ConversionProperties object.
   *
   * @return the (deep) copy of this ConversionProperties object.
   */ public new
 ConversionProperties clone() {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_clone(swigCPtr);
    ConversionProperties ret = (cPtr == IntPtr.Zero) ? null : new ConversionProperties(cPtr, true);
    return ret;
  }

  
/**
   * Returns the current target SBML namespace.
   *
   * @return the SBMLNamepaces object expressing the target namespace.
   */ public new
 SBMLNamespaces getTargetNamespaces() {
	SBMLNamespaces ret
	    = (SBMLNamespaces) libsbml.DowncastSBMLNamespaces(libsbmlPINVOKE.ConversionProperties_getTargetNamespaces(swigCPtr), false);
	return ret;
}

  
/**
   * Returns @c true if the target SBML namespace has been set.
   *
   * @return @c true if the target namespace has been set, @c false
   * otherwise.
   */ public new
 bool hasTargetNamespaces() {
    bool ret = libsbmlPINVOKE.ConversionProperties_hasTargetNamespaces(swigCPtr);
    return ret;
  }

  
/**
   * Sets the target namespace.
   *
   * @param targetNS the target namespace to use.
   */ public new
 void setTargetNamespaces(SBMLNamespaces targetNS) {
    libsbmlPINVOKE.ConversionProperties_setTargetNamespaces(swigCPtr, SBMLNamespaces.getCPtr(targetNS));
  }

  
/**
   * Returns the description string for a given option in this properties
   * object.
   *
   * @param key the key for the option.
   *
   * @return the description text of the option with the given key.
   */ public new
 string getDescription(string key) {
    string ret = libsbmlPINVOKE.ConversionProperties_getDescription(swigCPtr, key);
    return ret;
  }

  
/**
   * Returns the type of a given option in this properties object.
   *
   * @param key the key for the option.
   *
   * @return the type of the option with the given key.
   */ public new
 int getType(string key) {
    int ret = libsbmlPINVOKE.ConversionProperties_getType(swigCPtr, key);
    return ret;
  }

  
/**
   * Returns the ConversionOption object for a given key.
   *
   * @param key the key for the option.
   *
   * @return the option with the given key.
   */ public new
 ConversionOption getOption(string key) {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_getOption__SWIG_0(swigCPtr, key);
    ConversionOption ret = (cPtr == IntPtr.Zero) ? null : new ConversionOption(cPtr, false);
    return ret;
  }

  
/**
   * Returns the ConversionOption object for the given index.
   *
   * @param index the index for the option.
   *
   * @return the option with the given index.
   */ public new
 ConversionOption getOption(int index) {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_getOption__SWIG_1(swigCPtr, index);
    ConversionOption ret = (cPtr == IntPtr.Zero) ? null : new ConversionOption(cPtr, false);
    return ret;
  }

  
/**
   * Adds a copy of the given option to this properties object.
   *
   * @param option the option to add
   */ public new
 void addOption(ConversionOption option) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_0(swigCPtr, ConversionOption.getCPtr(option));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for ConversionOption for more information about the types)
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, string value, int type, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_1(swigCPtr, key, value, type, description);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for ConversionOption for more information about the types)
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, string value, int type) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_2(swigCPtr, key, value, type);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for ConversionOption for more information about the types)
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, string value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_3(swigCPtr, key, value);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for ConversionOption for more information about the types)
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_4(swigCPtr, key);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the string value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, string value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_5(swigCPtr, key, value, description);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the boolean value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, bool value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_7(swigCPtr, key, value, description);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the boolean value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, bool value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_8(swigCPtr, key, value);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the double value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, double value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_9(swigCPtr, key, value, description);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the double value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, double value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_10(swigCPtr, key, value);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the float value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, float value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_11(swigCPtr, key, value, description);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the float value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, float value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_12(swigCPtr, key, value);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the integer value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, int value, string description) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_13(swigCPtr, key, value, description);
  }

  
/**
   * Adds a new ConversionOption object with the given parameters.
   *
   * @param key the key for the new option
   * @param value the integer value of that option
   * @param description (optional) the description for the option
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public new
 void addOption(string key, int value) {
    libsbmlPINVOKE.ConversionProperties_addOption__SWIG_14(swigCPtr, key, value);
  }

  
/**
   * Removes the option with the given key from this properties object.
   *
   * @param key the key for the new option to remove
   * @return the removed option
   */ public new
 ConversionOption removeOption(string key) {
    IntPtr cPtr = libsbmlPINVOKE.ConversionProperties_removeOption(swigCPtr, key);
    ConversionOption ret = (cPtr == IntPtr.Zero) ? null : new ConversionOption(cPtr, false);
    return ret;
  }

  
/**
   * Returns @c true if this properties object contains an option with
   * the given key.
   *
   * @param key the key of the option to find.
   *
   * @return @c true if an option with the given @p key exists in
   * this properties object, @c false otherwise.
   */ public new
 bool hasOption(string key) {
    bool ret = libsbmlPINVOKE.ConversionProperties_hasOption(swigCPtr, key);
    return ret;
  }

  
/**
   * Returns the value of the given option as a string.
   *
   * @param key the key for the option.
   *
   * @return the string value of the option with the given key.
   */ public new
 string getValue(string key) {
    string ret = libsbmlPINVOKE.ConversionProperties_getValue(swigCPtr, key);
    return ret;
  }

  
/**
   * Sets the value of the given option to a string.
   *
   * @param key the key for the option
   * @param value the new value
   */ public new
 void setValue(string key, string value) {
    libsbmlPINVOKE.ConversionProperties_setValue(swigCPtr, key, value);
  }

  
/**
   * Returns the value of the given option as a Boolean.
   *
   * @param key the key for the option.
   *
   * @return the boolean value of the option with the given key.
   */ public new
 bool getBoolValue(string key) {
    bool ret = libsbmlPINVOKE.ConversionProperties_getBoolValue(swigCPtr, key);
    return ret;
  }

  
/**
   * Sets the value of the given option to a Boolean.
   *
   * @param key the key for the option.
   *
   * @param value the new Boolean value.
   */ public new
 void setBoolValue(string key, bool value) {
    libsbmlPINVOKE.ConversionProperties_setBoolValue(swigCPtr, key, value);
  }

  
/**
   * Returns the value of the given option as a @c double.
   *
   * @param key the key for the option.
   *
   * @return the double value of the option with the given key.
   */ public new
 double getDoubleValue(string key) {
    double ret = libsbmlPINVOKE.ConversionProperties_getDoubleValue(swigCPtr, key);
    return ret;
  }

  
/**
   * Sets the value of the given option to a @c double.
   *
   * @param key the key for the option.
   *
   * @param value the new double value.
   */ public new
 void setDoubleValue(string key, double value) {
    libsbmlPINVOKE.ConversionProperties_setDoubleValue(swigCPtr, key, value);
  }

  
/**
   * Returns the value of the given option as a @c float.
   *
   * @param key the key for the option.
   *
   * @return the float value of the option with the given key.
   */ public new
 float getFloatValue(string key) {
    float ret = libsbmlPINVOKE.ConversionProperties_getFloatValue(swigCPtr, key);
    return ret;
  }

  
/**
   * Sets the value of the given option to a @c float.
   *
   * @param key the key for the option.
   *
   * @param value the new float value.
   */ public new
 void setFloatValue(string key, float value) {
    libsbmlPINVOKE.ConversionProperties_setFloatValue(swigCPtr, key, value);
  }

  
/**
   * Returns the value of the given option as an integer.
   *
   * @param key the key for the option.
   *
   * @return the int value of the option with the given key.
   */ public new
 int getIntValue(string key) {
    int ret = libsbmlPINVOKE.ConversionProperties_getIntValue(swigCPtr, key);
    return ret;
  }

  
/**
   * Sets the value of the given option to an integer.
   *
   * @param key the key for the option.
   *
   * @param value the new integer value.
   */ public new
 void setIntValue(string key, int value) {
    libsbmlPINVOKE.ConversionProperties_setIntValue(swigCPtr, key, value);
  }

  
/** 
   * Returns the number of options in this Conversion Properties object
   *
   * @return the number of options in this properties object
   */ public new
 int getNumOptions() {
    int ret = libsbmlPINVOKE.ConversionProperties_getNumOptions(swigCPtr);
    return ret;
  }

}

}
