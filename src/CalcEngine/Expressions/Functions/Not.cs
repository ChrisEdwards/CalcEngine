using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Logical Not operator.
	/// </summary>
	internal class Not : PostfixMathCommand
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:CalcEngine.Expressions.Functions.Not" /> class.
		/// </summary>
		internal Not()
		{
			NumberOfParameters = 1;
		}


		/// <summary>
		/// Performs the mathematical evaluation of the NOT operator.
		/// </summary>
		/// <param name="param1">The param1.</param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"><c>ApplicationException</c>.</exception>
		internal virtual double? DoNot(double? param1)
		{
			if (!param1.HasValue)
				return null;

			if (param1 == 1.0)
				return 0.0;

			if (param1 != 0.0)
				throw new ApplicationException("Invalid parameter type: Expected null, 1 or 0, but was " + param1);

			return 1.0;
		}


		/// <summary>
		/// Performs the logical Not operation.
		/// </summary>
		/// <param name="stack"></param>
		internal override void Run(Stack<double?> stack)
		{
			double? result;

			double? param1 = stack.Pop();
			if (!param1.HasValue)
				result = null;
			else
				result = DoNot(param1);
			
			stack.Push(result);
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "not"; }
		}
	}
}