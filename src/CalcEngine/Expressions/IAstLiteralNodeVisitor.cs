namespace CalcEngine.Expressions
{
	/// <summary>
	/// Defines an interface to visit AstLiteralNode objects.
	/// <p>
	/// This is an implementation of the AcyclicVisitor pattern by Robert C. Martin.
	/// Details of the pattern and its usage can be found at ObjectMentor.com.<br />
	/// URL: http://www.objectmentor.com/resources/articles/acv.pdf
	/// </p>
	/// </summary>
	internal interface IAstLiteralNodeVisitor
	{
		/// <summary>
		/// Visit method called when the NodeVisitor encounters an AstLiteralNode.
		/// </summary>
		/// <param name="node">The AstLiteralNode encountered by the visitor.</param>
		/// <param name="sessionData">Misc sessionData that may be used by the visitor.</param>
		object Visit( AstLiteralNode node, object sessionData );
	}
}