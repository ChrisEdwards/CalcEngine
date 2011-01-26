using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Implements the Floor mathematical function.
	/// </summary>
	internal class Floor : PostfixMathCommand
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		internal Floor()
		{
			NumberOfParameters = VARIABLE_NUMBER_OF_PARAMETERS;
		}


		/// <summary>
		/// Overloads DoFloor to operate on a double.
		/// </summary>
		/// <param name="d1">The number to Floor.</param>
		internal virtual double DoFloor(double? d1)
		{
			return Math.Floor(d1.Value);
		}


		/// <summary>
		/// Gets data from the stack, performs the floor operation, then pushes the result on the stack.
		/// </summary>
		/// <param name="stack">The stack to operate upon.</param>
		internal override void Run(Stack<double?> stack)
		{
			CheckStack(stack);
			double? param = stack.Pop();
			if (!param.HasValue)
				stack.Push(null);
			else
			{
				double? returnValue = DoFloor(param);
				stack.Push(returnValue);
			}
		}


		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal override string Symbol
		{
			get { return "floor"; }
		}
	}
}