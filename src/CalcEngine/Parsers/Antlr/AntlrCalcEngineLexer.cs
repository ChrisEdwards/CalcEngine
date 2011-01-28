// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g 2011-01-28 15:07:33

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using Antlr.Runtime;
using Stack = Antlr.Runtime.Collections.StackList;


public class AntlrCalcEngineLexer : Lexer
{
	public const int FUNCTION = 19;
	public const int EXPONENT = 48;
	public const int OP_AND = 25;
	public const int OCTAL_ESC = 56;
	public const int CHAR = 53;
	public const int EOF = -1;
	public const int T__93 = 93;
	public const int T__94 = 94;
	public const int T__91 = 91;
	public const int OP_EQ = 27;
	public const int T__92 = 92;
	public const int NAME = 11;
	public const int T__90 = 90;
	public const int SQUOT = 47;
	public const int OP_GTE = 32;
	public const int THIS = 17;
	public const int OP_LT = 29;
	public const int COMMENT = 49;
	public const int T__96 = 96;
	public const int T__95 = 95;
	public const int OP_NE = 28;
	public const int T__80 = 80;
	public const int T__81 = 81;
	public const int T__82 = 82;
	public const int T__83 = 83;
	public const int OP_ADD = 33;
	public const int INT = 44;
	public const int T__85 = 85;
	public const int T__84 = 84;
	public const int T__87 = 87;
	public const int T__86 = 86;
	public const int RELATIONSHIP = 8;
	public const int T__89 = 89;
	public const int T__88 = 88;
	public const int WS = 50;
	public const int T__71 = 71;
	public const int T__72 = 72;
	public const int T__70 = 70;
	public const int PROPERTY = 7;
	public const int STATEMENT_BLOCK = 12;
	public const int FILTER = 21;
	public const int T__76 = 76;
	public const int T__75 = 75;
	public const int FALSE = 41;
	public const int T__74 = 74;
	public const int T__73 = 73;
	public const int T__79 = 79;
	public const int T__78 = 78;
	public const int T__77 = 77;
	public const int T__68 = 68;
	public const int T__69 = 69;
	public const int T__66 = 66;
	public const int T__67 = 67;
	public const int CLASS = 4;
	public const int T__64 = 64;
	public const int T__65 = 65;
	public const int T__62 = 62;
	public const int FORMULA = 13;
	public const int T__63 = 63;
	public const int PARAMETERS = 20;
	public const int OP_ASSIGN = 38;
	public const int OP_OR = 24;
	public const int OP_UNARY_NEGATION = 39;
	public const int DQUOT = 46;
	public const int OP_GT = 30;
	public const int SOURCE = 22;
	public const int BASE_CLASS = 5;
	public const int FLOAT = 45;
	public const int T__61 = 61;
	public const int ID = 42;
	public const int T__60 = 60;
	public const int ENTITY = 18;
	public const int MODIFIERS = 14;
	public const int T__57 = 57;
	public const int T__58 = 58;
	public const int ESC_SEQ = 51;
	public const int IDENTIFIER = 16;
	public const int T__59 = 59;
	public const int OP_NOT = 26;
	public const int EXPRESSION = 15;
	public const int OP_MULTIPLY = 35;
	public const int OP_LTE = 31;
	public const int UNICODE_ESC = 55;
	public const int OP_SUBTRACT = 34;
	public const int HEX_DIGIT = 54;
	public const int OP_DIVIDE = 36;
	public const int LITERAL = 43;
	public const int TARGET = 10;
	public const int TRUE = 40;
	public const int JOIN = 9;
	public const int CRITERIA = 23;
	public const int OP_MODULUS = 37;
	public const int DISCRIMINATOR = 6;
	public const int STRING = 52;

	// delegates
	// delegators

	public AntlrCalcEngineLexer()
	{
		InitializeCyclicDFAs();
	}


	public AntlrCalcEngineLexer( ICharStream input )
			: this( input, null ) {}


	public AntlrCalcEngineLexer( ICharStream input, RecognizerSharedState state )
			: base( input, state )
	{
		InitializeCyclicDFAs();
	}


	public override string GrammarFileName
	{
		get { return "C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g"; }
	}

	// $ANTLR start "T__57"
	public void mT__57() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__57;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:7:7: ( 'class' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:7:9: 'class'
			{
				Match( "class" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__57"

	// $ANTLR start "T__58"
	public void mT__58() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__58;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:8:7: ( ':' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:8:9: ':'
			{
				Match( ':' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__58"

	// $ANTLR start "T__59"
	public void mT__59() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__59;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:9:7: ( 'where' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:9:9: 'where'
			{
				Match( "where" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__59"

	// $ANTLR start "T__60"
	public void mT__60() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__60;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:10:7: ( '{' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:10:9: '{'
			{
				Match( '{' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__60"

	// $ANTLR start "T__61"
	public void mT__61() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__61;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:11:7: ( '}' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:11:9: '}'
			{
				Match( '}' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__61"

	// $ANTLR start "T__62"
	public void mT__62() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__62;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:12:7: ( 'property' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:12:9: 'property'
			{
				Match( "property" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__62"

	// $ANTLR start "T__63"
	public void mT__63() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__63;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:13:7: ( ';' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:13:9: ';'
			{
				Match( ';' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__63"

	// $ANTLR start "T__64"
	public void mT__64() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__64;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:14:7: ( 'primarykey' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:14:9: 'primarykey'
			{
				Match( "primarykey" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__64"

	// $ANTLR start "T__65"
	public void mT__65() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__65;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:15:7: ( 'calculated' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:15:9: 'calculated'
			{
				Match( "calculated" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__65"

	// $ANTLR start "T__66"
	public void mT__66() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__66;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:16:7: ( 'abstract' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:16:9: 'abstract'
			{
				Match( "abstract" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__66"

	// $ANTLR start "T__67"
	public void mT__67() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__67;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:17:7: ( 'relationship' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:17:9: 'relationship'
			{
				Match( "relationship" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__67"

	// $ANTLR start "T__68"
	public void mT__68() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__68;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:18:7: ( '=' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:18:9: '='
			{
				Match( '=' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__68"

	// $ANTLR start "T__69"
	public void mT__69() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__69;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:19:7: ( '(' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:19:9: '('
			{
				Match( '(' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__69"

	// $ANTLR start "T__70"
	public void mT__70() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__70;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:20:7: ( ')' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:20:9: ')'
			{
				Match( ')' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__70"

	// $ANTLR start "T__71"
	public void mT__71() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__71;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:21:7: ( 'not' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:21:9: 'not'
			{
				Match( "not" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__71"

	// $ANTLR start "T__72"
	public void mT__72() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__72;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:22:7: ( '!' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:22:9: '!'
			{
				Match( '!' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__72"

	// $ANTLR start "T__73"
	public void mT__73() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__73;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:23:7: ( 'or' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:23:9: 'or'
			{
				Match( "or" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__73"

	// $ANTLR start "T__74"
	public void mT__74() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__74;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:24:7: ( '||' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:24:9: '||'
			{
				Match( "||" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__74"

	// $ANTLR start "T__75"
	public void mT__75() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__75;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:25:7: ( 'and' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:25:9: 'and'
			{
				Match( "and" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__75"

	// $ANTLR start "T__76"
	public void mT__76() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__76;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:26:7: ( '&&' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:26:9: '&&'
			{
				Match( "&&" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__76"

	// $ANTLR start "T__77"
	public void mT__77() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__77;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:27:7: ( 'mod' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:27:9: 'mod'
			{
				Match( "mod" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__77"

	// $ANTLR start "T__78"
	public void mT__78() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__78;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:28:7: ( '%' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:28:9: '%'
			{
				Match( '%' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__78"

	// $ANTLR start "T__79"
	public void mT__79() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__79;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:29:7: ( '==' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:29:9: '=='
			{
				Match( "==" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__79"

	// $ANTLR start "T__80"
	public void mT__80() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__80;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:30:7: ( '!=' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:30:9: '!='
			{
				Match( "!=" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__80"

	// $ANTLR start "T__81"
	public void mT__81() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__81;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:31:7: ( '<>' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:31:9: '<>'
			{
				Match( "<>" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__81"

	// $ANTLR start "T__82"
	public void mT__82() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__82;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:32:7: ( '<' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:32:9: '<'
			{
				Match( '<' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__82"

	// $ANTLR start "T__83"
	public void mT__83() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__83;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:33:7: ( '>' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:33:9: '>'
			{
				Match( '>' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__83"

	// $ANTLR start "T__84"
	public void mT__84() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__84;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:34:7: ( '<=' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:34:9: '<='
			{
				Match( "<=" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__84"

	// $ANTLR start "T__85"
	public void mT__85() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__85;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:35:7: ( '>=' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:35:9: '>='
			{
				Match( ">=" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__85"

	// $ANTLR start "T__86"
	public void mT__86() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__86;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:36:7: ( '+' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:36:9: '+'
			{
				Match( '+' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__86"

	// $ANTLR start "T__87"
	public void mT__87() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__87;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:37:7: ( '-' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:37:9: '-'
			{
				Match( '-' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__87"

	// $ANTLR start "T__88"
	public void mT__88() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__88;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:38:7: ( '*' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:38:9: '*'
			{
				Match( '*' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__88"

	// $ANTLR start "T__89"
	public void mT__89() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__89;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:39:7: ( '/' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:39:9: '/'
			{
				Match( '/' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__89"

	// $ANTLR start "T__90"
	public void mT__90() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__90;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:40:7: ( '.' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:40:9: '.'
			{
				Match( '.' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__90"

	// $ANTLR start "T__91"
	public void mT__91() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__91;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:41:7: ( 'this' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:41:9: 'this'
			{
				Match( "this" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__91"

	// $ANTLR start "T__92"
	public void mT__92() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__92;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:42:7: ( '[' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:42:9: '['
			{
				Match( '[' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__92"

	// $ANTLR start "T__93"
	public void mT__93() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__93;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:43:7: ( ']' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:43:9: ']'
			{
				Match( ']' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__93"

	// $ANTLR start "T__94"
	public void mT__94() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__94;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:44:7: ( ',' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:44:9: ','
			{
				Match( ',' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__94"

	// $ANTLR start "T__95"
	public void mT__95() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__95;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:45:7: ( 'true' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:45:9: 'true'
			{
				Match( "true" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__95"

	// $ANTLR start "T__96"
	public void mT__96() // throws RecognitionException [2]
	{
		try
		{
			int _type = T__96;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:46:7: ( 'false' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:46:9: 'false'
			{
				Match( "false" );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "T__96"

	// $ANTLR start "LITERAL"
	public void mLITERAL() // throws RecognitionException [2]
	{
		try
		{
			int _type = LITERAL;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:2: ( DQUOT (~ DQUOT )* DQUOT | SQUOT (~ SQUOT )* SQUOT )
			int alt3 = 2;
			int LA3_0 = input.LA( 1 );

			if ( ( LA3_0 == '\"' ) )
				alt3 = 1;
			else if ( ( LA3_0 == '\'' ) )
				alt3 = 2;
			else
			{
				var nvae_d3s0 =
						new NoViableAltException( "", 3, 0, input );

				throw nvae_d3s0;
			}
			switch ( alt3 )
			{
				case 1:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:4: DQUOT (~ DQUOT )* DQUOT
					{
						mDQUOT();
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:10: (~ DQUOT )*
						do
						{
							int alt1 = 2;
							int LA1_0 = input.LA( 1 );

							if ( ( ( LA1_0 >= '\u0000' && LA1_0 <= '!' ) || ( LA1_0 >= '#' && LA1_0 <= '\uFFFF' ) ) )
								alt1 = 1;


							switch ( alt1 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:10: ~ DQUOT
									{
										if ( ( input.LA( 1 ) >= '\u0000' && input.LA( 1 ) <= '-' ) || ( input.LA( 1 ) >= '/' && input.LA( 1 ) <= '\uFFFF' ) )
											input.Consume();
										else
										{
											var mse = new MismatchedSetException( null, input );
											Recover( mse );
											throw mse;
										}
									}
									break;

								default:
									goto loop1;
							}
						} while ( true );

						loop1:
						; // Stops C# compiler whining that label 'loop1' has no statements

						mDQUOT();
					}
					break;
				case 2:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:281:4: SQUOT (~ SQUOT )* SQUOT
					{
						mSQUOT();
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:281:10: (~ SQUOT )*
						do
						{
							int alt2 = 2;
							int LA2_0 = input.LA( 1 );

							if ( ( ( LA2_0 >= '\u0000' && LA2_0 <= '&' ) || ( LA2_0 >= '(' && LA2_0 <= '\uFFFF' ) ) )
								alt2 = 1;


							switch ( alt2 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:281:10: ~ SQUOT
									{
										if ( ( input.LA( 1 ) >= '\u0000' && input.LA( 1 ) <= '.' ) || ( input.LA( 1 ) >= '0' && input.LA( 1 ) <= '\uFFFF' ) )
											input.Consume();
										else
										{
											var mse = new MismatchedSetException( null, input );
											Recover( mse );
											throw mse;
										}
									}
									break;

								default:
									goto loop2;
							}
						} while ( true );

						loop2:
						; // Stops C# compiler whining that label 'loop2' has no statements

						mSQUOT();
					}
					break;
			}
			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "LITERAL"

	// $ANTLR start "SQUOT"
	public void mSQUOT() // throws RecognitionException [2]
	{
		try
		{
			int _type = SQUOT;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:285:2: ( '\\'' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:285:4: '\\''
			{
				Match( '\'' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "SQUOT"

	// $ANTLR start "DQUOT"
	public void mDQUOT() // throws RecognitionException [2]
	{
		try
		{
			int _type = DQUOT;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:288:2: ( '\"' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:288:4: '\"'
			{
				Match( '\"' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "DQUOT"

	// $ANTLR start "ID"
	public void mID() // throws RecognitionException [2]
	{
		try
		{
			int _type = ID;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:291:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:291:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
			{
				if ( ( input.LA( 1 ) >= 'A' && input.LA( 1 ) <= 'Z' ) || input.LA( 1 ) == '_' || ( input.LA( 1 ) >= 'a' && input.LA( 1 ) <= 'z' ) )
					input.Consume();
				else
				{
					var mse = new MismatchedSetException( null, input );
					Recover( mse );
					throw mse;
				}

				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:291:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
				do
				{
					int alt4 = 2;
					int LA4_0 = input.LA( 1 );

					if ( ( ( LA4_0 >= '0' && LA4_0 <= '9' ) || ( LA4_0 >= 'A' && LA4_0 <= 'Z' ) || LA4_0 == '_' || ( LA4_0 >= 'a' && LA4_0 <= 'z' ) ) )
						alt4 = 1;


					switch ( alt4 )
					{
						case 1:
							// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
							{
								if ( ( input.LA( 1 ) >= '0' && input.LA( 1 ) <= '9' ) || ( input.LA( 1 ) >= 'A' && input.LA( 1 ) <= 'Z' ) || input.LA( 1 ) == '_' ||
								     ( input.LA( 1 ) >= 'a' && input.LA( 1 ) <= 'z' ) )
									input.Consume();
								else
								{
									var mse = new MismatchedSetException( null, input );
									Recover( mse );
									throw mse;
								}
							}
							break;

						default:
							goto loop4;
					}
				} while ( true );

				loop4:
				; // Stops C# compiler whining that label 'loop4' has no statements
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "ID"

	// $ANTLR start "INT"
	public void mINT() // throws RecognitionException [2]
	{
		try
		{
			int _type = INT;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:5: ( ( '0' .. '9' )+ )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:7: ( '0' .. '9' )+
			{
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:7: ( '0' .. '9' )+
				int cnt5 = 0;
				do
				{
					int alt5 = 2;
					int LA5_0 = input.LA( 1 );

					if ( ( ( LA5_0 >= '0' && LA5_0 <= '9' ) ) )
						alt5 = 1;


					switch ( alt5 )
					{
						case 1:
							// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:7: '0' .. '9'
							{
								MatchRange( '0', '9' );
							}
							break;

						default:
							if ( cnt5 >= 1 ) goto loop5;
							var eee5 =
									new EarlyExitException( 5, input );
							throw eee5;
					}
					cnt5++;
				} while ( true );

				loop5:
				; // Stops C# compiler whining that label 'loop5' has no statements
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "INT"

	// $ANTLR start "FLOAT"
	public void mFLOAT() // throws RecognitionException [2]
	{
		try
		{
			int _type = FLOAT;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
			int alt12 = 3;
			alt12 = dfa12.Predict( input );
			switch ( alt12 )
			{
				case 1:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
					{
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:9: ( '0' .. '9' )+
						int cnt6 = 0;
						do
						{
							int alt6 = 2;
							int LA6_0 = input.LA( 1 );

							if ( ( ( LA6_0 >= '0' && LA6_0 <= '9' ) ) )
								alt6 = 1;


							switch ( alt6 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:10: '0' .. '9'
									{
										MatchRange( '0', '9' );
									}
									break;

								default:
									if ( cnt6 >= 1 ) goto loop6;
									var eee6 =
											new EarlyExitException( 6, input );
									throw eee6;
							}
							cnt6++;
						} while ( true );

						loop6:
						; // Stops C# compiler whining that label 'loop6' has no statements

						Match( '.' );
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:25: ( '0' .. '9' )*
						do
						{
							int alt7 = 2;
							int LA7_0 = input.LA( 1 );

							if ( ( ( LA7_0 >= '0' && LA7_0 <= '9' ) ) )
								alt7 = 1;


							switch ( alt7 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:26: '0' .. '9'
									{
										MatchRange( '0', '9' );
									}
									break;

								default:
									goto loop7;
							}
						} while ( true );

						loop7:
						; // Stops C# compiler whining that label 'loop7' has no statements

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:37: ( EXPONENT )?
						int alt8 = 2;
						int LA8_0 = input.LA( 1 );

						if ( ( LA8_0 == 'E' || LA8_0 == 'e' ) )
							alt8 = 1;
						switch ( alt8 )
						{
							case 1:
								// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:37: EXPONENT
								{
									mEXPONENT();
								}
								break;
						}
					}
					break;
				case 2:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
					{
						Match( '.' );
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:13: ( '0' .. '9' )+
						int cnt9 = 0;
						do
						{
							int alt9 = 2;
							int LA9_0 = input.LA( 1 );

							if ( ( ( LA9_0 >= '0' && LA9_0 <= '9' ) ) )
								alt9 = 1;


							switch ( alt9 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:14: '0' .. '9'
									{
										MatchRange( '0', '9' );
									}
									break;

								default:
									if ( cnt9 >= 1 ) goto loop9;
									var eee9 =
											new EarlyExitException( 9, input );
									throw eee9;
							}
							cnt9++;
						} while ( true );

						loop9:
						; // Stops C# compiler whining that label 'loop9' has no statements

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:25: ( EXPONENT )?
						int alt10 = 2;
						int LA10_0 = input.LA( 1 );

						if ( ( LA10_0 == 'E' || LA10_0 == 'e' ) )
							alt10 = 1;
						switch ( alt10 )
						{
							case 1:
								// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:25: EXPONENT
								{
									mEXPONENT();
								}
								break;
						}
					}
					break;
				case 3:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:300:9: ( '0' .. '9' )+ EXPONENT
					{
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:300:9: ( '0' .. '9' )+
						int cnt11 = 0;
						do
						{
							int alt11 = 2;
							int LA11_0 = input.LA( 1 );

							if ( ( ( LA11_0 >= '0' && LA11_0 <= '9' ) ) )
								alt11 = 1;


							switch ( alt11 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:300:10: '0' .. '9'
									{
										MatchRange( '0', '9' );
									}
									break;

								default:
									if ( cnt11 >= 1 ) goto loop11;
									var eee11 =
											new EarlyExitException( 11, input );
									throw eee11;
							}
							cnt11++;
						} while ( true );

						loop11:
						; // Stops C# compiler whining that label 'loop11' has no statements

						mEXPONENT();
					}
					break;
			}
			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "FLOAT"

	// $ANTLR start "COMMENT"
	public void mCOMMENT() // throws RecognitionException [2]
	{
		try
		{
			int _type = COMMENT;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
			int alt16 = 2;
			int LA16_0 = input.LA( 1 );

			if ( ( LA16_0 == '/' ) )
			{
				int LA16_1 = input.LA( 2 );

				if ( ( LA16_1 == '/' ) )
					alt16 = 1;
				else if ( ( LA16_1 == '*' ) )
					alt16 = 2;
				else
				{
					var nvae_d16s1 =
							new NoViableAltException( "", 16, 1, input );

					throw nvae_d16s1;
				}
			}
			else
			{
				var nvae_d16s0 =
						new NoViableAltException( "", 16, 0, input );

				throw nvae_d16s0;
			}
			switch ( alt16 )
			{
				case 1:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
					{
						Match( "//" );

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:14: (~ ( '\\n' | '\\r' ) )*
						do
						{
							int alt13 = 2;
							int LA13_0 = input.LA( 1 );

							if ( ( ( LA13_0 >= '\u0000' && LA13_0 <= '\t' ) || ( LA13_0 >= '\u000B' && LA13_0 <= '\f' ) || ( LA13_0 >= '\u000E' && LA13_0 <= '\uFFFF' ) ) )
								alt13 = 1;


							switch ( alt13 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:14: ~ ( '\\n' | '\\r' )
									{
										if ( ( input.LA( 1 ) >= '\u0000' && input.LA( 1 ) <= '\t' ) || ( input.LA( 1 ) >= '\u000B' && input.LA( 1 ) <= '\f' ) ||
										     ( input.LA( 1 ) >= '\u000E' && input.LA( 1 ) <= '\uFFFF' ) )
											input.Consume();
										else
										{
											var mse = new MismatchedSetException( null, input );
											Recover( mse );
											throw mse;
										}
									}
									break;

								default:
									goto loop13;
							}
						} while ( true );

						loop13:
						; // Stops C# compiler whining that label 'loop13' has no statements

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:28: ( '\\r' )?
						int alt14 = 2;
						int LA14_0 = input.LA( 1 );

						if ( ( LA14_0 == '\r' ) )
							alt14 = 1;
						switch ( alt14 )
						{
							case 1:
								// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:28: '\\r'
								{
									Match( '\r' );
								}
								break;
						}

						Match( '\n' );
						_channel = HIDDEN;
					}
					break;
				case 2:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:305:9: '/*' ( options {greedy=false; } : . )* '*/'
					{
						Match( "/*" );

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:305:14: ( options {greedy=false; } : . )*
						do
						{
							int alt15 = 2;
							int LA15_0 = input.LA( 1 );

							if ( ( LA15_0 == '*' ) )
							{
								int LA15_1 = input.LA( 2 );

								if ( ( LA15_1 == '/' ) )
									alt15 = 2;
								else if ( ( ( LA15_1 >= '\u0000' && LA15_1 <= '.' ) || ( LA15_1 >= '0' && LA15_1 <= '\uFFFF' ) ) )
									alt15 = 1;
							}
							else if ( ( ( LA15_0 >= '\u0000' && LA15_0 <= ')' ) || ( LA15_0 >= '+' && LA15_0 <= '\uFFFF' ) ) )
								alt15 = 1;


							switch ( alt15 )
							{
								case 1:
									// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:305:42: .
									{
										MatchAny();
									}
									break;

								default:
									goto loop15;
							}
						} while ( true );

						loop15:
						; // Stops C# compiler whining that label 'loop15' has no statements

						Match( "*/" );

						_channel = HIDDEN;
					}
					break;
			}
			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "COMMENT"

	// $ANTLR start "WS"
	public void mWS() // throws RecognitionException [2]
	{
		try
		{
			int _type = WS;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:308:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:308:9: ( ' ' | '\\t' | '\\r' | '\\n' )
			{
				if ( ( input.LA( 1 ) >= '\t' && input.LA( 1 ) <= '\n' ) || input.LA( 1 ) == '\r' || input.LA( 1 ) == ' ' )
					input.Consume();
				else
				{
					var mse = new MismatchedSetException( null, input );
					Recover( mse );
					throw mse;
				}

				_channel = HIDDEN;
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "WS"

	// $ANTLR start "STRING"
	public void mSTRING() // throws RecognitionException [2]
	{
		try
		{
			int _type = STRING;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:5: ( '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:8: '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"'
			{
				Match( '\"' );
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:12: ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )*
				do
				{
					int alt17 = 3;
					int LA17_0 = input.LA( 1 );

					if ( ( LA17_0 == '\\' ) )
						alt17 = 1;
					else if ( ( ( LA17_0 >= '\u0000' && LA17_0 <= '!' ) || ( LA17_0 >= '#' && LA17_0 <= '[' ) || ( LA17_0 >= ']' && LA17_0 <= '\uFFFF' ) ) )
						alt17 = 2;


					switch ( alt17 )
					{
						case 1:
							// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:14: ESC_SEQ
							{
								mESC_SEQ();
							}
							break;
						case 2:
							// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:24: ~ ( '\\\\' | '\"' )
							{
								if ( ( input.LA( 1 ) >= '\u0000' && input.LA( 1 ) <= '!' ) || ( input.LA( 1 ) >= '#' && input.LA( 1 ) <= '[' ) || ( input.LA( 1 ) >= ']' && input.LA( 1 ) <= '\uFFFF' ) )
									input.Consume();
								else
								{
									var mse = new MismatchedSetException( null, input );
									Recover( mse );
									throw mse;
								}
							}
							break;

						default:
							goto loop17;
					}
				} while ( true );

				loop17:
				; // Stops C# compiler whining that label 'loop17' has no statements

				Match( '\"' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "STRING"

	// $ANTLR start "CHAR"
	public void mCHAR() // throws RecognitionException [2]
	{
		try
		{
			int _type = CHAR;
			int _channel = DEFAULT_TOKEN_CHANNEL;
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:5: ( '\\'' ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) ) '\\'' )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:8: '\\'' ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) ) '\\''
			{
				Match( '\'' );
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:13: ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) )
				int alt18 = 2;
				int LA18_0 = input.LA( 1 );

				if ( ( LA18_0 == '\\' ) )
					alt18 = 1;
				else if ( ( ( LA18_0 >= '\u0000' && LA18_0 <= '&' ) || ( LA18_0 >= '(' && LA18_0 <= '[' ) || ( LA18_0 >= ']' && LA18_0 <= '\uFFFF' ) ) )
					alt18 = 2;
				else
				{
					var nvae_d18s0 =
							new NoViableAltException( "", 18, 0, input );

					throw nvae_d18s0;
				}
				switch ( alt18 )
				{
					case 1:
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:15: ESC_SEQ
						{
							mESC_SEQ();
						}
						break;
					case 2:
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:25: ~ ( '\\'' | '\\\\' )
						{
							if ( ( input.LA( 1 ) >= '\u0000' && input.LA( 1 ) <= '&' ) || ( input.LA( 1 ) >= '(' && input.LA( 1 ) <= '[' ) || ( input.LA( 1 ) >= ']' && input.LA( 1 ) <= '\uFFFF' ) )
								input.Consume();
							else
							{
								var mse = new MismatchedSetException( null, input );
								Recover( mse );
								throw mse;
							}
						}
						break;
				}

				Match( '\'' );
			}

			state.type = _type;
			state.channel = _channel;
		}
		finally {}
	}


	// $ANTLR end "CHAR"

	// $ANTLR start "EXPONENT"
	public void mEXPONENT() // throws RecognitionException [2]
	{
		try
		{
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
			{
				if ( input.LA( 1 ) == 'E' || input.LA( 1 ) == 'e' )
					input.Consume();
				else
				{
					var mse = new MismatchedSetException( null, input );
					Recover( mse );
					throw mse;
				}

				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:22: ( '+' | '-' )?
				int alt19 = 2;
				int LA19_0 = input.LA( 1 );

				if ( ( LA19_0 == '+' || LA19_0 == '-' ) )
					alt19 = 1;
				switch ( alt19 )
				{
					case 1:
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
						{
							if ( input.LA( 1 ) == '+' || input.LA( 1 ) == '-' )
								input.Consume();
							else
							{
								var mse = new MismatchedSetException( null, input );
								Recover( mse );
								throw mse;
							}
						}
						break;
				}

				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:33: ( '0' .. '9' )+
				int cnt20 = 0;
				do
				{
					int alt20 = 2;
					int LA20_0 = input.LA( 1 );

					if ( ( ( LA20_0 >= '0' && LA20_0 <= '9' ) ) )
						alt20 = 1;


					switch ( alt20 )
					{
						case 1:
							// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:34: '0' .. '9'
							{
								MatchRange( '0', '9' );
							}
							break;

						default:
							if ( cnt20 >= 1 ) goto loop20;
							var eee20 =
									new EarlyExitException( 20, input );
							throw eee20;
					}
					cnt20++;
				} while ( true );

				loop20:
				; // Stops C# compiler whining that label 'loop20' has no statements
			}
		}
		finally {}
	}


	// $ANTLR end "EXPONENT"

	// $ANTLR start "HEX_DIGIT"
	public void mHEX_DIGIT() // throws RecognitionException [2]
	{
		try
		{
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:326:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:326:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
			{
				if ( ( input.LA( 1 ) >= '0' && input.LA( 1 ) <= '9' ) || ( input.LA( 1 ) >= 'A' && input.LA( 1 ) <= 'F' ) || ( input.LA( 1 ) >= 'a' && input.LA( 1 ) <= 'f' ) )
					input.Consume();
				else
				{
					var mse = new MismatchedSetException( null, input );
					Recover( mse );
					throw mse;
				}
			}
		}
		finally {}
	}


	// $ANTLR end "HEX_DIGIT"

	// $ANTLR start "ESC_SEQ"
	public void mESC_SEQ() // throws RecognitionException [2]
	{
		try
		{
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:330:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UNICODE_ESC | OCTAL_ESC )
			int alt21 = 3;
			int LA21_0 = input.LA( 1 );

			if ( ( LA21_0 == '\\' ) )
			{
				switch ( input.LA( 2 ) )
				{
					case '\"':
					case '\'':
					case '\\':
					case 'b':
					case 'f':
					case 'n':
					case 'r':
					case 't':
						{
							alt21 = 1;
						}
						break;
					case 'u':
						{
							alt21 = 2;
						}
						break;
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
						{
							alt21 = 3;
						}
						break;
					default:
						var nvae_d21s1 =
								new NoViableAltException( "", 21, 1, input );

						throw nvae_d21s1;
				}
			}
			else
			{
				var nvae_d21s0 =
						new NoViableAltException( "", 21, 0, input );

				throw nvae_d21s0;
			}
			switch ( alt21 )
			{
				case 1:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:330:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
					{
						Match( '\\' );
						if ( input.LA( 1 ) == '\"' || input.LA( 1 ) == '\'' || input.LA( 1 ) == '\\' || input.LA( 1 ) == 'b' || input.LA( 1 ) == 'f' || input.LA( 1 ) == 'n' || input.LA( 1 ) == 'r' ||
						     input.LA( 1 ) == 't' )
							input.Consume();
						else
						{
							var mse = new MismatchedSetException( null, input );
							Recover( mse );
							throw mse;
						}
					}
					break;
				case 2:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:331:9: UNICODE_ESC
					{
						mUNICODE_ESC();
					}
					break;
				case 3:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:332:9: OCTAL_ESC
					{
						mOCTAL_ESC();
					}
					break;
			}
		}
		finally {}
	}


	// $ANTLR end "ESC_SEQ"

	// $ANTLR start "OCTAL_ESC"
	public void mOCTAL_ESC() // throws RecognitionException [2]
	{
		try
		{
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
			int alt22 = 3;
			int LA22_0 = input.LA( 1 );

			if ( ( LA22_0 == '\\' ) )
			{
				int LA22_1 = input.LA( 2 );

				if ( ( ( LA22_1 >= '0' && LA22_1 <= '3' ) ) )
				{
					int LA22_2 = input.LA( 3 );

					if ( ( ( LA22_2 >= '0' && LA22_2 <= '7' ) ) )
					{
						int LA22_4 = input.LA( 4 );

						if ( ( ( LA22_4 >= '0' && LA22_4 <= '7' ) ) )
							alt22 = 1;
						else
							alt22 = 2;
					}
					else
						alt22 = 3;
				}
				else if ( ( ( LA22_1 >= '4' && LA22_1 <= '7' ) ) )
				{
					int LA22_3 = input.LA( 3 );

					if ( ( ( LA22_3 >= '0' && LA22_3 <= '7' ) ) )
						alt22 = 2;
					else
						alt22 = 3;
				}
				else
				{
					var nvae_d22s1 =
							new NoViableAltException( "", 22, 1, input );

					throw nvae_d22s1;
				}
			}
			else
			{
				var nvae_d22s0 =
						new NoViableAltException( "", 22, 0, input );

				throw nvae_d22s0;
			}
			switch ( alt22 )
			{
				case 1:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
					{
						Match( '\\' );
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:14: ( '0' .. '3' )
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:15: '0' .. '3'
						{
							MatchRange( '0', '3' );
						}

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:25: ( '0' .. '7' )
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:26: '0' .. '7'
						{
							MatchRange( '0', '7' );
						}

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:36: ( '0' .. '7' )
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:37: '0' .. '7'
						{
							MatchRange( '0', '7' );
						}
					}
					break;
				case 2:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
					{
						Match( '\\' );
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:14: ( '0' .. '7' )
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:15: '0' .. '7'
						{
							MatchRange( '0', '7' );
						}

						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:25: ( '0' .. '7' )
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:26: '0' .. '7'
						{
							MatchRange( '0', '7' );
						}
					}
					break;
				case 3:
					// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:339:9: '\\\\' ( '0' .. '7' )
					{
						Match( '\\' );
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:339:14: ( '0' .. '7' )
						// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:339:15: '0' .. '7'
						{
							MatchRange( '0', '7' );
						}
					}
					break;
			}
		}
		finally {}
	}


	// $ANTLR end "OCTAL_ESC"

	// $ANTLR start "UNICODE_ESC"
	public void mUNICODE_ESC() // throws RecognitionException [2]
	{
		try
		{
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:344:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
			// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:344:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
			{
				Match( '\\' );
				Match( 'u' );
				mHEX_DIGIT();
				mHEX_DIGIT();
				mHEX_DIGIT();
				mHEX_DIGIT();
			}
		}
		finally {}
	}


	// $ANTLR end "UNICODE_ESC"

	public override void mTokens() // throws RecognitionException 
	{
		// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:8: ( T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | T__94 | T__95 | T__96 | LITERAL | SQUOT | DQUOT | ID | INT | FLOAT | COMMENT | WS | STRING | CHAR )
		int alt23 = 50;
		alt23 = dfa23.Predict( input );
		switch ( alt23 )
		{
			case 1:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:10: T__57
				{
					mT__57();
				}
				break;
			case 2:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:16: T__58
				{
					mT__58();
				}
				break;
			case 3:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:22: T__59
				{
					mT__59();
				}
				break;
			case 4:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:28: T__60
				{
					mT__60();
				}
				break;
			case 5:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:34: T__61
				{
					mT__61();
				}
				break;
			case 6:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:40: T__62
				{
					mT__62();
				}
				break;
			case 7:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:46: T__63
				{
					mT__63();
				}
				break;
			case 8:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:52: T__64
				{
					mT__64();
				}
				break;
			case 9:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:58: T__65
				{
					mT__65();
				}
				break;
			case 10:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:64: T__66
				{
					mT__66();
				}
				break;
			case 11:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:70: T__67
				{
					mT__67();
				}
				break;
			case 12:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:76: T__68
				{
					mT__68();
				}
				break;
			case 13:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:82: T__69
				{
					mT__69();
				}
				break;
			case 14:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:88: T__70
				{
					mT__70();
				}
				break;
			case 15:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:94: T__71
				{
					mT__71();
				}
				break;
			case 16:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:100: T__72
				{
					mT__72();
				}
				break;
			case 17:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:106: T__73
				{
					mT__73();
				}
				break;
			case 18:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:112: T__74
				{
					mT__74();
				}
				break;
			case 19:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:118: T__75
				{
					mT__75();
				}
				break;
			case 20:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:124: T__76
				{
					mT__76();
				}
				break;
			case 21:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:130: T__77
				{
					mT__77();
				}
				break;
			case 22:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:136: T__78
				{
					mT__78();
				}
				break;
			case 23:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:142: T__79
				{
					mT__79();
				}
				break;
			case 24:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:148: T__80
				{
					mT__80();
				}
				break;
			case 25:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:154: T__81
				{
					mT__81();
				}
				break;
			case 26:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:160: T__82
				{
					mT__82();
				}
				break;
			case 27:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:166: T__83
				{
					mT__83();
				}
				break;
			case 28:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:172: T__84
				{
					mT__84();
				}
				break;
			case 29:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:178: T__85
				{
					mT__85();
				}
				break;
			case 30:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:184: T__86
				{
					mT__86();
				}
				break;
			case 31:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:190: T__87
				{
					mT__87();
				}
				break;
			case 32:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:196: T__88
				{
					mT__88();
				}
				break;
			case 33:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:202: T__89
				{
					mT__89();
				}
				break;
			case 34:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:208: T__90
				{
					mT__90();
				}
				break;
			case 35:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:214: T__91
				{
					mT__91();
				}
				break;
			case 36:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:220: T__92
				{
					mT__92();
				}
				break;
			case 37:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:226: T__93
				{
					mT__93();
				}
				break;
			case 38:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:232: T__94
				{
					mT__94();
				}
				break;
			case 39:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:238: T__95
				{
					mT__95();
				}
				break;
			case 40:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:244: T__96
				{
					mT__96();
				}
				break;
			case 41:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:250: LITERAL
				{
					mLITERAL();
				}
				break;
			case 42:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:258: SQUOT
				{
					mSQUOT();
				}
				break;
			case 43:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:264: DQUOT
				{
					mDQUOT();
				}
				break;
			case 44:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:270: ID
				{
					mID();
				}
				break;
			case 45:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:273: INT
				{
					mINT();
				}
				break;
			case 46:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:277: FLOAT
				{
					mFLOAT();
				}
				break;
			case 47:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:283: COMMENT
				{
					mCOMMENT();
				}
				break;
			case 48:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:291: WS
				{
					mWS();
				}
				break;
			case 49:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:294: STRING
				{
					mSTRING();
				}
				break;
			case 50:
				// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:301: CHAR
				{
					mCHAR();
				}
				break;
		}
	}


	protected DFA12 dfa12;
	protected DFA23 dfa23;


	private void InitializeCyclicDFAs()
	{
		dfa12 = new DFA12( this );
		dfa23 = new DFA23( this );
		dfa23.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler( DFA23_SpecialStateTransition );
	}


	private const string DFA12_eotS =
			"\x05\uffff";

	private const string DFA12_eofS =
			"\x05\uffff";

	private const string DFA12_minS =
			"\x02\x2e\x03\uffff";

	private const string DFA12_maxS =
			"\x01\x39\x01\x65\x03\uffff";

	private const string DFA12_acceptS =
			"\x02\uffff\x01\x02\x01\x01\x01\x03";

	private const string DFA12_specialS =
			"\x05\uffff}>";

	private static readonly string[] DFA12_transitionS = {
	                                                     		"\x01\x02\x01\uffff\x0a\x01",
	                                                     		"\x01\x03\x01\uffff\x0a\x01\x0b\uffff\x01\x04\x1f\uffff\x01" +
	                                                     		"\x04",
	                                                     		"",
	                                                     		"",
	                                                     		""
	                                                     };

	private static readonly short[] DFA12_eot = DFA.UnpackEncodedString( DFA12_eotS );
	private static readonly short[] DFA12_eof = DFA.UnpackEncodedString( DFA12_eofS );
	private static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars( DFA12_minS );
	private static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars( DFA12_maxS );
	private static readonly short[] DFA12_accept = DFA.UnpackEncodedString( DFA12_acceptS );
	private static readonly short[] DFA12_special = DFA.UnpackEncodedString( DFA12_specialS );
	private static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray( DFA12_transitionS );


	protected class DFA12 : DFA
	{
		public DFA12( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			decisionNumber = 12;
			eot = DFA12_eot;
			eof = DFA12_eof;
			min = DFA12_min;
			max = DFA12_max;
			accept = DFA12_accept;
			special = DFA12_special;
			transition = DFA12_transition;
		}


		public override string Description
		{
			get { return "297:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );"; }
		}
	}


	private const string DFA23_eotS =
			"\x01\uffff\x01\x22\x01\uffff\x01\x22\x02\uffff\x01\x22\x01\uffff" +
			"\x02\x22\x01\x2d\x02\uffff\x01\x22\x01\x30\x01\x22\x02\uffff\x01" +
			"\x22\x01\uffff\x01\x35\x01\x37\x03\uffff\x01\x39\x01\x3a\x01\x22" +
			"\x03\uffff\x01\x22\x01\x42\x01\x45\x01\uffff\x01\x47\x01\uffff\x07" +
			"\x22\x02\uffff\x01\x22\x02\uffff\x01\x51\x01\x22\x09\uffff\x03\x22" +
			"\x09\uffff\x06\x22\x01\x67\x01\x22\x01\x69\x01\uffff\x01\x6a\x03" +
			"\x22\x01\x46\x04\uffff\x01\x46\x05\uffff\x06\x22\x01\uffff\x01\x22" +
			"\x02\uffff\x01\x7d\x01\x7e\x01\x22\x08\uffff\x01\u0084\x01\x22\x01" +
			"\u0086\x04\x22\x02\uffff\x01\u008b\x05\uffff\x01\x22\x01\uffff\x04" +
			"\x22\x03\uffff\x05\x22\x02\uffff\x01\x22\x01\u009b\x01\x22\x01\u009d" +
			"\x02\x22\x01\uffff\x01\x22\x01\uffff\x01\x22\x01\u00a2\x01\u00a3" +
			"\x01\x22\x02\uffff\x01\x22\x01\u00a6\x01\uffff";

	private const string DFA23_eofS =
			"\u00a7\uffff";

	private const string DFA23_minS =
			"\x01\x09\x01\x61\x01\uffff\x01\x68\x02\uffff\x01\x72\x01\uffff" +
			"\x01\x62\x01\x65\x01\x3d\x02\uffff\x01\x6f\x01\x3d\x01\x72\x02\uffff" +
			"\x01\x6f\x01\uffff\x02\x3d\x03\uffff\x01\x2a\x01\x30\x01\x68\x03" +
			"\uffff\x01\x61\x02\x00\x01\uffff\x01\x2e\x01\uffff\x01\x61\x01\x6c" +
			"\x01\x65\x01\x69\x01\x73\x01\x64\x01\x6c\x02\uffff\x01\x74\x02\uffff" +
			"\x01\x30\x01\x64\x09\uffff\x01\x69\x01\x75\x01\x6c\x02\x00\x02\uffff" +
			"\x02\x00\x03\uffff\x01\x73\x01\x63\x01\x72\x01\x70\x01\x6d\x01\x74" +
			"\x01\x30\x01\x61\x01\x30\x01\uffff\x01\x30\x01\x73\x01\x65\x01\x73" +
			"\x05\x00\x01\x27\x04\x00\x01\uffff\x01\x73\x01\x75\x02\x65\x01\x61" +
			"\x01\x72\x01\uffff\x01\x74\x02\uffff\x02\x30\x01\x65\x01\uffff\x03" +
			"\x00\x01\uffff\x03\x00\x01\x30\x01\x6c\x01\x30\x02\x72\x01\x61\x01" +
			"\x69\x02\uffff\x01\x30\x04\x00\x01\uffff\x01\x61\x01\uffff\x01\x74" +
			"\x01\x79\x01\x63\x01\x6f\x01\uffff\x02\x00\x01\x74\x01\x79\x01\x6b" +
			"\x01\x74\x01\x6e\x02\x00\x01\x65\x01\x30\x01\x65\x01\x30\x01\x73" +
			"\x01\x64\x01\uffff\x01\x79\x01\uffff\x01\x68\x02\x30\x01\x69\x02" +
			"\uffff\x01\x70\x01\x30\x01\uffff";

	private const string DFA23_maxS =
			"\x01\x7d\x01\x6c\x01\uffff\x01\x68\x02\uffff\x01\x72\x01\uffff" +
			"\x01\x6e\x01\x65\x01\x3d\x02\uffff\x01\x6f\x01\x3d\x01\x72\x02\uffff" +
			"\x01\x6f\x01\uffff\x01\x3e\x01\x3d\x03\uffff\x01\x2f\x01\x39\x01" +
			"\x72\x03\uffff\x01\x61\x02\uffff\x01\uffff\x01\x65\x01\uffff\x01" +
			"\x61\x01\x6c\x01\x65\x01\x6f\x01\x73\x01\x64\x01\x6c\x02\uffff\x01" +
			"\x74\x02\uffff\x01\x7a\x01\x64\x09\uffff\x01\x69\x01\x75\x01\x6c" +
			"\x02\uffff\x02\uffff\x02\uffff\x03\uffff\x01\x73\x01\x63\x01\x72" +
			"\x01\x70\x01\x6d\x01\x74\x01\x7a\x01\x61\x01\x7a\x01\uffff\x01\x7a" +
			"\x01\x73\x01\x65\x01\x73\x05\uffff\x01\x27\x04\uffff\x01\uffff\x01" +
			"\x73\x01\x75\x02\x65\x01\x61\x01\x72\x01\uffff\x01\x74\x02\uffff" +
			"\x02\x7a\x01\x65\x01\uffff\x03\uffff\x01\uffff\x03\uffff\x01\x7a" +
			"\x01\x6c\x01\x7a\x02\x72\x01\x61\x01\x69\x02\uffff\x01\x7a\x04\uffff" +
			"\x01\uffff\x01\x61\x01\uffff\x01\x74\x01\x79\x01\x63\x01\x6f\x01" +
			"\uffff\x02\uffff\x01\x74\x01\x79\x01\x6b\x01\x74\x01\x6e\x02\uffff" +
			"\x01\x65\x01\x7a\x01\x65\x01\x7a\x01\x73\x01\x64\x01\uffff\x01\x79" +
			"\x01\uffff\x01\x68\x02\x7a\x01\x69\x02\uffff\x01\x70\x01\x7a\x01" +
			"\uffff";

	private const string DFA23_acceptS =
			"\x02\uffff\x01\x02\x01\uffff\x01\x04\x01\x05\x01\uffff\x01\x07" +
			"\x03\uffff\x01\x0d\x01\x0e\x03\uffff\x01\x12\x01\x14\x01\uffff\x01" +
			"\x16\x02\uffff\x01\x1e\x01\x1f\x01\x20\x03\uffff\x01\x24\x01\x25" +
			"\x01\x26\x03\uffff\x01\x2c\x01\uffff\x01\x30\x07\uffff\x01\x17\x01" +
			"\x0c\x01\uffff\x01\x18\x01\x10\x02\uffff\x01\x19\x01\x1c\x01\x1a" +
			"\x01\x1d\x01\x1b\x01\x2f\x01\x21\x01\x22\x01\x2e\x05\uffff\x01\x29" +
			"\x01\x2b\x02\uffff\x01\x2a\x01\x29\x01\x2d\x09\uffff\x01\x11\x0e" +
			"\uffff\x01\x29\x06\uffff\x01\x13\x01\uffff\x01\x0f\x01\x15\x03\uffff" +
			"\x01\x31\x03\uffff\x01\x32\x0a\uffff\x01\x23\x01\x27\x05\uffff\x01" +
			"\x01\x01\uffff\x01\x03\x04\uffff\x01\x28\x0f\uffff\x01\x06\x01\uffff" +
			"\x01\x0a\x04\uffff\x01\x09\x01\x08\x02\uffff\x01\x0b";

	private const string DFA23_specialS =
			"\x20\uffff\x01\x02\x01\x01\x1d\uffff\x01\x0e\x01\x07\x02\uffff" +
			"\x01\x17\x01\x18\x11\uffff\x01\x1b\x01\x05\x01\x19\x01\x06\x01\x1a" +
			"\x01\uffff\x01\x04\x01\x13\x01\x12\x01\x1c\x0f\uffff\x01\x09\x01" +
			"\x14\x01\x11\x01\uffff\x01\x0d\x01\x0f\x01\x0c\x0a\uffff\x01\x0a" +
			"\x01\x10\x01\x16\x01\x0b\x08\uffff\x01\x08\x01\x15\x05\uffff\x01" +
			"\x03\x01\x00\x12\uffff}>";

	private static readonly string[] DFA23_transitionS = {
	                                                     		"\x02\x24\x02\uffff\x01\x24\x12\uffff\x01\x24\x01\x0e\x01\x20" +
	                                                     		"\x02\uffff\x01\x13\x01\x11\x01\x21\x01\x0b\x01\x0c\x01\x18\x01" +
	                                                     		"\x16\x01\x1e\x01\x17\x01\x1a\x01\x19\x0a\x23\x01\x02\x01\x07" +
	                                                     		"\x01\x14\x01\x0a\x01\x15\x02\uffff\x1a\x22\x01\x1c\x01\uffff" +
	                                                     		"\x01\x1d\x01\uffff\x01\x22\x01\uffff\x01\x08\x01\x22\x01\x01" +
	                                                     		"\x02\x22\x01\x1f\x06\x22\x01\x12\x01\x0d\x01\x0f\x01\x06\x01" +
	                                                     		"\x22\x01\x09\x01\x22\x01\x1b\x02\x22\x01\x03\x03\x22\x01\x04" +
	                                                     		"\x01\x10\x01\x05",
	                                                     		"\x01\x26\x0a\uffff\x01\x25",
	                                                     		"",
	                                                     		"\x01\x27",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x28",
	                                                     		"",
	                                                     		"\x01\x29\x0b\uffff\x01\x2a",
	                                                     		"\x01\x2b",
	                                                     		"\x01\x2c",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x2e",
	                                                     		"\x01\x2f",
	                                                     		"\x01\x31",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x32",
	                                                     		"",
	                                                     		"\x01\x34\x01\x33",
	                                                     		"\x01\x36",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x38\x04\uffff\x01\x38",
	                                                     		"\x0a\x3b",
	                                                     		"\x01\x3c\x09\uffff\x01\x3d",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x3e",
	                                                     		"\x22\x40\x01\x41\x39\x40\x01\x3f\uffa3\x40",
	                                                     		"\x27\x44\x01\x46\x34\x44\x01\x43\uffa3\x44",
	                                                     		"",
	                                                     		"\x01\x3b\x01\uffff\x0a\x23\x0b\uffff\x01\x3b\x1f\uffff\x01" +
	                                                     		"\x3b",
	                                                     		"",
	                                                     		"\x01\x48",
	                                                     		"\x01\x49",
	                                                     		"\x01\x4a",
	                                                     		"\x01\x4c\x05\uffff\x01\x4b",
	                                                     		"\x01\x4d",
	                                                     		"\x01\x4e",
	                                                     		"\x01\x4f",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x50",
	                                                     		"",
	                                                     		"",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\x52",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x53",
	                                                     		"\x01\x54",
	                                                     		"\x01\x55",
	                                                     		"\x22\x46\x01\x56\x04\x46\x01\x5a\x08\x46\x04\x58\x04\x59\x24" +
	                                                     		"\x46\x01\x5a\x05\x46\x01\x5a\x03\x46\x01\x5a\x07\x46\x01\x5a" +
	                                                     		"\x03\x46\x01\x5a\x01\x46\x01\x5a\x01\x57\uff8a\x46",
	                                                     		"\x22\x40\x01\x41\x39\x40\x01\x3f\uffa3\x40",
	                                                     		"",
	                                                     		"",
	                                                     		"\x22\x46\x01\x5f\x04\x46\x01\x5b\x08\x46\x04\x5d\x04\x5e\x24" +
	                                                     		"\x46\x01\x5f\x05\x46\x01\x5f\x03\x46\x01\x5f\x07\x46\x01\x5f" +
	                                                     		"\x03\x46\x01\x5f\x01\x46\x01\x5f\x01\x5c\uff8a\x46",
	                                                     		"\x27\x46\x01\x60\uffd8\x46",
	                                                     		"",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\x61",
	                                                     		"\x01\x62",
	                                                     		"\x01\x63",
	                                                     		"\x01\x64",
	                                                     		"\x01\x65",
	                                                     		"\x01\x66",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\x68",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\x6b",
	                                                     		"\x01\x6c",
	                                                     		"\x01\x6d",
	                                                     		"\x00\x6e",
	                                                     		"\x30\x46\x0a\x6f\x07\x46\x06\x6f\x1a\x46\x06\x6f\uff99\x46",
	                                                     		"\x22\x40\x01\x41\x0d\x40\x08\x70\x24\x40\x01\x3f\uffa3\x40",
	                                                     		"\x22\x40\x01\x41\x0d\x40\x08\x71\x24\x40\x01\x3f\uffa3\x40",
	                                                     		"\x22\x40\x01\x41\x39\x40\x01\x3f\uffa3\x40",
	                                                     		"\x01\x72",
	                                                     		"\x30\x46\x0a\x73\x07\x46\x06\x73\x1a\x46\x06\x73\uff99\x46",
	                                                     		"\x27\x46\x01\x60\x08\x46\x08\x74\uffc8\x46",
	                                                     		"\x27\x46\x01\x60\x08\x46\x08\x75\uffc8\x46",
	                                                     		"\x27\x46\x01\x60\uffd8\x46",
	                                                     		"",
	                                                     		"\x01\x76",
	                                                     		"\x01\x77",
	                                                     		"\x01\x78",
	                                                     		"\x01\x79",
	                                                     		"\x01\x7a",
	                                                     		"\x01\x7b",
	                                                     		"",
	                                                     		"\x01\x7c",
	                                                     		"",
	                                                     		"",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\x7f",
	                                                     		"",
	                                                     		"\x30\x46\x0a\u0080\x07\x46\x06\u0080\x1a\x46\x06\u0080\uff99" +
	                                                     		"\x46",
	                                                     		"\x22\x40\x01\x41\x0d\x40\x08\u0081\x24\x40\x01\x3f\uffa3\x40",
	                                                     		"\x22\x40\x01\x41\x39\x40\x01\x3f\uffa3\x40",
	                                                     		"",
	                                                     		"\x30\x46\x0a\u0082\x07\x46\x06\u0082\x1a\x46\x06\u0082\uff99" +
	                                                     		"\x46",
	                                                     		"\x27\x46\x01\x60\x08\x46\x08\u0083\uffc8\x46",
	                                                     		"\x27\x46\x01\x60\uffd8\x46",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\u0085",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\u0087",
	                                                     		"\x01\u0088",
	                                                     		"\x01\u0089",
	                                                     		"\x01\u008a",
	                                                     		"",
	                                                     		"",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x30\x46\x0a\u008c\x07\x46\x06\u008c\x1a\x46\x06\u008c\uff99" +
	                                                     		"\x46",
	                                                     		"\x22\x40\x01\x41\x39\x40\x01\x3f\uffa3\x40",
	                                                     		"\x30\x46\x0a\u008d\x07\x46\x06\u008d\x1a\x46\x06\u008d\uff99" +
	                                                     		"\x46",
	                                                     		"\x27\x46\x01\x60\uffd8\x46",
	                                                     		"",
	                                                     		"\x01\u008e",
	                                                     		"",
	                                                     		"\x01\u008f",
	                                                     		"\x01\u0090",
	                                                     		"\x01\u0091",
	                                                     		"\x01\u0092",
	                                                     		"",
	                                                     		"\x30\x46\x0a\u0093\x07\x46\x06\u0093\x1a\x46\x06\u0093\uff99" +
	                                                     		"\x46",
	                                                     		"\x30\x46\x0a\u0094\x07\x46\x06\u0094\x1a\x46\x06\u0094\uff99" +
	                                                     		"\x46",
	                                                     		"\x01\u0095",
	                                                     		"\x01\u0096",
	                                                     		"\x01\u0097",
	                                                     		"\x01\u0098",
	                                                     		"\x01\u0099",
	                                                     		"\x22\x40\x01\x41\x39\x40\x01\x3f\uffa3\x40",
	                                                     		"\x27\x46\x01\x60\uffd8\x46",
	                                                     		"\x01\u009a",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\u009c",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\u009e",
	                                                     		"\x01\u009f",
	                                                     		"",
	                                                     		"\x01\u00a0",
	                                                     		"",
	                                                     		"\x01\u00a1",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		"\x01\u00a4",
	                                                     		"",
	                                                     		"",
	                                                     		"\x01\u00a5",
	                                                     		"\x0a\x22\x07\uffff\x1a\x22\x04\uffff\x01\x22\x01\uffff\x1a" +
	                                                     		"\x22",
	                                                     		""
	                                                     };

	private static readonly short[] DFA23_eot = DFA.UnpackEncodedString( DFA23_eotS );
	private static readonly short[] DFA23_eof = DFA.UnpackEncodedString( DFA23_eofS );
	private static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars( DFA23_minS );
	private static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars( DFA23_maxS );
	private static readonly short[] DFA23_accept = DFA.UnpackEncodedString( DFA23_acceptS );
	private static readonly short[] DFA23_special = DFA.UnpackEncodedString( DFA23_specialS );
	private static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray( DFA23_transitionS );


	protected class DFA23 : DFA
	{
		public DFA23( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			decisionNumber = 23;
			eot = DFA23_eot;
			eof = DFA23_eof;
			min = DFA23_min;
			max = DFA23_max;
			accept = DFA23_accept;
			special = DFA23_special;
			transition = DFA23_transition;
		}


		public override string Description
		{
			get
			{
				return
						"1:1: Tokens : ( T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | T__94 | T__95 | T__96 | LITERAL | SQUOT | DQUOT | ID | INT | FLOAT | COMMENT | WS | STRING | CHAR );";
			}
		}
	}


	protected internal int DFA23_SpecialStateTransition( DFA dfa, int s, IIntStream _input ) //throws NoViableAltException
	{
		IIntStream input = _input;
		int _s = s;
		switch ( s )
		{
			case 0:
				int LA23_148 = input.LA( 1 );

				s = -1;
				if ( ( LA23_148 == '\'' ) ) s = 96;

				else if ( ( ( LA23_148 >= '\u0000' && LA23_148 <= '&' ) || ( LA23_148 >= '(' && LA23_148 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 1:
				int LA23_33 = input.LA( 1 );

				s = -1;
				if ( ( LA23_33 == '\\' ) ) s = 67;

				else if ( ( ( LA23_33 >= '\u0000' && LA23_33 <= '&' ) || ( LA23_33 >= '(' && LA23_33 <= '[' ) || ( LA23_33 >= ']' && LA23_33 <= '\uFFFF' ) ) ) s = 68;

				else if ( ( LA23_33 == '\'' ) ) s = 70;

				else s = 69;

				if ( s >= 0 ) return s;
				break;
			case 2:
				int LA23_32 = input.LA( 1 );

				s = -1;
				if ( ( LA23_32 == '\\' ) ) s = 63;

				else if ( ( ( LA23_32 >= '\u0000' && LA23_32 <= '!' ) || ( LA23_32 >= '#' && LA23_32 <= '[' ) || ( LA23_32 >= ']' && LA23_32 <= '\uFFFF' ) ) ) s = 64;

				else if ( ( LA23_32 == '\"' ) ) s = 65;

				else s = 66;

				if ( s >= 0 ) return s;
				break;
			case 3:
				int LA23_147 = input.LA( 1 );

				s = -1;
				if ( ( LA23_147 == '\"' ) ) s = 65;

				else if ( ( LA23_147 == '\\' ) ) s = 63;

				else if ( ( ( LA23_147 >= '\u0000' && LA23_147 <= '!' ) || ( LA23_147 >= '#' && LA23_147 <= '[' ) || ( LA23_147 >= ']' && LA23_147 <= '\uFFFF' ) ) ) s = 64;

				if ( s >= 0 ) return s;
				break;
			case 4:
				int LA23_92 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_92 >= '\u0000' && LA23_92 <= '/' ) || ( LA23_92 >= ':' && LA23_92 <= '@' ) || ( LA23_92 >= 'G' && LA23_92 <= '`' ) || ( LA23_92 >= 'g' && LA23_92 <= '\uFFFF' ) ) )
					s = 70;

				else if ( ( ( LA23_92 >= '0' && LA23_92 <= '9' ) || ( LA23_92 >= 'A' && LA23_92 <= 'F' ) || ( LA23_92 >= 'a' && LA23_92 <= 'f' ) ) ) s = 115;

				if ( s >= 0 ) return s;
				break;
			case 5:
				int LA23_87 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_87 >= '0' && LA23_87 <= '9' ) || ( LA23_87 >= 'A' && LA23_87 <= 'F' ) || ( LA23_87 >= 'a' && LA23_87 <= 'f' ) ) ) s = 111;

				else if ( ( ( LA23_87 >= '\u0000' && LA23_87 <= '/' ) || ( LA23_87 >= ':' && LA23_87 <= '@' ) || ( LA23_87 >= 'G' && LA23_87 <= '`' ) || ( LA23_87 >= 'g' && LA23_87 <= '\uFFFF' ) ) )
					s = 70;

				if ( s >= 0 ) return s;
				break;
			case 6:
				int LA23_89 = input.LA( 1 );

				s = -1;
				if ( ( LA23_89 == '\"' ) ) s = 65;

				else if ( ( LA23_89 == '\\' ) ) s = 63;

				else if ( ( ( LA23_89 >= '0' && LA23_89 <= '7' ) ) ) s = 113;

				else if ( ( ( LA23_89 >= '\u0000' && LA23_89 <= '!' ) || ( LA23_89 >= '#' && LA23_89 <= '/' ) || ( LA23_89 >= '8' && LA23_89 <= '[' ) || ( LA23_89 >= ']' && LA23_89 <= '\uFFFF' ) ) )
					s = 64;

				if ( s >= 0 ) return s;
				break;
			case 7:
				int LA23_64 = input.LA( 1 );

				s = -1;
				if ( ( LA23_64 == '\"' ) ) s = 65;

				else if ( ( LA23_64 == '\\' ) ) s = 63;

				else if ( ( ( LA23_64 >= '\u0000' && LA23_64 <= '!' ) || ( LA23_64 >= '#' && LA23_64 <= '[' ) || ( LA23_64 >= ']' && LA23_64 <= '\uFFFF' ) ) ) s = 64;

				if ( s >= 0 ) return s;
				break;
			case 8:
				int LA23_140 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_140 >= '0' && LA23_140 <= '9' ) || ( LA23_140 >= 'A' && LA23_140 <= 'F' ) || ( LA23_140 >= 'a' && LA23_140 <= 'f' ) ) ) s = 147;

				else if ( ( ( LA23_140 >= '\u0000' && LA23_140 <= '/' ) || ( LA23_140 >= ':' && LA23_140 <= '@' ) || ( LA23_140 >= 'G' && LA23_140 <= '`' ) ||
				            ( LA23_140 >= 'g' && LA23_140 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 9:
				int LA23_111 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_111 >= '0' && LA23_111 <= '9' ) || ( LA23_111 >= 'A' && LA23_111 <= 'F' ) || ( LA23_111 >= 'a' && LA23_111 <= 'f' ) ) ) s = 128;

				else if ( ( ( LA23_111 >= '\u0000' && LA23_111 <= '/' ) || ( LA23_111 >= ':' && LA23_111 <= '@' ) || ( LA23_111 >= 'G' && LA23_111 <= '`' ) ||
				            ( LA23_111 >= 'g' && LA23_111 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 10:
				int LA23_128 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_128 >= '0' && LA23_128 <= '9' ) || ( LA23_128 >= 'A' && LA23_128 <= 'F' ) || ( LA23_128 >= 'a' && LA23_128 <= 'f' ) ) ) s = 140;

				else if ( ( ( LA23_128 >= '\u0000' && LA23_128 <= '/' ) || ( LA23_128 >= ':' && LA23_128 <= '@' ) || ( LA23_128 >= 'G' && LA23_128 <= '`' ) ||
				            ( LA23_128 >= 'g' && LA23_128 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 11:
				int LA23_131 = input.LA( 1 );

				s = -1;
				if ( ( LA23_131 == '\'' ) ) s = 96;

				else if ( ( ( LA23_131 >= '\u0000' && LA23_131 <= '&' ) || ( LA23_131 >= '(' && LA23_131 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 12:
				int LA23_117 = input.LA( 1 );

				s = -1;
				if ( ( LA23_117 == '\'' ) ) s = 96;

				else if ( ( ( LA23_117 >= '\u0000' && LA23_117 <= '&' ) || ( LA23_117 >= '(' && LA23_117 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 13:
				int LA23_115 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_115 >= '\u0000' && LA23_115 <= '/' ) || ( LA23_115 >= ':' && LA23_115 <= '@' ) || ( LA23_115 >= 'G' && LA23_115 <= '`' ) ||
				       ( LA23_115 >= 'g' && LA23_115 <= '\uFFFF' ) ) ) s = 70;

				else if ( ( ( LA23_115 >= '0' && LA23_115 <= '9' ) || ( LA23_115 >= 'A' && LA23_115 <= 'F' ) || ( LA23_115 >= 'a' && LA23_115 <= 'f' ) ) ) s = 130;

				if ( s >= 0 ) return s;
				break;
			case 14:
				int LA23_63 = input.LA( 1 );

				s = -1;
				if ( ( LA23_63 == '\"' ) ) s = 86;

				else if ( ( LA23_63 == 'u' ) ) s = 87;

				else if ( ( ( LA23_63 >= '0' && LA23_63 <= '3' ) ) ) s = 88;

				else if ( ( ( LA23_63 >= '4' && LA23_63 <= '7' ) ) ) s = 89;

				else if ( ( LA23_63 == '\'' || LA23_63 == '\\' || LA23_63 == 'b' || LA23_63 == 'f' || LA23_63 == 'n' || LA23_63 == 'r' || LA23_63 == 't' ) ) s = 90;

				else if ( ( ( LA23_63 >= '\u0000' && LA23_63 <= '!' ) || ( LA23_63 >= '#' && LA23_63 <= '&' ) || ( LA23_63 >= '(' && LA23_63 <= '/' ) || ( LA23_63 >= '8' && LA23_63 <= '[' ) ||
				            ( LA23_63 >= ']' && LA23_63 <= 'a' ) || ( LA23_63 >= 'c' && LA23_63 <= 'e' ) || ( LA23_63 >= 'g' && LA23_63 <= 'm' ) || ( LA23_63 >= 'o' && LA23_63 <= 'q' ) ||
				            LA23_63 == 's' || ( LA23_63 >= 'v' && LA23_63 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 15:
				int LA23_116 = input.LA( 1 );

				s = -1;
				if ( ( LA23_116 == '\'' ) ) s = 96;

				else if ( ( ( LA23_116 >= '0' && LA23_116 <= '7' ) ) ) s = 131;

				else if ( ( ( LA23_116 >= '\u0000' && LA23_116 <= '&' ) || ( LA23_116 >= '(' && LA23_116 <= '/' ) || ( LA23_116 >= '8' && LA23_116 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 16:
				int LA23_129 = input.LA( 1 );

				s = -1;
				if ( ( LA23_129 == '\"' ) ) s = 65;

				else if ( ( LA23_129 == '\\' ) ) s = 63;

				else if ( ( ( LA23_129 >= '\u0000' && LA23_129 <= '!' ) || ( LA23_129 >= '#' && LA23_129 <= '[' ) || ( LA23_129 >= ']' && LA23_129 <= '\uFFFF' ) ) ) s = 64;

				if ( s >= 0 ) return s;
				break;
			case 17:
				int LA23_113 = input.LA( 1 );

				s = -1;
				if ( ( LA23_113 == '\"' ) ) s = 65;

				else if ( ( LA23_113 == '\\' ) ) s = 63;

				else if ( ( ( LA23_113 >= '\u0000' && LA23_113 <= '!' ) || ( LA23_113 >= '#' && LA23_113 <= '[' ) || ( LA23_113 >= ']' && LA23_113 <= '\uFFFF' ) ) ) s = 64;

				if ( s >= 0 ) return s;
				break;
			case 18:
				int LA23_94 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_94 >= '0' && LA23_94 <= '7' ) ) ) s = 117;

				else if ( ( LA23_94 == '\'' ) ) s = 96;

				else if ( ( ( LA23_94 >= '\u0000' && LA23_94 <= '&' ) || ( LA23_94 >= '(' && LA23_94 <= '/' ) || ( LA23_94 >= '8' && LA23_94 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 19:
				int LA23_93 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_93 >= '0' && LA23_93 <= '7' ) ) ) s = 116;

				else if ( ( LA23_93 == '\'' ) ) s = 96;

				else if ( ( ( LA23_93 >= '\u0000' && LA23_93 <= '&' ) || ( LA23_93 >= '(' && LA23_93 <= '/' ) || ( LA23_93 >= '8' && LA23_93 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 20:
				int LA23_112 = input.LA( 1 );

				s = -1;
				if ( ( LA23_112 == '\"' ) ) s = 65;

				else if ( ( LA23_112 == '\\' ) ) s = 63;

				else if ( ( ( LA23_112 >= '0' && LA23_112 <= '7' ) ) ) s = 129;

				else if ( ( ( LA23_112 >= '\u0000' && LA23_112 <= '!' ) || ( LA23_112 >= '#' && LA23_112 <= '/' ) || ( LA23_112 >= '8' && LA23_112 <= '[' ) ||
				            ( LA23_112 >= ']' && LA23_112 <= '\uFFFF' ) ) ) s = 64;

				if ( s >= 0 ) return s;
				break;
			case 21:
				int LA23_141 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_141 >= '0' && LA23_141 <= '9' ) || ( LA23_141 >= 'A' && LA23_141 <= 'F' ) || ( LA23_141 >= 'a' && LA23_141 <= 'f' ) ) ) s = 148;

				else if ( ( ( LA23_141 >= '\u0000' && LA23_141 <= '/' ) || ( LA23_141 >= ':' && LA23_141 <= '@' ) || ( LA23_141 >= 'G' && LA23_141 <= '`' ) ||
				            ( LA23_141 >= 'g' && LA23_141 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 22:
				int LA23_130 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_130 >= '0' && LA23_130 <= '9' ) || ( LA23_130 >= 'A' && LA23_130 <= 'F' ) || ( LA23_130 >= 'a' && LA23_130 <= 'f' ) ) ) s = 141;

				else if ( ( ( LA23_130 >= '\u0000' && LA23_130 <= '/' ) || ( LA23_130 >= ':' && LA23_130 <= '@' ) || ( LA23_130 >= 'G' && LA23_130 <= '`' ) ||
				            ( LA23_130 >= 'g' && LA23_130 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 23:
				int LA23_67 = input.LA( 1 );

				s = -1;
				if ( ( LA23_67 == '\'' ) ) s = 91;

				else if ( ( LA23_67 == 'u' ) ) s = 92;

				else if ( ( ( LA23_67 >= '0' && LA23_67 <= '3' ) ) ) s = 93;

				else if ( ( ( LA23_67 >= '4' && LA23_67 <= '7' ) ) ) s = 94;

				else if ( ( LA23_67 == '\"' || LA23_67 == '\\' || LA23_67 == 'b' || LA23_67 == 'f' || LA23_67 == 'n' || LA23_67 == 'r' || LA23_67 == 't' ) ) s = 95;

				else if ( ( ( LA23_67 >= '\u0000' && LA23_67 <= '!' ) || ( LA23_67 >= '#' && LA23_67 <= '&' ) || ( LA23_67 >= '(' && LA23_67 <= '/' ) || ( LA23_67 >= '8' && LA23_67 <= '[' ) ||
				            ( LA23_67 >= ']' && LA23_67 <= 'a' ) || ( LA23_67 >= 'c' && LA23_67 <= 'e' ) || ( LA23_67 >= 'g' && LA23_67 <= 'm' ) || ( LA23_67 >= 'o' && LA23_67 <= 'q' ) ||
				            LA23_67 == 's' || ( LA23_67 >= 'v' && LA23_67 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 24:
				int LA23_68 = input.LA( 1 );

				s = -1;
				if ( ( LA23_68 == '\'' ) ) s = 96;

				else if ( ( ( LA23_68 >= '\u0000' && LA23_68 <= '&' ) || ( LA23_68 >= '(' && LA23_68 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
			case 25:
				int LA23_88 = input.LA( 1 );

				s = -1;
				if ( ( LA23_88 == '\"' ) ) s = 65;

				else if ( ( LA23_88 == '\\' ) ) s = 63;

				else if ( ( ( LA23_88 >= '0' && LA23_88 <= '7' ) ) ) s = 112;

				else if ( ( ( LA23_88 >= '\u0000' && LA23_88 <= '!' ) || ( LA23_88 >= '#' && LA23_88 <= '/' ) || ( LA23_88 >= '8' && LA23_88 <= '[' ) || ( LA23_88 >= ']' && LA23_88 <= '\uFFFF' ) ) )
					s = 64;

				if ( s >= 0 ) return s;
				break;
			case 26:
				int LA23_90 = input.LA( 1 );

				s = -1;
				if ( ( LA23_90 == '\"' ) ) s = 65;

				else if ( ( LA23_90 == '\\' ) ) s = 63;

				else if ( ( ( LA23_90 >= '\u0000' && LA23_90 <= '!' ) || ( LA23_90 >= '#' && LA23_90 <= '[' ) || ( LA23_90 >= ']' && LA23_90 <= '\uFFFF' ) ) ) s = 64;

				if ( s >= 0 ) return s;
				break;
			case 27:
				int LA23_86 = input.LA( 1 );

				s = -1;
				if ( ( ( LA23_86 >= '\u0000' && LA23_86 <= '\uFFFF' ) ) ) s = 110;

				else s = 70;

				if ( s >= 0 ) return s;
				break;
			case 28:
				int LA23_95 = input.LA( 1 );

				s = -1;
				if ( ( LA23_95 == '\'' ) ) s = 96;

				else if ( ( ( LA23_95 >= '\u0000' && LA23_95 <= '&' ) || ( LA23_95 >= '(' && LA23_95 <= '\uFFFF' ) ) ) s = 70;

				if ( s >= 0 ) return s;
				break;
		}
		var nvae23 =
				new NoViableAltException( dfa.Description, 23, _s, input );
		dfa.Error( nvae23 );
		throw nvae23;
	}
}