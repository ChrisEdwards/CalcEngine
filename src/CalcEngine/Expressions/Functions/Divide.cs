using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the Division mathematical operator.
	/// </summary>
	internal class Divide : PostfixMathCommand
	{
		/// <summary>
		/// Construct a Divide Function. The number of parameters is set to 2 since this
		/// function needs 2 operands.
		/// </summary>
		internal Divide()
		{
			base.NumberOfParameters = 2;
		}


		/// <summary>
		/// Overloads the div() function to handle Double.
		/// Calculates the result of applying the "/" operator to the arguments from
		/// the stack and pushes it back on the stack.
		/// </summary>
		/// <param name="d1">Double Numerator</param>
		/// <param name="d2">Double Denominator</param>
		internal virtual double? DoDivide( double? d1, double? d2 )
		{
			if ( d2 == 0.0 )
				return 0.0;
			if ( !( d1.HasValue & d2.HasValue ) )
				return null;
			return d1.GetValueOrDefault() / d2.GetValueOrDefault();
		}


		/// <summary>
		/// Calculates the result of applying the "/" operator to the arguments from
		/// the stack and pushes it back on the stack.
		/// </summary>
		/// <exception cref="T:System.ApplicationException">For Invalid Parameter Type.</exception>
		/// <param name="param1">Numerator (As Object)</param>
		/// <param name="param2">Denominator (As Object)</param>
		internal virtual object DoDivide( object param1, object param2 )
		{
			if ( !( param1 is double ) || !( param2 is double ) )
				throw new ApplicationException( "Invalid parameter type" );
			return DoDivide( (double)param1, (double)param2 );
		}


		/// <summary>
		/// Calculates the result of applying the "+" operator to the arguments from the
		/// stack and pushes it back on the stack.
		/// </summary>
		/// <param name="stack">The stack to operator off of.</param>
		internal override void Run( Stack< double? > stack )
		{
			CheckStack( stack );
			double? param2 = stack.Pop();
			double? param1 = stack.Pop();

			double? returnValue;
			if ( param1.HasValue && param2.HasValue )
				returnValue = DoDivide( param1, param2 );
			else
				returnValue = null;

			stack.Push( returnValue );
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "/"; }
		}
	}
}