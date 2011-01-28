namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Computes the Minimum amount in a group of aggregated values.
	/// </summary>
	internal class Min : Aggregate
	{
		/// <summary>
		/// Creates a default instance of the Min object.
		/// </summary>
		internal Min()
		{
			Comparator = new Comparator();
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
			if ( valuesToAggregate.Length == 0 )
				return null;

			double? lowestValue = valuesToAggregate[0];

			foreach ( double? t in valuesToAggregate )
			{
				if ( Comparator.DoLessThan( t, lowestValue ) )
					lowestValue = t;
			}

			return lowestValue;
		}


		/// <summary>
		/// Gets or sets the comparator.
		/// </summary>
		/// <value>The comparator.</value>
		internal Comparator Comparator { get; set; }

		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "min"; }
		}
	}
}