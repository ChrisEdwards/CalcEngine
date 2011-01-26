namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Computes the count of aggregated values.
	/// </summary>
	internal class Count : Aggregate
	{
		/// <summary>
		/// Abstract method that all derived Aggregate functions must implement to perform
		/// the actual calculation. The only parameter is an array of all the resulting
		/// valuesToAggregate that are to be aggregated. It should push the result onto the stack
		/// before exiting.
		/// </summary>
		/// <param name="valuesToAggregate">The valuesToAggregate to aggregate.</param>
		internal override double? DoAggregate( double?[] valuesToAggregate )
		{
			return valuesToAggregate.Length;
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "count"; }
		}
	}
}