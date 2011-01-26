namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Computes the average of aggregated values.
	/// </summary>
	internal class Average : Aggregate
	{
		/// <summary>
		/// Creates a default instance of the Average object using default instances of the
		/// Sum and Divide objects to calculate the average.
		/// </summary>
		internal Average()
		{
			DivideFunction = new Divide();
			SumFunction = new Sum();
		}


		/// <summary>
		/// Abstract method that all derived Aggregate functions must implement to perform
		/// the actual calculation. The only parameter is an array of all the resulting
		/// valuesToAggregate that are to be aggregated. It should push the result onto the stack
		/// before exiting.
		/// </summary>
		/// <param name="valuesToAggregate">The valuesToAggregate to aggregate.</param>
		internal override double? DoAggregate( double?[] valuesToAggregate )
		{
			return DivideFunction.DoDivide( SumFunction.DoAggregate( valuesToAggregate ), valuesToAggregate.Length );
		}


		/// <summary>
		/// Gets or sets the divide function.
		/// </summary>
		/// <value>The divide function.</value>
		internal Divide DivideFunction { get; set; }

		/// <summary>
		/// Gets or sets the sum function.
		/// </summary>
		/// <value>The sum function.</value>
		internal Sum SumFunction { get; set; }

		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "avg"; }
		}
	}
}