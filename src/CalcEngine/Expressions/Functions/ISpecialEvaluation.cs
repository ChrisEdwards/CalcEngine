using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Functions which require greater control over their evaluation should implement
	/// this interface.
	/// </summary>
	internal interface ISpecialEvaluation
	{
		/// <summary>
		/// Performs some special evaluation on the node. This method has the
		/// responsability for evaluating the
		/// children of the node and it should generally call
		/// <c>
		/// node.jjtGetChild(i).Accept(pv,data);
		/// </c>
		/// for each child.
		/// </summary>
		/// <returns>the value after evaluation</returns>
		/// <param name="node">The current node</param>
		/// <param name="data">The data passed to visitor, typically not used</param>
		/// <param name="pv">The visitor, can be used evaluate the children</param>
		/// <param name="stack">The stack of the evaluator</param>
		object Evaluate( AstNode node, object data, IAstNodeVisitor pv, Stack< double? > stack );
	}
}