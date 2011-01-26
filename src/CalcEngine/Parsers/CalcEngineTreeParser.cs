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


		private AstNode ParseFunctionNode( ITree source )
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

				case TokenTypes.FUNCTION:
					command = _functionSet[source.Text];
					break;

				default:
					throw new NoViableAltException();
			}

			var node = new AstFunctionNode( command, command.Symbol );

			for ( int i = 0; i < source.ChildCount; i++ )
			{
				ITree sourceChild = source.GetChild( i );
				node.AddChild( ParseExpression( sourceChild ) );
			}

			return node;
		}
	}
}