using System;
using System.Collections.Generic;


namespace CalcEngine.Expressions.Functions
{
	/// <summary>
	/// Set of Functions used by Expressions.
	/// </summary>
	internal class FunctionSet
	{
		/// <summary>
		/// Set of custom functions used by Expressions. If a custom function has the same
		/// name as a standard function, the custom function is used.
		/// </summary>
		private readonly IDictionary< string, PostfixMathCommand > _functions = new Dictionary< string, PostfixMathCommand >();


		/// <summary>
		/// Creates an empty FunctionSet object.
		/// </summary>
		private FunctionSet() {}


		/// <summary>
		/// Static function to create a default FunctionSet. This may be called by any
		/// object at any time if it needs the standard functions.
		/// </summary>
		internal static FunctionSet GetDefaultFunctionSet()
		{
			var fs = new FunctionSet();
			fs["+"] = new Add();
			fs["-"] = new Subtract();
			fs["*"] = new Multiply();
			fs["/"] = new Divide();
			fs["="] = new Comparator( ComparatorType.EQ );
			fs["=="] = new Comparator( ComparatorType.EQ );
			fs["<"] = new Comparator( ComparatorType.LT );
			fs["<="] = new Comparator( ComparatorType.LE );
			fs[">"] = new Comparator( ComparatorType.GT );
			fs[">="] = new Comparator( ComparatorType.GE );
			fs["!="] = new Comparator( ComparatorType.NE );
			fs["<>"] = new Comparator( ComparatorType.NE );
			fs["and"] = new And();
			fs["or"] = new Or();
			fs["not"] = new Not();
			fs["if"] = new Conditional();
			fs["round"] = new Round();
			fs["floor"] = new Floor();
			fs["sum"] = new Sum();
			fs["min"] = new Min();
			fs["max"] = new Max();
			fs["avg"] = new Average();
			fs["count"] = new Count();
			return fs;
		}


		/// <summary>
		/// Indexer of Functions by FunctionName.
		/// </summary>
		/// <param name="functionName">The name of the function to access via the indexer.
		/// </param>
		/// <exception cref="ApplicationException">Empty or Null FunctionName passed to indexer of FunctionSet</exception>
		internal PostfixMathCommand this[ string functionName ]
		{
			get
			{
				if ( string.IsNullOrEmpty( functionName ) )
					throw new ApplicationException( "Empty or Null FunctionName passed to indexer of FunctionSet" );

				return _functions[functionName.ToLower()];
			}
			set
			{
				if ( string.IsNullOrEmpty( functionName ) )
					throw new ApplicationException( "Empty or Null FunctionName passed to indexer of FunctionSet" );

				_functions[functionName.ToLower()] = value;
			}
		}
	}
}