/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.sbml.libsbml;

/** 
 *  Set of configuration option values for a converter.
 <p>
 * <p style='color: #777; font-style: italic'>
This class of objects is defined by libSBML only and has no direct
equivalent in terms of SBML components.  It is a class used in
the implementation of extra functionality provided by libSBML.
</p>

 <p>
 * LibSBML provides a number of converters that can perform transformations
 * on SBML documents. The properties of SBML converters are communicated
 * using objects of class {@link ConversionProperties}, and within such objects,
 * individual options are encapsulated using {@link ConversionOption} objects.  The
 * {@link ConversionProperties} class provides numerous methods for setting and
 * getting options.
 <p>
 * {@link ConversionProperties} objects are also used to determine the target SBML
 * namespace when an SBML converter's behavior depends on the intended
 * Level+Version combination of SBML.  In addition, it is conceivable that
 * conversions may be affected by SBML Level&nbsp;3 packages being used by an
 * SBML document; consequently, the packages in use are also communicated by
 * the values of the SBML namespaces set on a {@link ConversionProperties} object.
 <p>
 * <p>
 * <h2>General information about the use of SBML converters</h2>
 <p>
 * The use of all the converters follows a similar approach.  First, one
 * creates a {@link ConversionProperties} object and calls
 * {@link ConversionProperties#addOption(ConversionOption)}
 * on this object with one arguments: a text string that identifies the desired
 * converter.  (The text string is specific to each converter; consult the
 * documentation for a given converter to find out how it should be enabled.)
 <p>
 * Next, for some converters, the caller can optionally set some
 * converter-specific properties using additional calls to
 * {@link ConversionProperties#addOption(ConversionOption)}.
 * Many converters provide the ability to
 * configure their behavior to some extent; this is realized through the use
 * of properties that offer different options.  The default property values
 * for each converter can be interrogated using the method
 * {@link SBMLConverter#getDefaultProperties()} on the converter class in question .
 <p>
 * Finally, the caller should invoke the method
 * {@link SBMLDocument#convert(ConversionProperties)}
 * with the {@link ConversionProperties} object as an argument.
 <p>
 * <h3>Example of invoking an SBML converter</h3>
 <p>
 * The following code fragment illustrates an example using
 * {@link SBMLReactionConverter}, which is invoked using the option string 
 * <code>'replaceReactions':</code>
 <p>
<pre class='fragment'>
{@link ConversionProperties} props = new {@link ConversionProperties}();
if (props != null) {
  props.addOption('replaceReactions');
} else {
  // Deal with error.
}
</pre>
<p>
 * In the case of {@link SBMLReactionConverter}, there are no options to affect
 * its behavior, so the next step is simply to invoke the converter on
 * an {@link SBMLDocument} object.  Continuing the example code:
 <p>
<pre class='fragment'>
  // Assume that the variable 'document' has been set to an {@link SBMLDocument} object.
  status = document.convert(config);
  if (status != libsbml.LIBSBML_OPERATION_SUCCESS)
  {
    // Handle error somehow.
    System.out.println('Error: conversion failed due to the following:');
    document.printErrors();
  }
</pre>
<p>
 * Here is an example of using a converter that offers an option. The
 * following code invokes {@link SBMLStripPackageConverter} to remove the
 * SBML Level&nbsp;3 <em>Layout</em> package from a model.  It sets the name
 * of the package to be removed by adding a value for the option named
 * <code>'package'</code> defined by that converter:
 <p>
<pre class='fragment'>
{@link ConversionProperties} config = new {@link ConversionProperties}();
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
  System.out.println('Error: unable to create {@link ConversionProperties} object');
}
</pre>
<p>
 * <h3>Available SBML converters in libSBML</h3>
 <p>
 * LibSBML provides a number of built-in converters; by convention, their
 * names end in <em>Converter</em>. The following are the built-in converters
 * provided by libSBML 5.11.1:
 <p>
 * <p>
 * <ul>
 * <li> CobraToFbcConverter
 * <li> CompFlatteningConverter
 * <li> FbcToCobraConverter
 * <li> {@link SBMLFunctionDefinitionConverter}
 * <li> {@link SBMLIdConverter}
 * <li> {@link SBMLInferUnitsConverter}
 * <li> {@link SBMLInitialAssignmentConverter}
 * <li> {@link SBMLLevelVersionConverter}
 * <li> {@link SBMLLocalParameterConverter}
 * <li> {@link SBMLReactionConverter}
 * <li> {@link SBMLRuleConverter}
 * <li> {@link SBMLStripPackageConverter}
 * <li> {@link SBMLUnitsConverter}
 *
 * </ul>
 <p>
 * @see ConversionOption
 * @see SBMLNamespaces
 */

public class ConversionProperties {
   private long swigCPtr;
   protected boolean swigCMemOwn;

   protected ConversionProperties(long cPtr, boolean cMemoryOwn)
   {
     swigCMemOwn = cMemoryOwn;
     swigCPtr    = cPtr;
   }

   protected static long getCPtr(ConversionProperties obj)
   {
     return (obj == null) ? 0 : obj.swigCPtr;
   }

   protected static long getCPtrAndDisown (ConversionProperties obj)
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
        libsbmlJNI.delete_ConversionProperties(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  
/**
   * Constructor that initializes the conversion properties
   * with a specific SBML target namespace.
   <p>
   * @param targetNS the target namespace to convert to
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 ConversionProperties(SBMLNamespaces targetNS) {
    this(libsbmlJNI.new_ConversionProperties__SWIG_0(SBMLNamespaces.getCPtr(targetNS), targetNS), true);
  }

  
/**
   * Constructor that initializes the conversion properties
   * with a specific SBML target namespace.
   <p>
   * @param targetNS the target namespace to convert to
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 ConversionProperties() {
    this(libsbmlJNI.new_ConversionProperties__SWIG_1(), true);
  }

  
/**
   * Copy constructor.
   <p>
   * @param orig the object to copy.
   <p>
   * @throws SBMLConstructorException
   * Thrown if the argument <code>orig</code> is <code>null.</code>
   */ public
 ConversionProperties(ConversionProperties orig) {
    this(libsbmlJNI.new_ConversionProperties__SWIG_2(ConversionProperties.getCPtr(orig), orig), true);
  }

  
/**
   * Creates and returns a deep copy of this {@link ConversionProperties} object.
   <p>
   * @return the (deep) copy of this {@link ConversionProperties} object.
   */ public
 ConversionProperties cloneObject() {
    long cPtr = libsbmlJNI.ConversionProperties_cloneObject(swigCPtr, this);
    return (cPtr == 0) ? null : new ConversionProperties(cPtr, true);
  }

  
/**
   * Returns the current target SBML namespace.
   <p>
   * @return the SBMLNamepaces object expressing the target namespace.
   */ public
 SBMLNamespaces getTargetNamespaces() {
  return libsbml.DowncastSBMLNamespaces(libsbmlJNI.ConversionProperties_getTargetNamespaces(swigCPtr, this), false);
}

  
/**
   * Returns <code>true</code> if the target SBML namespace has been set.
   <p>
   * @return <code>true</code> if the target namespace has been set, <code>false</code>
   * otherwise.
   */ public
 boolean hasTargetNamespaces() {
    return libsbmlJNI.ConversionProperties_hasTargetNamespaces(swigCPtr, this);
  }

  
/**
   * Sets the target namespace.
   <p>
   * @param targetNS the target namespace to use.
   */ public
 void setTargetNamespaces(SBMLNamespaces targetNS) {
    libsbmlJNI.ConversionProperties_setTargetNamespaces(swigCPtr, this, SBMLNamespaces.getCPtr(targetNS), targetNS);
  }

  
/**
   * Returns the description string for a given option in this properties
   * object.
   <p>
   * @param key the key for the option.
   <p>
   * @return the description text of the option with the given key.
   */ public
 String getDescription(String key) {
    return libsbmlJNI.ConversionProperties_getDescription(swigCPtr, this, key);
  }

  
/**
   * Returns the type of a given option in this properties object.
   <p>
   * @param key the key for the option.
   <p>
   * @return the type of the option with the given key.
   */ public
 int getType(String key) {
    return libsbmlJNI.ConversionProperties_getType(swigCPtr, this, key);
  }

  
/**
   * Returns the {@link ConversionOption} object for a given key.
   <p>
   * @param key the key for the option.
   <p>
   * @return the option with the given key.
   */ public
 ConversionOption getOption(String key) {
    long cPtr = libsbmlJNI.ConversionProperties_getOption__SWIG_0(swigCPtr, this, key);
    return (cPtr == 0) ? null : new ConversionOption(cPtr, false);
  }

  
/**
   * Returns the {@link ConversionOption} object for the given index.
   <p>
   * @param index the index for the option.
   <p>
   * @return the option with the given index.
   */ public
 ConversionOption getOption(int index) {
    long cPtr = libsbmlJNI.ConversionProperties_getOption__SWIG_1(swigCPtr, this, index);
    return (cPtr == 0) ? null : new ConversionOption(cPtr, false);
  }

  
/**
   * Adds a copy of the given option to this properties object.
   <p>
   * @param option the option to add
   */ public
 void addOption(ConversionOption option) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_0(swigCPtr, this, ConversionOption.getCPtr(option), option);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for {@link ConversionOption} for more information about the types)
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, String value, int type, String description) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_1(swigCPtr, this, key, value, type, description);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for {@link ConversionOption} for more information about the types)
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, String value, int type) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_2(swigCPtr, this, key, value, type);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for {@link ConversionOption} for more information about the types)
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, String value) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_3(swigCPtr, this, key, value);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value (optional) the value of that option
   * @param type (optional) the type of the option (see the documentation
   * for {@link ConversionOption} for more information about the types)
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_4(swigCPtr, this, key);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the string value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, String value, String description) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_5(swigCPtr, this, key, value, description);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the boolean value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, boolean value, String description) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_7(swigCPtr, this, key, value, description);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the boolean value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, boolean value) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_8(swigCPtr, this, key, value);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the double value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, double value, String description) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_9(swigCPtr, this, key, value, description);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the double value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, double value) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_10(swigCPtr, this, key, value);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the float value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, float value, String description) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_11(swigCPtr, this, key, value, description);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the float value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, float value) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_12(swigCPtr, this, key, value);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the integer value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, int value, String description) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_13(swigCPtr, this, key, value, description);
  }

  
/**
   * Adds a new {@link ConversionOption} object with the given parameters.
   <p>
   * @param key the key for the new option
   * @param value the integer value of that option
   * @param description (optional) the description for the option
   <p>
   * 
</dl><dl class="docnote"><dt><b>Documentation note:</b></dt><dd>
The native C++ implementation of this method defines a default argument
value. In the documentation generated for different libSBML language
bindings, you may or may not see corresponding arguments in the method
declarations. For example, in Java and C#, a default argument is handled by
declaring two separate methods, with one of them having the argument and
the other one lacking the argument. However, the libSBML documentation will
be <em>identical</em> for both methods. Consequently, if you are reading
this and do not see an argument even though one is described, please look
for descriptions of other variants of this method near where this one
appears in the documentation.
</dd></dl>
 
   */ public
 void addOption(String key, int value) {
    libsbmlJNI.ConversionProperties_addOption__SWIG_14(swigCPtr, this, key, value);
  }

  
/**
   * Removes the option with the given key from this properties object.
   <p>
   * @param key the key for the new option to remove
   * @return the removed option
   */ public
 ConversionOption removeOption(String key) {
    long cPtr = libsbmlJNI.ConversionProperties_removeOption(swigCPtr, this, key);
    return (cPtr == 0) ? null : new ConversionOption(cPtr, false);
  }

  
/**
   * Returns <code>true</code> if this properties object contains an option with
   * the given key.
   <p>
   * @param key the key of the option to find.
   <p>
   * @return <code>true</code> if an option with the given <code>key</code> exists in
   * this properties object, <code>false</code> otherwise.
   */ public
 boolean hasOption(String key) {
    return libsbmlJNI.ConversionProperties_hasOption(swigCPtr, this, key);
  }

  
/**
   * Returns the value of the given option as a string.
   <p>
   * @param key the key for the option.
   <p>
   * @return the string value of the option with the given key.
   */ public
 String getValue(String key) {
    return libsbmlJNI.ConversionProperties_getValue(swigCPtr, this, key);
  }

  
/**
   * Sets the value of the given option to a string.
   <p>
   * @param key the key for the option
   * @param value the new value
   */ public
 void setValue(String key, String value) {
    libsbmlJNI.ConversionProperties_setValue(swigCPtr, this, key, value);
  }

  
/**
   * Returns the value of the given option as a Boolean.
   <p>
   * @param key the key for the option.
   <p>
   * @return the boolean value of the option with the given key.
   */ public
 boolean getBoolValue(String key) {
    return libsbmlJNI.ConversionProperties_getBoolValue(swigCPtr, this, key);
  }

  
/**
   * Sets the value of the given option to a Boolean.
   <p>
   * @param key the key for the option.
   <p>
   * @param value the new Boolean value.
   */ public
 void setBoolValue(String key, boolean value) {
    libsbmlJNI.ConversionProperties_setBoolValue(swigCPtr, this, key, value);
  }

  
/**
   * Returns the value of the given option as a <code>double.</code>
   <p>
   * @param key the key for the option.
   <p>
   * @return the double value of the option with the given key.
   */ public
 double getDoubleValue(String key) {
    return libsbmlJNI.ConversionProperties_getDoubleValue(swigCPtr, this, key);
  }

  
/**
   * Sets the value of the given option to a <code>double.</code>
   <p>
   * @param key the key for the option.
   <p>
   * @param value the new double value.
   */ public
 void setDoubleValue(String key, double value) {
    libsbmlJNI.ConversionProperties_setDoubleValue(swigCPtr, this, key, value);
  }

  
/**
   * Returns the value of the given option as a <code>float.</code>
   <p>
   * @param key the key for the option.
   <p>
   * @return the float value of the option with the given key.
   */ public
 float getFloatValue(String key) {
    return libsbmlJNI.ConversionProperties_getFloatValue(swigCPtr, this, key);
  }

  
/**
   * Sets the value of the given option to a <code>float.</code>
   <p>
   * @param key the key for the option.
   <p>
   * @param value the new float value.
   */ public
 void setFloatValue(String key, float value) {
    libsbmlJNI.ConversionProperties_setFloatValue(swigCPtr, this, key, value);
  }

  
/**
   * Returns the value of the given option as an integer.
   <p>
   * @param key the key for the option.
   <p>
   * @return the int value of the option with the given key.
   */ public
 int getIntValue(String key) {
    return libsbmlJNI.ConversionProperties_getIntValue(swigCPtr, this, key);
  }

  
/**
   * Sets the value of the given option to an integer.
   <p>
   * @param key the key for the option.
   <p>
   * @param value the new integer value.
   */ public
 void setIntValue(String key, int value) {
    libsbmlJNI.ConversionProperties_setIntValue(swigCPtr, this, key, value);
  }

  
/** 
   * Returns the number of options in this Conversion Properties object
   <p>
   * @return the number of options in this properties object
   */ public
 int getNumOptions() {
    return libsbmlJNI.ConversionProperties_getNumOptions(swigCPtr, this);
  }

}
