using System;
using CalcEngine.Expressions.Functions;


namespace CalcEngine.Tests.Assertions
{
	public static class Node
	{
		public static NodeExpectation Value( double? value )
		{
			return NodeExpectationFactory.BuildExpectation( value );
		}


		public static NodeExpectation Function< TExpectedFunctionType >( params object[] childExpectations ) where TExpectedFunctionType : PostfixMathCommand
		{
			NodeExpectation[] childNodeExpectations = BuildExpectations( childExpectations );
			return new NodeExpectation(
					node => node.ShouldBe_Function< TExpectedFunctionType >( childNodeExpectations )
					);
		}


		/// <summary>
		/// Builds the expectations from a list of objects. This allows us to pass literal values directly, and they will get converted into a literal expectation. 
		/// So rather than Node.Function&lt;Add&gt;( Node.Value( 1.0 ), Node.Value( 2.0 ) ); You can have Node.Function&lt;Add&gt;( 1.0, 2.0 ).
		/// </summary>
		/// <param name="childExpectations">The child expectations.</param>
		/// <returns>The list of NodeExceptions built from the childExpectations.</returns>
		/// <exception cref="ArgumentException">childExpectations</exception>
		private static NodeExpectation[] BuildExpectations(object[] childExpectations)
		{
			var results = new NodeExpectation[childExpectations.Length];

			for ( int i = 0; i < childExpectations.Length; i++ )
			{
				try
				{
					results[i] = NodeExpectationFactory.BuildExpectation( childExpectations[i] );
				}
				catch ( Exception e )
				{
					throw new ArgumentException( "Error processing child expectation at index " + i + ". See inner exception for more details.", "childExpectations", e );
				}
			}

			return results;
		}
	}
}