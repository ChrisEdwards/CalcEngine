using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the Mathematical Add operator.
	/// </summary>
	internal class Add : PostfixMathCommand
	{
		/// <summary>
		/// Construct an Add Function. The number of parameters is set to -1 to
		/// indicate that this function can accept a variable number of parameters.
		/// </summary>
		internal Add()
		{
			base.NumberOfParameters = 2;
		}


		/// <summary>
		/// Calculates the result of applying the "+" operator to the arguments from the
		/// stack and pushes it back on the stack.
		/// </summary>
		/// <param name="param1">Object to add to.</param>
		/// <param name="param2">Object to add to the first.</param>
		internal virtual double? DoAdd(double? param1, double? param2)
		{
			double? cs0 = param1;
			double? cs1 = param2;
			if (!(cs0.HasValue & cs1.HasValue))
				return null;
			return cs0.GetValueOrDefault() + cs1.GetValueOrDefault();
		}


		/// <summary>
		/// Calculates the result of applying the "+" operator to the arguments from
		/// the stack and pushes it back on the stack.
		/// </summary>
		/// <param name="stack"></param>
		internal override void Run(Stack<double?> stack)
		{
			CheckStack(stack);
			double? param1 = stack.Pop();
			double? param2 = stack.Pop();
			if (!param1.HasValue || !param2.HasValue)
				stack.Push(null);
			else
			{
				double? sum = DoAdd(param2, param1);
				stack.Push(sum);
			}
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "+"; }
		}
	}
}