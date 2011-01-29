using System;


namespace CalcEngine.Tests.Assertions
{
	public static class NodeExpectationFactory
	{
		/// <summary>
		/// Builds a NodeExpectation from an object. If its already an expectation, it just returns it back.
		/// </summary>
		/// <param name="expectation">The expectation.</param>
		/// <returns>The NodeExpectation object that was built.</returns>
		/// <exception cref="ArgumentException">childExpectations</exception>
		public static NodeExpectation BuildExpectation( object expectationValue )
		{
			if ( expectationValue is NodeExpectation )
				return (NodeExpectation)expectationValue;

			if ( expectationValue is double? || expectationValue is double )
				return BuildExpectation( (double?)expectationValue );

			if ( expectationValue is int )
				return BuildExpectation( Double.Parse( expectationValue.ToString() ) );

			throw new ArgumentException( "Invalid expectation encounterd. Expecting either a NodeExpectation or double?, but found " + expectationValue.GetType() + ".",
			                             "expectationValue" );
		}


		public static NodeExpectation BuildExpectation( double? value )
		{
			return new NodeExpectation(
					node => node.ShouldBe_LiteralValue( value )
					);
		}
	}
}