using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the Subtraction mathematical operator.
	/// </summary>
	internal class Subtract : PostfixMathCommand
	{
		/// <summary>
		/// Construct a Subtract Function. Number of parameters is -1 because subtract can take either 1 parameter (-x)
		/// or 2 parameters (x - y)
		/// </summary>
		internal Subtract()
		{
			NumberOfParameters = VARIABLE_NUMBER_OF_PARAMETERS;
		}


		private static double? DoNegate( double? value )
		{
			if ( !value.HasValue )
				return null;

			return -value.GetValueOrDefault();
		}


		/// <summary>
		/// Performs the subtraction of two doubles.
		/// </summary>
		/// <param name="d1">The double value to subtract from.</param>
		/// <param name="d2">The double value to subtract from param1.</param>
		internal virtual double? DoSubtract( double? d1, double? d2 )
		{
			if ( !( d1.HasValue & d2.HasValue ) )
				return null;

			return d1.GetValueOrDefault() - d2.GetValueOrDefault();
		}


		/// <summary>
		/// Performs the subtraction of two objects.
		/// </summary>
		/// <param name="param1">The value to subtract from.</param>
		/// <param name="param2">The amount to subtract from param1.</param>
		/// <returns></returns>
		/// <exception cref="ApplicationException">Invalid parameter type</exception>
		internal virtual object DoSubtract( object param1, object param2 )
		{
			if ( !( param1 is double ) || !( param2 is double ) )
				throw new ApplicationException( "Invalid parameter type" );

			return DoSubtract( (double)param1, (double)param2 );
		}


		/// <summary>
		/// Calculates the result of applying the "-" operator to the arguments from
		/// the stack and pushes it back on the stack.
		/// </summary>
		/// <param name="stack">The stack to operate off of.</param>
		internal override void Run( Stack< double? > stack )
		{
			CheckStack( stack );
			if ( CurNumberOfParameters == 1 )
			{
				double? value = stack.Pop();
				if ( !value.HasValue )
					stack.Push( null );
				else
					stack.Push( DoNegate( value ) );
			}
			else if ( CurNumberOfParameters == 2 )
			{
				double? param2 = stack.Pop();
				double? param1 = stack.Pop();
				if ( !param1.HasValue || !param2.HasValue )
					stack.Push( null );
				else
					stack.Push( DoSubtract( param1, param2 ) );
			}
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "-"; }
		}
	}
}