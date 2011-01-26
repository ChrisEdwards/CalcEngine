using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Logical And operator.
	/// </summary>
	internal class And : PostfixMathCommand
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:CalcEngine.Expressions.Functions.And" /> class.
		/// </summary>
		internal And()
		{
			NumberOfParameters = 2;
		}


		/// <summary>
		/// Performs the actual logic of the logical And operator.
		/// Note that if either of the terms are false, the operation returns false...even if the other
		/// parameter is null. This is because null is assumed to be unknown. Therefore if any term of
		/// an And operation is false, its result is false, regardless of what the unknown term is.
		/// </summary>
		/// <param name="param1">The param1.</param>
		/// <param name="param2">The param2.</param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"><c>ApplicationException</c>.</exception>
		internal virtual double? DoAnd(double? param1, double? param2)
		{
			if ((param1.HasValue && (param1 == 0.0)) || (param2.HasValue && (param2 == 0.0)))
				return 0.0;

			if (!param1.HasValue || !param2.HasValue)
				return null;

			if ((param1 != 1.0) || (param2 != 1.0))
			{
				throw new ApplicationException("Invalid parameter type: Expected null, 1 or 0, but was param1=" + param1 +
												", param2=" + param2);
			}
			return 1.0;
		}


		/// <summary>
		/// Executes the logical And operation.
		/// </summary>
		/// <param name="stack"></param>
		internal override void Run(Stack<double?> stack)
		{
			double? param1 = stack.Pop();
			double? param2 = stack.Pop();

			stack.Push(DoAnd(param1, param2));
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "and"; }
		}
	}
}