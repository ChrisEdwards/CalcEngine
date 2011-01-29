namespace CalcEngine.Expressions
{
	/// <summary>
	/// Defines a Literal value to be used within the Abstract Syntax Tree.
	/// </summary>
	internal class AstLiteralNode : AstValueNode
	{
		/// <summary>
		/// The value this literal represents.
		/// </summary>
		private double? _literalValue;


		/// <summary>
		/// Initializes a new instance of the <see cref="AstLiteralNode"/> class with the given intial value.
		/// </summary>
		/// <param name="initialValue">
		/// Value of the constant.
		/// </param>
		internal AstLiteralNode( double? initialValue )
		{
			SetValue( initialValue );
		}


		/// <summary>
		/// Accept a visitor object. The visitor must be of type IAstNodeVisitor, however
		/// if the visitor also implements the most type-specific IAstLiteralNodeVisitor,
		/// or the next most type-specific IAstValueNodeVisitor interface, it uses the
		/// interface for the visit callback. Note that it uses the most type-specific
		/// interface as per its own inheritence tree. ie.
		/// <p/>
		/// AstLiteralNode -&gt; AstValueNode -&gt; SimpleNode <br/>
		/// IAstLiteralNodeVisitor -&gt; IAstValueNodeVisitor -&gt; IAstNodeVisitor
		/// <p/>
		/// This is an implementation of the AcyclicVisitor pattern by Robert C. Martin.
		/// Details of the pattern and its usage can be found at ObjectMentor.com.<br/>
		/// URL: http://www.objectmentor.com/resources/articles/acv.pdf
		/// </summary>
		/// <param name="visitor"> The object visiting this node. </param>
		/// <param name="sessionData"> Misc sessionData to use during this visit. </param>
		/// <returns> The session data object. </returns>
		internal override object Accept( IAstNodeVisitor visitor, object sessionData )
		{
			if ( visitor is IAstLiteralNodeVisitor )
				return ( (IAstLiteralNodeVisitor)visitor ).Visit( this, sessionData );
			if ( visitor is IAstValueNodeVisitor )
				return ( (IAstValueNodeVisitor)visitor ).Visit( this, sessionData );
			return visitor.Visit( this, sessionData );
		}


		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />.</param>
		/// <returns>
		/// <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the
		/// current <see cref="T:System.Object" />; otherwise, <see langword="false" />.
		/// </returns>
		public override bool Equals( object obj )
		{
			if ( ( obj == null ) || ( GetType() != obj.GetType() ) )
				return false;
			var node = (AstLiteralNode)obj;
			return GetValue().Equals( node.GetValue() );
		}


		/// <summary>
		/// Serves as a hash function for a particular type, suitable
		/// for use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <remarks>^ bitwise or - true if and only if one is true</remarks>
		/// <returns> A hash code for the current <see cref="T:System.Object" />. </returns>
		public override int GetHashCode()
		{
			return "AstLiteralNode".GetHashCode() ^ GetValue().GetHashCode();
		}


		/// <summary>
		/// Gets the value for this LiteralNode.
		/// </summary>
		/// <param name="sessionData">The session data to use as the current context..</param>
		/// <returns>The value.</returns>
		internal override double? GetValue( object sessionData = null )
		{
			return _literalValue;
		}


		/// <summary>
		/// Sets the value of this Literal Node. Passes null as context as Literals
		/// have the same value regardless of context.
		/// </summary>
		/// <param name="newValue">The new value.</param>
		internal void SetValue( double? newValue )
		{
			_literalValue = newValue;
		}


		/// <summary>
		/// Returns a string containing the function name.
		/// </summary>
		/// <returns> The to string. </returns>
		public override string ToString()
		{
			return ( "( Literal \"" + GetValue() + "\" " ) + ") ";
		}
	}
}