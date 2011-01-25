namespace CalcEngine.Expressions
{
	/// <summary>
	/// Defines an interface to visit AstValueNode objects.
	/// <p>
	/// This is an implementation of the AcyclicVisitor pattern by Robert C. Martin.
	/// Details of the pattern and its usage can be found at ObjectMentor.com.<br />
	/// URL: http://www.objectmentor.com/resources/articles/acv.pdf
	/// </p>
	/// </summary>
	internal interface IAstValueNodeVisitor
	{
		/// <summary>
		/// Visit method called when the NodeVisitor encounters an AstValueNode.
		/// </summary>
		/// <param name="node">The AstValueNode encountered by the visitor.</param>
		/// <param name="sessionData">Misc data that may be used by the visitor.</param>
		/// <returns>session data</returns>
		object Visit( AstValueNode node, object sessionData );
	}
}