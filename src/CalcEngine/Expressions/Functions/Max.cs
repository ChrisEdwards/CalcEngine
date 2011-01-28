namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Computes the Maximum value in a set of aggregated values.
	/// </summary>
	internal class Max : Aggregate
	{
		/// <summary>
		/// Creates a default Max object.
		/// </summary>
		internal Max()
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

			double? greatestValue = valuesToAggregate[0];

			foreach ( double? t in valuesToAggregate )
			{
				if ( Comparator.DoGreaterThan( t, greatestValue ) )
					greatestValue = t;
			}

			return greatestValue;
		}


		/// <summary>
		/// Gets or sets the comparator.
		/// </summary>
		/// <value>The comparator.</value>
		public Comparator Comparator { get; set; }

		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "max"; }
		}
	}
}