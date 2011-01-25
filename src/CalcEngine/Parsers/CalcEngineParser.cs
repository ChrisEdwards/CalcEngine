using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CalcEngine.Expressions;
using CalcEngine.Parsers.Antlr;


namespace CalcEngine.Parsers
{
	public class CalcEngineParser
	{
		
		public AstNode Parse( string sourceText )
		{
			throw new NotImplementedException();
		}

		public AstNode ParseExpression( string expressionText )
		{
			var antlrParser = CreateParser( expressionText );
			var parserResult = antlrParser.expression();
			var root = (CommonTree)parserResult.Tree;

			var treeParser = new CalcEngineTreeParser();
			return treeParser.ParseExpression( root );
		}

		private static AntlrCalcEngineParser CreateParser(string parseText)
		{
			var input = new ANTLRStringStream( parseText );

			var lex = new AntlrCalcEngineLexer( input );
			var tokens = new CommonTokenStream( lex );
			return new AntlrCalcEngineParser( tokens );
		}
	}
}