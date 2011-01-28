using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the Round mathematical function.
	/// </summary>
	internal class Round : PostfixMathCommand
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		internal Round()
		{
			NumberOfParameters = VARIABLE_NUMBER_OF_PARAMETERS;
		}


		/// <summary>
		/// Overloads DoRound to operate on a double with and integer number of decimals.
		/// </summary>
		/// <param name="d1">The number to round.</param>
		/// <param name="numberOfDecimals">The number of decimal places to round to.</param>
		internal virtual double DoRound( double? d1, double? numberOfDecimals )
		{
			return Math.Round( d1.Value, (int)numberOfDecimals.Value );
		}


		/// <summary>
		/// Perform the Round operation.
		/// </summary>
		/// <param name="param1">The number to round.</param>
		/// <param name="numberOfDecimals">The number of decimal places to round to.</param>
		/// <exception cref="ApplicationException">Invalid parameter type</exception>
		internal virtual object DoRound( object param1, object numberOfDecimals )
		{
			if ( !( param1 is double ) || !( numberOfDecimals is double ) )
				throw new ApplicationException( "Invalid parameter type" );

			return DoRound( (double)param1, Convert.ToInt32( numberOfDecimals ) );
		}


		/// <summary>
		/// Gets data from the stack, performs the Round operation, then pushes the result on the stack.
		/// </summary>
		/// <param name="stack">The stack to operate upon.</param>
		/// <exception cref="ApplicationException"><c>ApplicationException</c>.</exception>
		internal override void Run( Stack< double? > stack )
		{
			double? decimals;
			CheckStack( stack );
			switch ( CurNumberOfParameters )
			{
				case 1:
					decimals = 0.0;
					break;

				case 2:
					decimals = stack.Pop();
					break;

				default:
					throw new ApplicationException( "Invalid number of parameters for Round() function. Expected 1 or 2, but was " +
					                                CurNumberOfParameters );
			}
			double? param = stack.Pop();
			if ( !param.HasValue || !decimals.HasValue )
				stack.Push( null );
			else
				stack.Push( DoRound( param, decimals ) );
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "round"; }
		}
	}
}