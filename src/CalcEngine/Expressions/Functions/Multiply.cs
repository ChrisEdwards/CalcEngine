using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the Multiplication mathematical operator.
	/// </summary>
	internal class Multiply : PostfixMathCommand
	{
		/// <summary>
		/// Construct a Multipy Function. The number of parameters is set to -1 to indicate
		/// that this function can accept a variable number of parameters.It multiplies all
		/// parameters together.
		/// </summary>
		internal Multiply()
		{
			NumberOfParameters = -1;
		}


		/// <summary>
		/// Multiply two Double numbers together.
		/// </summary>
		/// <param name="d1">Double argument to multiply.</param>
		/// <param name="d2">Double argument to multiply.</param>
		internal virtual double? DoMultiply( double? d1, double? d2 )
		{
			if ( !( d1.HasValue & d2.HasValue ) )
				return null;

			return d1.GetValueOrDefault() * d2.GetValueOrDefault();
		}


		/// <summary>
		/// Wrapper function for type-independent multiplication.
		/// </summary>
		/// <remarks>NOTE: This would be be implemented as operator overloading in C# for
		/// each of the specific types rather than hardcoded here.</remarks>
		/// <param name="param1">Object argument to multiply.</param>
		/// <param name="param2">Object argument to multiply</param>
		internal virtual object DoMultiply( object param1, object param2 )
		{
			if ( !( param1 is double ) || !( param2 is double ) )
				throw new ApplicationException( "Invalid parameter type" );

			return DoMultiply( (double)param1, (double)param2 );
		}


		/// <summary>
		/// Calculates the result of applying the "*" operator to the arguments from
		/// the stack and pushes it back on the stack.
		/// </summary>
		/// <param name="stack">The stack to operate off of.</param>
		internal override void Run( Stack< double? > stack )
		{
			CheckStack( stack );
			double? param1 = stack.Pop();
			double? param2 = stack.Pop();

			double? product;
			if ( param1.HasValue && param2.HasValue )
				product = DoMultiply( param2, param1 );
			else
				product = null;

			stack.Push( product );
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "*"; }
		}
	}
}