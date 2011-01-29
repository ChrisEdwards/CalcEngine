using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CalcEngine.Expressions;
using CalcEngine.Expressions.Functions;
using CalcEngine.Parsers.Antlr;


namespace CalcEngine.Parsers
{
	internal class CalcEngineTreeParser
	{
		private readonly FunctionSet _functionSet = FunctionSet.GetDefaultFunctionSet();


		internal AstNode Parse( ITree source )
		{
			return null;
		}


		/// <summary>
		/// Parses the expression.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <returns>The parsed AstNode tree.</returns>
		/// <exception cref="NoViableAltException"><c>NoViableAltException</c>.</exception>
		internal AstNode ParseExpression( ITree source )
		{
			switch ( source.Type )
			{
				case TokenTypes.INT:
				case TokenTypes.FLOAT:
					return ParseLiteralNode( source );

				case TokenTypes.OP_ADD:
				case TokenTypes.OP_SUBTRACT:
				case TokenTypes.OP_MULTIPLY:
				case TokenTypes.OP_DIVIDE:
					return ParseOperatorNode( source );

				case TokenTypes.FUNCTION:
					return ParseFunctionNode( source );

				default:
					throw new NoViableAltException();
			}
		}


		private AstNode ParseLiteralNode( ITree source )
		{
			return new AstLiteralNode( double.Parse( source.Text ) );
		}


		/// <summary>
		/// Parses the operator node.
		/// </summary>
		/// <param name="source">The source Antlr Tree to parse..</param>
		/// <returns>The parsed AstNode.</returns>
		private AstNode ParseOperatorNode( ITree source )
		{
			return new AstFunctionNode(
					GetCommandForOperator( source ),
					ParseChildExpressions( source )
					);
		}


		/// <summary>
		/// Parses the function node.
		/// </summary>
		/// <param name="source">The source Antlr Tree to parse..</param>
		/// <returns>The parsed AstNode.</returns>
		/// <exception cref="NoViableAltException"><c>NoViableAltException</c>.</exception>
		private AstNode ParseFunctionNode( ITree source )
		{
			return new AstFunctionNode(
					GetFunctionByName( source.Text ),
					ParseChildExpressions( source )
					);
		}


		/// <summary>
		/// Gets the command for the function called in the specified source tree.
		/// </summary>
		/// <param name="source">The source Antlr tree representing a function call..</param>
		/// <returns>The parsed AstFunctionNode.</returns>
		/// <exception cref="NoViableAltException"><c>NoViableAltException</c>.</exception>
		private static PostfixMathCommand GetCommandForOperator( ITree source )
		{
			PostfixMathCommand command;
			switch ( source.Type )
			{
				case TokenTypes.OP_ADD:
					command = new Add();
					break;

				case TokenTypes.OP_SUBTRACT:
					command = new Subtract();
					break;

				case TokenTypes.OP_MULTIPLY:
					command = new Multiply();
					break;

				case TokenTypes.OP_DIVIDE:
					command = new Divide();
					break;

				default:
					throw new NoViableAltException();
			}
			return command;
		}


		private PostfixMathCommand GetFunctionByName( string functionName )
		{
			return _functionSet[functionName];
		}


		private IEnumerable< AstNode > ParseChildExpressions( ITree source )
		{
			IList< AstNode > children = new List< AstNode >();

			for ( int i = 0; i < source.ChildCount; i++ )
				children.Add( ParseExpression( source.GetChild( i ) ) );

			return children;
		}
	}
}