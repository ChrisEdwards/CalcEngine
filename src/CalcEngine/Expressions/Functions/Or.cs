using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// The logical Or operator.
	/// </summary>
	internal class Or : PostfixMathCommand
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:CalcEngine.Expressions.Functions.Or" /> class.
		/// </summary>
		internal Or()
		{
			NumberOfParameters = 2;
		}


		/// <summary>
		/// Performs the actual mathematical evaluation of the Or operator.
		/// </summary>
		/// <param name="param1">The param1.</param>
		/// <param name="param2">The param2.</param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"><c>ApplicationException</c>.</exception>
		internal virtual double? DoOr( double? param1, double? param2 )
		{
			if ( ( param1.HasValue && ( param1 == 1.0 ) ) || ( param2.HasValue && ( param2 == 1.0 ) ) )
				return 1.0;

			if ( !param1.HasValue || !param2.HasValue )
				return null;

			if ( ( param1 != 0.0 ) || ( param2 != 0.0 ) )
			{
				throw new ApplicationException( "Invalid parameter type: Expected null, 1 or 0, but was param1=" + param1 +
				                                ", param2=" + param2 );
			}

			return 0.0;
		}


		/// <summary>
		/// Performs the Or operation.
		/// </summary>
		/// <param name="stack"></param>
		internal override void Run( Stack< double? > stack )
		{
			double? param1 = stack.Pop();
			double? param2 = stack.Pop();
			stack.Push( DoOr( param1, param2 ) );
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "or"; }
		}
	}
}