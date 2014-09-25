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
@htmlinclude pkg-marker-core.html Methods for checking the validity of SBML identifiers.
 * 
 * @htmlinclude not-sbml-warning.html
 * 
 * This utility class provides static methods for checking the syntax of
 * identifiers and other text used in an SBML model.  The methods allow
 * callers to verify that strings such as SBML identifiers and XHTML notes
 * text conform to the SBML specifications.
 */

public class SyntaxChecker : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal SyntaxChecker(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(SyntaxChecker obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (SyntaxChecker obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~SyntaxChecker() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_SyntaxChecker(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
/**
   * Returns true @c true or @c false depending on whether the argument
   * string conforms to the syntax of SBML identifiers.
   *
   * *
 * 
 * In SBML, identifiers that are the values of 'id' attributes on objects
 * must conform to a data type called <code>SId</code> in the SBML
 * specifications.  LibSBML does not provide an explicit <code>SId</code>
 * data type; it uses ordinary character strings, which is easier for
 * applications to support.  (LibSBML does, however, test for identifier
 * validity at various times, such as when reading in models from files
 * and data streams.)
 *
 *
 * 
   *
   * This method provides programs with the ability to test explicitly that
   * the identifier strings they create conform to the SBML identifier
   * syntax.
   *
   * @param sid string to be checked for conformance to SBML identifier
   * syntax.
   *
   * @return @c true if the string conforms to type SBML data type
   * <code>SId</code>, @c false otherwise.
   *
   * *
 * 
 * SBML has strict requirements for the syntax of identifiers, that is, the
 * values of the 'id' attribute present on most types of SBML objects.
 * The following is a summary of the definition of the SBML identifier type
 * <code>SId</code>, which defines the permitted syntax of identifiers.  We
 * express the syntax using an extended form of BNF notation:
 * <pre style='margin-left: 2em; border: none; font-weight: bold; font-size: 13px; color: black'>
 * letter ::= 'a'..'z','A'..'Z'
 * digit  ::= '0'..'9'
 * idChar ::= letter | digit | '_'
 * SId    ::= ( letter | '_' ) idChar*</pre>
 * The characters <code>(</code> and <code>)</code> are used for grouping, the
 * character <code>*</code> 'zero or more times', and the character
 * <code>|</code> indicates logical 'or'.  The equality of SBML identifiers is
 * determined by an exact character sequence match; i.e., comparisons must be
 * performed in a case-sensitive manner.  In addition, there are a few
 * conditions for the uniqueness of identifiers in an SBML model.  Please
 * consult the SBML specifications for the exact details of the uniqueness
 * requirements.
 *
 *
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
   *
   * @see @if clike isValidUnitSId(string sid) @else SyntaxChecker::isValidUnitSId(string sid) @endif
   * @see @if clike isValidXMLID(string sid) @else SyntaxChecker::isValidXMLID(string sid) @endif
   */ public
 static bool isValidSBMLSId(string sid) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_isValidSBMLSId(sid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns @c true or @c false depending on whether the argument string
   * conforms to the XML data type <code>ID</code>.
   *
   * *
 * 
 * The optional attribute named 'metaid', present on every major SBML
 * component type, is for supporting metadata annotations using RDF (<a
 * href='http://www.w3.org/RDF/'>Resource Description Format</a>).  The
 * attribute value has the data type <a
 * href='http://www.w3.org/TR/REC-xml/#id'>XML <code>ID</code></a>, the XML
 * identifier type, which means each 'metaid' value must be globally unique
 * within an SBML file.  The latter point is important, because the
 * uniqueness criterion applies across <em>any</em> attribute with type
 * <code>ID</code> anywhere in the file, not just the 'metaid' attribute used
 * by SBML---something to be aware of if your application-specific XML
 * content inside the 'annotation' subelement happens to use the XML
 * <code>ID</code> type.  Although SBML itself specifies the use of <a
 * href='http://www.w3.org/TR/REC-xml/#id'>XML <code>ID</code></a> only for
 * the 'metaid' attribute, SBML-compatible applications should be careful if
 * they use XML <code>ID</code>'s in XML portions of a model that are not
 * defined by SBML, such as in the application-specific content of the
 * 'annotation' subelement.  Finally, note that LibSBML does not provide an
 * explicit XML <code>ID</code> data type; it uses ordinary character
 * strings, which is easier for applications to support.
 *
 * 
   *
   * This method provides programs with the ability to test explicitly that
   * the identifier strings they create conform to the SBML identifier
   * syntax.
   *
   * @param id string to be checked for conformance to the syntax of
   * <a target='_blank' href='http://www.w3.org/TR/REC-xml/#id'>XML ID</a>.
   *
   * @return @c true if the string is a syntactically-valid value for the
   * XML type <a target='_blank'
   * href='http://www.w3.org/TR/REC-xml/#id'>ID</a>, @c false otherwise.
   *
   * @note @htmlinclude xmlid-syntax.html
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
   * 
   * @see @if clike isValidSBMLSId(string sid) @else SyntaxChecker::isValidSBMLSId(string sid) @endif
   * @see @if clike isValidUnitSId(string sid) @else SyntaxChecker::isValidUnitSId(string sid) @endif
   */ public
 static bool isValidXMLID(string id) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_isValidXMLID(id);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns @c true or @c false depending on whether the @p uri argument string
   * conforms to the XML data type <code>anyURI</code>.
   *
   * Type anyURI is defined by XML Schema 1.0. It is a character string 
   * data type whose values are interpretable as URIs (Universal Resource 
   * Identifiers) as described by the W3C document RFC 3986.  LibSBML
   * does not provide an explicit XML <code>anyURI</code> data type; it uses
   * ordinary character strings, which is easier for applications to
   * support.  LibSBML does, however, test for anyURI validity at
   * various times, such as when reading in models from files and data
   * streams.
   *
   * This method provides programs with the ability to test explicitly that
   * the strings they create conform to the XML anyURI syntax.
   *
   * @param uri string to be checked for conformance to the syntax of
   * <a target='_blank' 
   * href='http://www.w3.org/TR/xmlschema-2/#anyURI'>anyURI</a>.
   *
   * @return @c true if the string is a syntactically-valid value for the
   * XML type <a target='_blank'
   * href='http://www.w3.org/TR/xmlschema-2/#anyURI'>anyURI</a>, 
   * @c false otherwise.
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
   */ public
 static bool isValidXMLanyURI(string uri) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_isValidXMLanyURI(uri);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns @c true or @c false depending on whether the argument string
   * conforms to the syntax of SBML unit identifiers.
   *
   * In SBML, the identifiers of units (of both the predefined units and
   * user-defined units) must conform to a data type called
   * <code>UnitSId</code> in the SBML specifications.  LibSBML does not
   * provide an explicit <code>UnitSId</code> data type; it uses ordinary
   * character strings, which is easier for applications to support.
   * LibSBML does, however, test for identifier validity at various times,
   * such as when reading in models from files and data streams.
   *
   * This method provides programs with the ability to test explicitly that
   * the identifier strings they create conform to the SBML identifier
   * syntax.
   *
   * @param units string to be checked for conformance to SBML unit
   * identifier syntax.
   *
   * @return @c true if the string conforms to type SBML data type
   * <code>UnitSId</code>, @c false otherwise.
   *
   * @note @htmlinclude unitid-syntax.html
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
   *
   * @see @if clike isValidSBMLSId(string sid) @else SyntaxChecker::isValidSBMLSId(string sid) @endif
   * @see @if clike isValidXMLID(string sid) @else SyntaxChecker::isValidXMLID(string sid) @endif
   */ public
 static bool isValidUnitSId(string units) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_isValidUnitSId(units);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns @c true or @c false depending on whether the given XMLNode
   * object contains valid XHTML content.
   *
   * *
 * 
 * The optional SBML element named 'notes', present on every major SBML
 * component type (and in SBML Level&nbsp;3, the 'message' subelement of
 * Constraint), is intended as a place for storing optional information
 * intended to be seen by humans.  An example use of the 'notes' element
 * would be to contain formatted user comments about the model element in
 * which the 'notes' element is enclosed.  Every object derived directly or
 * indirectly from type SBase can have a separate value for 'notes', allowing
 * users considerable freedom when adding comments to their models.
 *
 * The format of 'notes' elements conform to the definition of <a
 * target='_blank' href='http://www.w3.org/TR/xhtml1/'>XHTML&nbsp;1.0</a>.
 * However, the content cannot be @em entirely free-form; it must satisfy
 * certain requirements defined in the <a target='_blank'
 * href='http://sbml.org/Documents/Specifications'>SBML specifications</a>
 * for specific SBML Levels.  To help verify the formatting of 'notes'
 * content, libSBML provides the static utility method
 * SyntaxChecker::hasExpectedXHTMLSyntax(@if java XMLNode@endif); this
 * method implements a verification process that lets callers check whether
 * the content of a given XMLNode object conforms to the SBML requirements
 * for 'notes' and 'message' structure.  Developers are urged to consult the
 * appropriate <a target='_blank'
 * href='http://sbml.org/Documents/Specifications'>SBML specification
 * document</a> for the Level and Version of their model for more in-depth
 * explanations of using 'notes' in SBML.  The SBML Level&nbsp;2 and &nbsp;3
 * specifications have considerable detail about how 'notes' element content
 * must be structured.
 *
 *
   *
   * An aspect of XHTML validity is that the content is declared to be in
   * the XML namespace for XHTML&nbsp;1.0.  There is more than one way in
   * which this can be done in XML.  In particular, a model might not
   * contain the declaration within the 'notes' or 'message' subelement
   * itself, but might instead place the declaration on an enclosing
   * element and use an XML namespace prefix within the 'notes' element to
   * refer to it.  In other words, the following is valid:
   * @verbatim
<sbml xmlns='http://www.sbml.org/sbml/level2/version3' level='2' version='3'
      xmlns:xhtml='http://www.w3.org/1999/xhtml'>
  <model>
    <notes>
      <xhtml:body>
        <xhtml:center><xhtml:h2>A Simple Mitotic Oscillator</xhtml:h2></xhtml:center>
        <xhtml:p>A minimal cascade model for the mitotic oscillator.</xhtml:p>
      </xhtml:body>
    </notes>
  ... rest of model ...
</sbml>
@endverbatim
   * Contrast the above with the following, self-contained version, which
   * places the XML namespace declaration within the <code>&lt;notes&gt;</code>
   * element itself:
   * @verbatim
<sbml xmlns='http://www.sbml.org/sbml/level2/version3' level='2' version='3'>
  <model>
    <notes>
      <html xmlns='http://www.w3.org/1999/xhtml'>
        <head>
          <title/>
        </head>
        <body>
          <center><h2>A Simple Mitotic Oscillator</h2></center>
          <p>A minimal cascade model for the mitotic oscillator.</p>
        </body>
      </html>
    </notes>
  ... rest of model ...
</sbml>
@endverbatim
   *
   * Both of the above are valid XML.  The purpose of the @p sbmlns
   * argument to this method is to allow callers to check the validity of
   * 'notes' and 'message' subelements whose XML namespace declarations
   * have been put elsewhere in the manner illustrated above.  Callers can
   * can pass in the SBMLNamespaces object of a higher-level model
   * component if the XMLNode object does not itself have the XML namespace
   * declaration for XHTML&nbsp;1.0.
   * 
   * @param xhtml the XMLNode to be checked for conformance.
   * @param sbmlns the SBMLNamespaces associated with the object.
   *
   * @return @c true if the XMLNode content conforms, @c false otherwise.
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
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 static bool hasExpectedXHTMLSyntax(XMLNode xhtml, SBMLNamespaces sbmlns) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_hasExpectedXHTMLSyntax__SWIG_0(XMLNode.getCPtr(xhtml), SBMLNamespaces.getCPtr(sbmlns));
    return ret;
  }

  
/**
   * Returns @c true or @c false depending on whether the given XMLNode
   * object contains valid XHTML content.
   *
   * *
 * 
 * The optional SBML element named 'notes', present on every major SBML
 * component type (and in SBML Level&nbsp;3, the 'message' subelement of
 * Constraint), is intended as a place for storing optional information
 * intended to be seen by humans.  An example use of the 'notes' element
 * would be to contain formatted user comments about the model element in
 * which the 'notes' element is enclosed.  Every object derived directly or
 * indirectly from type SBase can have a separate value for 'notes', allowing
 * users considerable freedom when adding comments to their models.
 *
 * The format of 'notes' elements conform to the definition of <a
 * target='_blank' href='http://www.w3.org/TR/xhtml1/'>XHTML&nbsp;1.0</a>.
 * However, the content cannot be @em entirely free-form; it must satisfy
 * certain requirements defined in the <a target='_blank'
 * href='http://sbml.org/Documents/Specifications'>SBML specifications</a>
 * for specific SBML Levels.  To help verify the formatting of 'notes'
 * content, libSBML provides the static utility method
 * SyntaxChecker::hasExpectedXHTMLSyntax(@if java XMLNode@endif); this
 * method implements a verification process that lets callers check whether
 * the content of a given XMLNode object conforms to the SBML requirements
 * for 'notes' and 'message' structure.  Developers are urged to consult the
 * appropriate <a target='_blank'
 * href='http://sbml.org/Documents/Specifications'>SBML specification
 * document</a> for the Level and Version of their model for more in-depth
 * explanations of using 'notes' in SBML.  The SBML Level&nbsp;2 and &nbsp;3
 * specifications have considerable detail about how 'notes' element content
 * must be structured.
 *
 *
   *
   * An aspect of XHTML validity is that the content is declared to be in
   * the XML namespace for XHTML&nbsp;1.0.  There is more than one way in
   * which this can be done in XML.  In particular, a model might not
   * contain the declaration within the 'notes' or 'message' subelement
   * itself, but might instead place the declaration on an enclosing
   * element and use an XML namespace prefix within the 'notes' element to
   * refer to it.  In other words, the following is valid:
   * @verbatim
<sbml xmlns='http://www.sbml.org/sbml/level2/version3' level='2' version='3'
      xmlns:xhtml='http://www.w3.org/1999/xhtml'>
  <model>
    <notes>
      <xhtml:body>
        <xhtml:center><xhtml:h2>A Simple Mitotic Oscillator</xhtml:h2></xhtml:center>
        <xhtml:p>A minimal cascade model for the mitotic oscillator.</xhtml:p>
      </xhtml:body>
    </notes>
  ... rest of model ...
</sbml>
@endverbatim
   * Contrast the above with the following, self-contained version, which
   * places the XML namespace declaration within the <code>&lt;notes&gt;</code>
   * element itself:
   * @verbatim
<sbml xmlns='http://www.sbml.org/sbml/level2/version3' level='2' version='3'>
  <model>
    <notes>
      <html xmlns='http://www.w3.org/1999/xhtml'>
        <head>
          <title/>
        </head>
        <body>
          <center><h2>A Simple Mitotic Oscillator</h2></center>
          <p>A minimal cascade model for the mitotic oscillator.</p>
        </body>
      </html>
    </notes>
  ... rest of model ...
</sbml>
@endverbatim
   *
   * Both of the above are valid XML.  The purpose of the @p sbmlns
   * argument to this method is to allow callers to check the validity of
   * 'notes' and 'message' subelements whose XML namespace declarations
   * have been put elsewhere in the manner illustrated above.  Callers can
   * can pass in the SBMLNamespaces object of a higher-level model
   * component if the XMLNode object does not itself have the XML namespace
   * declaration for XHTML&nbsp;1.0.
   * 
   * @param xhtml the XMLNode to be checked for conformance.
   * @param sbmlns the SBMLNamespaces associated with the object.
   *
   * @return @c true if the XMLNode content conforms, @c false otherwise.
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
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 static bool hasExpectedXHTMLSyntax(XMLNode xhtml) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_hasExpectedXHTMLSyntax__SWIG_1(XMLNode.getCPtr(xhtml));
    return ret;
  }

  
/**
   * Returns true @c true or @c false depending on whether the argument
   * string conforms to the syntax of SBML identifiers or is empty.
   */ /* libsbml-internal */ public
 static bool isValidInternalSId(string sid) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_isValidInternalSId(sid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/** */ /* libsbml-internal */ public
 static bool isValidInternalUnitSId(string sid) {
    bool ret = libsbmlPINVOKE.SyntaxChecker_isValidInternalUnitSId(sid);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SyntaxChecker() : this(libsbmlPINVOKE.new_SyntaxChecker(), true) {
  }

}

}
