namespace CalcEngine.Expressions
{
	/// <summary>
	/// Defines an interface to visit AstFunctionNode objects.
	/// <p>
	/// This is an implementation of the AcyclicVisitor pattern by Robert C. Martin.
	/// Details of the pattern and its usage can be found at ObjectMentor.com.<br />
	/// URL: http://www.objectmentor.com/resources/articles/acv.pdf
	/// </p> 
	/// </summary>
	internal interface IAstFunctionNodeVisitor
	{
		/// <summary>
		/// Visit method called when the NodeVisitor encounters an AstFunctionNode.
		/// </summary>
		/// <param name="node">The AstFunctionNode encountered by the visitor.</param>
		/// <param name="sessionData">Misc data that may be used by the visitor.</param>
		object Visit( AstFunctionNode node, object sessionData );
	}
}