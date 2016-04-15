using System;
using System.Runtime.InteropServices;
 
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.6
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
@htmlinclude pkg-marker-core.html A node in libSBML's XML document tree.
 *
 * LibSBML implements an XML abstraction layer.  This layer presents a
 * uniform XML interface to calling programs regardless of which underlying
 * XML parser libSBML has actually been configured to use.  The basic data
 * object in the XML abstraction is a @em node, represented by XMLNode.
 *
 * An XMLNode can contain any number of children.  Each child is another
 * XMLNode, thereby forming a tree.  The methods XMLNode::getNumChildren()
 * and XMLNode::getChild(@if java long@endif) can be used to access the tree
 * structure starting from a given node.
 *
 * Each XMLNode is subclassed from XMLToken, and thus has the same methods
 * available as XMLToken.  These methods include XMLToken::getNamespaces(),
 * XMLToken::getPrefix(), XMLToken::getName(), XMLToken::getURI(), and
 * XMLToken::getAttributes().
 *
 * @section xmlnode-str2xmlnode Conversion between an XML string and an XMLNode
 *
 * LibSBML provides the following utility functions for converting an XML
 * string (e.g., <code>&lt;annotation&gt;...&lt;/annotation&gt;</code>)
 * to/from an XMLNode object.
 *
 * @li XMLNode::toXMLString() returns a string representation of the XMLNode
 * object.
 *
 * @li XMLNode::convertXMLNodeToString(@if java XMLNode@endif) (static
 * function) returns a string representation of the given XMLNode object.
 *
 * @li XMLNode::convertStringToXMLNode(@if java String@endif) (static
 * function) returns an XMLNode object converted from the given XML string.
 *
 * The returned XMLNode object by XMLNode::convertStringToXMLNode(@if java
 * String@endif) is a dummy root (container) XMLNode if the given XML string
 * has two or more top-level elements (e.g.,
 * &quot;<code>&lt;p&gt;...&lt;/p&gt;&lt;p&gt;...&lt;/p&gt;</code>&quot;). In
 * the dummy root node, each top-level element in the given XML string is
 * contained as a child XMLNode. XMLToken::isEOF() can be used to identify
 * if the returned XMLNode object is a dummy node or not.  Here is an
 * example: 
@if cpp
@code{.cpp}
// Checks if the XMLNode object returned by XMLNode::convertStringToXMLNode()
// is a dummy root node:

string str = '...';
XMLNode xn = XMLNode::convertStringToXMLNode(str);
if ( xn == null )
{
  // returned value is null (error)
  ...
}
else if ( xn->isEOF() )
{
  // Root node is a dummy node.
  for ( int i = 0; i < xn->getNumChildren(); i++ )
  {
    // access to each child node of the dummy node.
    XMLNode xnChild = xn->getChild(i);
    ...
  }
}
else
{
  // Root node is NOT a dummy node.
  ...
}
@endcode
@endif
@if java
@code{.java}
// Checks if the returned XMLNode object is a dummy root node:

String str = '...';
XMLNode xn = XMLNode.convertStringToXMLNode(str);
if ( xn == null )
{
  // returned value is null (error)
  ...
}
else if ( xn.isEOF() )
{
  // Root node is a dummy node.
  for ( int i = 0; i < xn.getNumChildren(); i++ )
  {
    // access to each child node of the dummy node.
    XMLNode xnChild = xn.getChild(i);
    ...
  }
}
else
{
  // Root node is NOT a dummy node.
  ...
}
@endcode
@endif
@if python
@code{.py}
xn = XMLNode.convertStringToXMLNode('<p></p>')
if xn == None:
  # Do something to handle exceptional situation.

elif xn.isEOF():
  # Node is a dummy node.

else:
  # None is not a dummy node.
@endcode
@endif
 *
 */

public class XMLNode : XMLToken {
	private HandleRef swigCPtr;
	
	internal XMLNode(IntPtr cPtr, bool cMemoryOwn) : base(libsbmlPINVOKE.XMLNode_SWIGUpcast(cPtr), cMemoryOwn)
	{
		//super(libsbmlPINVOKE.XMLNodeUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(XMLNode obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (XMLNode obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~XMLNode() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_XMLNode(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static bool operator==(XMLNode lhs, XMLNode rhs)
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

  public static bool operator!=(XMLNode lhs, XMLNode rhs)
  {
    return !(lhs == rhs);
  }

  public override bool Equals(Object sb)
  {
    if ( ! (sb is XMLNode) )
    {
      return false;
    }

    return this == (XMLNode)sb;
  }

  public override int GetHashCode()
  {
    return swigCPtr.Handle.ToInt32();
  }

  
/**
   * Creates a new empty XMLNode with no children.
   */ public
 XMLNode() : this(libsbmlPINVOKE.new_XMLNode__SWIG_0(), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new XMLNode by copying an XMLToken object.
   *
   * @param token XMLToken to be copied to XMLNode
   */ public
 XMLNode(XMLToken token) : this(libsbmlPINVOKE.new_XMLNode__SWIG_1(XMLToken.getCPtr(token)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new start element XMLNode with the given set of attributes and
   * namespace declarations.
   *
   * @param triple XMLTriple.
   * @param attributes XMLAttributes, the attributes to set.
   * @param namespaces XMLNamespaces, the namespaces to set.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(XMLTriple triple, XMLAttributes attributes, XMLNamespaces namespaces, long line, long column) : this(libsbmlPINVOKE.new_XMLNode__SWIG_2(XMLTriple.getCPtr(triple), XMLAttributes.getCPtr(attributes), XMLNamespaces.getCPtr(namespaces), line, column), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new start element XMLNode with the given set of attributes and
   * namespace declarations.
   *
   * @param triple XMLTriple.
   * @param attributes XMLAttributes, the attributes to set.
   * @param namespaces XMLNamespaces, the namespaces to set.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(XMLTriple triple, XMLAttributes attributes, XMLNamespaces namespaces, long line) : this(libsbmlPINVOKE.new_XMLNode__SWIG_3(XMLTriple.getCPtr(triple), XMLAttributes.getCPtr(attributes), XMLNamespaces.getCPtr(namespaces), line), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a new start element XMLNode with the given set of attributes and
   * namespace declarations.
   *
   * @param triple XMLTriple.
   * @param attributes XMLAttributes, the attributes to set.
   * @param namespaces XMLNamespaces, the namespaces to set.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(XMLTriple triple, XMLAttributes attributes, XMLNamespaces namespaces) : this(libsbmlPINVOKE.new_XMLNode__SWIG_4(XMLTriple.getCPtr(triple), XMLAttributes.getCPtr(attributes), XMLNamespaces.getCPtr(namespaces)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a start element XMLNode with the given set of attributes.
   *
   * @param triple XMLTriple.
   * @param attributes XMLAttributes, the attributes to set.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
  */ public
 XMLNode(XMLTriple triple, XMLAttributes attributes, long line, long column) : this(libsbmlPINVOKE.new_XMLNode__SWIG_5(XMLTriple.getCPtr(triple), XMLAttributes.getCPtr(attributes), line, column), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a start element XMLNode with the given set of attributes.
   *
   * @param triple XMLTriple.
   * @param attributes XMLAttributes, the attributes to set.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
  */ public
 XMLNode(XMLTriple triple, XMLAttributes attributes, long line) : this(libsbmlPINVOKE.new_XMLNode__SWIG_6(XMLTriple.getCPtr(triple), XMLAttributes.getCPtr(attributes), line), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a start element XMLNode with the given set of attributes.
   *
   * @param triple XMLTriple.
   * @param attributes XMLAttributes, the attributes to set.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
  */ public
 XMLNode(XMLTriple triple, XMLAttributes attributes) : this(libsbmlPINVOKE.new_XMLNode__SWIG_7(XMLTriple.getCPtr(triple), XMLAttributes.getCPtr(attributes)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates an end element XMLNode.
   *
   * @param triple XMLTriple.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(XMLTriple triple, long line, long column) : this(libsbmlPINVOKE.new_XMLNode__SWIG_8(XMLTriple.getCPtr(triple), line, column), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates an end element XMLNode.
   *
   * @param triple XMLTriple.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(XMLTriple triple, long line) : this(libsbmlPINVOKE.new_XMLNode__SWIG_9(XMLTriple.getCPtr(triple), line), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates an end element XMLNode.
   *
   * @param triple XMLTriple.
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(XMLTriple triple) : this(libsbmlPINVOKE.new_XMLNode__SWIG_10(XMLTriple.getCPtr(triple)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a text XMLNode.
   *
   * @param chars a string, the text to be added to the XMLToken
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(string chars, long line, long column) : this(libsbmlPINVOKE.new_XMLNode__SWIG_11(chars, line, column), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a text XMLNode.
   *
   * @param chars a string, the text to be added to the XMLToken
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(string chars, long line) : this(libsbmlPINVOKE.new_XMLNode__SWIG_12(chars, line), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates a text XMLNode.
   *
   * @param chars a string, the text to be added to the XMLToken
   * @param line a long integer, the line number (default = 0).
   * @param column a long integer, the column number (default = 0).
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 XMLNode(string chars) : this(libsbmlPINVOKE.new_XMLNode__SWIG_13(chars), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/** */ /* libsbml-internal */ public
 XMLNode(XMLInputStream stream) : this(libsbmlPINVOKE.new_XMLNode__SWIG_14(XMLInputStream.getCPtr(stream)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this XMLNode.
   *
   * @param orig the XMLNode instance to copy.
   */ public
 XMLNode(XMLNode orig) : this(libsbmlPINVOKE.new_XMLNode__SWIG_15(XMLNode.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this XMLNode object.
   *
   * @return the (deep) copy of this XMLNode object.
   */ public new
 XMLNode clone() {
    IntPtr cPtr = libsbmlPINVOKE.XMLNode_clone(swigCPtr);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true);
    return ret;
  }

  
/**
   * Adds a copy of @p node as a child of this XMLNode.
   *
   * The given @p node is added at the end of the list of children.
   *
   * @param node the XMLNode to be added as child.
   *
   *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbml#LIBSBML_OPERATION_FAILED LIBSBML_OPERATION_FAILED@endlink
   * @li @link libsbml#LIBSBML_INVALID_XML_OPERATION LIBSBML_INVALID_XML_OPERATION@endlink
   *
   * @note The given node is added at the end of the children list.
   */ public
 int addChild(XMLNode node) {
    int ret = libsbmlPINVOKE.XMLNode_addChild(swigCPtr, XMLNode.getCPtr(node));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Inserts a copy of the given node as the <code>n</code>th child of this
   * XMLNode.
   *
   * If the given index @p n is out of range for this XMLNode instance,
   * the @p node is added at the end of the list of children.  Even in
   * that situation, this method does not throw an error.
   *
   * @param n an integer, the index at which the given node is inserted
   * @param node an XMLNode to be inserted as <code>n</code>th child.
   *
   * @return a reference to the newly-inserted child @p node
   */ public
 XMLNode insertChild(long n, XMLNode node) {
    XMLNode ret = new XMLNode(libsbmlPINVOKE.XMLNode_insertChild(swigCPtr, n, XMLNode.getCPtr(node)), false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Removes the <code>n</code>th child of this XMLNode and returns the
   * removed node.
   *
   * It is important to keep in mind that a given XMLNode may have more
   * than one child.  Calling this method erases all existing references to
   * child nodes @em after the given position @p n.  If the index @p n is
   * greater than the number of child nodes in this XMLNode, this method
   * takes no action (and returns @c null).
   *
   * @param n an integer, the index of the node to be removed
   *
   * @return the removed child, or @c null if @p n is greater than the number
   * of children in this node
   *
   * @note The caller owns the returned node and is responsible for deleting it.
   */ public
 XMLNode removeChild(long n) {
    IntPtr cPtr = libsbmlPINVOKE.XMLNode_removeChild(swigCPtr, n);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true);
    return ret;
  }

  
/**
   * Removes all children from this node.
   *
 * @return integer value indicating success/failure of the
 * function.  @if clike The value is drawn from the
 * enumeration #OperationReturnValues_t. @endif The possible values
 * returned by this function are:
 * @li @link libsbml#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int removeChildren() {
    int ret = libsbmlPINVOKE.XMLNode_removeChildren(swigCPtr);
    return ret;
  }

  
/**
   * Returns the <code>n</code>th child of this XMLNode.
   *
   * If the index @p n is greater than the number of child nodes,
   * this method returns an empty node.
   *
   * @param n a long integereger, the index of the node to return
   *
   * @return the <code>n</code>th child of this XMLNode.
   */ public
 XMLNode getChild(long n) {
    XMLNode ret = new XMLNode(libsbmlPINVOKE.XMLNode_getChild__SWIG_0(swigCPtr, n), false);
    return ret;
  }

  
/**
   * Returns the first child of this XMLNode with the corresponding name.
   *
   * If no child with corrsponding name can be found,
   * this method returns an empty node.
   *
   * @param name the name of the node to return
   *
   * @return the first child of this XMLNode with given name.
   */ public
 XMLNode getChild(string name) {
    XMLNode ret = new XMLNode(libsbmlPINVOKE.XMLNode_getChild__SWIG_2(swigCPtr, name), false);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Return the index of the first child of this XMLNode with the given name.
   *
   * @param name a string, the name of the child for which the
   * index is required.
   *
   * @return the index of the first child of this XMLNode with the given
   * name, or -1 if not present.
   */ public
 int getIndex(string name) {
    int ret = libsbmlPINVOKE.XMLNode_getIndex(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Return a boolean indicating whether this XMLNode has a child with the
   * given name.
   *
   * @param name a string, the name of the child to be checked.
   *
   * @return boolean indicating whether this XMLNode has a child with the
   * given name.
   */ public
 bool hasChild(string name) {
    bool ret = libsbmlPINVOKE.XMLNode_hasChild(swigCPtr, name);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Compare this XMLNode against another XMLNode returning true if both
   * nodes represent the same XML tree, or false otherwise.
   *
   * @param other another XMLNode to compare against.
   *
   * @param ignoreURI whether to ignore the namespace URI when doing the
   * comparison.
   *
   * @return boolean indicating whether this XMLNode represents the same XML
   * tree as another.
   */ public
 bool equals(XMLNode other, bool ignoreURI) {
    bool ret = libsbmlPINVOKE.XMLNode_equals__SWIG_0(swigCPtr, XMLNode.getCPtr(other), ignoreURI);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Compare this XMLNode against another XMLNode returning true if both
   * nodes represent the same XML tree, or false otherwise.
   *
   * @param other another XMLNode to compare against.
   *
   * @param ignoreURI whether to ignore the namespace URI when doing the
   * comparison.
   *
   * @return boolean indicating whether this XMLNode represents the same XML
   * tree as another.
   */ public
 bool equals(XMLNode other) {
    bool ret = libsbmlPINVOKE.XMLNode_equals__SWIG_1(swigCPtr, XMLNode.getCPtr(other));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns the number of children for this XMLNode.
   *
   * @return the number of children for this XMLNode.
   */ public
 long getNumChildren() { return (long)libsbmlPINVOKE.XMLNode_getNumChildren(swigCPtr); }

  
/**
   * Returns a string representation of this XMLNode.
   *
   * @return a string derived from this XMLNode.
   */ public
 string toXMLString() {
    string ret = libsbmlPINVOKE.XMLNode_toXMLString(swigCPtr);
    return ret;
  }

  
/**
   * Returns a string representation of a given XMLNode.
   *
   * @param node the XMLNode to be represented as a string
   *
   * @return a string-form representation of @p node
   */ public
 static string convertXMLNodeToString(XMLNode node) {
    string ret = libsbmlPINVOKE.XMLNode_convertXMLNodeToString(XMLNode.getCPtr(node));
    return ret;
  }

  
/**
   * Returns an XMLNode which is derived from a string containing XML
   * content.
   *
   * The XML namespace must be defined using argument @p xmlns if the
   * corresponding XML namespace attribute is not part of the string of the
   * first argument.
   *
   * @param xmlstr string to be converted to a XML node.
   * @param xmlns XMLNamespaces the namespaces to set (default value is @c null).
   *
   * @note The caller owns the returned XMLNode and is reponsible for
   * deleting it.  The returned XMLNode object is a dummy root (container)
   * XMLNode if the top-level element in the given XML string is NOT
   * <code>&lt;html&gt;</code>, <code>&lt;body&gt;</code>,
   * <code>&lt;annotation&gt;</code>, or <code>&lt;notes&gt;</code>.  In
   * the dummy root node, each top-level element in the given XML string is
   * contained as a child XMLNode. XMLToken::isEOF() can be used to
   * identify if the returned XMLNode object is a dummy node.
   *
   * @return a XMLNode which is converted from string @p xmlstr.  If the
   * conversion failed, this method returns @c null.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 static XMLNode convertStringToXMLNode(string xmlstr, XMLNamespaces xmlns) {
    IntPtr cPtr = libsbmlPINVOKE.XMLNode_convertStringToXMLNode__SWIG_0(xmlstr, XMLNamespaces.getCPtr(xmlns));
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Returns an XMLNode which is derived from a string containing XML
   * content.
   *
   * The XML namespace must be defined using argument @p xmlns if the
   * corresponding XML namespace attribute is not part of the string of the
   * first argument.
   *
   * @param xmlstr string to be converted to a XML node.
   * @param xmlns XMLNamespaces the namespaces to set (default value is @c null).
   *
   * @note The caller owns the returned XMLNode and is reponsible for
   * deleting it.  The returned XMLNode object is a dummy root (container)
   * XMLNode if the top-level element in the given XML string is NOT
   * <code>&lt;html&gt;</code>, <code>&lt;body&gt;</code>,
   * <code>&lt;annotation&gt;</code>, or <code>&lt;notes&gt;</code>.  In
   * the dummy root node, each top-level element in the given XML string is
   * contained as a child XMLNode. XMLToken::isEOF() can be used to
   * identify if the returned XMLNode object is a dummy node.
   *
   * @return a XMLNode which is converted from string @p xmlstr.  If the
   * conversion failed, this method returns @c null.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 static XMLNode convertStringToXMLNode(string xmlstr) {
    IntPtr cPtr = libsbmlPINVOKE.XMLNode_convertStringToXMLNode__SWIG_1(xmlstr);
    XMLNode ret = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
