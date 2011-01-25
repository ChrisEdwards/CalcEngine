// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g 2011-01-13 17:36:55

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

namespace  CalcEngine.Parsers.Antlr 
{
public partial class AntlrCalcEngineParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"CLASS", 
		"BASE_CLASS", 
		"DISCRIMINATOR", 
		"PROPERTY", 
		"RELATIONSHIP", 
		"JOIN", 
		"TARGET", 
		"NAME", 
		"STATEMENT_BLOCK", 
		"FORMULA", 
		"MODIFIERS", 
		"EXPRESSION", 
		"IDENTIFIER", 
		"THIS", 
		"ENTITY", 
		"FUNCTION", 
		"PARAMETERS", 
		"FILTER", 
		"SOURCE", 
		"CRITERIA", 
		"OP_OR", 
		"OP_AND", 
		"OP_NOT", 
		"OP_EQ", 
		"OP_NE", 
		"OP_LT", 
		"OP_GT", 
		"OP_LTE", 
		"OP_GTE", 
		"OP_ADD", 
		"OP_SUBTRACT", 
		"OP_MULTIPLY", 
		"OP_DIVIDE", 
		"OP_MODULUS", 
		"OP_ASSIGN", 
		"OP_UNARY_NEGATION", 
		"TRUE", 
		"FALSE", 
		"ID", 
		"LITERAL", 
		"INT", 
		"FLOAT", 
		"DQUOT", 
		"SQUOT", 
		"EXPONENT", 
		"COMMENT", 
		"WS", 
		"ESC_SEQ", 
		"STRING", 
		"CHAR", 
		"HEX_DIGIT", 
		"UNICODE_ESC", 
		"OCTAL_ESC", 
		"'class'", 
		"':'", 
		"'where'", 
		"'{'", 
		"'}'", 
		"'property'", 
		"';'", 
		"'primarykey'", 
		"'calculated'", 
		"'abstract'", 
		"'relationship'", 
		"'='", 
		"'('", 
		"')'", 
		"'not'", 
		"'!'", 
		"'or'", 
		"'||'", 
		"'and'", 
		"'&&'", 
		"'mod'", 
		"'%'", 
		"'=='", 
		"'!='", 
		"'<>'", 
		"'<'", 
		"'>'", 
		"'<='", 
		"'>='", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'.'", 
		"'this'", 
		"'['", 
		"']'", 
		"','", 
		"'true'", 
		"'false'"
    };

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
    public const int T__89 = 89;
    public const int RELATIONSHIP = 8;
    public const int T__88 = 88;
    public const int T__71 = 71;
    public const int WS = 50;
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



        public AntlrCalcEngineParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public AntlrCalcEngineParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return AntlrCalcEngineParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g"; }
    }


    public class root_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "root"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:68:1: root : ( rootLevelStatement )* ;
    public AntlrCalcEngineParser.root_return root() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.root_return retval = new AntlrCalcEngineParser.root_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.rootLevelStatement_return rootLevelStatement1 = default(AntlrCalcEngineParser.rootLevelStatement_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:2: ( ( rootLevelStatement )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:4: ( rootLevelStatement )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:4: ( rootLevelStatement )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == ID || LA1_0 == 57) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:4: rootLevelStatement
            			    {
            			    	PushFollow(FOLLOW_rootLevelStatement_in_root231);
            			    	rootLevelStatement1 = rootLevelStatement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, rootLevelStatement1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "root"

    public class rootLevelStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "rootLevelStatement"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:71:1: rootLevelStatement : ( formulaDeclaration | classDeclaration );
    public AntlrCalcEngineParser.rootLevelStatement_return rootLevelStatement() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.rootLevelStatement_return retval = new AntlrCalcEngineParser.rootLevelStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.formulaDeclaration_return formulaDeclaration2 = default(AntlrCalcEngineParser.formulaDeclaration_return);

        AntlrCalcEngineParser.classDeclaration_return classDeclaration3 = default(AntlrCalcEngineParser.classDeclaration_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:72:2: ( formulaDeclaration | classDeclaration )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == ID) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 57) )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:72:4: formulaDeclaration
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_formulaDeclaration_in_rootLevelStatement242);
                    	formulaDeclaration2 = formulaDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, formulaDeclaration2.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:73:4: classDeclaration
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_classDeclaration_in_rootLevelStatement248);
                    	classDeclaration3 = classDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, classDeclaration3.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "rootLevelStatement"

    public class classDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "classDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:79:1: classDeclaration : 'class' name ( baseClassDeclaration )? classStatementBlock -> ^( CLASS name ( baseClassDeclaration )? classStatementBlock ) ;
    public AntlrCalcEngineParser.classDeclaration_return classDeclaration() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.classDeclaration_return retval = new AntlrCalcEngineParser.classDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal4 = null;
        AntlrCalcEngineParser.name_return name5 = default(AntlrCalcEngineParser.name_return);

        AntlrCalcEngineParser.baseClassDeclaration_return baseClassDeclaration6 = default(AntlrCalcEngineParser.baseClassDeclaration_return);

        AntlrCalcEngineParser.classStatementBlock_return classStatementBlock7 = default(AntlrCalcEngineParser.classStatementBlock_return);


        CommonTree string_literal4_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_classStatementBlock = new RewriteRuleSubtreeStream(adaptor,"rule classStatementBlock");
        RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor,"rule name");
        RewriteRuleSubtreeStream stream_baseClassDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule baseClassDeclaration");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:2: ( 'class' name ( baseClassDeclaration )? classStatementBlock -> ^( CLASS name ( baseClassDeclaration )? classStatementBlock ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:4: 'class' name ( baseClassDeclaration )? classStatementBlock
            {
            	string_literal4=(IToken)Match(input,57,FOLLOW_57_in_classDeclaration262);  
            	stream_57.Add(string_literal4);

            	PushFollow(FOLLOW_name_in_classDeclaration264);
            	name5 = name();
            	state.followingStackPointer--;

            	stream_name.Add(name5.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:17: ( baseClassDeclaration )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == 58) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:17: baseClassDeclaration
            	        {
            	        	PushFollow(FOLLOW_baseClassDeclaration_in_classDeclaration266);
            	        	baseClassDeclaration6 = baseClassDeclaration();
            	        	state.followingStackPointer--;

            	        	stream_baseClassDeclaration.Add(baseClassDeclaration6.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_classStatementBlock_in_classDeclaration269);
            	classStatementBlock7 = classStatementBlock();
            	state.followingStackPointer--;

            	stream_classStatementBlock.Add(classStatementBlock7.Tree);


            	// AST REWRITE
            	// elements:          baseClassDeclaration, classStatementBlock, name
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 80:59: -> ^( CLASS name ( baseClassDeclaration )? classStatementBlock )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:62: ^( CLASS name ( baseClassDeclaration )? classStatementBlock )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CLASS, "CLASS"), root_1);

            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:76: ( baseClassDeclaration )?
            	    if ( stream_baseClassDeclaration.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_baseClassDeclaration.NextTree());

            	    }
            	    stream_baseClassDeclaration.Reset();
            	    adaptor.AddChild(root_1, stream_classStatementBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "classDeclaration"

    public class baseClassDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "baseClassDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:82:1: baseClassDeclaration : ':' name 'where' expression -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) ) ;
    public AntlrCalcEngineParser.baseClassDeclaration_return baseClassDeclaration() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.baseClassDeclaration_return retval = new AntlrCalcEngineParser.baseClassDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal8 = null;
        IToken string_literal10 = null;
        AntlrCalcEngineParser.name_return name9 = default(AntlrCalcEngineParser.name_return);

        AntlrCalcEngineParser.expression_return expression11 = default(AntlrCalcEngineParser.expression_return);


        CommonTree char_literal8_tree=null;
        CommonTree string_literal10_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor,"rule name");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:2: ( ':' name 'where' expression -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:4: ':' name 'where' expression
            {
            	char_literal8=(IToken)Match(input,58,FOLLOW_58_in_baseClassDeclaration294);  
            	stream_58.Add(char_literal8);

            	PushFollow(FOLLOW_name_in_baseClassDeclaration296);
            	name9 = name();
            	state.followingStackPointer--;

            	stream_name.Add(name9.Tree);
            	string_literal10=(IToken)Match(input,59,FOLLOW_59_in_baseClassDeclaration298);  
            	stream_59.Add(string_literal10);

            	PushFollow(FOLLOW_expression_in_baseClassDeclaration300);
            	expression11 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression11.Tree);


            	// AST REWRITE
            	// elements:          name, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 83:32: -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:35: ^( BASE_CLASS name ^( DISCRIMINATOR expression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(BASE_CLASS, "BASE_CLASS"), root_1);

            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:54: ^( DISCRIMINATOR expression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DISCRIMINATOR, "DISCRIMINATOR"), root_2);

            	    adaptor.AddChild(root_2, stream_expression.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "baseClassDeclaration"

    public class classStatementBlock_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "classStatementBlock"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:85:1: classStatementBlock : '{' ( classLevelStatement )* '}' -> ^( STATEMENT_BLOCK ( classLevelStatement )* ) ;
    public AntlrCalcEngineParser.classStatementBlock_return classStatementBlock() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.classStatementBlock_return retval = new AntlrCalcEngineParser.classStatementBlock_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal12 = null;
        IToken char_literal14 = null;
        AntlrCalcEngineParser.classLevelStatement_return classLevelStatement13 = default(AntlrCalcEngineParser.classLevelStatement_return);


        CommonTree char_literal12_tree=null;
        CommonTree char_literal14_tree=null;
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleSubtreeStream stream_classLevelStatement = new RewriteRuleSubtreeStream(adaptor,"rule classLevelStatement");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:2: ( '{' ( classLevelStatement )* '}' -> ^( STATEMENT_BLOCK ( classLevelStatement )* ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:4: '{' ( classLevelStatement )* '}'
            {
            	char_literal12=(IToken)Match(input,60,FOLLOW_60_in_classStatementBlock328);  
            	stream_60.Add(char_literal12);

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:8: ( classLevelStatement )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 62 || LA4_0 == 67) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:8: classLevelStatement
            			    {
            			    	PushFollow(FOLLOW_classLevelStatement_in_classStatementBlock330);
            			    	classLevelStatement13 = classLevelStatement();
            			    	state.followingStackPointer--;

            			    	stream_classLevelStatement.Add(classLevelStatement13.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	char_literal14=(IToken)Match(input,61,FOLLOW_61_in_classStatementBlock333);  
            	stream_61.Add(char_literal14);



            	// AST REWRITE
            	// elements:          classLevelStatement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 86:33: -> ^( STATEMENT_BLOCK ( classLevelStatement )* )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:36: ^( STATEMENT_BLOCK ( classLevelStatement )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(STATEMENT_BLOCK, "STATEMENT_BLOCK"), root_1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:55: ( classLevelStatement )*
            	    while ( stream_classLevelStatement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_classLevelStatement.NextTree());

            	    }
            	    stream_classLevelStatement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "classStatementBlock"

    public class classLevelStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "classLevelStatement"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:88:1: classLevelStatement : ( propertyDeclaration | relationshipDeclaration );
    public AntlrCalcEngineParser.classLevelStatement_return classLevelStatement() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.classLevelStatement_return retval = new AntlrCalcEngineParser.classLevelStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.propertyDeclaration_return propertyDeclaration15 = default(AntlrCalcEngineParser.propertyDeclaration_return);

        AntlrCalcEngineParser.relationshipDeclaration_return relationshipDeclaration16 = default(AntlrCalcEngineParser.relationshipDeclaration_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:89:2: ( propertyDeclaration | relationshipDeclaration )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == 62) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 67) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:89:4: propertyDeclaration
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_propertyDeclaration_in_classLevelStatement354);
                    	propertyDeclaration15 = propertyDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, propertyDeclaration15.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:90:4: relationshipDeclaration
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_relationshipDeclaration_in_classLevelStatement359);
                    	relationshipDeclaration16 = relationshipDeclaration();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, relationshipDeclaration16.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "classLevelStatement"

    public class name_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "name"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:92:1: name : x= ID -> NAME[$x] ;
    public AntlrCalcEngineParser.name_return name() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.name_return retval = new AntlrCalcEngineParser.name_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:93:2: (x= ID -> NAME[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:93:4: x= ID
            {
            	x=(IToken)Match(input,ID,FOLLOW_ID_in_name371);  
            	stream_ID.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 93:9: -> NAME[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(NAME, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "name"

    public class propertyDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "propertyDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:97:1: propertyDeclaration : 'property' name ( propertyModifiers )? ';' -> ^( PROPERTY name ( propertyModifiers )? ) ;
    public AntlrCalcEngineParser.propertyDeclaration_return propertyDeclaration() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.propertyDeclaration_return retval = new AntlrCalcEngineParser.propertyDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal17 = null;
        IToken char_literal20 = null;
        AntlrCalcEngineParser.name_return name18 = default(AntlrCalcEngineParser.name_return);

        AntlrCalcEngineParser.propertyModifiers_return propertyModifiers19 = default(AntlrCalcEngineParser.propertyModifiers_return);


        CommonTree string_literal17_tree=null;
        CommonTree char_literal20_tree=null;
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_propertyModifiers = new RewriteRuleSubtreeStream(adaptor,"rule propertyModifiers");
        RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor,"rule name");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:2: ( 'property' name ( propertyModifiers )? ';' -> ^( PROPERTY name ( propertyModifiers )? ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:4: 'property' name ( propertyModifiers )? ';'
            {
            	string_literal17=(IToken)Match(input,62,FOLLOW_62_in_propertyDeclaration389);  
            	stream_62.Add(string_literal17);

            	PushFollow(FOLLOW_name_in_propertyDeclaration391);
            	name18 = name();
            	state.followingStackPointer--;

            	stream_name.Add(name18.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:20: ( propertyModifiers )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( ((LA6_0 >= 64 && LA6_0 <= 66)) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:20: propertyModifiers
            	        {
            	        	PushFollow(FOLLOW_propertyModifiers_in_propertyDeclaration393);
            	        	propertyModifiers19 = propertyModifiers();
            	        	state.followingStackPointer--;

            	        	stream_propertyModifiers.Add(propertyModifiers19.Tree);

            	        }
            	        break;

            	}

            	char_literal20=(IToken)Match(input,63,FOLLOW_63_in_propertyDeclaration396);  
            	stream_63.Add(char_literal20);



            	// AST REWRITE
            	// elements:          name, propertyModifiers
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 98:43: -> ^( PROPERTY name ( propertyModifiers )? )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:46: ^( PROPERTY name ( propertyModifiers )? )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PROPERTY, "PROPERTY"), root_1);

            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:63: ( propertyModifiers )?
            	    if ( stream_propertyModifiers.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_propertyModifiers.NextTree());

            	    }
            	    stream_propertyModifiers.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyDeclaration"

    public class propertyModifiers_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "propertyModifiers"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:100:1: propertyModifiers : ( exclusivePropertyModifier -> ^( MODIFIERS exclusivePropertyModifier ) | ( propertyModifier )+ -> ^( MODIFIERS ( propertyModifier )+ ) );
    public AntlrCalcEngineParser.propertyModifiers_return propertyModifiers() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.propertyModifiers_return retval = new AntlrCalcEngineParser.propertyModifiers_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.exclusivePropertyModifier_return exclusivePropertyModifier21 = default(AntlrCalcEngineParser.exclusivePropertyModifier_return);

        AntlrCalcEngineParser.propertyModifier_return propertyModifier22 = default(AntlrCalcEngineParser.propertyModifier_return);


        RewriteRuleSubtreeStream stream_propertyModifier = new RewriteRuleSubtreeStream(adaptor,"rule propertyModifier");
        RewriteRuleSubtreeStream stream_exclusivePropertyModifier = new RewriteRuleSubtreeStream(adaptor,"rule exclusivePropertyModifier");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:101:2: ( exclusivePropertyModifier -> ^( MODIFIERS exclusivePropertyModifier ) | ( propertyModifier )+ -> ^( MODIFIERS ( propertyModifier )+ ) )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 64) )
            {
                alt8 = 1;
            }
            else if ( ((LA8_0 >= 65 && LA8_0 <= 66)) )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:101:4: exclusivePropertyModifier
                    {
                    	PushFollow(FOLLOW_exclusivePropertyModifier_in_propertyModifiers419);
                    	exclusivePropertyModifier21 = exclusivePropertyModifier();
                    	state.followingStackPointer--;

                    	stream_exclusivePropertyModifier.Add(exclusivePropertyModifier21.Tree);


                    	// AST REWRITE
                    	// elements:          exclusivePropertyModifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 101:30: -> ^( MODIFIERS exclusivePropertyModifier )
                    	{
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:101:33: ^( MODIFIERS exclusivePropertyModifier )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MODIFIERS, "MODIFIERS"), root_1);

                    	    adaptor.AddChild(root_1, stream_exclusivePropertyModifier.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:4: ( propertyModifier )+
                    {
                    	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:4: ( propertyModifier )+
                    	int cnt7 = 0;
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( ((LA7_0 >= 65 && LA7_0 <= 66)) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:4: propertyModifier
                    			    {
                    			    	PushFollow(FOLLOW_propertyModifier_in_propertyModifiers434);
                    			    	propertyModifier22 = propertyModifier();
                    			    	state.followingStackPointer--;

                    			    	stream_propertyModifier.Add(propertyModifier22.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt7 >= 1 ) goto loop7;
                    		            EarlyExitException eee7 =
                    		                new EarlyExitException(7, input);
                    		            throw eee7;
                    	    }
                    	    cnt7++;
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements



                    	// AST REWRITE
                    	// elements:          propertyModifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 102:22: -> ^( MODIFIERS ( propertyModifier )+ )
                    	{
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:25: ^( MODIFIERS ( propertyModifier )+ )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MODIFIERS, "MODIFIERS"), root_1);

                    	    if ( !(stream_propertyModifier.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_propertyModifier.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_propertyModifier.NextTree());

                    	    }
                    	    stream_propertyModifier.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyModifiers"

    public class exclusivePropertyModifier_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exclusivePropertyModifier"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:104:1: exclusivePropertyModifier : 'primarykey' ;
    public AntlrCalcEngineParser.exclusivePropertyModifier_return exclusivePropertyModifier() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.exclusivePropertyModifier_return retval = new AntlrCalcEngineParser.exclusivePropertyModifier_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal23 = null;

        CommonTree string_literal23_tree=null;

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:105:2: ( 'primarykey' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:105:4: 'primarykey'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal23=(IToken)Match(input,64,FOLLOW_64_in_exclusivePropertyModifier456); 
            		string_literal23_tree = (CommonTree)adaptor.Create(string_literal23);
            		adaptor.AddChild(root_0, string_literal23_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exclusivePropertyModifier"

    public class propertyModifier_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "propertyModifier"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:107:1: propertyModifier : ( 'calculated' | 'abstract' );
    public AntlrCalcEngineParser.propertyModifier_return propertyModifier() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.propertyModifier_return retval = new AntlrCalcEngineParser.propertyModifier_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set24 = null;

        CommonTree set24_tree=null;

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:108:2: ( 'calculated' | 'abstract' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set24 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= 65 && input.LA(1) <= 66) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set24));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyModifier"

    public class relationshipDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationshipDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:113:1: relationshipDeclaration : 'relationship' name '=' relationshipJoinDeclaration ';' -> ^( RELATIONSHIP name relationshipJoinDeclaration ) ;
    public AntlrCalcEngineParser.relationshipDeclaration_return relationshipDeclaration() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.relationshipDeclaration_return retval = new AntlrCalcEngineParser.relationshipDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal25 = null;
        IToken char_literal27 = null;
        IToken char_literal29 = null;
        AntlrCalcEngineParser.name_return name26 = default(AntlrCalcEngineParser.name_return);

        AntlrCalcEngineParser.relationshipJoinDeclaration_return relationshipJoinDeclaration28 = default(AntlrCalcEngineParser.relationshipJoinDeclaration_return);


        CommonTree string_literal25_tree=null;
        CommonTree char_literal27_tree=null;
        CommonTree char_literal29_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor,"rule name");
        RewriteRuleSubtreeStream stream_relationshipJoinDeclaration = new RewriteRuleSubtreeStream(adaptor,"rule relationshipJoinDeclaration");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:114:2: ( 'relationship' name '=' relationshipJoinDeclaration ';' -> ^( RELATIONSHIP name relationshipJoinDeclaration ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:114:4: 'relationship' name '=' relationshipJoinDeclaration ';'
            {
            	string_literal25=(IToken)Match(input,67,FOLLOW_67_in_relationshipDeclaration484);  
            	stream_67.Add(string_literal25);

            	PushFollow(FOLLOW_name_in_relationshipDeclaration486);
            	name26 = name();
            	state.followingStackPointer--;

            	stream_name.Add(name26.Tree);
            	char_literal27=(IToken)Match(input,68,FOLLOW_68_in_relationshipDeclaration488);  
            	stream_68.Add(char_literal27);

            	PushFollow(FOLLOW_relationshipJoinDeclaration_in_relationshipDeclaration490);
            	relationshipJoinDeclaration28 = relationshipJoinDeclaration();
            	state.followingStackPointer--;

            	stream_relationshipJoinDeclaration.Add(relationshipJoinDeclaration28.Tree);
            	char_literal29=(IToken)Match(input,63,FOLLOW_63_in_relationshipDeclaration492);  
            	stream_63.Add(char_literal29);



            	// AST REWRITE
            	// elements:          name, relationshipJoinDeclaration
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 114:60: -> ^( RELATIONSHIP name relationshipJoinDeclaration )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:114:63: ^( RELATIONSHIP name relationshipJoinDeclaration )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(RELATIONSHIP, "RELATIONSHIP"), root_1);

            	    adaptor.AddChild(root_1, stream_name.NextTree());
            	    adaptor.AddChild(root_1, stream_relationshipJoinDeclaration.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationshipDeclaration"

    public class relationshipJoinDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationshipJoinDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:116:1: relationshipJoinDeclaration : name 'where' expression -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) ) ;
    public AntlrCalcEngineParser.relationshipJoinDeclaration_return relationshipJoinDeclaration() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.relationshipJoinDeclaration_return retval = new AntlrCalcEngineParser.relationshipJoinDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal31 = null;
        AntlrCalcEngineParser.name_return name30 = default(AntlrCalcEngineParser.name_return);

        AntlrCalcEngineParser.expression_return expression32 = default(AntlrCalcEngineParser.expression_return);


        CommonTree string_literal31_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_name = new RewriteRuleSubtreeStream(adaptor,"rule name");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:2: ( name 'where' expression -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:4: name 'where' expression
            {
            	PushFollow(FOLLOW_name_in_relationshipJoinDeclaration514);
            	name30 = name();
            	state.followingStackPointer--;

            	stream_name.Add(name30.Tree);
            	string_literal31=(IToken)Match(input,59,FOLLOW_59_in_relationshipJoinDeclaration516);  
            	stream_59.Add(string_literal31);

            	PushFollow(FOLLOW_expression_in_relationshipJoinDeclaration518);
            	expression32 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression32.Tree);


            	// AST REWRITE
            	// elements:          expression, name
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 117:28: -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:31: ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(JOIN, "JOIN"), root_1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:39: ^( TARGET name )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TARGET, "TARGET"), root_2);

            	    adaptor.AddChild(root_2, stream_name.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:56: ^( CRITERIA expression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CRITERIA, "CRITERIA"), root_2);

            	    adaptor.AddChild(root_2, stream_expression.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationshipJoinDeclaration"

    public class formulaDeclaration_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "formulaDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:125:1: formulaDeclaration : entityChainNoFilter assignmentOp expression ';' -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) ) ;
    public AntlrCalcEngineParser.formulaDeclaration_return formulaDeclaration() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.formulaDeclaration_return retval = new AntlrCalcEngineParser.formulaDeclaration_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal36 = null;
        AntlrCalcEngineParser.entityChainNoFilter_return entityChainNoFilter33 = default(AntlrCalcEngineParser.entityChainNoFilter_return);

        AntlrCalcEngineParser.assignmentOp_return assignmentOp34 = default(AntlrCalcEngineParser.assignmentOp_return);

        AntlrCalcEngineParser.expression_return expression35 = default(AntlrCalcEngineParser.expression_return);


        CommonTree char_literal36_tree=null;
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_entityChainNoFilter = new RewriteRuleSubtreeStream(adaptor,"rule entityChainNoFilter");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_assignmentOp = new RewriteRuleSubtreeStream(adaptor,"rule assignmentOp");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:2: ( entityChainNoFilter assignmentOp expression ';' -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:4: entityChainNoFilter assignmentOp expression ';'
            {
            	PushFollow(FOLLOW_entityChainNoFilter_in_formulaDeclaration558);
            	entityChainNoFilter33 = entityChainNoFilter();
            	state.followingStackPointer--;

            	stream_entityChainNoFilter.Add(entityChainNoFilter33.Tree);
            	PushFollow(FOLLOW_assignmentOp_in_formulaDeclaration560);
            	assignmentOp34 = assignmentOp();
            	state.followingStackPointer--;

            	stream_assignmentOp.Add(assignmentOp34.Tree);
            	PushFollow(FOLLOW_expression_in_formulaDeclaration562);
            	expression35 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression35.Tree);
            	char_literal36=(IToken)Match(input,63,FOLLOW_63_in_formulaDeclaration564);  
            	stream_63.Add(char_literal36);



            	// AST REWRITE
            	// elements:          assignmentOp, expression, entityChainNoFilter
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 126:52: -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:55: ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FORMULA, "FORMULA"), root_1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:66: ^( assignmentOp entityChainNoFilter expression )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot(stream_assignmentOp.NextNode(), root_2);

            	    adaptor.AddChild(root_2, stream_entityChainNoFilter.NextTree());
            	    adaptor.AddChild(root_2, stream_expression.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "formulaDeclaration"

    public class expression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:132:1: expression : orExpr ;
    public AntlrCalcEngineParser.expression_return expression() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.expression_return retval = new AntlrCalcEngineParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.orExpr_return orExpr37 = default(AntlrCalcEngineParser.orExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:133:2: ( orExpr )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:133:4: orExpr
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_orExpr_in_expression599);
            	orExpr37 = orExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, orExpr37.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class orExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "orExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:135:1: orExpr : andExpr ( orOp andExpr )* ;
    public AntlrCalcEngineParser.orExpr_return orExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.orExpr_return retval = new AntlrCalcEngineParser.orExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.andExpr_return andExpr38 = default(AntlrCalcEngineParser.andExpr_return);

        AntlrCalcEngineParser.orOp_return orOp39 = default(AntlrCalcEngineParser.orOp_return);

        AntlrCalcEngineParser.andExpr_return andExpr40 = default(AntlrCalcEngineParser.andExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:2: ( andExpr ( orOp andExpr )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:4: andExpr ( orOp andExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_andExpr_in_orExpr609);
            	andExpr38 = andExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, andExpr38.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:12: ( orOp andExpr )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= 73 && LA9_0 <= 74)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:14: orOp andExpr
            			    {
            			    	PushFollow(FOLLOW_orOp_in_orExpr613);
            			    	orOp39 = orOp();
            			    	state.followingStackPointer--;

            			    	root_0 = (CommonTree)adaptor.BecomeRoot(orOp39.Tree, root_0);
            			    	PushFollow(FOLLOW_andExpr_in_orExpr616);
            			    	andExpr40 = andExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, andExpr40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orExpr"

    public class andExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "andExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:138:1: andExpr : equalityExpr ( andOp equalityExpr )* ;
    public AntlrCalcEngineParser.andExpr_return andExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.andExpr_return retval = new AntlrCalcEngineParser.andExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.equalityExpr_return equalityExpr41 = default(AntlrCalcEngineParser.equalityExpr_return);

        AntlrCalcEngineParser.andOp_return andOp42 = default(AntlrCalcEngineParser.andOp_return);

        AntlrCalcEngineParser.equalityExpr_return equalityExpr43 = default(AntlrCalcEngineParser.equalityExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:2: ( equalityExpr ( andOp equalityExpr )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:4: equalityExpr ( andOp equalityExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpr_in_andExpr629);
            	equalityExpr41 = equalityExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpr41.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:17: ( andOp equalityExpr )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= 75 && LA10_0 <= 76)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:19: andOp equalityExpr
            			    {
            			    	PushFollow(FOLLOW_andOp_in_andExpr633);
            			    	andOp42 = andOp();
            			    	state.followingStackPointer--;

            			    	root_0 = (CommonTree)adaptor.BecomeRoot(andOp42.Tree, root_0);
            			    	PushFollow(FOLLOW_equalityExpr_in_andExpr636);
            			    	equalityExpr43 = equalityExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpr43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "andExpr"

    public class equalityExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalityExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:141:1: equalityExpr : relationalExpr ( ( equalsOp | notEqualsOp ) relationalExpr )* ;
    public AntlrCalcEngineParser.equalityExpr_return equalityExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.equalityExpr_return retval = new AntlrCalcEngineParser.equalityExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.relationalExpr_return relationalExpr44 = default(AntlrCalcEngineParser.relationalExpr_return);

        AntlrCalcEngineParser.equalsOp_return equalsOp45 = default(AntlrCalcEngineParser.equalsOp_return);

        AntlrCalcEngineParser.notEqualsOp_return notEqualsOp46 = default(AntlrCalcEngineParser.notEqualsOp_return);

        AntlrCalcEngineParser.relationalExpr_return relationalExpr47 = default(AntlrCalcEngineParser.relationalExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:2: ( relationalExpr ( ( equalsOp | notEqualsOp ) relationalExpr )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:4: relationalExpr ( ( equalsOp | notEqualsOp ) relationalExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpr_in_equalityExpr650);
            	relationalExpr44 = relationalExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpr44.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:19: ( ( equalsOp | notEqualsOp ) relationalExpr )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 68 || (LA12_0 >= 79 && LA12_0 <= 81)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:21: ( equalsOp | notEqualsOp ) relationalExpr
            			    {
            			    	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:21: ( equalsOp | notEqualsOp )
            			    	int alt11 = 2;
            			    	int LA11_0 = input.LA(1);

            			    	if ( (LA11_0 == 68 || LA11_0 == 79) )
            			    	{
            			    	    alt11 = 1;
            			    	}
            			    	else if ( ((LA11_0 >= 80 && LA11_0 <= 81)) )
            			    	{
            			    	    alt11 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d11s0 =
            			    	        new NoViableAltException("", 11, 0, input);

            			    	    throw nvae_d11s0;
            			    	}
            			    	switch (alt11) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:23: equalsOp
            			    	        {
            			    	        	PushFollow(FOLLOW_equalsOp_in_equalityExpr656);
            			    	        	equalsOp45 = equalsOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(equalsOp45.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:35: notEqualsOp
            			    	        {
            			    	        	PushFollow(FOLLOW_notEqualsOp_in_equalityExpr661);
            			    	        	notEqualsOp46 = notEqualsOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(notEqualsOp46.Tree, root_0);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpr_in_equalityExpr666);
            			    	relationalExpr47 = relationalExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpr47.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpr"

    public class relationalExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationalExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:144:1: relationalExpr : additiveExpr ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )* ;
    public AntlrCalcEngineParser.relationalExpr_return relationalExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.relationalExpr_return retval = new AntlrCalcEngineParser.relationalExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.additiveExpr_return additiveExpr48 = default(AntlrCalcEngineParser.additiveExpr_return);

        AntlrCalcEngineParser.ltOp_return ltOp49 = default(AntlrCalcEngineParser.ltOp_return);

        AntlrCalcEngineParser.gtOp_return gtOp50 = default(AntlrCalcEngineParser.gtOp_return);

        AntlrCalcEngineParser.lteOp_return lteOp51 = default(AntlrCalcEngineParser.lteOp_return);

        AntlrCalcEngineParser.gteOp_return gteOp52 = default(AntlrCalcEngineParser.gteOp_return);

        AntlrCalcEngineParser.additiveExpr_return additiveExpr53 = default(AntlrCalcEngineParser.additiveExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:2: ( additiveExpr ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:4: additiveExpr ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpr_in_relationalExpr679);
            	additiveExpr48 = additiveExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpr48.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:17: ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= 82 && LA14_0 <= 85)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:19: ( ltOp | gtOp | lteOp | gteOp ) additiveExpr
            			    {
            			    	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:19: ( ltOp | gtOp | lteOp | gteOp )
            			    	int alt13 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 82:
            			    		{
            			    	    alt13 = 1;
            			    	    }
            			    	    break;
            			    	case 83:
            			    		{
            			    	    alt13 = 2;
            			    	    }
            			    	    break;
            			    	case 84:
            			    		{
            			    	    alt13 = 3;
            			    	    }
            			    	    break;
            			    	case 85:
            			    		{
            			    	    alt13 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d13s0 =
            			    		        new NoViableAltException("", 13, 0, input);

            			    		    throw nvae_d13s0;
            			    	}

            			    	switch (alt13) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:21: ltOp
            			    	        {
            			    	        	PushFollow(FOLLOW_ltOp_in_relationalExpr685);
            			    	        	ltOp49 = ltOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(ltOp49.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:29: gtOp
            			    	        {
            			    	        	PushFollow(FOLLOW_gtOp_in_relationalExpr690);
            			    	        	gtOp50 = gtOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(gtOp50.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:37: lteOp
            			    	        {
            			    	        	PushFollow(FOLLOW_lteOp_in_relationalExpr695);
            			    	        	lteOp51 = lteOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(lteOp51.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:46: gteOp
            			    	        {
            			    	        	PushFollow(FOLLOW_gteOp_in_relationalExpr700);
            			    	        	gteOp52 = gteOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(gteOp52.Tree, root_0);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpr_in_relationalExpr705);
            			    	additiveExpr53 = additiveExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpr53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpr"

    public class additiveExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:147:1: additiveExpr : multiplicativeExpr ( ( addOp | subtractOp ) multiplicativeExpr )* ;
    public AntlrCalcEngineParser.additiveExpr_return additiveExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.additiveExpr_return retval = new AntlrCalcEngineParser.additiveExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.multiplicativeExpr_return multiplicativeExpr54 = default(AntlrCalcEngineParser.multiplicativeExpr_return);

        AntlrCalcEngineParser.addOp_return addOp55 = default(AntlrCalcEngineParser.addOp_return);

        AntlrCalcEngineParser.subtractOp_return subtractOp56 = default(AntlrCalcEngineParser.subtractOp_return);

        AntlrCalcEngineParser.multiplicativeExpr_return multiplicativeExpr57 = default(AntlrCalcEngineParser.multiplicativeExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:2: ( multiplicativeExpr ( ( addOp | subtractOp ) multiplicativeExpr )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:4: multiplicativeExpr ( ( addOp | subtractOp ) multiplicativeExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpr_in_additiveExpr719);
            	multiplicativeExpr54 = multiplicativeExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpr54.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:23: ( ( addOp | subtractOp ) multiplicativeExpr )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= 86 && LA16_0 <= 87)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:25: ( addOp | subtractOp ) multiplicativeExpr
            			    {
            			    	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:25: ( addOp | subtractOp )
            			    	int alt15 = 2;
            			    	int LA15_0 = input.LA(1);

            			    	if ( (LA15_0 == 86) )
            			    	{
            			    	    alt15 = 1;
            			    	}
            			    	else if ( (LA15_0 == 87) )
            			    	{
            			    	    alt15 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d15s0 =
            			    	        new NoViableAltException("", 15, 0, input);

            			    	    throw nvae_d15s0;
            			    	}
            			    	switch (alt15) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:27: addOp
            			    	        {
            			    	        	PushFollow(FOLLOW_addOp_in_additiveExpr725);
            			    	        	addOp55 = addOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(addOp55.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:36: subtractOp
            			    	        {
            			    	        	PushFollow(FOLLOW_subtractOp_in_additiveExpr730);
            			    	        	subtractOp56 = subtractOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(subtractOp56.Tree, root_0);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpr_in_additiveExpr735);
            			    	multiplicativeExpr57 = multiplicativeExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpr57.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpr"

    public class multiplicativeExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:150:1: multiplicativeExpr : unaryExpr ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )* ;
    public AntlrCalcEngineParser.multiplicativeExpr_return multiplicativeExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.multiplicativeExpr_return retval = new AntlrCalcEngineParser.multiplicativeExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.unaryExpr_return unaryExpr58 = default(AntlrCalcEngineParser.unaryExpr_return);

        AntlrCalcEngineParser.multiplyOp_return multiplyOp59 = default(AntlrCalcEngineParser.multiplyOp_return);

        AntlrCalcEngineParser.divideOp_return divideOp60 = default(AntlrCalcEngineParser.divideOp_return);

        AntlrCalcEngineParser.modulusOp_return modulusOp61 = default(AntlrCalcEngineParser.modulusOp_return);

        AntlrCalcEngineParser.unaryExpr_return unaryExpr62 = default(AntlrCalcEngineParser.unaryExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:2: ( unaryExpr ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:4: unaryExpr ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpr_in_multiplicativeExpr749);
            	unaryExpr58 = unaryExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpr58.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:14: ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= 77 && LA18_0 <= 78) || (LA18_0 >= 88 && LA18_0 <= 89)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:16: ( multiplyOp | divideOp | modulusOp ) unaryExpr
            			    {
            			    	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:16: ( multiplyOp | divideOp | modulusOp )
            			    	int alt17 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 88:
            			    		{
            			    	    alt17 = 1;
            			    	    }
            			    	    break;
            			    	case 89:
            			    		{
            			    	    alt17 = 2;
            			    	    }
            			    	    break;
            			    	case 77:
            			    	case 78:
            			    		{
            			    	    alt17 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d17s0 =
            			    		        new NoViableAltException("", 17, 0, input);

            			    		    throw nvae_d17s0;
            			    	}

            			    	switch (alt17) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:18: multiplyOp
            			    	        {
            			    	        	PushFollow(FOLLOW_multiplyOp_in_multiplicativeExpr755);
            			    	        	multiplyOp59 = multiplyOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(multiplyOp59.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:32: divideOp
            			    	        {
            			    	        	PushFollow(FOLLOW_divideOp_in_multiplicativeExpr760);
            			    	        	divideOp60 = divideOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(divideOp60.Tree, root_0);

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:44: modulusOp
            			    	        {
            			    	        	PushFollow(FOLLOW_modulusOp_in_multiplicativeExpr765);
            			    	        	modulusOp61 = modulusOp();
            			    	        	state.followingStackPointer--;

            			    	        	root_0 = (CommonTree)adaptor.BecomeRoot(modulusOp61.Tree, root_0);

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_unaryExpr_in_multiplicativeExpr770);
            			    	unaryExpr62 = unaryExpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, unaryExpr62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpr"

    public class unaryExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:153:1: unaryExpr : ( unaryNegationOp )? negationExpr ;
    public AntlrCalcEngineParser.unaryExpr_return unaryExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.unaryExpr_return retval = new AntlrCalcEngineParser.unaryExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.unaryNegationOp_return unaryNegationOp63 = default(AntlrCalcEngineParser.unaryNegationOp_return);

        AntlrCalcEngineParser.negationExpr_return negationExpr64 = default(AntlrCalcEngineParser.negationExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:2: ( ( unaryNegationOp )? negationExpr )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:4: ( unaryNegationOp )? negationExpr
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:19: ( unaryNegationOp )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 87) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:19: unaryNegationOp
            	        {
            	        	PushFollow(FOLLOW_unaryNegationOp_in_unaryExpr785);
            	        	unaryNegationOp63 = unaryNegationOp();
            	        	state.followingStackPointer--;

            	        	root_0 = (CommonTree)adaptor.BecomeRoot(unaryNegationOp63.Tree, root_0);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_negationExpr_in_unaryExpr789);
            	negationExpr64 = negationExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negationExpr64.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpr"

    public class negationExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "negationExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:156:1: negationExpr : ( notOp )* primaryExpr ;
    public AntlrCalcEngineParser.negationExpr_return negationExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.negationExpr_return retval = new AntlrCalcEngineParser.negationExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.notOp_return notOp65 = default(AntlrCalcEngineParser.notOp_return);

        AntlrCalcEngineParser.primaryExpr_return primaryExpr66 = default(AntlrCalcEngineParser.primaryExpr_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:2: ( ( notOp )* primaryExpr )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:4: ( notOp )* primaryExpr
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:4: ( notOp )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= 71 && LA20_0 <= 72)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:6: notOp
            			    {
            			    	PushFollow(FOLLOW_notOp_in_negationExpr802);
            			    	notOp65 = notOp();
            			    	state.followingStackPointer--;

            			    	root_0 = (CommonTree)adaptor.BecomeRoot(notOp65.Tree, root_0);

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements

            	PushFollow(FOLLOW_primaryExpr_in_negationExpr808);
            	primaryExpr66 = primaryExpr();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, primaryExpr66.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "negationExpr"

    public class primaryExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "primaryExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:159:1: primaryExpr : ( '(' expression ')' | number | booleanValue | LITERAL | functionCall | entityChain );
    public AntlrCalcEngineParser.primaryExpr_return primaryExpr() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.primaryExpr_return retval = new AntlrCalcEngineParser.primaryExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal67 = null;
        IToken char_literal69 = null;
        IToken LITERAL72 = null;
        AntlrCalcEngineParser.expression_return expression68 = default(AntlrCalcEngineParser.expression_return);

        AntlrCalcEngineParser.number_return number70 = default(AntlrCalcEngineParser.number_return);

        AntlrCalcEngineParser.booleanValue_return booleanValue71 = default(AntlrCalcEngineParser.booleanValue_return);

        AntlrCalcEngineParser.functionCall_return functionCall73 = default(AntlrCalcEngineParser.functionCall_return);

        AntlrCalcEngineParser.entityChain_return entityChain74 = default(AntlrCalcEngineParser.entityChain_return);


        CommonTree char_literal67_tree=null;
        CommonTree char_literal69_tree=null;
        CommonTree LITERAL72_tree=null;

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:160:2: ( '(' expression ')' | number | booleanValue | LITERAL | functionCall | entityChain )
            int alt21 = 6;
            switch ( input.LA(1) ) 
            {
            case 69:
            	{
                alt21 = 1;
                }
                break;
            case INT:
            case FLOAT:
            	{
                alt21 = 2;
                }
                break;
            case 95:
            case 96:
            	{
                alt21 = 3;
                }
                break;
            case LITERAL:
            	{
                alt21 = 4;
                }
                break;
            case ID:
            	{
                int LA21_5 = input.LA(2);

                if ( (LA21_5 == 69) )
                {
                    alt21 = 5;
                }
                else if ( (LA21_5 == 60 || LA21_5 == 63 || LA21_5 == 68 || LA21_5 == 70 || (LA21_5 >= 73 && LA21_5 <= 90) || (LA21_5 >= 92 && LA21_5 <= 94)) )
                {
                    alt21 = 6;
                }
                else 
                {
                    NoViableAltException nvae_d21s5 =
                        new NoViableAltException("", 21, 5, input);

                    throw nvae_d21s5;
                }
                }
                break;
            case 91:
            	{
                alt21 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:160:4: '(' expression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal67=(IToken)Match(input,69,FOLLOW_69_in_primaryExpr819); 
                    	PushFollow(FOLLOW_expression_in_primaryExpr822);
                    	expression68 = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expression68.Tree);
                    	char_literal69=(IToken)Match(input,70,FOLLOW_70_in_primaryExpr824); 

                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:161:4: number
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_number_in_primaryExpr830);
                    	number70 = number();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, number70.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:162:4: booleanValue
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_booleanValue_in_primaryExpr835);
                    	booleanValue71 = booleanValue();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, booleanValue71.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:163:4: LITERAL
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LITERAL72=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_primaryExpr840); 
                    		LITERAL72_tree = (CommonTree)adaptor.Create(LITERAL72);
                    		adaptor.AddChild(root_0, LITERAL72_tree);


                    }
                    break;
                case 5 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:164:4: functionCall
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionCall_in_primaryExpr845);
                    	functionCall73 = functionCall();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functionCall73.Tree);

                    }
                    break;
                case 6 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:165:4: entityChain
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_entityChain_in_primaryExpr850);
                    	entityChain74 = entityChain();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, entityChain74.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primaryExpr"

    public class notOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:173:1: notOp : (x= 'not' -> OP_NOT[$x] | x= '!' -> OP_NOT[$x] );
    public AntlrCalcEngineParser.notOp_return notOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.notOp_return retval = new AntlrCalcEngineParser.notOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_71 = new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:174:2: (x= 'not' -> OP_NOT[$x] | x= '!' -> OP_NOT[$x] )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == 71) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == 72) )
            {
                alt22 = 2;
            }
            else 
            {
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:174:4: x= 'not'
                    {
                    	x=(IToken)Match(input,71,FOLLOW_71_in_notOp868);  
                    	stream_71.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 174:12: -> OP_NOT[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_NOT, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:175:4: x= '!'
                    {
                    	x=(IToken)Match(input,72,FOLLOW_72_in_notOp880);  
                    	stream_72.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 175:10: -> OP_NOT[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_NOT, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notOp"

    public class orOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "orOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:177:1: orOp : (x= 'or' -> OP_OR[$x] | x= '||' -> OP_OR[$x] );
    public AntlrCalcEngineParser.orOp_return orOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.orOp_return retval = new AntlrCalcEngineParser.orOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:178:2: (x= 'or' -> OP_OR[$x] | x= '||' -> OP_OR[$x] )
            int alt23 = 2;
            int LA23_0 = input.LA(1);

            if ( (LA23_0 == 73) )
            {
                alt23 = 1;
            }
            else if ( (LA23_0 == 74) )
            {
                alt23 = 2;
            }
            else 
            {
                NoViableAltException nvae_d23s0 =
                    new NoViableAltException("", 23, 0, input);

                throw nvae_d23s0;
            }
            switch (alt23) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:178:4: x= 'or'
                    {
                    	x=(IToken)Match(input,73,FOLLOW_73_in_orOp898);  
                    	stream_73.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 178:11: -> OP_OR[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_OR, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:179:4: x= '||'
                    {
                    	x=(IToken)Match(input,74,FOLLOW_74_in_orOp910);  
                    	stream_74.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 179:11: -> OP_OR[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_OR, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "orOp"

    public class andOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "andOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:181:1: andOp : (x= 'and' -> OP_AND[$x] | x= '&&' -> OP_AND[$x] );
    public AntlrCalcEngineParser.andOp_return andOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.andOp_return retval = new AntlrCalcEngineParser.andOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:182:2: (x= 'and' -> OP_AND[$x] | x= '&&' -> OP_AND[$x] )
            int alt24 = 2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0 == 75) )
            {
                alt24 = 1;
            }
            else if ( (LA24_0 == 76) )
            {
                alt24 = 2;
            }
            else 
            {
                NoViableAltException nvae_d24s0 =
                    new NoViableAltException("", 24, 0, input);

                throw nvae_d24s0;
            }
            switch (alt24) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:182:4: x= 'and'
                    {
                    	x=(IToken)Match(input,75,FOLLOW_75_in_andOp927);  
                    	stream_75.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 182:12: -> OP_AND[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_AND, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:183:4: x= '&&'
                    {
                    	x=(IToken)Match(input,76,FOLLOW_76_in_andOp939);  
                    	stream_76.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 183:12: -> OP_AND[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_AND, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "andOp"

    public class modulusOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulusOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:185:1: modulusOp : (x= 'mod' -> OP_MODULUS[$x] | x= '%' -> OP_MODULUS[$x] );
    public AntlrCalcEngineParser.modulusOp_return modulusOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.modulusOp_return retval = new AntlrCalcEngineParser.modulusOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:186:2: (x= 'mod' -> OP_MODULUS[$x] | x= '%' -> OP_MODULUS[$x] )
            int alt25 = 2;
            int LA25_0 = input.LA(1);

            if ( (LA25_0 == 77) )
            {
                alt25 = 1;
            }
            else if ( (LA25_0 == 78) )
            {
                alt25 = 2;
            }
            else 
            {
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:186:4: x= 'mod'
                    {
                    	x=(IToken)Match(input,77,FOLLOW_77_in_modulusOp957);  
                    	stream_77.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 186:12: -> OP_MODULUS[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_MODULUS, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:187:4: x= '%'
                    {
                    	x=(IToken)Match(input,78,FOLLOW_78_in_modulusOp969);  
                    	stream_78.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 187:12: -> OP_MODULUS[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_MODULUS, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulusOp"

    public class equalsOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalsOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:189:1: equalsOp : (x= '==' -> OP_EQ[$x] | x= '=' -> OP_EQ[$x] );
    public AntlrCalcEngineParser.equalsOp_return equalsOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.equalsOp_return retval = new AntlrCalcEngineParser.equalsOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:190:2: (x= '==' -> OP_EQ[$x] | x= '=' -> OP_EQ[$x] )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == 79) )
            {
                alt26 = 1;
            }
            else if ( (LA26_0 == 68) )
            {
                alt26 = 2;
            }
            else 
            {
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:190:4: x= '=='
                    {
                    	x=(IToken)Match(input,79,FOLLOW_79_in_equalsOp988);  
                    	stream_79.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 190:11: -> OP_EQ[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_EQ, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:191:4: x= '='
                    {
                    	x=(IToken)Match(input,68,FOLLOW_68_in_equalsOp1001);  
                    	stream_68.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 191:11: -> OP_EQ[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_EQ, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalsOp"

    public class notEqualsOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notEqualsOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:193:1: notEqualsOp : (x= '!=' -> OP_NE[$x] | x= '<>' -> OP_NE[$x] );
    public AntlrCalcEngineParser.notEqualsOp_return notEqualsOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.notEqualsOp_return retval = new AntlrCalcEngineParser.notEqualsOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:194:2: (x= '!=' -> OP_NE[$x] | x= '<>' -> OP_NE[$x] )
            int alt27 = 2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0 == 80) )
            {
                alt27 = 1;
            }
            else if ( (LA27_0 == 81) )
            {
                alt27 = 2;
            }
            else 
            {
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:194:4: x= '!='
                    {
                    	x=(IToken)Match(input,80,FOLLOW_80_in_notEqualsOp1019);  
                    	stream_80.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 194:11: -> OP_NE[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_NE, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:195:4: x= '<>'
                    {
                    	x=(IToken)Match(input,81,FOLLOW_81_in_notEqualsOp1031);  
                    	stream_81.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 195:11: -> OP_NE[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_NE, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notEqualsOp"

    public class ltOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ltOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:197:1: ltOp : x= '<' -> OP_LT[$x] ;
    public AntlrCalcEngineParser.ltOp_return ltOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.ltOp_return retval = new AntlrCalcEngineParser.ltOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:198:2: (x= '<' -> OP_LT[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:198:4: x= '<'
            {
            	x=(IToken)Match(input,82,FOLLOW_82_in_ltOp1048);  
            	stream_82.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 198:10: -> OP_LT[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_LT, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ltOp"

    public class gtOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "gtOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:200:1: gtOp : x= '>' -> OP_GT[$x] ;
    public AntlrCalcEngineParser.gtOp_return gtOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.gtOp_return retval = new AntlrCalcEngineParser.gtOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:201:2: (x= '>' -> OP_GT[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:201:4: x= '>'
            {
            	x=(IToken)Match(input,83,FOLLOW_83_in_gtOp1065);  
            	stream_83.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 201:10: -> OP_GT[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_GT, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "gtOp"

    public class lteOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "lteOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:203:1: lteOp : x= '<=' -> OP_LTE[$x] ;
    public AntlrCalcEngineParser.lteOp_return lteOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.lteOp_return retval = new AntlrCalcEngineParser.lteOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:204:2: (x= '<=' -> OP_LTE[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:204:4: x= '<='
            {
            	x=(IToken)Match(input,84,FOLLOW_84_in_lteOp1082);  
            	stream_84.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 204:11: -> OP_LTE[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_LTE, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lteOp"

    public class gteOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "gteOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:206:1: gteOp : x= '>=' -> OP_GTE[$x] ;
    public AntlrCalcEngineParser.gteOp_return gteOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.gteOp_return retval = new AntlrCalcEngineParser.gteOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:207:2: (x= '>=' -> OP_GTE[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:207:4: x= '>='
            {
            	x=(IToken)Match(input,85,FOLLOW_85_in_gteOp1099);  
            	stream_85.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 207:11: -> OP_GTE[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_GTE, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "gteOp"

    public class addOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "addOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:209:1: addOp : x= '+' -> OP_ADD[$x] ;
    public AntlrCalcEngineParser.addOp_return addOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.addOp_return retval = new AntlrCalcEngineParser.addOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:210:2: (x= '+' -> OP_ADD[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:210:4: x= '+'
            {
            	x=(IToken)Match(input,86,FOLLOW_86_in_addOp1116);  
            	stream_86.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 210:10: -> OP_ADD[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_ADD, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addOp"

    public class subtractOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "subtractOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:212:1: subtractOp : x= '-' -> OP_SUBTRACT[$x] ;
    public AntlrCalcEngineParser.subtractOp_return subtractOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.subtractOp_return retval = new AntlrCalcEngineParser.subtractOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:213:2: (x= '-' -> OP_SUBTRACT[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:213:4: x= '-'
            {
            	x=(IToken)Match(input,87,FOLLOW_87_in_subtractOp1133);  
            	stream_87.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 213:10: -> OP_SUBTRACT[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_SUBTRACT, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtractOp"

    public class multiplyOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplyOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:215:1: multiplyOp : x= '*' -> OP_MULTIPLY[$x] ;
    public AntlrCalcEngineParser.multiplyOp_return multiplyOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.multiplyOp_return retval = new AntlrCalcEngineParser.multiplyOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:216:2: (x= '*' -> OP_MULTIPLY[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:216:4: x= '*'
            {
            	x=(IToken)Match(input,88,FOLLOW_88_in_multiplyOp1150);  
            	stream_88.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 216:10: -> OP_MULTIPLY[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_MULTIPLY, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplyOp"

    public class divideOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "divideOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:218:1: divideOp : x= '/' -> OP_DIVIDE[$x] ;
    public AntlrCalcEngineParser.divideOp_return divideOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.divideOp_return retval = new AntlrCalcEngineParser.divideOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:219:2: (x= '/' -> OP_DIVIDE[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:219:4: x= '/'
            {
            	x=(IToken)Match(input,89,FOLLOW_89_in_divideOp1167);  
            	stream_89.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 219:10: -> OP_DIVIDE[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_DIVIDE, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "divideOp"

    public class unaryNegationOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "unaryNegationOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:221:1: unaryNegationOp : x= '-' -> OP_UNARY_NEGATION[$x] ;
    public AntlrCalcEngineParser.unaryNegationOp_return unaryNegationOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.unaryNegationOp_return retval = new AntlrCalcEngineParser.unaryNegationOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:222:2: (x= '-' -> OP_UNARY_NEGATION[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:222:4: x= '-'
            {
            	x=(IToken)Match(input,87,FOLLOW_87_in_unaryNegationOp1184);  
            	stream_87.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 222:10: -> OP_UNARY_NEGATION[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_UNARY_NEGATION, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryNegationOp"

    public class assignmentOp_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignmentOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:224:1: assignmentOp : x= '=' -> OP_ASSIGN[$x] ;
    public AntlrCalcEngineParser.assignmentOp_return assignmentOp() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.assignmentOp_return retval = new AntlrCalcEngineParser.assignmentOp_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:225:2: (x= '=' -> OP_ASSIGN[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:225:4: x= '='
            {
            	x=(IToken)Match(input,68,FOLLOW_68_in_assignmentOp1201);  
            	stream_68.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 225:10: -> OP_ASSIGN[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(OP_ASSIGN, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignmentOp"

    public class entityChain_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "entityChain"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:232:1: entityChain : ( thisKeyword | filteredEntity ) ( '.' filteredEntity )* ;
    public AntlrCalcEngineParser.entityChain_return entityChain() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.entityChain_return retval = new AntlrCalcEngineParser.entityChain_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal77 = null;
        AntlrCalcEngineParser.thisKeyword_return thisKeyword75 = default(AntlrCalcEngineParser.thisKeyword_return);

        AntlrCalcEngineParser.filteredEntity_return filteredEntity76 = default(AntlrCalcEngineParser.filteredEntity_return);

        AntlrCalcEngineParser.filteredEntity_return filteredEntity78 = default(AntlrCalcEngineParser.filteredEntity_return);


        CommonTree char_literal77_tree=null;

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:2: ( ( thisKeyword | filteredEntity ) ( '.' filteredEntity )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:5: ( thisKeyword | filteredEntity ) ( '.' filteredEntity )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:5: ( thisKeyword | filteredEntity )
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == 91) )
            	{
            	    alt28 = 1;
            	}
            	else if ( (LA28_0 == ID) )
            	{
            	    alt28 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d28s0 =
            	        new NoViableAltException("", 28, 0, input);

            	    throw nvae_d28s0;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:7: thisKeyword
            	        {
            	        	PushFollow(FOLLOW_thisKeyword_in_entityChain1224);
            	        	thisKeyword75 = thisKeyword();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, thisKeyword75.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:21: filteredEntity
            	        {
            	        	PushFollow(FOLLOW_filteredEntity_in_entityChain1228);
            	        	filteredEntity76 = filteredEntity();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, filteredEntity76.Tree);

            	        }
            	        break;

            	}

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:38: ( '.' filteredEntity )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == 90) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:40: '.' filteredEntity
            			    {
            			    	char_literal77=(IToken)Match(input,90,FOLLOW_90_in_entityChain1234); 
            			    		char_literal77_tree = (CommonTree)adaptor.Create(char_literal77);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal77_tree, root_0);

            			    	PushFollow(FOLLOW_filteredEntity_in_entityChain1237);
            			    	filteredEntity78 = filteredEntity();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, filteredEntity78.Tree);

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "entityChain"

    public class entityChainNoFilter_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "entityChainNoFilter"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:235:1: entityChainNoFilter : entity ( '.' entity )* ;
    public AntlrCalcEngineParser.entityChainNoFilter_return entityChainNoFilter() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.entityChainNoFilter_return retval = new AntlrCalcEngineParser.entityChainNoFilter_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal80 = null;
        AntlrCalcEngineParser.entity_return entity79 = default(AntlrCalcEngineParser.entity_return);

        AntlrCalcEngineParser.entity_return entity81 = default(AntlrCalcEngineParser.entity_return);


        CommonTree char_literal80_tree=null;

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:2: ( entity ( '.' entity )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:4: entity ( '.' entity )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_entity_in_entityChainNoFilter1250);
            	entity79 = entity();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, entity79.Tree);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:11: ( '.' entity )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == 90) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:13: '.' entity
            			    {
            			    	char_literal80=(IToken)Match(input,90,FOLLOW_90_in_entityChainNoFilter1254); 
            			    		char_literal80_tree = (CommonTree)adaptor.Create(char_literal80);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal80_tree, root_0);

            			    	PushFollow(FOLLOW_entity_in_entityChainNoFilter1257);
            			    	entity81 = entity();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, entity81.Tree);

            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "entityChainNoFilter"

    public class filteredEntity_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "filteredEntity"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:238:1: filteredEntity : entity ( criteria )? ;
    public AntlrCalcEngineParser.filteredEntity_return filteredEntity() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.filteredEntity_return retval = new AntlrCalcEngineParser.filteredEntity_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.entity_return entity82 = default(AntlrCalcEngineParser.entity_return);

        AntlrCalcEngineParser.criteria_return criteria83 = default(AntlrCalcEngineParser.criteria_return);



        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:2: ( entity ( criteria )? )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:4: entity ( criteria )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_entity_in_filteredEntity1271);
            	entity82 = entity();
            	state.followingStackPointer--;

            	root_0 = (CommonTree)adaptor.BecomeRoot(entity82.Tree, root_0);
            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:12: ( criteria )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == 92) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:12: criteria
            	        {
            	        	PushFollow(FOLLOW_criteria_in_filteredEntity1274);
            	        	criteria83 = criteria();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, criteria83.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "filteredEntity"

    public class thisKeyword_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "thisKeyword"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:241:1: thisKeyword : x= 'this' -> THIS[$x] ;
    public AntlrCalcEngineParser.thisKeyword_return thisKeyword() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.thisKeyword_return retval = new AntlrCalcEngineParser.thisKeyword_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_91 = new RewriteRuleTokenStream(adaptor,"token 91");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:242:2: (x= 'this' -> THIS[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:242:4: x= 'this'
            {
            	x=(IToken)Match(input,91,FOLLOW_91_in_thisKeyword1287);  
            	stream_91.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 242:13: -> THIS[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(THIS, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "thisKeyword"

    public class entity_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "entity"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:244:1: entity : x= ID -> ENTITY[$x] ;
    public AntlrCalcEngineParser.entity_return entity() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.entity_return retval = new AntlrCalcEngineParser.entity_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:246:2: (x= ID -> ENTITY[$x] )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:246:4: x= ID
            {
            	x=(IToken)Match(input,ID,FOLLOW_ID_in_entity1305);  
            	stream_ID.Add(x);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 246:9: -> ENTITY[$x]
            	{
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(ENTITY, x));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "entity"

    public class criteria_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "criteria"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:248:1: criteria : '[' expression ']' -> ^( CRITERIA expression ) ;
    public AntlrCalcEngineParser.criteria_return criteria() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.criteria_return retval = new AntlrCalcEngineParser.criteria_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal84 = null;
        IToken char_literal86 = null;
        AntlrCalcEngineParser.expression_return expression85 = default(AntlrCalcEngineParser.expression_return);


        CommonTree char_literal84_tree=null;
        CommonTree char_literal86_tree=null;
        RewriteRuleTokenStream stream_93 = new RewriteRuleTokenStream(adaptor,"token 93");
        RewriteRuleTokenStream stream_92 = new RewriteRuleTokenStream(adaptor,"token 92");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:249:2: ( '[' expression ']' -> ^( CRITERIA expression ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:249:4: '[' expression ']'
            {
            	char_literal84=(IToken)Match(input,92,FOLLOW_92_in_criteria1320);  
            	stream_92.Add(char_literal84);

            	PushFollow(FOLLOW_expression_in_criteria1322);
            	expression85 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression85.Tree);
            	char_literal86=(IToken)Match(input,93,FOLLOW_93_in_criteria1324);  
            	stream_93.Add(char_literal86);



            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 249:23: -> ^( CRITERIA expression )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:249:26: ^( CRITERIA expression )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CRITERIA, "CRITERIA"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "criteria"

    public class functionCall_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "functionCall"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:255:1: functionCall : ID '(' ( expression ( ',' expression )* )? ')' -> ^( FUNCTION ^( NAME ID ) ^( PARAMETERS ( expression )* ) ) ;
    public AntlrCalcEngineParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.functionCall_return retval = new AntlrCalcEngineParser.functionCall_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID87 = null;
        IToken char_literal88 = null;
        IToken char_literal90 = null;
        IToken char_literal92 = null;
        AntlrCalcEngineParser.expression_return expression89 = default(AntlrCalcEngineParser.expression_return);

        AntlrCalcEngineParser.expression_return expression91 = default(AntlrCalcEngineParser.expression_return);


        CommonTree ID87_tree=null;
        CommonTree char_literal88_tree=null;
        CommonTree char_literal90_tree=null;
        CommonTree char_literal92_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_94 = new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_70 = new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:2: ( ID '(' ( expression ( ',' expression )* )? ')' -> ^( FUNCTION ^( NAME ID ) ^( PARAMETERS ( expression )* ) ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:4: ID '(' ( expression ( ',' expression )* )? ')'
            {
            	ID87=(IToken)Match(input,ID,FOLLOW_ID_in_functionCall1350);  
            	stream_ID.Add(ID87);

            	char_literal88=(IToken)Match(input,69,FOLLOW_69_in_functionCall1352);  
            	stream_69.Add(char_literal88);

            	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:11: ( expression ( ',' expression )* )?
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( ((LA33_0 >= ID && LA33_0 <= FLOAT) || LA33_0 == 69 || (LA33_0 >= 71 && LA33_0 <= 72) || LA33_0 == 87 || LA33_0 == 91 || (LA33_0 >= 95 && LA33_0 <= 96)) )
            	{
            	    alt33 = 1;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:13: expression ( ',' expression )*
            	        {
            	        	PushFollow(FOLLOW_expression_in_functionCall1356);
            	        	expression89 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression89.Tree);
            	        	// C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:24: ( ',' expression )*
            	        	do 
            	        	{
            	        	    int alt32 = 2;
            	        	    int LA32_0 = input.LA(1);

            	        	    if ( (LA32_0 == 94) )
            	        	    {
            	        	        alt32 = 1;
            	        	    }


            	        	    switch (alt32) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:26: ',' expression
            	        			    {
            	        			    	char_literal90=(IToken)Match(input,94,FOLLOW_94_in_functionCall1360);  
            	        			    	stream_94.Add(char_literal90);

            	        			    	PushFollow(FOLLOW_expression_in_functionCall1362);
            	        			    	expression91 = expression();
            	        			    	state.followingStackPointer--;

            	        			    	stream_expression.Add(expression91.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop32;
            	        	    }
            	        	} while (true);

            	        	loop32:
            	        		;	// Stops C# compiler whining that label 'loop32' has no statements


            	        }
            	        break;

            	}

            	char_literal92=(IToken)Match(input,70,FOLLOW_70_in_functionCall1370);  
            	stream_70.Add(char_literal92);



            	// AST REWRITE
            	// elements:          ID, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 256:51: -> ^( FUNCTION ^( NAME ID ) ^( PARAMETERS ( expression )* ) )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:54: ^( FUNCTION ^( NAME ID ) ^( PARAMETERS ( expression )* ) )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(FUNCTION, "FUNCTION"), root_1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:66: ^( NAME ID )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(NAME, "NAME"), root_2);

            	    adaptor.AddChild(root_2, stream_ID.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:79: ^( PARAMETERS ( expression )* )
            	    {
            	    CommonTree root_2 = (CommonTree)adaptor.GetNilNode();
            	    root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(PARAMETERS, "PARAMETERS"), root_2);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:93: ( expression )*
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionCall"

    public class identifier_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "identifier"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:262:1: identifier : ID -> ^( IDENTIFIER ID ) ;
    public AntlrCalcEngineParser.identifier_return identifier() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.identifier_return retval = new AntlrCalcEngineParser.identifier_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID93 = null;

        CommonTree ID93_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:263:2: ( ID -> ^( IDENTIFIER ID ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:263:4: ID
            {
            	ID93=(IToken)Match(input,ID,FOLLOW_ID_in_identifier1410);  
            	stream_ID.Add(ID93);



            	// AST REWRITE
            	// elements:          ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 263:7: -> ^( IDENTIFIER ID )
            	{
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:263:10: ^( IDENTIFIER ID )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(IDENTIFIER, "IDENTIFIER"), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "identifier"

    public class number_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "number"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:265:1: number : ( INT | FLOAT );
    public AntlrCalcEngineParser.number_return number() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.number_return retval = new AntlrCalcEngineParser.number_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set94 = null;

        CommonTree set94_tree=null;

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:266:2: ( INT | FLOAT )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set94 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INT && input.LA(1) <= FLOAT) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set94));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "number"

    public class booleanValue_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "booleanValue"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:269:1: booleanValue : (x= 'true' -> TRUE[$x] | x= 'false' -> FALSE[$x] );
    public AntlrCalcEngineParser.booleanValue_return booleanValue() // throws RecognitionException [1]
    {   
        AntlrCalcEngineParser.booleanValue_return retval = new AntlrCalcEngineParser.booleanValue_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken x = null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_96 = new RewriteRuleTokenStream(adaptor,"token 96");
        RewriteRuleTokenStream stream_95 = new RewriteRuleTokenStream(adaptor,"token 95");

        try 
    	{
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:270:2: (x= 'true' -> TRUE[$x] | x= 'false' -> FALSE[$x] )
            int alt34 = 2;
            int LA34_0 = input.LA(1);

            if ( (LA34_0 == 95) )
            {
                alt34 = 1;
            }
            else if ( (LA34_0 == 96) )
            {
                alt34 = 2;
            }
            else 
            {
                NoViableAltException nvae_d34s0 =
                    new NoViableAltException("", 34, 0, input);

                throw nvae_d34s0;
            }
            switch (alt34) 
            {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:270:4: x= 'true'
                    {
                    	x=(IToken)Match(input,95,FOLLOW_95_in_booleanValue1451);  
                    	stream_95.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 270:13: -> TRUE[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(TRUE, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:271:4: x= 'false'
                    {
                    	x=(IToken)Match(input,96,FOLLOW_96_in_booleanValue1463);  
                    	stream_96.Add(x);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 271:14: -> FALSE[$x]
                    	{
                    	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(FALSE, x));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "booleanValue"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_rootLevelStatement_in_root231 = new BitSet(new ulong[]{0x0200040000000002UL});
    public static readonly BitSet FOLLOW_formulaDeclaration_in_rootLevelStatement242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classDeclaration_in_rootLevelStatement248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_classDeclaration262 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_name_in_classDeclaration264 = new BitSet(new ulong[]{0x1400000000000000UL});
    public static readonly BitSet FOLLOW_baseClassDeclaration_in_classDeclaration266 = new BitSet(new ulong[]{0x1400000000000000UL});
    public static readonly BitSet FOLLOW_classStatementBlock_in_classDeclaration269 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_baseClassDeclaration294 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_name_in_baseClassDeclaration296 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_baseClassDeclaration298 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_expression_in_baseClassDeclaration300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_classStatementBlock328 = new BitSet(new ulong[]{0x6000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_classLevelStatement_in_classStatementBlock330 = new BitSet(new ulong[]{0x6000000000000000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_61_in_classStatementBlock333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyDeclaration_in_classLevelStatement354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_relationshipDeclaration_in_classLevelStatement359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_name371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_propertyDeclaration389 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_name_in_propertyDeclaration391 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_propertyModifiers_in_propertyDeclaration393 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_propertyDeclaration396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exclusivePropertyModifier_in_propertyModifiers419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyModifier_in_propertyModifiers434 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_64_in_exclusivePropertyModifier456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_propertyModifier0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_relationshipDeclaration484 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_name_in_relationshipDeclaration486 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_relationshipDeclaration488 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_relationshipJoinDeclaration_in_relationshipDeclaration490 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_relationshipDeclaration492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_name_in_relationshipJoinDeclaration514 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_relationshipJoinDeclaration516 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_expression_in_relationshipJoinDeclaration518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_entityChainNoFilter_in_formulaDeclaration558 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_assignmentOp_in_formulaDeclaration560 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_expression_in_formulaDeclaration562 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_formulaDeclaration564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_orExpr_in_expression599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andExpr_in_orExpr609 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_orOp_in_orExpr613 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_andExpr_in_orExpr616 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_equalityExpr_in_andExpr629 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_andOp_in_andExpr633 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_equalityExpr_in_andExpr636 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_relationalExpr_in_equalityExpr650 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000038010UL});
    public static readonly BitSet FOLLOW_equalsOp_in_equalityExpr656 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_notEqualsOp_in_equalityExpr661 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_relationalExpr_in_equalityExpr666 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000038010UL});
    public static readonly BitSet FOLLOW_additiveExpr_in_relationalExpr679 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000003C0000UL});
    public static readonly BitSet FOLLOW_ltOp_in_relationalExpr685 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_gtOp_in_relationalExpr690 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_lteOp_in_relationalExpr695 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_gteOp_in_relationalExpr700 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_additiveExpr_in_relationalExpr705 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000003C0000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpr_in_additiveExpr719 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000C00000UL});
    public static readonly BitSet FOLLOW_addOp_in_additiveExpr725 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_subtractOp_in_additiveExpr730 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_multiplicativeExpr_in_additiveExpr735 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000C00000UL});
    public static readonly BitSet FOLLOW_unaryExpr_in_multiplicativeExpr749 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000003006000UL});
    public static readonly BitSet FOLLOW_multiplyOp_in_multiplicativeExpr755 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_divideOp_in_multiplicativeExpr760 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_modulusOp_in_multiplicativeExpr765 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_unaryExpr_in_multiplicativeExpr770 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000003006000UL});
    public static readonly BitSet FOLLOW_unaryNegationOp_in_unaryExpr785 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_negationExpr_in_unaryExpr789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notOp_in_negationExpr802 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_primaryExpr_in_negationExpr808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_primaryExpr819 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_expression_in_primaryExpr822 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_primaryExpr824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_number_in_primaryExpr830 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanValue_in_primaryExpr835 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LITERAL_in_primaryExpr840 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_primaryExpr845 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_entityChain_in_primaryExpr850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_71_in_notOp868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_notOp880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_orOp898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_orOp910 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_andOp927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_andOp939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_modulusOp957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_modulusOp969 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_equalsOp988 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_equalsOp1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_notEqualsOp1019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_notEqualsOp1031 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_ltOp1048 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_gtOp1065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_lteOp1082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_gteOp1099 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_addOp1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_subtractOp1133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_multiplyOp1150 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_89_in_divideOp1167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_unaryNegationOp1184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_assignmentOp1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_thisKeyword_in_entityChain1224 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_filteredEntity_in_entityChain1228 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_90_in_entityChain1234 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_filteredEntity_in_entityChain1237 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_entity_in_entityChainNoFilter1250 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_90_in_entityChainNoFilter1254 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_entity_in_entityChainNoFilter1257 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000004000000UL});
    public static readonly BitSet FOLLOW_entity_in_filteredEntity1271 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000010000000UL});
    public static readonly BitSet FOLLOW_criteria_in_filteredEntity1274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_91_in_thisKeyword1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_entity1305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_92_in_criteria1320 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_expression_in_criteria1322 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000020000000UL});
    public static readonly BitSet FOLLOW_93_in_criteria1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_functionCall1350 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_functionCall1352 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001E0UL});
    public static readonly BitSet FOLLOW_expression_in_functionCall1356 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000040UL});
    public static readonly BitSet FOLLOW_94_in_functionCall1360 = new BitSet(new ulong[]{0x00003C0000000000UL,0x00000001888001A0UL});
    public static readonly BitSet FOLLOW_expression_in_functionCall1362 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000040000040UL});
    public static readonly BitSet FOLLOW_70_in_functionCall1370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_identifier1410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_number0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_95_in_booleanValue1451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_96_in_booleanValue1463 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}