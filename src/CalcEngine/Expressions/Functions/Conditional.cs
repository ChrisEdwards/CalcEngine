using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// The if(condExpr,posExpr,negExpr) function.
	/// The value of trueExpr will be returned if condExpr is &gt;0 (true)
	/// otherwise the value of negExpr will be returned.
	/// 
	/// This function performs lazy evaluation so that
	/// only posExpr or negExpr will be evaluated.
	/// For Complex numbers only the real part is used.
	/// 
	/// This function implements the ISpecialEvaluation interface
	/// so that it handles setting the value of a variable.
	/// </summary>
	internal class Conditional : PostfixMathCommand, ISpecialEvaluation
	{
		/// <summary>
		/// Create an If function object.
		/// </summary>
		internal Conditional()
		{
			NumberOfParameters = 3;
		}


		/// <summary>
		/// Performs the specified action on an expression tree.
		/// </summary>
		/// <returns>The top node of the results.</returns>
		/// <exception>ApplicationException</exception>
		/// <param name="node">The top node of the tree.</param>
		/// <param name="data">Data passed to the visitor (Typically not used).</param>
		/// <param name="pv">Visitor object that can be used to descend the tree.</param>
		/// <param name="stack">The stack to operate on.</param>
		/// <exception cref="ApplicationException">If operator must have 3 arguments.</exception>
		public virtual object Evaluate( AstNode node, object data, IAstNodeVisitor pv, Stack< double? > stack )
		{
			if ( node.NumChildren != 3 )
				throw new ApplicationException( "If operator must have 3 arguments." );

			AstNode condition = node.GetChild( 0 );
			condition.Accept( pv, data );

			CheckStack( stack );

			double? condVal = stack.Pop();
			if ( condVal.HasValue && ( condVal > 0.0 ) )
			{
				AstNode trueNode = node.GetChild( 1 );
				trueNode.Accept( pv, data );
				return data;
			}

			AstNode falseNode = node.GetChild( 2 );
			falseNode.Accept( pv, data );
			return data;
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "if"; }
		}
	}
}