namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Computes a Sum of aggregated values.
	/// </summary>
	internal class Sum : Aggregate
	{
		/// <summary>
		/// Creates an instance of the Sum objectthat uses a default Add  object to perform
		/// the sum.
		/// </summary>
		internal Sum()
		{
			AddFunction = new Add();
		}


		/// <summary>
		/// Abstract method that all derived Aggregate functions must implement to perform
		/// the actual calculation. The only parameter is an array of all the resulting
		/// valuesToAggregate that are to be aggregated. 
		/// </summary>
		/// <param name="valuesToAggregate">The valuesToAggregate to aggregate.</param>
		internal override double? DoAggregate( double?[] valuesToAggregate )
		{
			double? sum = 0.0;
			for ( int i = 0; i < valuesToAggregate.Length; i++ )
				sum = AddFunction.DoAdd( sum, valuesToAggregate[i] );

			return sum;
		}


		/// <summary>
		/// Gets or sets the add function.
		/// </summary>
		/// <value>The add function.</value>
		internal Add AddFunction { get; set; }

		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "sum"; }
		}
	}
}