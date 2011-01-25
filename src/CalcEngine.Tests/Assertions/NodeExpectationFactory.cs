using CalcEngine.Expressions.Functions;


namespace CalcEngine.Tests.Assertions
{
	public class NodeExpectationFactory
	{
		public NodeExpectation ShouldBe_BinaryFunction< TExpectedFunction >( double? expectedLeftValue, double? expectedRightValue ) where TExpectedFunction : PostfixMathCommand
		{
			return new NodeExpectation( n => n.ShouldBe_BinaryFunction< TExpectedFunction >( expectedLeftValue, expectedRightValue ) );
		}


		public NodeExpectation ShouldBe_LiteralValue( double? expectedValue )
		{
			return new NodeExpectation( n => n.ShouldBe_LiteralValue( expectedValue ) );
		}
	}
}