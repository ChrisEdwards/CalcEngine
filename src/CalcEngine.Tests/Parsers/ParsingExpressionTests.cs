using CalcEngine.Expressions;
using CalcEngine.Expressions.Functions;
using CalcEngine.Parsers;
using CalcEngine.Tests.Assertions;
using NUnit.Framework;


namespace CalcEngine.Tests.Parsers
{
	[ TestFixture ]
	public class ParsingExpressionTests
	{
		private CalcEngineParser _parser;


		[ SetUp ]
		public void SetUp()
		{
			_parser = new CalcEngineParser();
		}


		[ Test ]
		public void parsing_an_integer()
		{
			AstNode node = _parser.ParseExpression( "1" );

			node.ShouldBe_LiteralValue( 1 );
		}


		[ Test ]
		public void parsing_a_decimal()
		{
			AstNode node = _parser.ParseExpression( "1.323" );

			node.ShouldBe_LiteralValue( 1.323 );
		}


		[ Test ]
		public void parsing_a_simple_addition()
		{
			AstNode node = _parser.ParseExpression( "1 + 2" );

			node.ShouldBe_BinaryFunction< Add >( 1.0, 2.0 );
		}


		[ Test ]
		public void parsing_a_simple_subtraction()
		{
			AstNode node = _parser.ParseExpression( "1 - 2" );

			node.ShouldBe_BinaryFunction< Subtract >( 1.0, 2.0 );
		}


		[ Test ]
		public void parsing_a_simple_multiplication()
		{
			AstNode node = _parser.ParseExpression( "1 * 2" );

			node.ShouldBe_BinaryFunction< Multiply >( 1.0, 2.0 );
		}


		[ Test ]
		public void parsing_a_simple_division()
		{
			AstNode node = _parser.ParseExpression( "1 / 2" );

			node.ShouldBe_BinaryFunction< Divide >( 1.0, 2.0 );
		}


		[ Test ]
		public void parenthesis_should_promote_order_of_precedence()
		{
			AstNode node = _parser.ParseExpression( "1 * ( 2 + 3 )" );

			node.ShouldBe_BinaryFunction< Multiply >(
					x => x.ShouldBe_LiteralValue( 1.0 ),
					x => x.ShouldBe_BinaryFunction< Add >( 2.0, 3.0 )
					);
		}
	}
}