using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Base class for all aggregate functions. Locates all data to be aggregated based
	/// on criteria and places it on the stack ready to be processed by the function
	/// implemented by the derived classes.
	/// 
	/// This node will have 2 child nodes. The Left will be the DataNode or Expression
	/// to aggregate, the right will be the
	/// criteria expression (filter) for which to aggregate it.
	/// </summary>
	internal abstract class Aggregate : PostfixMathCommand
	{
		private const int AGGREGATE_CRITERIA_INDEX = 1;
		private const int AGGREGATE_VALUE_INDEX = 0;


		/// <summary>
		/// Abstract method that all derived Aggregate functions must implement to perform
		/// the actual calculation. The only parameter is an array of all the resulting
		/// valuesToAggregate that are to be aggregated.  The result of the computation should be returned.
		/// </summary>
		/// <param name="valuesToAggregate">The valuesToAggregate to aggregate.</param>
		internal abstract double? DoAggregate( double?[] valuesToAggregate );


		/// <summary>
		/// Performs the Aggregate Calculation.
		/// </summary>
		/// <param name="stack"></param>
		/// <exception cref="System.InvalidOperationException">The <see cref="T:System.Collections.Generic.Stack`1" /> is empty.</exception>
		internal override void Run( Stack< double? > stack )
		{
			var numberOfValuesToAggregate = (int)stack.Pop().Value;

			var valuesToAggregate = new double?[numberOfValuesToAggregate];
			for ( int i = 0; i < numberOfValuesToAggregate; i++ )
				valuesToAggregate[i] = stack.Pop();

			double? result = DoAggregate( valuesToAggregate );
			stack.Push( result );
		}
	}
}