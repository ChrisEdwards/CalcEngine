using CalcEngine.Expressions;
using CalcEngine.Expressions.Functions;
using CalcEngine.Parsers;
using CalcEngine.Tests.Assertions;
using NUnit.Framework;

// ReSharper disable InconsistentNaming


namespace CalcEngine.Tests.Parsers
{
	[ TestFixture ]
	public class ParsingExpressionTests
	{
		#region Setup/Teardown

		[ SetUp ]
		public void SetUp()
		{
			_parser = new CalcEngineParser();
		}

		#endregion


		private CalcEngineParser _parser;


		[ Test ]
		public void parenthesis_should_promote_order_of_precedence()
		{
			AstNode node = _parser.ParseExpression( "1 * ( 2 + 3 )" );
			node.ShouldBe( Node.Function< Multiply >( 1, Node.Function< Add >( 2, 3 ) ) );
		}


		[ Test ]
		public void parsing_a_decimal()
		{
			AstNode node = _parser.ParseExpression( "1.323" );

			node.ShouldBe( 1.323 );
		}


		[ Test ]
		public void parsing_a_simple_addition()
		{
			AstNode node = _parser.ParseExpression( "1 + 2" );
			node.ShouldBe( Node.Function< Add >( 1, 2 ) );
		}


		[ Test ]
		public void parsing_a_simple_division()
		{
			AstNode node = _parser.ParseExpression( "1 / 2" );
			node.ShouldBe( Node.Function< Divide >( 1, 2 ) );
		}


		[ Test ]
		public void parsing_a_simple_multiplication()
		{
			AstNode node = _parser.ParseExpression( "1 * 2" );
			node.ShouldBe( Node.Function< Multiply >( 1, 2 ) );
		}


		[ Test ]
		public void parsing_a_simple_subtraction()
		{
			AstNode node = _parser.ParseExpression( "1 - 2" );
			node.ShouldBe( Node.Function< Subtract >( 1, 2 ) );
		}


		[ Test ]
		public void parsing_an_integer()
		{
			AstNode node = _parser.ParseExpression( "1" );
			node.ShouldBe( 1 );
		}


		[ Test ]
		public void parsing_round_function()
		{
			AstNode node = _parser.ParseExpression( "Round( 2.1 )" );
			node.ShouldBe( Node.Function< Round >( 2.1 ) );
		}
	}
}


// ReSharper restore InconsistentNaming