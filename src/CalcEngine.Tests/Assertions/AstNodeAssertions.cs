using System;
using CalcEngine.Expressions;
using CalcEngine.Expressions.Functions;
using CalcEngine.Tests.Extensions;
using NUnit.Framework;


namespace CalcEngine.Tests.Assertions
{
	public static class AstNodeAssertions
	{
		/// <summary>
		/// Asserts a node is equal to another node using an NUnit assertion.
		/// </summary>
		/// <param name="actual">The node to test.</param>
		/// <param name="expected">Node that defines what we expect the actual node to look like.</param>
		public static void ShouldEqual( this AstNode actual, AstNode expected )
		{
			Assert.IsTrue( actual.Equals( expected ) );
		}


		public static void ShouldBe_LiteralValue( this AstNode node, double? expectedValue )
		{
			node.ShouldBe< AstLiteralNode >();
			Assert.That( node.As< AstLiteralNode >().GetValue(), Is.EqualTo( expectedValue ) );
		}


		public static void ShouldBe_Function< TExpectedFunction >( this AstNode node ) where TExpectedFunction : PostfixMathCommand
		{
			node.ShouldBe< AstFunctionNode >();
			node.As< AstFunctionNode >().Pfmc.ShouldBe< TExpectedFunction >();
		}


		public static void ShouldBe_Function< TExpectedFunction >( this AstNode node, params NodeExpectation[] childExpectations ) where TExpectedFunction : PostfixMathCommand
		{
			node.ShouldBe< AstFunctionNode >();
			node.As< AstFunctionNode >().Pfmc.ShouldBe< TExpectedFunction >();

			for ( int i = 0; i < node.NumChildren; i++ )
				childExpectations[i].AssertIsSatisfiedBy( node.GetChild( i ) );
		}

		public static void ShouldBe( this AstNode node,  object expectation )
		{
			var nodeExpectation = NodeExpectationFactory.BuildExpectation( expectation );
			nodeExpectation.AssertIsSatisfiedBy( node );
		}


		public static void ShouldBe_BinaryFunction< TExpectedFunction >( this AstNode node, double? expectedLeftValue, double? expectedRightValue )
				where TExpectedFunction : PostfixMathCommand
		{
			node.ShouldBe_Function< TExpectedFunction >();
			Assert.That( node.NumChildren, Is.EqualTo( 2 ) );

			AstNode leftNode = node.GetChild( 0 );
			leftNode.ShouldBe_LiteralValue( expectedLeftValue );

			AstNode rightNode = node.GetChild( 1 );
			rightNode.ShouldBe_LiteralValue( expectedRightValue );
		}
	}
}