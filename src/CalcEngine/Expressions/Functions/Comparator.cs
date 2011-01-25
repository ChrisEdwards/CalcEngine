using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the comparative operations LT, GT, LE, GE, NE and EQ
	/// Caverts should work where arguments are Double, Complex or String
	/// for the last two only != and == work.
	/// For other types care might be needed.
	/// </summary>
	/// <remarks><Author>		N Funk and R Morris	</Author>
	/// <Versions>
	/// 2.3.0 beta 1 a bit of a rewrite to make sub classing easier,
	/// now allows Complex to be compared to Double i.e. 1+0 i == 1.
	/// 
	/// 2.3.0 beta 2 changed the internal lt,gt,le,ge,ne and eq method
	/// to return boolean. If this breaks anything use:
	/// <code>
	/// if(lt(obj1,obj2))
	/// stack.push(new Double(1));
	/// else
	/// stack.push(new Double(0));
	/// </code>
	/// </Versions></remarks>
	internal class Comparator : PostfixMathCommand
	{
		/// <summary>
		/// The type of compare operation this Comparator object performs.
		/// </summary>
		private readonly ComparatorType _comparatorType;


		/// <summary>
		/// Creates a default Comparator object. The default ComparatorType is set to Equality.
		/// </summary>
		internal Comparator()
				: this( ComparatorType.EQ ) {}


		/// <summary>
		/// Creates a Comparator object using the specified ComparatorType.
		/// </summary>
		/// <param name="comparatorType">The type of compare operation this Comparator object is to perform.</param>
		internal Comparator( ComparatorType comparatorType )
		{
			_comparatorType = comparatorType;
			base.NumberOfParameters = 2;
		}


		/// <summary>
		/// Determines if parameters are comparable and, if so, returns CompareTo()
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		/// <exception cref="ApplicationException"><c>ApplicationException</c>.</exception>
		protected virtual int DoCompare( object param1, object param2 )
		{
			if ( !( param1 is IComparable ) || !( param2 is IComparable ) )
			{
				throw new ApplicationException( "Comparison not defined for object of type " + param1.GetType().FullName + " and " +
				                                param1.GetType().FullName );
			}
			return ( (IComparable)param1 ).CompareTo( param2 );
		}


		internal bool DoEqual( double? param1, double? param2 )
		{
			return ( param1 == param2 );
		}


		/// <summary>
		/// Compares the two operands and returns true if the left-hand operand is equal to the right-hand operand.
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		internal virtual bool DoEqual( object param1, object param2 )
		{
			throw new ApplicationException( "ir" );
		}


		internal bool DoGreaterThan( double? param1, double? param2 )
		{
			double? cs0 = param1;
			double? cs1 = param2;
			return ( ( cs0.GetValueOrDefault() > cs1.GetValueOrDefault() ) && ( cs0.HasValue & cs1.HasValue ) );
		}


		/// <summary>
		/// Compares the two operands and returns true if the left-hand operand is greater than the right-hand operand.
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		internal virtual bool DoGreaterThan( object param1, object param2 )
		{
			return ( DoCompare( param1, param2 ) > 0 );
		}


		internal bool DoGreaterThanOrEqual( double? param1, double? param2 )
		{
			double? cs0 = param1;
			double? cs1 = param2;
			return ( ( cs0.GetValueOrDefault() >= cs1.GetValueOrDefault() ) && ( cs0.HasValue & cs1.HasValue ) );
		}


		/// <summary>
		/// Compares the two operands and returns true if the left-hand operand is greater than or equal to the right-hand operand.
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		internal virtual bool DoGreaterThanOrEqual( object param1, object param2 )
		{
			return ( DoCompare( param1, param2 ) >= 0 );
		}


		internal bool DoLessThan( double? param1, double? param2 )
		{
			double? cs0 = param1;
			double? cs1 = param2;
			return ( ( cs0.GetValueOrDefault() < cs1.GetValueOrDefault() ) && ( cs0.HasValue & cs1.HasValue ) );
		}


		/// <summary>
		/// Compares the two operands and returns true if the left-hand operand is less than the right-hand operand.
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		internal virtual bool DoLessThan( object param1, object param2 )
		{
			return ( DoCompare( param1, param2 ) < 0 );
		}


		internal bool DoLessThanOrEqual( double? param1, double? param2 )
		{
			double? cs0 = param1;
			double? cs1 = param2;
			return ( ( cs0.GetValueOrDefault() <= cs1.GetValueOrDefault() ) && ( cs0.HasValue & cs1.HasValue ) );
		}


		/// <summary>
		/// Compares the two operands and returns true if the left-hand operand is less than or equal to the right-hand operand.
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		internal virtual bool DoLessThanOrEqual( object param1, object param2 )
		{
			return ( DoCompare( param1, param2 ) <= 0 );
		}


		internal bool DoNotEqual( double? param1, double? param2 )
		{
			double? cs0 = param1;
			double? cs1 = param2;

			if ( cs0.GetValueOrDefault() == cs1.GetValueOrDefault() )
				return ( cs0.HasValue != cs1.HasValue );

			return true;
		}


		/// <summary>
		/// Compares the two operands and returns true if the left-hand operand is not equal to the right-hand operand.
		/// </summary>
		/// <param name="param1">The left-hand operand to compare.</param>
		/// <param name="param2">The right-hand operand to compare.</param>
		internal virtual bool DoNotEqual( object param1, object param2 )
		{
			return ( DoCompare( param1, param2 ) != 0 );
		}


		/// <summary>
		/// Performs the Compare operation.
		/// </summary>
		/// <param name="stack">The stack to opearate upon.</param>
		internal override void Run( Stack< double? > stack )
		{
			CheckStack( stack );

			double? param2 = stack.Pop();
			double? param1 = stack.Pop();

			if ( !param1.HasValue || !param2.HasValue )
				stack.Push( null );
			else
			{
				bool result = false;
				switch ( _comparatorType )
				{
					case ComparatorType.LT:
						result = DoLessThan( param1, param2 );
						break;

					case ComparatorType.GT:
						result = DoGreaterThan( param1, param2 );
						break;

					case ComparatorType.LE:
						result = DoLessThanOrEqual( param1, param2 );
						break;

					case ComparatorType.GE:
						result = DoGreaterThanOrEqual( param1, param2 );
						break;

					case ComparatorType.NE:
						result = DoNotEqual( param1, param2 );
						break;

					case ComparatorType.EQ:
						result = DoEqual( param1, param2 );
						break;
				}

				if ( result )
					stack.Push( 1.0 );
				else
					stack.Push( 0.0 );
			}
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get
			{
				switch ( _comparatorType )
				{
					case ComparatorType.LT:
						return "<";

					case ComparatorType.GT:
						return ">";

					case ComparatorType.LE:
						return "<=";

					case ComparatorType.GE:
						return ">=";

					case ComparatorType.NE:
						return "!=";

					case ComparatorType.EQ:
						return "==";
				}
				throw new ApplicationException( "Invalid ComparatorType Encountered." );
			}
		}
	}
}