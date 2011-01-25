namespace CalcEngine.Expressions
{
	/// <summary>
	/// Expression expression node that is the base class for a node containing a value, such
	/// as a Literal or a Data value.
	/// </summary>
	internal abstract class AstValueNode : AstNode
	{
		/// <summary>
		/// Retrieves the value for this node.
		/// </summary>
		/// <param name="sessionData">The domain row.</param>
		/// <returns></returns>
		internal abstract double? GetValue( object sessionData );
	}
}