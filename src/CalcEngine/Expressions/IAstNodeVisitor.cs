namespace CalcEngine.Expressions
{
	/// <summary>
	/// Interface defining a visitor object that visits node trees.
	/// <p /> This is an implementation of the AcyclicVisitor pattern by Robert C.
	/// Martin. Details of the pattern and its usage can be found at ObjectMentor.com.
	/// <br /> URL: http://www.objectmentor.com/resources/articles/acv.pdf
	/// </summary>
	internal interface IAstNodeVisitor
	{
		/// <summary>
		/// Visit method called when the NodeVisitor encounters a AstNode object. This
		/// generally means the node type was unknown since it is the general type and not
		/// specific.
		/// </summary>
		/// <param name="node">The AstNode encountered by the visitor.</param>
		/// <param name="sessionData">Misc data that may be used by the visitor.</param>
		/// <returns>object</returns>
		object Visit( AstNode node, object sessionData );
	}
}