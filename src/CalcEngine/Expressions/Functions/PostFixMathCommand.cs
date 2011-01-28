using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Function classes extend this class.
	/// <p>
	/// It includes a numberOfParameters member, that is checked when parsing the
	/// expression. This member should be initialized to an appropriate value for all
	/// classes extending this class. If an arbitrary number of parameters should be
	/// allowed, initialize this member to -1.
	/// </p>
	/// </summary>
	public abstract class PostfixMathCommand
	{
		/// <summary>
		/// This value, if used as the numberOfParameters, denotes that the function
		/// supports a variable number of parameters.
		/// </summary>
		internal const int VARIABLE_NUMBER_OF_PARAMETERS = -1;


		/// <summary>
		/// Check whether the stack is not null, throw a ApplicationException if it is.
		/// </summary>
		/// <param name="inStack">The stack to check.</param>
		/// <exception cref="ApplicationException">Stack argument null</exception>
		internal virtual void CheckStack( Stack< double? > inStack )
		{
			if ( inStack == null )
				throw new ApplicationException( "Stack argument null" );
		}


		/// <summary>
		/// Throws an exception because this method should never be called under normal
		/// circumstances. Each function should use it's own run() method for evaluating
		/// the function. This includes popping off the parameters from the stack, and
		/// pushing the result back on the stack.
		/// </summary>
		/// <param name="stack"></param>
		/// <exception cref="ApplicationException">run() method of PostfixMathCommand called</exception>
		internal virtual void Run( Stack< double? > stack )
		{
			throw new ApplicationException( "run() method of PostfixMathCommand called" );
		}


		/// <summary>
		/// Sets the number of current number of parameters used in the next call
		/// of run(). This method is only called when the reqNumberOfParameters is -1.
		/// </summary>
		internal int CurNumberOfParameters { get; set; }

		/// <summary>
		/// Return the required number of parameters.
		/// </summary>
		internal int NumberOfParameters { get; set; }

		/// <summary>
		/// Determines whether this PostfixMathCommand supports a variable number of parameters.
		/// </summary>
		internal bool SupportsVariableNumberOfParameters
		{
			get { return ( NumberOfParameters == VARIABLE_NUMBER_OF_PARAMETERS ); }
		}

		/// <summary>
		/// Gets the operator symbol or function name for this command.
		/// </summary>
		/// <value>The symbol.</value>
		internal abstract string Symbol { get; }
	}
}