// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g 2011-01-28 15:05:30

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class AntlrCalcEngineParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "CLASS", "BASE_CLASS", "DISCRIMINATOR", "PROPERTY", "RELATIONSHIP", "JOIN", "TARGET", "NAME", "STATEMENT_BLOCK", "FORMULA", "MODIFIERS", "EXPRESSION", "IDENTIFIER", "THIS", "ENTITY", "FUNCTION", "PARAMETERS", "FILTER", "SOURCE", "CRITERIA", "OP_OR", "OP_AND", "OP_NOT", "OP_EQ", "OP_NE", "OP_LT", "OP_GT", "OP_LTE", "OP_GTE", "OP_ADD", "OP_SUBTRACT", "OP_MULTIPLY", "OP_DIVIDE", "OP_MODULUS", "OP_ASSIGN", "OP_UNARY_NEGATION", "TRUE", "FALSE", "ID", "LITERAL", "INT", "FLOAT", "DQUOT", "SQUOT", "EXPONENT", "COMMENT", "WS", "ESC_SEQ", "STRING", "CHAR", "HEX_DIGIT", "UNICODE_ESC", "OCTAL_ESC", "'class'", "':'", "'where'", "'{'", "'}'", "'property'", "';'", "'primarykey'", "'calculated'", "'abstract'", "'relationship'", "'='", "'('", "')'", "'not'", "'!'", "'or'", "'||'", "'and'", "'&&'", "'mod'", "'%'", "'=='", "'!='", "'<>'", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'.'", "'this'", "'['", "']'", "','", "'true'", "'false'"
    };
    public static final int FUNCTION=19;
    public static final int EXPONENT=48;
    public static final int OP_AND=25;
    public static final int OCTAL_ESC=56;
    public static final int CHAR=53;
    public static final int EOF=-1;
    public static final int T__93=93;
    public static final int T__94=94;
    public static final int T__91=91;
    public static final int OP_EQ=27;
    public static final int T__92=92;
    public static final int NAME=11;
    public static final int T__90=90;
    public static final int SQUOT=47;
    public static final int OP_GTE=32;
    public static final int THIS=17;
    public static final int OP_LT=29;
    public static final int COMMENT=49;
    public static final int T__96=96;
    public static final int T__95=95;
    public static final int OP_NE=28;
    public static final int T__80=80;
    public static final int T__81=81;
    public static final int T__82=82;
    public static final int T__83=83;
    public static final int OP_ADD=33;
    public static final int INT=44;
    public static final int T__85=85;
    public static final int T__84=84;
    public static final int T__87=87;
    public static final int T__86=86;
    public static final int T__89=89;
    public static final int RELATIONSHIP=8;
    public static final int T__88=88;
    public static final int T__71=71;
    public static final int WS=50;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int PROPERTY=7;
    public static final int STATEMENT_BLOCK=12;
    public static final int FILTER=21;
    public static final int T__76=76;
    public static final int T__75=75;
    public static final int FALSE=41;
    public static final int T__74=74;
    public static final int T__73=73;
    public static final int T__79=79;
    public static final int T__78=78;
    public static final int T__77=77;
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int T__67=67;
    public static final int CLASS=4;
    public static final int T__64=64;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int FORMULA=13;
    public static final int T__63=63;
    public static final int PARAMETERS=20;
    public static final int OP_ASSIGN=38;
    public static final int OP_OR=24;
    public static final int OP_UNARY_NEGATION=39;
    public static final int DQUOT=46;
    public static final int OP_GT=30;
    public static final int SOURCE=22;
    public static final int BASE_CLASS=5;
    public static final int FLOAT=45;
    public static final int T__61=61;
    public static final int ID=42;
    public static final int T__60=60;
    public static final int ENTITY=18;
    public static final int MODIFIERS=14;
    public static final int T__57=57;
    public static final int T__58=58;
    public static final int ESC_SEQ=51;
    public static final int IDENTIFIER=16;
    public static final int T__59=59;
    public static final int OP_NOT=26;
    public static final int EXPRESSION=15;
    public static final int OP_MULTIPLY=35;
    public static final int OP_LTE=31;
    public static final int UNICODE_ESC=55;
    public static final int OP_SUBTRACT=34;
    public static final int HEX_DIGIT=54;
    public static final int OP_DIVIDE=36;
    public static final int LITERAL=43;
    public static final int TARGET=10;
    public static final int TRUE=40;
    public static final int JOIN=9;
    public static final int CRITERIA=23;
    public static final int OP_MODULUS=37;
    public static final int DISCRIMINATOR=6;
    public static final int STRING=52;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "propertyModifiers", "subtractOp", "orOp", "functionCall", 
        "equalityExpr", "name", "thisKeyword", "gteOp", "ltOp", "relationshipDeclaration", 
        "classDeclaration", "notEqualsOp", "divideOp", "assignmentOp", "notOp", 
        "primaryExpr", "equalsOp", "classLevelStatement", "identifier", 
        "baseClassDeclaration", "unaryExpr", "andOp", "relationalExpr", 
        "expression", "filteredEntity", "relationshipJoinDeclaration", "booleanValue", 
        "additiveExpr", "gtOp", "negationExpr", "multiplyOp", "entityChain", 
        "multiplicativeExpr", "formulaDeclaration", "exclusivePropertyModifier", 
        "root", "entity", "entityChainNoFilter", "orExpr", "addOp", "modulusOp", 
        "rootLevelStatement", "number", "classStatementBlock", "lteOp", 
        "propertyDeclaration", "criteria", "andExpr", "propertyModifier", 
        "unaryNegationOp"
    };
     
        public int ruleLevel = 0;
        public int getRuleLevel() { return ruleLevel; }
        public void incRuleLevel() { ruleLevel++; }
        public void decRuleLevel() { ruleLevel--; }
        public AntlrCalcEngineParser(TokenStream input) {
            this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState());
        }
        public AntlrCalcEngineParser(TokenStream input, int port, RecognizerSharedState state) {
            super(input, state);
            DebugEventSocketProxy proxy =
                new DebugEventSocketProxy(this,port,adaptor);
            setDebugListener(proxy);
            setTokenStream(new DebugTokenStream(input,proxy));
            try {
                proxy.handshake();
            }
            catch (IOException ioe) {
                reportError(ioe);
            }
            TreeAdaptor adap = new CommonTreeAdaptor();
            setTreeAdaptor(adap);
            proxy.setTreeAdaptor(adap);
        }
    public AntlrCalcEngineParser(TokenStream input, DebugEventListener dbg) {
        super(input, dbg);

         
        TreeAdaptor adap = new CommonTreeAdaptor();
        setTreeAdaptor(adap);

    }
    protected boolean evalPredicate(boolean result, String predicate) {
        dbg.semanticPredicate(result, predicate);
        return result;
    }

    protected DebugTreeAdaptor adaptor;
    public void setTreeAdaptor(TreeAdaptor adaptor) {
        this.adaptor = new DebugTreeAdaptor(dbg,adaptor);

    }
    public TreeAdaptor getTreeAdaptor() {
        return adaptor;
    }


    public String[] getTokenNames() { return AntlrCalcEngineParser.tokenNames; }
    public String getGrammarFileName() { return "C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g"; }


    public static class root_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "root"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:68:1: root : ( rootLevelStatement )* ;
    public final AntlrCalcEngineParser.root_return root() throws RecognitionException {
        AntlrCalcEngineParser.root_return retval = new AntlrCalcEngineParser.root_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.rootLevelStatement_return rootLevelStatement1 = null;



        try { dbg.enterRule(getGrammarFileName(), "root");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(68, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:2: ( ( rootLevelStatement )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:4: ( rootLevelStatement )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(69,4);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:4: ( rootLevelStatement )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( (LA1_0==ID||LA1_0==57) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:69:4: rootLevelStatement
            	    {
            	    dbg.location(69,4);
            	    pushFollow(FOLLOW_rootLevelStatement_in_root225);
            	    rootLevelStatement1=rootLevelStatement();

            	    state._fsp--;

            	    adaptor.addChild(root_0, rootLevelStatement1.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);
            } finally {dbg.exitSubRule(1);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(70, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "root");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "root"

    public static class rootLevelStatement_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "rootLevelStatement"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:71:1: rootLevelStatement : ( formulaDeclaration | classDeclaration );
    public final AntlrCalcEngineParser.rootLevelStatement_return rootLevelStatement() throws RecognitionException {
        AntlrCalcEngineParser.rootLevelStatement_return retval = new AntlrCalcEngineParser.rootLevelStatement_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.formulaDeclaration_return formulaDeclaration2 = null;

        AntlrCalcEngineParser.classDeclaration_return classDeclaration3 = null;



        try { dbg.enterRule(getGrammarFileName(), "rootLevelStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(71, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:72:2: ( formulaDeclaration | classDeclaration )
            int alt2=2;
            try { dbg.enterDecision(2);

            int LA2_0 = input.LA(1);

            if ( (LA2_0==ID) ) {
                alt2=1;
            }
            else if ( (LA2_0==57) ) {
                alt2=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 2, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(2);}

            switch (alt2) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:72:4: formulaDeclaration
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(72,4);
                    pushFollow(FOLLOW_formulaDeclaration_in_rootLevelStatement236);
                    formulaDeclaration2=formulaDeclaration();

                    state._fsp--;

                    adaptor.addChild(root_0, formulaDeclaration2.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:73:4: classDeclaration
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(73,4);
                    pushFollow(FOLLOW_classDeclaration_in_rootLevelStatement242);
                    classDeclaration3=classDeclaration();

                    state._fsp--;

                    adaptor.addChild(root_0, classDeclaration3.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(74, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "rootLevelStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "rootLevelStatement"

    public static class classDeclaration_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "classDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:79:1: classDeclaration : 'class' name ( baseClassDeclaration )? classStatementBlock -> ^( CLASS name ( baseClassDeclaration )? classStatementBlock ) ;
    public final AntlrCalcEngineParser.classDeclaration_return classDeclaration() throws RecognitionException {
        AntlrCalcEngineParser.classDeclaration_return retval = new AntlrCalcEngineParser.classDeclaration_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token string_literal4=null;
        AntlrCalcEngineParser.name_return name5 = null;

        AntlrCalcEngineParser.baseClassDeclaration_return baseClassDeclaration6 = null;

        AntlrCalcEngineParser.classStatementBlock_return classStatementBlock7 = null;


        CommonTree string_literal4_tree=null;
        RewriteRuleTokenStream stream_57=new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_classStatementBlock=new RewriteRuleSubtreeStream(adaptor,"rule classStatementBlock");
        RewriteRuleSubtreeStream stream_name=new RewriteRuleSubtreeStream(adaptor,"rule name");
        RewriteRuleSubtreeStream stream_baseClassDeclaration=new RewriteRuleSubtreeStream(adaptor,"rule baseClassDeclaration");
        try { dbg.enterRule(getGrammarFileName(), "classDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(79, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:2: ( 'class' name ( baseClassDeclaration )? classStatementBlock -> ^( CLASS name ( baseClassDeclaration )? classStatementBlock ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:4: 'class' name ( baseClassDeclaration )? classStatementBlock
            {
            dbg.location(80,4);
            string_literal4=(Token)match(input,57,FOLLOW_57_in_classDeclaration256);  
            stream_57.add(string_literal4);

            dbg.location(80,12);
            pushFollow(FOLLOW_name_in_classDeclaration258);
            name5=name();

            state._fsp--;

            stream_name.add(name5.getTree());
            dbg.location(80,17);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:17: ( baseClassDeclaration )?
            int alt3=2;
            try { dbg.enterSubRule(3);
            try { dbg.enterDecision(3);

            int LA3_0 = input.LA(1);

            if ( (LA3_0==58) ) {
                alt3=1;
            }
            } finally {dbg.exitDecision(3);}

            switch (alt3) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:17: baseClassDeclaration
                    {
                    dbg.location(80,17);
                    pushFollow(FOLLOW_baseClassDeclaration_in_classDeclaration260);
                    baseClassDeclaration6=baseClassDeclaration();

                    state._fsp--;

                    stream_baseClassDeclaration.add(baseClassDeclaration6.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(3);}

            dbg.location(80,39);
            pushFollow(FOLLOW_classStatementBlock_in_classDeclaration263);
            classStatementBlock7=classStatementBlock();

            state._fsp--;

            stream_classStatementBlock.add(classStatementBlock7.getTree());


            // AST REWRITE
            // elements: classStatementBlock, baseClassDeclaration, name
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 80:59: -> ^( CLASS name ( baseClassDeclaration )? classStatementBlock )
            {
                dbg.location(80,62);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:62: ^( CLASS name ( baseClassDeclaration )? classStatementBlock )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(80,65);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(CLASS, "CLASS"), root_1);

                dbg.location(80,71);
                adaptor.addChild(root_1, stream_name.nextTree());
                dbg.location(80,76);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:80:76: ( baseClassDeclaration )?
                if ( stream_baseClassDeclaration.hasNext() ) {
                    dbg.location(80,76);
                    adaptor.addChild(root_1, stream_baseClassDeclaration.nextTree());

                }
                stream_baseClassDeclaration.reset();
                dbg.location(80,98);
                adaptor.addChild(root_1, stream_classStatementBlock.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(81, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "classDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "classDeclaration"

    public static class baseClassDeclaration_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "baseClassDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:82:1: baseClassDeclaration : ':' name 'where' expression -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) ) ;
    public final AntlrCalcEngineParser.baseClassDeclaration_return baseClassDeclaration() throws RecognitionException {
        AntlrCalcEngineParser.baseClassDeclaration_return retval = new AntlrCalcEngineParser.baseClassDeclaration_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal8=null;
        Token string_literal10=null;
        AntlrCalcEngineParser.name_return name9 = null;

        AntlrCalcEngineParser.expression_return expression11 = null;


        CommonTree char_literal8_tree=null;
        CommonTree string_literal10_tree=null;
        RewriteRuleTokenStream stream_59=new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58=new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_name=new RewriteRuleSubtreeStream(adaptor,"rule name");
        try { dbg.enterRule(getGrammarFileName(), "baseClassDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(82, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:2: ( ':' name 'where' expression -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:4: ':' name 'where' expression
            {
            dbg.location(83,4);
            char_literal8=(Token)match(input,58,FOLLOW_58_in_baseClassDeclaration288);  
            stream_58.add(char_literal8);

            dbg.location(83,8);
            pushFollow(FOLLOW_name_in_baseClassDeclaration290);
            name9=name();

            state._fsp--;

            stream_name.add(name9.getTree());
            dbg.location(83,13);
            string_literal10=(Token)match(input,59,FOLLOW_59_in_baseClassDeclaration292);  
            stream_59.add(string_literal10);

            dbg.location(83,21);
            pushFollow(FOLLOW_expression_in_baseClassDeclaration294);
            expression11=expression();

            state._fsp--;

            stream_expression.add(expression11.getTree());


            // AST REWRITE
            // elements: expression, name
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 83:32: -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) )
            {
                dbg.location(83,35);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:35: ^( BASE_CLASS name ^( DISCRIMINATOR expression ) )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(83,38);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(BASE_CLASS, "BASE_CLASS"), root_1);

                dbg.location(83,49);
                adaptor.addChild(root_1, stream_name.nextTree());
                dbg.location(83,54);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:83:54: ^( DISCRIMINATOR expression )
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(83,57);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(DISCRIMINATOR, "DISCRIMINATOR"), root_2);

                dbg.location(83,71);
                adaptor.addChild(root_2, stream_expression.nextTree());

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(84, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "baseClassDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "baseClassDeclaration"

    public static class classStatementBlock_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "classStatementBlock"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:85:1: classStatementBlock : '{' ( classLevelStatement )* '}' -> ^( STATEMENT_BLOCK ( classLevelStatement )* ) ;
    public final AntlrCalcEngineParser.classStatementBlock_return classStatementBlock() throws RecognitionException {
        AntlrCalcEngineParser.classStatementBlock_return retval = new AntlrCalcEngineParser.classStatementBlock_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal12=null;
        Token char_literal14=null;
        AntlrCalcEngineParser.classLevelStatement_return classLevelStatement13 = null;


        CommonTree char_literal12_tree=null;
        CommonTree char_literal14_tree=null;
        RewriteRuleTokenStream stream_60=new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleTokenStream stream_61=new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleSubtreeStream stream_classLevelStatement=new RewriteRuleSubtreeStream(adaptor,"rule classLevelStatement");
        try { dbg.enterRule(getGrammarFileName(), "classStatementBlock");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(85, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:2: ( '{' ( classLevelStatement )* '}' -> ^( STATEMENT_BLOCK ( classLevelStatement )* ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:4: '{' ( classLevelStatement )* '}'
            {
            dbg.location(86,4);
            char_literal12=(Token)match(input,60,FOLLOW_60_in_classStatementBlock322);  
            stream_60.add(char_literal12);

            dbg.location(86,8);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:8: ( classLevelStatement )*
            try { dbg.enterSubRule(4);

            loop4:
            do {
                int alt4=2;
                try { dbg.enterDecision(4);

                int LA4_0 = input.LA(1);

                if ( (LA4_0==62||LA4_0==67) ) {
                    alt4=1;
                }


                } finally {dbg.exitDecision(4);}

                switch (alt4) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:8: classLevelStatement
            	    {
            	    dbg.location(86,8);
            	    pushFollow(FOLLOW_classLevelStatement_in_classStatementBlock324);
            	    classLevelStatement13=classLevelStatement();

            	    state._fsp--;

            	    stream_classLevelStatement.add(classLevelStatement13.getTree());

            	    }
            	    break;

            	default :
            	    break loop4;
                }
            } while (true);
            } finally {dbg.exitSubRule(4);}

            dbg.location(86,29);
            char_literal14=(Token)match(input,61,FOLLOW_61_in_classStatementBlock327);  
            stream_61.add(char_literal14);



            // AST REWRITE
            // elements: classLevelStatement
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 86:33: -> ^( STATEMENT_BLOCK ( classLevelStatement )* )
            {
                dbg.location(86,36);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:36: ^( STATEMENT_BLOCK ( classLevelStatement )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(86,39);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(STATEMENT_BLOCK, "STATEMENT_BLOCK"), root_1);

                dbg.location(86,55);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:86:55: ( classLevelStatement )*
                while ( stream_classLevelStatement.hasNext() ) {
                    dbg.location(86,55);
                    adaptor.addChild(root_1, stream_classLevelStatement.nextTree());

                }
                stream_classLevelStatement.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(87, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "classStatementBlock");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "classStatementBlock"

    public static class classLevelStatement_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "classLevelStatement"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:88:1: classLevelStatement : ( propertyDeclaration | relationshipDeclaration );
    public final AntlrCalcEngineParser.classLevelStatement_return classLevelStatement() throws RecognitionException {
        AntlrCalcEngineParser.classLevelStatement_return retval = new AntlrCalcEngineParser.classLevelStatement_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.propertyDeclaration_return propertyDeclaration15 = null;

        AntlrCalcEngineParser.relationshipDeclaration_return relationshipDeclaration16 = null;



        try { dbg.enterRule(getGrammarFileName(), "classLevelStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(88, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:89:2: ( propertyDeclaration | relationshipDeclaration )
            int alt5=2;
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( (LA5_0==62) ) {
                alt5=1;
            }
            else if ( (LA5_0==67) ) {
                alt5=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 5, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:89:4: propertyDeclaration
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(89,4);
                    pushFollow(FOLLOW_propertyDeclaration_in_classLevelStatement348);
                    propertyDeclaration15=propertyDeclaration();

                    state._fsp--;

                    adaptor.addChild(root_0, propertyDeclaration15.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:90:4: relationshipDeclaration
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(90,4);
                    pushFollow(FOLLOW_relationshipDeclaration_in_classLevelStatement353);
                    relationshipDeclaration16=relationshipDeclaration();

                    state._fsp--;

                    adaptor.addChild(root_0, relationshipDeclaration16.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(91, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "classLevelStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "classLevelStatement"

    public static class name_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "name"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:92:1: name : x= ID -> NAME[$x] ;
    public final AntlrCalcEngineParser.name_return name() throws RecognitionException {
        AntlrCalcEngineParser.name_return retval = new AntlrCalcEngineParser.name_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "name");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(92, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:93:2: (x= ID -> NAME[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:93:4: x= ID
            {
            dbg.location(93,5);
            x=(Token)match(input,ID,FOLLOW_ID_in_name365);  
            stream_ID.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 93:9: -> NAME[$x]
            {
                dbg.location(93,12);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(NAME, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(94, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "name");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "name"

    public static class propertyDeclaration_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "propertyDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:97:1: propertyDeclaration : 'property' name ( propertyModifiers )? ';' -> ^( PROPERTY name ( propertyModifiers )? ) ;
    public final AntlrCalcEngineParser.propertyDeclaration_return propertyDeclaration() throws RecognitionException {
        AntlrCalcEngineParser.propertyDeclaration_return retval = new AntlrCalcEngineParser.propertyDeclaration_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token string_literal17=null;
        Token char_literal20=null;
        AntlrCalcEngineParser.name_return name18 = null;

        AntlrCalcEngineParser.propertyModifiers_return propertyModifiers19 = null;


        CommonTree string_literal17_tree=null;
        CommonTree char_literal20_tree=null;
        RewriteRuleTokenStream stream_62=new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_63=new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_propertyModifiers=new RewriteRuleSubtreeStream(adaptor,"rule propertyModifiers");
        RewriteRuleSubtreeStream stream_name=new RewriteRuleSubtreeStream(adaptor,"rule name");
        try { dbg.enterRule(getGrammarFileName(), "propertyDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(97, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:2: ( 'property' name ( propertyModifiers )? ';' -> ^( PROPERTY name ( propertyModifiers )? ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:4: 'property' name ( propertyModifiers )? ';'
            {
            dbg.location(98,4);
            string_literal17=(Token)match(input,62,FOLLOW_62_in_propertyDeclaration383);  
            stream_62.add(string_literal17);

            dbg.location(98,15);
            pushFollow(FOLLOW_name_in_propertyDeclaration385);
            name18=name();

            state._fsp--;

            stream_name.add(name18.getTree());
            dbg.location(98,20);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:20: ( propertyModifiers )?
            int alt6=2;
            try { dbg.enterSubRule(6);
            try { dbg.enterDecision(6);

            int LA6_0 = input.LA(1);

            if ( ((LA6_0>=64 && LA6_0<=66)) ) {
                alt6=1;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:20: propertyModifiers
                    {
                    dbg.location(98,20);
                    pushFollow(FOLLOW_propertyModifiers_in_propertyDeclaration387);
                    propertyModifiers19=propertyModifiers();

                    state._fsp--;

                    stream_propertyModifiers.add(propertyModifiers19.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(98,39);
            char_literal20=(Token)match(input,63,FOLLOW_63_in_propertyDeclaration390);  
            stream_63.add(char_literal20);



            // AST REWRITE
            // elements: propertyModifiers, name
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 98:43: -> ^( PROPERTY name ( propertyModifiers )? )
            {
                dbg.location(98,46);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:46: ^( PROPERTY name ( propertyModifiers )? )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(98,49);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(PROPERTY, "PROPERTY"), root_1);

                dbg.location(98,58);
                adaptor.addChild(root_1, stream_name.nextTree());
                dbg.location(98,63);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:98:63: ( propertyModifiers )?
                if ( stream_propertyModifiers.hasNext() ) {
                    dbg.location(98,63);
                    adaptor.addChild(root_1, stream_propertyModifiers.nextTree());

                }
                stream_propertyModifiers.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(99, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "propertyDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "propertyDeclaration"

    public static class propertyModifiers_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "propertyModifiers"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:100:1: propertyModifiers : ( exclusivePropertyModifier -> ^( MODIFIERS exclusivePropertyModifier ) | ( propertyModifier )+ -> ^( MODIFIERS ( propertyModifier )+ ) );
    public final AntlrCalcEngineParser.propertyModifiers_return propertyModifiers() throws RecognitionException {
        AntlrCalcEngineParser.propertyModifiers_return retval = new AntlrCalcEngineParser.propertyModifiers_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.exclusivePropertyModifier_return exclusivePropertyModifier21 = null;

        AntlrCalcEngineParser.propertyModifier_return propertyModifier22 = null;


        RewriteRuleSubtreeStream stream_propertyModifier=new RewriteRuleSubtreeStream(adaptor,"rule propertyModifier");
        RewriteRuleSubtreeStream stream_exclusivePropertyModifier=new RewriteRuleSubtreeStream(adaptor,"rule exclusivePropertyModifier");
        try { dbg.enterRule(getGrammarFileName(), "propertyModifiers");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(100, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:101:2: ( exclusivePropertyModifier -> ^( MODIFIERS exclusivePropertyModifier ) | ( propertyModifier )+ -> ^( MODIFIERS ( propertyModifier )+ ) )
            int alt8=2;
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==64) ) {
                alt8=1;
            }
            else if ( ((LA8_0>=65 && LA8_0<=66)) ) {
                alt8=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 8, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:101:4: exclusivePropertyModifier
                    {
                    dbg.location(101,4);
                    pushFollow(FOLLOW_exclusivePropertyModifier_in_propertyModifiers413);
                    exclusivePropertyModifier21=exclusivePropertyModifier();

                    state._fsp--;

                    stream_exclusivePropertyModifier.add(exclusivePropertyModifier21.getTree());


                    // AST REWRITE
                    // elements: exclusivePropertyModifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 101:30: -> ^( MODIFIERS exclusivePropertyModifier )
                    {
                        dbg.location(101,33);
                        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:101:33: ^( MODIFIERS exclusivePropertyModifier )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(101,36);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(MODIFIERS, "MODIFIERS"), root_1);

                        dbg.location(101,46);
                        adaptor.addChild(root_1, stream_exclusivePropertyModifier.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:4: ( propertyModifier )+
                    {
                    dbg.location(102,4);
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:4: ( propertyModifier )+
                    int cnt7=0;
                    try { dbg.enterSubRule(7);

                    loop7:
                    do {
                        int alt7=2;
                        try { dbg.enterDecision(7);

                        int LA7_0 = input.LA(1);

                        if ( ((LA7_0>=65 && LA7_0<=66)) ) {
                            alt7=1;
                        }


                        } finally {dbg.exitDecision(7);}

                        switch (alt7) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:4: propertyModifier
                    	    {
                    	    dbg.location(102,4);
                    	    pushFollow(FOLLOW_propertyModifier_in_propertyModifiers428);
                    	    propertyModifier22=propertyModifier();

                    	    state._fsp--;

                    	    stream_propertyModifier.add(propertyModifier22.getTree());

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt7 >= 1 ) break loop7;
                                EarlyExitException eee =
                                    new EarlyExitException(7, input);
                                dbg.recognitionException(eee);

                                throw eee;
                        }
                        cnt7++;
                    } while (true);
                    } finally {dbg.exitSubRule(7);}



                    // AST REWRITE
                    // elements: propertyModifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 102:22: -> ^( MODIFIERS ( propertyModifier )+ )
                    {
                        dbg.location(102,25);
                        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:102:25: ^( MODIFIERS ( propertyModifier )+ )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        dbg.location(102,28);
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(MODIFIERS, "MODIFIERS"), root_1);

                        dbg.location(102,38);
                        if ( !(stream_propertyModifier.hasNext()) ) {
                            throw new RewriteEarlyExitException();
                        }
                        while ( stream_propertyModifier.hasNext() ) {
                            dbg.location(102,38);
                            adaptor.addChild(root_1, stream_propertyModifier.nextTree());

                        }
                        stream_propertyModifier.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(103, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "propertyModifiers");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "propertyModifiers"

    public static class exclusivePropertyModifier_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "exclusivePropertyModifier"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:104:1: exclusivePropertyModifier : 'primarykey' ;
    public final AntlrCalcEngineParser.exclusivePropertyModifier_return exclusivePropertyModifier() throws RecognitionException {
        AntlrCalcEngineParser.exclusivePropertyModifier_return retval = new AntlrCalcEngineParser.exclusivePropertyModifier_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token string_literal23=null;

        CommonTree string_literal23_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "exclusivePropertyModifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(104, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:105:2: ( 'primarykey' )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:105:4: 'primarykey'
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(105,4);
            string_literal23=(Token)match(input,64,FOLLOW_64_in_exclusivePropertyModifier450); 
            string_literal23_tree = (CommonTree)adaptor.create(string_literal23);
            adaptor.addChild(root_0, string_literal23_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(106, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "exclusivePropertyModifier");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "exclusivePropertyModifier"

    public static class propertyModifier_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "propertyModifier"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:107:1: propertyModifier : ( 'calculated' | 'abstract' );
    public final AntlrCalcEngineParser.propertyModifier_return propertyModifier() throws RecognitionException {
        AntlrCalcEngineParser.propertyModifier_return retval = new AntlrCalcEngineParser.propertyModifier_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token set24=null;

        CommonTree set24_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "propertyModifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(107, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:108:2: ( 'calculated' | 'abstract' )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(108,2);
            set24=(Token)input.LT(1);
            if ( (input.LA(1)>=65 && input.LA(1)<=66) ) {
                input.consume();
                adaptor.addChild(root_0, (CommonTree)adaptor.create(set24));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(110, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "propertyModifier");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "propertyModifier"

    public static class relationshipDeclaration_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "relationshipDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:113:1: relationshipDeclaration : 'relationship' name '=' relationshipJoinDeclaration ';' -> ^( RELATIONSHIP name relationshipJoinDeclaration ) ;
    public final AntlrCalcEngineParser.relationshipDeclaration_return relationshipDeclaration() throws RecognitionException {
        AntlrCalcEngineParser.relationshipDeclaration_return retval = new AntlrCalcEngineParser.relationshipDeclaration_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token string_literal25=null;
        Token char_literal27=null;
        Token char_literal29=null;
        AntlrCalcEngineParser.name_return name26 = null;

        AntlrCalcEngineParser.relationshipJoinDeclaration_return relationshipJoinDeclaration28 = null;


        CommonTree string_literal25_tree=null;
        CommonTree char_literal27_tree=null;
        CommonTree char_literal29_tree=null;
        RewriteRuleTokenStream stream_67=new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_63=new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_name=new RewriteRuleSubtreeStream(adaptor,"rule name");
        RewriteRuleSubtreeStream stream_relationshipJoinDeclaration=new RewriteRuleSubtreeStream(adaptor,"rule relationshipJoinDeclaration");
        try { dbg.enterRule(getGrammarFileName(), "relationshipDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(113, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:114:2: ( 'relationship' name '=' relationshipJoinDeclaration ';' -> ^( RELATIONSHIP name relationshipJoinDeclaration ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:114:4: 'relationship' name '=' relationshipJoinDeclaration ';'
            {
            dbg.location(114,4);
            string_literal25=(Token)match(input,67,FOLLOW_67_in_relationshipDeclaration478);  
            stream_67.add(string_literal25);

            dbg.location(114,19);
            pushFollow(FOLLOW_name_in_relationshipDeclaration480);
            name26=name();

            state._fsp--;

            stream_name.add(name26.getTree());
            dbg.location(114,24);
            char_literal27=(Token)match(input,68,FOLLOW_68_in_relationshipDeclaration482);  
            stream_68.add(char_literal27);

            dbg.location(114,28);
            pushFollow(FOLLOW_relationshipJoinDeclaration_in_relationshipDeclaration484);
            relationshipJoinDeclaration28=relationshipJoinDeclaration();

            state._fsp--;

            stream_relationshipJoinDeclaration.add(relationshipJoinDeclaration28.getTree());
            dbg.location(114,56);
            char_literal29=(Token)match(input,63,FOLLOW_63_in_relationshipDeclaration486);  
            stream_63.add(char_literal29);



            // AST REWRITE
            // elements: relationshipJoinDeclaration, name
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 114:60: -> ^( RELATIONSHIP name relationshipJoinDeclaration )
            {
                dbg.location(114,63);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:114:63: ^( RELATIONSHIP name relationshipJoinDeclaration )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(114,66);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(RELATIONSHIP, "RELATIONSHIP"), root_1);

                dbg.location(114,79);
                adaptor.addChild(root_1, stream_name.nextTree());
                dbg.location(114,84);
                adaptor.addChild(root_1, stream_relationshipJoinDeclaration.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(115, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "relationshipDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "relationshipDeclaration"

    public static class relationshipJoinDeclaration_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "relationshipJoinDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:116:1: relationshipJoinDeclaration : name 'where' expression -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) ) ;
    public final AntlrCalcEngineParser.relationshipJoinDeclaration_return relationshipJoinDeclaration() throws RecognitionException {
        AntlrCalcEngineParser.relationshipJoinDeclaration_return retval = new AntlrCalcEngineParser.relationshipJoinDeclaration_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token string_literal31=null;
        AntlrCalcEngineParser.name_return name30 = null;

        AntlrCalcEngineParser.expression_return expression32 = null;


        CommonTree string_literal31_tree=null;
        RewriteRuleTokenStream stream_59=new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_name=new RewriteRuleSubtreeStream(adaptor,"rule name");
        try { dbg.enterRule(getGrammarFileName(), "relationshipJoinDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(116, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:2: ( name 'where' expression -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:4: name 'where' expression
            {
            dbg.location(117,4);
            pushFollow(FOLLOW_name_in_relationshipJoinDeclaration508);
            name30=name();

            state._fsp--;

            stream_name.add(name30.getTree());
            dbg.location(117,9);
            string_literal31=(Token)match(input,59,FOLLOW_59_in_relationshipJoinDeclaration510);  
            stream_59.add(string_literal31);

            dbg.location(117,17);
            pushFollow(FOLLOW_expression_in_relationshipJoinDeclaration512);
            expression32=expression();

            state._fsp--;

            stream_expression.add(expression32.getTree());


            // AST REWRITE
            // elements: name, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 117:28: -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) )
            {
                dbg.location(117,31);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:31: ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(117,34);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(JOIN, "JOIN"), root_1);

                dbg.location(117,39);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:39: ^( TARGET name )
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(117,42);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(TARGET, "TARGET"), root_2);

                dbg.location(117,49);
                adaptor.addChild(root_2, stream_name.nextTree());

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(117,56);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:117:56: ^( CRITERIA expression )
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(117,59);
                root_2 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(CRITERIA, "CRITERIA"), root_2);

                dbg.location(117,68);
                adaptor.addChild(root_2, stream_expression.nextTree());

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(118, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "relationshipJoinDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "relationshipJoinDeclaration"

    public static class formulaDeclaration_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "formulaDeclaration"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:125:1: formulaDeclaration : entityChainNoFilter assignmentOp expression ';' -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) ) ;
    public final AntlrCalcEngineParser.formulaDeclaration_return formulaDeclaration() throws RecognitionException {
        AntlrCalcEngineParser.formulaDeclaration_return retval = new AntlrCalcEngineParser.formulaDeclaration_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal36=null;
        AntlrCalcEngineParser.entityChainNoFilter_return entityChainNoFilter33 = null;

        AntlrCalcEngineParser.assignmentOp_return assignmentOp34 = null;

        AntlrCalcEngineParser.expression_return expression35 = null;


        CommonTree char_literal36_tree=null;
        RewriteRuleTokenStream stream_63=new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_entityChainNoFilter=new RewriteRuleSubtreeStream(adaptor,"rule entityChainNoFilter");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_assignmentOp=new RewriteRuleSubtreeStream(adaptor,"rule assignmentOp");
        try { dbg.enterRule(getGrammarFileName(), "formulaDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(125, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:2: ( entityChainNoFilter assignmentOp expression ';' -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:4: entityChainNoFilter assignmentOp expression ';'
            {
            dbg.location(126,4);
            pushFollow(FOLLOW_entityChainNoFilter_in_formulaDeclaration552);
            entityChainNoFilter33=entityChainNoFilter();

            state._fsp--;

            stream_entityChainNoFilter.add(entityChainNoFilter33.getTree());
            dbg.location(126,24);
            pushFollow(FOLLOW_assignmentOp_in_formulaDeclaration554);
            assignmentOp34=assignmentOp();

            state._fsp--;

            stream_assignmentOp.add(assignmentOp34.getTree());
            dbg.location(126,37);
            pushFollow(FOLLOW_expression_in_formulaDeclaration556);
            expression35=expression();

            state._fsp--;

            stream_expression.add(expression35.getTree());
            dbg.location(126,48);
            char_literal36=(Token)match(input,63,FOLLOW_63_in_formulaDeclaration558);  
            stream_63.add(char_literal36);



            // AST REWRITE
            // elements: assignmentOp, entityChainNoFilter, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 126:52: -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) )
            {
                dbg.location(126,55);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:55: ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(126,58);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(FORMULA, "FORMULA"), root_1);

                dbg.location(126,66);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:126:66: ^( assignmentOp entityChainNoFilter expression )
                {
                CommonTree root_2 = (CommonTree)adaptor.nil();
                dbg.location(126,69);
                root_2 = (CommonTree)adaptor.becomeRoot(stream_assignmentOp.nextNode(), root_2);

                dbg.location(126,82);
                adaptor.addChild(root_2, stream_entityChainNoFilter.nextTree());
                dbg.location(126,102);
                adaptor.addChild(root_2, stream_expression.nextTree());

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(127, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "formulaDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "formulaDeclaration"

    public static class expression_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expression"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:132:1: expression : orExpr ;
    public final AntlrCalcEngineParser.expression_return expression() throws RecognitionException {
        AntlrCalcEngineParser.expression_return retval = new AntlrCalcEngineParser.expression_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.orExpr_return orExpr37 = null;



        try { dbg.enterRule(getGrammarFileName(), "expression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(132, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:133:2: ( orExpr )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:133:4: orExpr
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(133,4);
            pushFollow(FOLLOW_orExpr_in_expression593);
            orExpr37=orExpr();

            state._fsp--;

            adaptor.addChild(root_0, orExpr37.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(134, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "expression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "expression"

    public static class orExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "orExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:135:1: orExpr : andExpr ( orOp andExpr )* ;
    public final AntlrCalcEngineParser.orExpr_return orExpr() throws RecognitionException {
        AntlrCalcEngineParser.orExpr_return retval = new AntlrCalcEngineParser.orExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.andExpr_return andExpr38 = null;

        AntlrCalcEngineParser.orOp_return orOp39 = null;

        AntlrCalcEngineParser.andExpr_return andExpr40 = null;



        try { dbg.enterRule(getGrammarFileName(), "orExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(135, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:2: ( andExpr ( orOp andExpr )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:4: andExpr ( orOp andExpr )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(136,4);
            pushFollow(FOLLOW_andExpr_in_orExpr603);
            andExpr38=andExpr();

            state._fsp--;

            adaptor.addChild(root_0, andExpr38.getTree());
            dbg.location(136,12);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:12: ( orOp andExpr )*
            try { dbg.enterSubRule(9);

            loop9:
            do {
                int alt9=2;
                try { dbg.enterDecision(9);

                int LA9_0 = input.LA(1);

                if ( ((LA9_0>=73 && LA9_0<=74)) ) {
                    alt9=1;
                }


                } finally {dbg.exitDecision(9);}

                switch (alt9) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:136:14: orOp andExpr
            	    {
            	    dbg.location(136,18);
            	    pushFollow(FOLLOW_orOp_in_orExpr607);
            	    orOp39=orOp();

            	    state._fsp--;

            	    root_0 = (CommonTree)adaptor.becomeRoot(orOp39.getTree(), root_0);
            	    dbg.location(136,20);
            	    pushFollow(FOLLOW_andExpr_in_orExpr610);
            	    andExpr40=andExpr();

            	    state._fsp--;

            	    adaptor.addChild(root_0, andExpr40.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
                }
            } while (true);
            } finally {dbg.exitSubRule(9);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(137, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "orExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "orExpr"

    public static class andExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "andExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:138:1: andExpr : equalityExpr ( andOp equalityExpr )* ;
    public final AntlrCalcEngineParser.andExpr_return andExpr() throws RecognitionException {
        AntlrCalcEngineParser.andExpr_return retval = new AntlrCalcEngineParser.andExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.equalityExpr_return equalityExpr41 = null;

        AntlrCalcEngineParser.andOp_return andOp42 = null;

        AntlrCalcEngineParser.equalityExpr_return equalityExpr43 = null;



        try { dbg.enterRule(getGrammarFileName(), "andExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(138, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:2: ( equalityExpr ( andOp equalityExpr )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:4: equalityExpr ( andOp equalityExpr )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(139,4);
            pushFollow(FOLLOW_equalityExpr_in_andExpr623);
            equalityExpr41=equalityExpr();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpr41.getTree());
            dbg.location(139,17);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:17: ( andOp equalityExpr )*
            try { dbg.enterSubRule(10);

            loop10:
            do {
                int alt10=2;
                try { dbg.enterDecision(10);

                int LA10_0 = input.LA(1);

                if ( ((LA10_0>=75 && LA10_0<=76)) ) {
                    alt10=1;
                }


                } finally {dbg.exitDecision(10);}

                switch (alt10) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:139:19: andOp equalityExpr
            	    {
            	    dbg.location(139,24);
            	    pushFollow(FOLLOW_andOp_in_andExpr627);
            	    andOp42=andOp();

            	    state._fsp--;

            	    root_0 = (CommonTree)adaptor.becomeRoot(andOp42.getTree(), root_0);
            	    dbg.location(139,26);
            	    pushFollow(FOLLOW_equalityExpr_in_andExpr630);
            	    equalityExpr43=equalityExpr();

            	    state._fsp--;

            	    adaptor.addChild(root_0, equalityExpr43.getTree());

            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);
            } finally {dbg.exitSubRule(10);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(140, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "andExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "andExpr"

    public static class equalityExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "equalityExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:141:1: equalityExpr : relationalExpr ( ( equalsOp | notEqualsOp ) relationalExpr )* ;
    public final AntlrCalcEngineParser.equalityExpr_return equalityExpr() throws RecognitionException {
        AntlrCalcEngineParser.equalityExpr_return retval = new AntlrCalcEngineParser.equalityExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.relationalExpr_return relationalExpr44 = null;

        AntlrCalcEngineParser.equalsOp_return equalsOp45 = null;

        AntlrCalcEngineParser.notEqualsOp_return notEqualsOp46 = null;

        AntlrCalcEngineParser.relationalExpr_return relationalExpr47 = null;



        try { dbg.enterRule(getGrammarFileName(), "equalityExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(141, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:2: ( relationalExpr ( ( equalsOp | notEqualsOp ) relationalExpr )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:4: relationalExpr ( ( equalsOp | notEqualsOp ) relationalExpr )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(142,4);
            pushFollow(FOLLOW_relationalExpr_in_equalityExpr644);
            relationalExpr44=relationalExpr();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpr44.getTree());
            dbg.location(142,19);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:19: ( ( equalsOp | notEqualsOp ) relationalExpr )*
            try { dbg.enterSubRule(12);

            loop12:
            do {
                int alt12=2;
                try { dbg.enterDecision(12);

                int LA12_0 = input.LA(1);

                if ( (LA12_0==68||(LA12_0>=79 && LA12_0<=81)) ) {
                    alt12=1;
                }


                } finally {dbg.exitDecision(12);}

                switch (alt12) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:21: ( equalsOp | notEqualsOp ) relationalExpr
            	    {
            	    dbg.location(142,21);
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:21: ( equalsOp | notEqualsOp )
            	    int alt11=2;
            	    try { dbg.enterSubRule(11);
            	    try { dbg.enterDecision(11);

            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0==68||LA11_0==79) ) {
            	        alt11=1;
            	    }
            	    else if ( ((LA11_0>=80 && LA11_0<=81)) ) {
            	        alt11=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 11, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(11);}

            	    switch (alt11) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:23: equalsOp
            	            {
            	            dbg.location(142,31);
            	            pushFollow(FOLLOW_equalsOp_in_equalityExpr650);
            	            equalsOp45=equalsOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(equalsOp45.getTree(), root_0);

            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:142:35: notEqualsOp
            	            {
            	            dbg.location(142,46);
            	            pushFollow(FOLLOW_notEqualsOp_in_equalityExpr655);
            	            notEqualsOp46=notEqualsOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(notEqualsOp46.getTree(), root_0);

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(11);}

            	    dbg.location(142,50);
            	    pushFollow(FOLLOW_relationalExpr_in_equalityExpr660);
            	    relationalExpr47=relationalExpr();

            	    state._fsp--;

            	    adaptor.addChild(root_0, relationalExpr47.getTree());

            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);
            } finally {dbg.exitSubRule(12);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(143, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "equalityExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "equalityExpr"

    public static class relationalExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "relationalExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:144:1: relationalExpr : additiveExpr ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )* ;
    public final AntlrCalcEngineParser.relationalExpr_return relationalExpr() throws RecognitionException {
        AntlrCalcEngineParser.relationalExpr_return retval = new AntlrCalcEngineParser.relationalExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.additiveExpr_return additiveExpr48 = null;

        AntlrCalcEngineParser.ltOp_return ltOp49 = null;

        AntlrCalcEngineParser.gtOp_return gtOp50 = null;

        AntlrCalcEngineParser.lteOp_return lteOp51 = null;

        AntlrCalcEngineParser.gteOp_return gteOp52 = null;

        AntlrCalcEngineParser.additiveExpr_return additiveExpr53 = null;



        try { dbg.enterRule(getGrammarFileName(), "relationalExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(144, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:2: ( additiveExpr ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:4: additiveExpr ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(145,4);
            pushFollow(FOLLOW_additiveExpr_in_relationalExpr673);
            additiveExpr48=additiveExpr();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpr48.getTree());
            dbg.location(145,17);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:17: ( ( ltOp | gtOp | lteOp | gteOp ) additiveExpr )*
            try { dbg.enterSubRule(14);

            loop14:
            do {
                int alt14=2;
                try { dbg.enterDecision(14);

                int LA14_0 = input.LA(1);

                if ( ((LA14_0>=82 && LA14_0<=85)) ) {
                    alt14=1;
                }


                } finally {dbg.exitDecision(14);}

                switch (alt14) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:19: ( ltOp | gtOp | lteOp | gteOp ) additiveExpr
            	    {
            	    dbg.location(145,19);
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:19: ( ltOp | gtOp | lteOp | gteOp )
            	    int alt13=4;
            	    try { dbg.enterSubRule(13);
            	    try { dbg.enterDecision(13);

            	    switch ( input.LA(1) ) {
            	    case 82:
            	        {
            	        alt13=1;
            	        }
            	        break;
            	    case 83:
            	        {
            	        alt13=2;
            	        }
            	        break;
            	    case 84:
            	        {
            	        alt13=3;
            	        }
            	        break;
            	    case 85:
            	        {
            	        alt13=4;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 13, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(13);}

            	    switch (alt13) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:21: ltOp
            	            {
            	            dbg.location(145,25);
            	            pushFollow(FOLLOW_ltOp_in_relationalExpr679);
            	            ltOp49=ltOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(ltOp49.getTree(), root_0);

            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:29: gtOp
            	            {
            	            dbg.location(145,33);
            	            pushFollow(FOLLOW_gtOp_in_relationalExpr684);
            	            gtOp50=gtOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(gtOp50.getTree(), root_0);

            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:37: lteOp
            	            {
            	            dbg.location(145,42);
            	            pushFollow(FOLLOW_lteOp_in_relationalExpr689);
            	            lteOp51=lteOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(lteOp51.getTree(), root_0);

            	            }
            	            break;
            	        case 4 :
            	            dbg.enterAlt(4);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:145:46: gteOp
            	            {
            	            dbg.location(145,51);
            	            pushFollow(FOLLOW_gteOp_in_relationalExpr694);
            	            gteOp52=gteOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(gteOp52.getTree(), root_0);

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(13);}

            	    dbg.location(145,55);
            	    pushFollow(FOLLOW_additiveExpr_in_relationalExpr699);
            	    additiveExpr53=additiveExpr();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpr53.getTree());

            	    }
            	    break;

            	default :
            	    break loop14;
                }
            } while (true);
            } finally {dbg.exitSubRule(14);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(146, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "relationalExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "relationalExpr"

    public static class additiveExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "additiveExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:147:1: additiveExpr : multiplicativeExpr ( ( addOp | subtractOp ) multiplicativeExpr )* ;
    public final AntlrCalcEngineParser.additiveExpr_return additiveExpr() throws RecognitionException {
        AntlrCalcEngineParser.additiveExpr_return retval = new AntlrCalcEngineParser.additiveExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.multiplicativeExpr_return multiplicativeExpr54 = null;

        AntlrCalcEngineParser.addOp_return addOp55 = null;

        AntlrCalcEngineParser.subtractOp_return subtractOp56 = null;

        AntlrCalcEngineParser.multiplicativeExpr_return multiplicativeExpr57 = null;



        try { dbg.enterRule(getGrammarFileName(), "additiveExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(147, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:2: ( multiplicativeExpr ( ( addOp | subtractOp ) multiplicativeExpr )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:4: multiplicativeExpr ( ( addOp | subtractOp ) multiplicativeExpr )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(148,4);
            pushFollow(FOLLOW_multiplicativeExpr_in_additiveExpr713);
            multiplicativeExpr54=multiplicativeExpr();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpr54.getTree());
            dbg.location(148,23);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:23: ( ( addOp | subtractOp ) multiplicativeExpr )*
            try { dbg.enterSubRule(16);

            loop16:
            do {
                int alt16=2;
                try { dbg.enterDecision(16);

                int LA16_0 = input.LA(1);

                if ( ((LA16_0>=86 && LA16_0<=87)) ) {
                    alt16=1;
                }


                } finally {dbg.exitDecision(16);}

                switch (alt16) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:25: ( addOp | subtractOp ) multiplicativeExpr
            	    {
            	    dbg.location(148,25);
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:25: ( addOp | subtractOp )
            	    int alt15=2;
            	    try { dbg.enterSubRule(15);
            	    try { dbg.enterDecision(15);

            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0==86) ) {
            	        alt15=1;
            	    }
            	    else if ( (LA15_0==87) ) {
            	        alt15=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 15, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(15);}

            	    switch (alt15) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:27: addOp
            	            {
            	            dbg.location(148,32);
            	            pushFollow(FOLLOW_addOp_in_additiveExpr719);
            	            addOp55=addOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(addOp55.getTree(), root_0);

            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:148:36: subtractOp
            	            {
            	            dbg.location(148,46);
            	            pushFollow(FOLLOW_subtractOp_in_additiveExpr724);
            	            subtractOp56=subtractOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(subtractOp56.getTree(), root_0);

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(15);}

            	    dbg.location(148,50);
            	    pushFollow(FOLLOW_multiplicativeExpr_in_additiveExpr729);
            	    multiplicativeExpr57=multiplicativeExpr();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpr57.getTree());

            	    }
            	    break;

            	default :
            	    break loop16;
                }
            } while (true);
            } finally {dbg.exitSubRule(16);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(149, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "additiveExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "additiveExpr"

    public static class multiplicativeExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "multiplicativeExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:150:1: multiplicativeExpr : unaryExpr ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )* ;
    public final AntlrCalcEngineParser.multiplicativeExpr_return multiplicativeExpr() throws RecognitionException {
        AntlrCalcEngineParser.multiplicativeExpr_return retval = new AntlrCalcEngineParser.multiplicativeExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.unaryExpr_return unaryExpr58 = null;

        AntlrCalcEngineParser.multiplyOp_return multiplyOp59 = null;

        AntlrCalcEngineParser.divideOp_return divideOp60 = null;

        AntlrCalcEngineParser.modulusOp_return modulusOp61 = null;

        AntlrCalcEngineParser.unaryExpr_return unaryExpr62 = null;



        try { dbg.enterRule(getGrammarFileName(), "multiplicativeExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(150, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:2: ( unaryExpr ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:4: unaryExpr ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(151,4);
            pushFollow(FOLLOW_unaryExpr_in_multiplicativeExpr743);
            unaryExpr58=unaryExpr();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpr58.getTree());
            dbg.location(151,14);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:14: ( ( multiplyOp | divideOp | modulusOp ) unaryExpr )*
            try { dbg.enterSubRule(18);

            loop18:
            do {
                int alt18=2;
                try { dbg.enterDecision(18);

                int LA18_0 = input.LA(1);

                if ( ((LA18_0>=77 && LA18_0<=78)||(LA18_0>=88 && LA18_0<=89)) ) {
                    alt18=1;
                }


                } finally {dbg.exitDecision(18);}

                switch (alt18) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:16: ( multiplyOp | divideOp | modulusOp ) unaryExpr
            	    {
            	    dbg.location(151,16);
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:16: ( multiplyOp | divideOp | modulusOp )
            	    int alt17=3;
            	    try { dbg.enterSubRule(17);
            	    try { dbg.enterDecision(17);

            	    switch ( input.LA(1) ) {
            	    case 88:
            	        {
            	        alt17=1;
            	        }
            	        break;
            	    case 89:
            	        {
            	        alt17=2;
            	        }
            	        break;
            	    case 77:
            	    case 78:
            	        {
            	        alt17=3;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 17, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(17);}

            	    switch (alt17) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:18: multiplyOp
            	            {
            	            dbg.location(151,28);
            	            pushFollow(FOLLOW_multiplyOp_in_multiplicativeExpr749);
            	            multiplyOp59=multiplyOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(multiplyOp59.getTree(), root_0);

            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:32: divideOp
            	            {
            	            dbg.location(151,40);
            	            pushFollow(FOLLOW_divideOp_in_multiplicativeExpr754);
            	            divideOp60=divideOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(divideOp60.getTree(), root_0);

            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:151:44: modulusOp
            	            {
            	            dbg.location(151,53);
            	            pushFollow(FOLLOW_modulusOp_in_multiplicativeExpr759);
            	            modulusOp61=modulusOp();

            	            state._fsp--;

            	            root_0 = (CommonTree)adaptor.becomeRoot(modulusOp61.getTree(), root_0);

            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(17);}

            	    dbg.location(151,57);
            	    pushFollow(FOLLOW_unaryExpr_in_multiplicativeExpr764);
            	    unaryExpr62=unaryExpr();

            	    state._fsp--;

            	    adaptor.addChild(root_0, unaryExpr62.getTree());

            	    }
            	    break;

            	default :
            	    break loop18;
                }
            } while (true);
            } finally {dbg.exitSubRule(18);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(152, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "multiplicativeExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "multiplicativeExpr"

    public static class unaryExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unaryExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:153:1: unaryExpr : ( unaryNegationOp )? negationExpr ;
    public final AntlrCalcEngineParser.unaryExpr_return unaryExpr() throws RecognitionException {
        AntlrCalcEngineParser.unaryExpr_return retval = new AntlrCalcEngineParser.unaryExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.unaryNegationOp_return unaryNegationOp63 = null;

        AntlrCalcEngineParser.negationExpr_return negationExpr64 = null;



        try { dbg.enterRule(getGrammarFileName(), "unaryExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(153, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:2: ( ( unaryNegationOp )? negationExpr )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:4: ( unaryNegationOp )? negationExpr
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(154,19);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:19: ( unaryNegationOp )?
            int alt19=2;
            try { dbg.enterSubRule(19);
            try { dbg.enterDecision(19);

            int LA19_0 = input.LA(1);

            if ( (LA19_0==87) ) {
                alt19=1;
            }
            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:154:19: unaryNegationOp
                    {
                    dbg.location(154,19);
                    pushFollow(FOLLOW_unaryNegationOp_in_unaryExpr779);
                    unaryNegationOp63=unaryNegationOp();

                    state._fsp--;

                    root_0 = (CommonTree)adaptor.becomeRoot(unaryNegationOp63.getTree(), root_0);

                    }
                    break;

            }
            } finally {dbg.exitSubRule(19);}

            dbg.location(154,22);
            pushFollow(FOLLOW_negationExpr_in_unaryExpr783);
            negationExpr64=negationExpr();

            state._fsp--;

            adaptor.addChild(root_0, negationExpr64.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(155, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "unaryExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "unaryExpr"

    public static class negationExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "negationExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:156:1: negationExpr : ( notOp )* primaryExpr ;
    public final AntlrCalcEngineParser.negationExpr_return negationExpr() throws RecognitionException {
        AntlrCalcEngineParser.negationExpr_return retval = new AntlrCalcEngineParser.negationExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.notOp_return notOp65 = null;

        AntlrCalcEngineParser.primaryExpr_return primaryExpr66 = null;



        try { dbg.enterRule(getGrammarFileName(), "negationExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(156, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:2: ( ( notOp )* primaryExpr )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:4: ( notOp )* primaryExpr
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(157,4);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:4: ( notOp )*
            try { dbg.enterSubRule(20);

            loop20:
            do {
                int alt20=2;
                try { dbg.enterDecision(20);

                int LA20_0 = input.LA(1);

                if ( ((LA20_0>=71 && LA20_0<=72)) ) {
                    alt20=1;
                }


                } finally {dbg.exitDecision(20);}

                switch (alt20) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:157:6: notOp
            	    {
            	    dbg.location(157,11);
            	    pushFollow(FOLLOW_notOp_in_negationExpr796);
            	    notOp65=notOp();

            	    state._fsp--;

            	    root_0 = (CommonTree)adaptor.becomeRoot(notOp65.getTree(), root_0);

            	    }
            	    break;

            	default :
            	    break loop20;
                }
            } while (true);
            } finally {dbg.exitSubRule(20);}

            dbg.location(157,16);
            pushFollow(FOLLOW_primaryExpr_in_negationExpr802);
            primaryExpr66=primaryExpr();

            state._fsp--;

            adaptor.addChild(root_0, primaryExpr66.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(158, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "negationExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "negationExpr"

    public static class primaryExpr_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "primaryExpr"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:159:1: primaryExpr : ( '(' expression ')' | number | booleanValue | LITERAL | functionCall | entityChain );
    public final AntlrCalcEngineParser.primaryExpr_return primaryExpr() throws RecognitionException {
        AntlrCalcEngineParser.primaryExpr_return retval = new AntlrCalcEngineParser.primaryExpr_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal67=null;
        Token char_literal69=null;
        Token LITERAL72=null;
        AntlrCalcEngineParser.expression_return expression68 = null;

        AntlrCalcEngineParser.number_return number70 = null;

        AntlrCalcEngineParser.booleanValue_return booleanValue71 = null;

        AntlrCalcEngineParser.functionCall_return functionCall73 = null;

        AntlrCalcEngineParser.entityChain_return entityChain74 = null;


        CommonTree char_literal67_tree=null;
        CommonTree char_literal69_tree=null;
        CommonTree LITERAL72_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "primaryExpr");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(159, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:160:2: ( '(' expression ')' | number | booleanValue | LITERAL | functionCall | entityChain )
            int alt21=6;
            try { dbg.enterDecision(21);

            switch ( input.LA(1) ) {
            case 69:
                {
                alt21=1;
                }
                break;
            case INT:
            case FLOAT:
                {
                alt21=2;
                }
                break;
            case 95:
            case 96:
                {
                alt21=3;
                }
                break;
            case LITERAL:
                {
                alt21=4;
                }
                break;
            case ID:
                {
                int LA21_5 = input.LA(2);

                if ( (LA21_5==69) ) {
                    alt21=5;
                }
                else if ( (LA21_5==60||LA21_5==63||LA21_5==68||LA21_5==70||(LA21_5>=73 && LA21_5<=90)||(LA21_5>=92 && LA21_5<=94)) ) {
                    alt21=6;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 21, 5, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                }
                break;
            case 91:
                {
                alt21=6;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 21, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(21);}

            switch (alt21) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:160:4: '(' expression ')'
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(160,7);
                    char_literal67=(Token)match(input,69,FOLLOW_69_in_primaryExpr813); 
                    dbg.location(160,9);
                    pushFollow(FOLLOW_expression_in_primaryExpr816);
                    expression68=expression();

                    state._fsp--;

                    adaptor.addChild(root_0, expression68.getTree());
                    dbg.location(160,23);
                    char_literal69=(Token)match(input,70,FOLLOW_70_in_primaryExpr818); 

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:161:4: number
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(161,4);
                    pushFollow(FOLLOW_number_in_primaryExpr824);
                    number70=number();

                    state._fsp--;

                    adaptor.addChild(root_0, number70.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:162:4: booleanValue
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(162,4);
                    pushFollow(FOLLOW_booleanValue_in_primaryExpr829);
                    booleanValue71=booleanValue();

                    state._fsp--;

                    adaptor.addChild(root_0, booleanValue71.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:163:4: LITERAL
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(163,4);
                    LITERAL72=(Token)match(input,LITERAL,FOLLOW_LITERAL_in_primaryExpr834); 
                    LITERAL72_tree = (CommonTree)adaptor.create(LITERAL72);
                    adaptor.addChild(root_0, LITERAL72_tree);


                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:164:4: functionCall
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(164,4);
                    pushFollow(FOLLOW_functionCall_in_primaryExpr839);
                    functionCall73=functionCall();

                    state._fsp--;

                    adaptor.addChild(root_0, functionCall73.getTree());

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:165:4: entityChain
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    dbg.location(165,4);
                    pushFollow(FOLLOW_entityChain_in_primaryExpr844);
                    entityChain74=entityChain();

                    state._fsp--;

                    adaptor.addChild(root_0, entityChain74.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(166, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "primaryExpr");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "primaryExpr"

    public static class notOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "notOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:173:1: notOp : (x= 'not' -> OP_NOT[$x] | x= '!' -> OP_NOT[$x] );
    public final AntlrCalcEngineParser.notOp_return notOp() throws RecognitionException {
        AntlrCalcEngineParser.notOp_return retval = new AntlrCalcEngineParser.notOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_71=new RewriteRuleTokenStream(adaptor,"token 71");
        RewriteRuleTokenStream stream_72=new RewriteRuleTokenStream(adaptor,"token 72");

        try { dbg.enterRule(getGrammarFileName(), "notOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(173, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:174:2: (x= 'not' -> OP_NOT[$x] | x= '!' -> OP_NOT[$x] )
            int alt22=2;
            try { dbg.enterDecision(22);

            int LA22_0 = input.LA(1);

            if ( (LA22_0==71) ) {
                alt22=1;
            }
            else if ( (LA22_0==72) ) {
                alt22=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 22, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(22);}

            switch (alt22) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:174:4: x= 'not'
                    {
                    dbg.location(174,5);
                    x=(Token)match(input,71,FOLLOW_71_in_notOp862);  
                    stream_71.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 174:12: -> OP_NOT[$x]
                    {
                        dbg.location(174,15);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_NOT, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:175:4: x= '!'
                    {
                    dbg.location(175,5);
                    x=(Token)match(input,72,FOLLOW_72_in_notOp874);  
                    stream_72.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 175:10: -> OP_NOT[$x]
                    {
                        dbg.location(175,13);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_NOT, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(176, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "notOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "notOp"

    public static class orOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "orOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:177:1: orOp : (x= 'or' -> OP_OR[$x] | x= '||' -> OP_OR[$x] );
    public final AntlrCalcEngineParser.orOp_return orOp() throws RecognitionException {
        AntlrCalcEngineParser.orOp_return retval = new AntlrCalcEngineParser.orOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_73=new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");

        try { dbg.enterRule(getGrammarFileName(), "orOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(177, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:178:2: (x= 'or' -> OP_OR[$x] | x= '||' -> OP_OR[$x] )
            int alt23=2;
            try { dbg.enterDecision(23);

            int LA23_0 = input.LA(1);

            if ( (LA23_0==73) ) {
                alt23=1;
            }
            else if ( (LA23_0==74) ) {
                alt23=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 23, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(23);}

            switch (alt23) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:178:4: x= 'or'
                    {
                    dbg.location(178,5);
                    x=(Token)match(input,73,FOLLOW_73_in_orOp892);  
                    stream_73.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 178:11: -> OP_OR[$x]
                    {
                        dbg.location(178,14);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_OR, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:179:4: x= '||'
                    {
                    dbg.location(179,5);
                    x=(Token)match(input,74,FOLLOW_74_in_orOp904);  
                    stream_74.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 179:11: -> OP_OR[$x]
                    {
                        dbg.location(179,14);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_OR, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(180, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "orOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "orOp"

    public static class andOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "andOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:181:1: andOp : (x= 'and' -> OP_AND[$x] | x= '&&' -> OP_AND[$x] );
    public final AntlrCalcEngineParser.andOp_return andOp() throws RecognitionException {
        AntlrCalcEngineParser.andOp_return retval = new AntlrCalcEngineParser.andOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_75=new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_76=new RewriteRuleTokenStream(adaptor,"token 76");

        try { dbg.enterRule(getGrammarFileName(), "andOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(181, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:182:2: (x= 'and' -> OP_AND[$x] | x= '&&' -> OP_AND[$x] )
            int alt24=2;
            try { dbg.enterDecision(24);

            int LA24_0 = input.LA(1);

            if ( (LA24_0==75) ) {
                alt24=1;
            }
            else if ( (LA24_0==76) ) {
                alt24=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 24, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(24);}

            switch (alt24) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:182:4: x= 'and'
                    {
                    dbg.location(182,5);
                    x=(Token)match(input,75,FOLLOW_75_in_andOp921);  
                    stream_75.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 182:12: -> OP_AND[$x]
                    {
                        dbg.location(182,15);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_AND, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:183:4: x= '&&'
                    {
                    dbg.location(183,5);
                    x=(Token)match(input,76,FOLLOW_76_in_andOp933);  
                    stream_76.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 183:12: -> OP_AND[$x]
                    {
                        dbg.location(183,15);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_AND, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(184, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "andOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "andOp"

    public static class modulusOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "modulusOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:185:1: modulusOp : (x= 'mod' -> OP_MODULUS[$x] | x= '%' -> OP_MODULUS[$x] );
    public final AntlrCalcEngineParser.modulusOp_return modulusOp() throws RecognitionException {
        AntlrCalcEngineParser.modulusOp_return retval = new AntlrCalcEngineParser.modulusOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_78=new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_77=new RewriteRuleTokenStream(adaptor,"token 77");

        try { dbg.enterRule(getGrammarFileName(), "modulusOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(185, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:186:2: (x= 'mod' -> OP_MODULUS[$x] | x= '%' -> OP_MODULUS[$x] )
            int alt25=2;
            try { dbg.enterDecision(25);

            int LA25_0 = input.LA(1);

            if ( (LA25_0==77) ) {
                alt25=1;
            }
            else if ( (LA25_0==78) ) {
                alt25=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 25, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(25);}

            switch (alt25) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:186:4: x= 'mod'
                    {
                    dbg.location(186,5);
                    x=(Token)match(input,77,FOLLOW_77_in_modulusOp951);  
                    stream_77.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 186:12: -> OP_MODULUS[$x]
                    {
                        dbg.location(186,15);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_MODULUS, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:187:4: x= '%'
                    {
                    dbg.location(187,5);
                    x=(Token)match(input,78,FOLLOW_78_in_modulusOp963);  
                    stream_78.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 187:12: -> OP_MODULUS[$x]
                    {
                        dbg.location(187,15);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_MODULUS, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(188, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "modulusOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "modulusOp"

    public static class equalsOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "equalsOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:189:1: equalsOp : (x= '==' -> OP_EQ[$x] | x= '=' -> OP_EQ[$x] );
    public final AntlrCalcEngineParser.equalsOp_return equalsOp() throws RecognitionException {
        AntlrCalcEngineParser.equalsOp_return retval = new AntlrCalcEngineParser.equalsOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_79=new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");

        try { dbg.enterRule(getGrammarFileName(), "equalsOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(189, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:190:2: (x= '==' -> OP_EQ[$x] | x= '=' -> OP_EQ[$x] )
            int alt26=2;
            try { dbg.enterDecision(26);

            int LA26_0 = input.LA(1);

            if ( (LA26_0==79) ) {
                alt26=1;
            }
            else if ( (LA26_0==68) ) {
                alt26=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 26, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(26);}

            switch (alt26) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:190:4: x= '=='
                    {
                    dbg.location(190,5);
                    x=(Token)match(input,79,FOLLOW_79_in_equalsOp982);  
                    stream_79.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 190:11: -> OP_EQ[$x]
                    {
                        dbg.location(190,14);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_EQ, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:191:4: x= '='
                    {
                    dbg.location(191,5);
                    x=(Token)match(input,68,FOLLOW_68_in_equalsOp995);  
                    stream_68.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 191:11: -> OP_EQ[$x]
                    {
                        dbg.location(191,14);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_EQ, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(192, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "equalsOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "equalsOp"

    public static class notEqualsOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "notEqualsOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:193:1: notEqualsOp : (x= '!=' -> OP_NE[$x] | x= '<>' -> OP_NE[$x] );
    public final AntlrCalcEngineParser.notEqualsOp_return notEqualsOp() throws RecognitionException {
        AntlrCalcEngineParser.notEqualsOp_return retval = new AntlrCalcEngineParser.notEqualsOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_80=new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81=new RewriteRuleTokenStream(adaptor,"token 81");

        try { dbg.enterRule(getGrammarFileName(), "notEqualsOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(193, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:194:2: (x= '!=' -> OP_NE[$x] | x= '<>' -> OP_NE[$x] )
            int alt27=2;
            try { dbg.enterDecision(27);

            int LA27_0 = input.LA(1);

            if ( (LA27_0==80) ) {
                alt27=1;
            }
            else if ( (LA27_0==81) ) {
                alt27=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 27, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(27);}

            switch (alt27) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:194:4: x= '!='
                    {
                    dbg.location(194,5);
                    x=(Token)match(input,80,FOLLOW_80_in_notEqualsOp1013);  
                    stream_80.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 194:11: -> OP_NE[$x]
                    {
                        dbg.location(194,14);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_NE, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:195:4: x= '<>'
                    {
                    dbg.location(195,5);
                    x=(Token)match(input,81,FOLLOW_81_in_notEqualsOp1025);  
                    stream_81.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 195:11: -> OP_NE[$x]
                    {
                        dbg.location(195,14);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_NE, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(196, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "notEqualsOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "notEqualsOp"

    public static class ltOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "ltOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:197:1: ltOp : x= '<' -> OP_LT[$x] ;
    public final AntlrCalcEngineParser.ltOp_return ltOp() throws RecognitionException {
        AntlrCalcEngineParser.ltOp_return retval = new AntlrCalcEngineParser.ltOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_82=new RewriteRuleTokenStream(adaptor,"token 82");

        try { dbg.enterRule(getGrammarFileName(), "ltOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(197, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:198:2: (x= '<' -> OP_LT[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:198:4: x= '<'
            {
            dbg.location(198,5);
            x=(Token)match(input,82,FOLLOW_82_in_ltOp1042);  
            stream_82.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 198:10: -> OP_LT[$x]
            {
                dbg.location(198,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_LT, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(199, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "ltOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "ltOp"

    public static class gtOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "gtOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:200:1: gtOp : x= '>' -> OP_GT[$x] ;
    public final AntlrCalcEngineParser.gtOp_return gtOp() throws RecognitionException {
        AntlrCalcEngineParser.gtOp_return retval = new AntlrCalcEngineParser.gtOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_83=new RewriteRuleTokenStream(adaptor,"token 83");

        try { dbg.enterRule(getGrammarFileName(), "gtOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:201:2: (x= '>' -> OP_GT[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:201:4: x= '>'
            {
            dbg.location(201,5);
            x=(Token)match(input,83,FOLLOW_83_in_gtOp1059);  
            stream_83.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 201:10: -> OP_GT[$x]
            {
                dbg.location(201,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_GT, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(202, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "gtOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "gtOp"

    public static class lteOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "lteOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:203:1: lteOp : x= '<=' -> OP_LTE[$x] ;
    public final AntlrCalcEngineParser.lteOp_return lteOp() throws RecognitionException {
        AntlrCalcEngineParser.lteOp_return retval = new AntlrCalcEngineParser.lteOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_84=new RewriteRuleTokenStream(adaptor,"token 84");

        try { dbg.enterRule(getGrammarFileName(), "lteOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(203, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:204:2: (x= '<=' -> OP_LTE[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:204:4: x= '<='
            {
            dbg.location(204,5);
            x=(Token)match(input,84,FOLLOW_84_in_lteOp1076);  
            stream_84.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 204:11: -> OP_LTE[$x]
            {
                dbg.location(204,14);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_LTE, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(205, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "lteOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "lteOp"

    public static class gteOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "gteOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:206:1: gteOp : x= '>=' -> OP_GTE[$x] ;
    public final AntlrCalcEngineParser.gteOp_return gteOp() throws RecognitionException {
        AntlrCalcEngineParser.gteOp_return retval = new AntlrCalcEngineParser.gteOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_85=new RewriteRuleTokenStream(adaptor,"token 85");

        try { dbg.enterRule(getGrammarFileName(), "gteOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(206, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:207:2: (x= '>=' -> OP_GTE[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:207:4: x= '>='
            {
            dbg.location(207,5);
            x=(Token)match(input,85,FOLLOW_85_in_gteOp1093);  
            stream_85.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 207:11: -> OP_GTE[$x]
            {
                dbg.location(207,14);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_GTE, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(208, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "gteOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "gteOp"

    public static class addOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "addOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:209:1: addOp : x= '+' -> OP_ADD[$x] ;
    public final AntlrCalcEngineParser.addOp_return addOp() throws RecognitionException {
        AntlrCalcEngineParser.addOp_return retval = new AntlrCalcEngineParser.addOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_86=new RewriteRuleTokenStream(adaptor,"token 86");

        try { dbg.enterRule(getGrammarFileName(), "addOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(209, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:210:2: (x= '+' -> OP_ADD[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:210:4: x= '+'
            {
            dbg.location(210,5);
            x=(Token)match(input,86,FOLLOW_86_in_addOp1110);  
            stream_86.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 210:10: -> OP_ADD[$x]
            {
                dbg.location(210,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_ADD, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(211, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "addOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "addOp"

    public static class subtractOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "subtractOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:212:1: subtractOp : x= '-' -> OP_SUBTRACT[$x] ;
    public final AntlrCalcEngineParser.subtractOp_return subtractOp() throws RecognitionException {
        AntlrCalcEngineParser.subtractOp_return retval = new AntlrCalcEngineParser.subtractOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_87=new RewriteRuleTokenStream(adaptor,"token 87");

        try { dbg.enterRule(getGrammarFileName(), "subtractOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(212, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:213:2: (x= '-' -> OP_SUBTRACT[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:213:4: x= '-'
            {
            dbg.location(213,5);
            x=(Token)match(input,87,FOLLOW_87_in_subtractOp1127);  
            stream_87.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 213:10: -> OP_SUBTRACT[$x]
            {
                dbg.location(213,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_SUBTRACT, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(214, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "subtractOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "subtractOp"

    public static class multiplyOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "multiplyOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:215:1: multiplyOp : x= '*' -> OP_MULTIPLY[$x] ;
    public final AntlrCalcEngineParser.multiplyOp_return multiplyOp() throws RecognitionException {
        AntlrCalcEngineParser.multiplyOp_return retval = new AntlrCalcEngineParser.multiplyOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_88=new RewriteRuleTokenStream(adaptor,"token 88");

        try { dbg.enterRule(getGrammarFileName(), "multiplyOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(215, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:216:2: (x= '*' -> OP_MULTIPLY[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:216:4: x= '*'
            {
            dbg.location(216,5);
            x=(Token)match(input,88,FOLLOW_88_in_multiplyOp1144);  
            stream_88.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 216:10: -> OP_MULTIPLY[$x]
            {
                dbg.location(216,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_MULTIPLY, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(217, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "multiplyOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "multiplyOp"

    public static class divideOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "divideOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:218:1: divideOp : x= '/' -> OP_DIVIDE[$x] ;
    public final AntlrCalcEngineParser.divideOp_return divideOp() throws RecognitionException {
        AntlrCalcEngineParser.divideOp_return retval = new AntlrCalcEngineParser.divideOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_89=new RewriteRuleTokenStream(adaptor,"token 89");

        try { dbg.enterRule(getGrammarFileName(), "divideOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(218, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:219:2: (x= '/' -> OP_DIVIDE[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:219:4: x= '/'
            {
            dbg.location(219,5);
            x=(Token)match(input,89,FOLLOW_89_in_divideOp1161);  
            stream_89.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 219:10: -> OP_DIVIDE[$x]
            {
                dbg.location(219,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_DIVIDE, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(220, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "divideOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "divideOp"

    public static class unaryNegationOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unaryNegationOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:221:1: unaryNegationOp : x= '-' -> OP_UNARY_NEGATION[$x] ;
    public final AntlrCalcEngineParser.unaryNegationOp_return unaryNegationOp() throws RecognitionException {
        AntlrCalcEngineParser.unaryNegationOp_return retval = new AntlrCalcEngineParser.unaryNegationOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_87=new RewriteRuleTokenStream(adaptor,"token 87");

        try { dbg.enterRule(getGrammarFileName(), "unaryNegationOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(221, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:222:2: (x= '-' -> OP_UNARY_NEGATION[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:222:4: x= '-'
            {
            dbg.location(222,5);
            x=(Token)match(input,87,FOLLOW_87_in_unaryNegationOp1178);  
            stream_87.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 222:10: -> OP_UNARY_NEGATION[$x]
            {
                dbg.location(222,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_UNARY_NEGATION, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(223, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "unaryNegationOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "unaryNegationOp"

    public static class assignmentOp_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "assignmentOp"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:224:1: assignmentOp : x= '=' -> OP_ASSIGN[$x] ;
    public final AntlrCalcEngineParser.assignmentOp_return assignmentOp() throws RecognitionException {
        AntlrCalcEngineParser.assignmentOp_return retval = new AntlrCalcEngineParser.assignmentOp_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_68=new RewriteRuleTokenStream(adaptor,"token 68");

        try { dbg.enterRule(getGrammarFileName(), "assignmentOp");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(224, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:225:2: (x= '=' -> OP_ASSIGN[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:225:4: x= '='
            {
            dbg.location(225,5);
            x=(Token)match(input,68,FOLLOW_68_in_assignmentOp1195);  
            stream_68.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 225:10: -> OP_ASSIGN[$x]
            {
                dbg.location(225,13);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(OP_ASSIGN, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(226, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "assignmentOp");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "assignmentOp"

    public static class entityChain_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "entityChain"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:232:1: entityChain : ( thisKeyword | filteredEntity ) ( '.' filteredEntity )* ;
    public final AntlrCalcEngineParser.entityChain_return entityChain() throws RecognitionException {
        AntlrCalcEngineParser.entityChain_return retval = new AntlrCalcEngineParser.entityChain_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal77=null;
        AntlrCalcEngineParser.thisKeyword_return thisKeyword75 = null;

        AntlrCalcEngineParser.filteredEntity_return filteredEntity76 = null;

        AntlrCalcEngineParser.filteredEntity_return filteredEntity78 = null;


        CommonTree char_literal77_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "entityChain");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(232, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:2: ( ( thisKeyword | filteredEntity ) ( '.' filteredEntity )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:5: ( thisKeyword | filteredEntity ) ( '.' filteredEntity )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(233,5);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:5: ( thisKeyword | filteredEntity )
            int alt28=2;
            try { dbg.enterSubRule(28);
            try { dbg.enterDecision(28);

            int LA28_0 = input.LA(1);

            if ( (LA28_0==91) ) {
                alt28=1;
            }
            else if ( (LA28_0==ID) ) {
                alt28=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 28, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(28);}

            switch (alt28) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:7: thisKeyword
                    {
                    dbg.location(233,7);
                    pushFollow(FOLLOW_thisKeyword_in_entityChain1218);
                    thisKeyword75=thisKeyword();

                    state._fsp--;

                    adaptor.addChild(root_0, thisKeyword75.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:21: filteredEntity
                    {
                    dbg.location(233,21);
                    pushFollow(FOLLOW_filteredEntity_in_entityChain1222);
                    filteredEntity76=filteredEntity();

                    state._fsp--;

                    adaptor.addChild(root_0, filteredEntity76.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(28);}

            dbg.location(233,38);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:38: ( '.' filteredEntity )*
            try { dbg.enterSubRule(29);

            loop29:
            do {
                int alt29=2;
                try { dbg.enterDecision(29);

                int LA29_0 = input.LA(1);

                if ( (LA29_0==90) ) {
                    alt29=1;
                }


                } finally {dbg.exitDecision(29);}

                switch (alt29) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:233:40: '.' filteredEntity
            	    {
            	    dbg.location(233,43);
            	    char_literal77=(Token)match(input,90,FOLLOW_90_in_entityChain1228); 
            	    char_literal77_tree = (CommonTree)adaptor.create(char_literal77);
            	    root_0 = (CommonTree)adaptor.becomeRoot(char_literal77_tree, root_0);

            	    dbg.location(233,45);
            	    pushFollow(FOLLOW_filteredEntity_in_entityChain1231);
            	    filteredEntity78=filteredEntity();

            	    state._fsp--;

            	    adaptor.addChild(root_0, filteredEntity78.getTree());

            	    }
            	    break;

            	default :
            	    break loop29;
                }
            } while (true);
            } finally {dbg.exitSubRule(29);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(234, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "entityChain");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "entityChain"

    public static class entityChainNoFilter_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "entityChainNoFilter"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:235:1: entityChainNoFilter : entity ( '.' entity )* ;
    public final AntlrCalcEngineParser.entityChainNoFilter_return entityChainNoFilter() throws RecognitionException {
        AntlrCalcEngineParser.entityChainNoFilter_return retval = new AntlrCalcEngineParser.entityChainNoFilter_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal80=null;
        AntlrCalcEngineParser.entity_return entity79 = null;

        AntlrCalcEngineParser.entity_return entity81 = null;


        CommonTree char_literal80_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "entityChainNoFilter");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(235, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:2: ( entity ( '.' entity )* )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:4: entity ( '.' entity )*
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(236,4);
            pushFollow(FOLLOW_entity_in_entityChainNoFilter1244);
            entity79=entity();

            state._fsp--;

            adaptor.addChild(root_0, entity79.getTree());
            dbg.location(236,11);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:11: ( '.' entity )*
            try { dbg.enterSubRule(30);

            loop30:
            do {
                int alt30=2;
                try { dbg.enterDecision(30);

                int LA30_0 = input.LA(1);

                if ( (LA30_0==90) ) {
                    alt30=1;
                }


                } finally {dbg.exitDecision(30);}

                switch (alt30) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:236:13: '.' entity
            	    {
            	    dbg.location(236,16);
            	    char_literal80=(Token)match(input,90,FOLLOW_90_in_entityChainNoFilter1248); 
            	    char_literal80_tree = (CommonTree)adaptor.create(char_literal80);
            	    root_0 = (CommonTree)adaptor.becomeRoot(char_literal80_tree, root_0);

            	    dbg.location(236,18);
            	    pushFollow(FOLLOW_entity_in_entityChainNoFilter1251);
            	    entity81=entity();

            	    state._fsp--;

            	    adaptor.addChild(root_0, entity81.getTree());

            	    }
            	    break;

            	default :
            	    break loop30;
                }
            } while (true);
            } finally {dbg.exitSubRule(30);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(237, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "entityChainNoFilter");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "entityChainNoFilter"

    public static class filteredEntity_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "filteredEntity"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:238:1: filteredEntity : entity ( criteria )? ;
    public final AntlrCalcEngineParser.filteredEntity_return filteredEntity() throws RecognitionException {
        AntlrCalcEngineParser.filteredEntity_return retval = new AntlrCalcEngineParser.filteredEntity_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        AntlrCalcEngineParser.entity_return entity82 = null;

        AntlrCalcEngineParser.criteria_return criteria83 = null;



        try { dbg.enterRule(getGrammarFileName(), "filteredEntity");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(238, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:2: ( entity ( criteria )? )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:4: entity ( criteria )?
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(239,10);
            pushFollow(FOLLOW_entity_in_filteredEntity1265);
            entity82=entity();

            state._fsp--;

            root_0 = (CommonTree)adaptor.becomeRoot(entity82.getTree(), root_0);
            dbg.location(239,12);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:12: ( criteria )?
            int alt31=2;
            try { dbg.enterSubRule(31);
            try { dbg.enterDecision(31);

            int LA31_0 = input.LA(1);

            if ( (LA31_0==92) ) {
                alt31=1;
            }
            } finally {dbg.exitDecision(31);}

            switch (alt31) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:239:12: criteria
                    {
                    dbg.location(239,12);
                    pushFollow(FOLLOW_criteria_in_filteredEntity1268);
                    criteria83=criteria();

                    state._fsp--;

                    adaptor.addChild(root_0, criteria83.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(31);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(240, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "filteredEntity");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "filteredEntity"

    public static class thisKeyword_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "thisKeyword"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:241:1: thisKeyword : x= 'this' -> THIS[$x] ;
    public final AntlrCalcEngineParser.thisKeyword_return thisKeyword() throws RecognitionException {
        AntlrCalcEngineParser.thisKeyword_return retval = new AntlrCalcEngineParser.thisKeyword_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_91=new RewriteRuleTokenStream(adaptor,"token 91");

        try { dbg.enterRule(getGrammarFileName(), "thisKeyword");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(241, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:242:2: (x= 'this' -> THIS[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:242:4: x= 'this'
            {
            dbg.location(242,5);
            x=(Token)match(input,91,FOLLOW_91_in_thisKeyword1281);  
            stream_91.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 242:13: -> THIS[$x]
            {
                dbg.location(242,16);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(THIS, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(243, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "thisKeyword");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "thisKeyword"

    public static class entity_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "entity"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:244:1: entity : x= ID -> ENTITY[$x] ;
    public final AntlrCalcEngineParser.entity_return entity() throws RecognitionException {
        AntlrCalcEngineParser.entity_return retval = new AntlrCalcEngineParser.entity_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "entity");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(244, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:246:2: (x= ID -> ENTITY[$x] )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:246:4: x= ID
            {
            dbg.location(246,5);
            x=(Token)match(input,ID,FOLLOW_ID_in_entity1299);  
            stream_ID.add(x);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 246:9: -> ENTITY[$x]
            {
                dbg.location(246,12);
                adaptor.addChild(root_0, (CommonTree)adaptor.create(ENTITY, x));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(247, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "entity");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "entity"

    public static class criteria_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "criteria"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:248:1: criteria : '[' expression ']' -> ^( CRITERIA expression ) ;
    public final AntlrCalcEngineParser.criteria_return criteria() throws RecognitionException {
        AntlrCalcEngineParser.criteria_return retval = new AntlrCalcEngineParser.criteria_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal84=null;
        Token char_literal86=null;
        AntlrCalcEngineParser.expression_return expression85 = null;


        CommonTree char_literal84_tree=null;
        CommonTree char_literal86_tree=null;
        RewriteRuleTokenStream stream_93=new RewriteRuleTokenStream(adaptor,"token 93");
        RewriteRuleTokenStream stream_92=new RewriteRuleTokenStream(adaptor,"token 92");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try { dbg.enterRule(getGrammarFileName(), "criteria");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(248, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:249:2: ( '[' expression ']' -> ^( CRITERIA expression ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:249:4: '[' expression ']'
            {
            dbg.location(249,4);
            char_literal84=(Token)match(input,92,FOLLOW_92_in_criteria1314);  
            stream_92.add(char_literal84);

            dbg.location(249,8);
            pushFollow(FOLLOW_expression_in_criteria1316);
            expression85=expression();

            state._fsp--;

            stream_expression.add(expression85.getTree());
            dbg.location(249,19);
            char_literal86=(Token)match(input,93,FOLLOW_93_in_criteria1318);  
            stream_93.add(char_literal86);



            // AST REWRITE
            // elements: expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 249:23: -> ^( CRITERIA expression )
            {
                dbg.location(249,26);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:249:26: ^( CRITERIA expression )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(249,29);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(CRITERIA, "CRITERIA"), root_1);

                dbg.location(249,38);
                adaptor.addChild(root_1, stream_expression.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(250, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "criteria");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "criteria"

    public static class functionCall_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "functionCall"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:255:1: functionCall : x= ID '(' ( expression ( ',' expression )* )? ')' -> ^( FUNCTION[$x] ( expression )* ) ;
    public final AntlrCalcEngineParser.functionCall_return functionCall() throws RecognitionException {
        AntlrCalcEngineParser.functionCall_return retval = new AntlrCalcEngineParser.functionCall_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;
        Token char_literal87=null;
        Token char_literal89=null;
        Token char_literal91=null;
        AntlrCalcEngineParser.expression_return expression88 = null;

        AntlrCalcEngineParser.expression_return expression90 = null;


        CommonTree x_tree=null;
        CommonTree char_literal87_tree=null;
        CommonTree char_literal89_tree=null;
        CommonTree char_literal91_tree=null;
        RewriteRuleTokenStream stream_69=new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_94=new RewriteRuleTokenStream(adaptor,"token 94");
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_70=new RewriteRuleTokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try { dbg.enterRule(getGrammarFileName(), "functionCall");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(255, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:2: (x= ID '(' ( expression ( ',' expression )* )? ')' -> ^( FUNCTION[$x] ( expression )* ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:4: x= ID '(' ( expression ( ',' expression )* )? ')'
            {
            dbg.location(256,5);
            x=(Token)match(input,ID,FOLLOW_ID_in_functionCall1346);  
            stream_ID.add(x);

            dbg.location(256,9);
            char_literal87=(Token)match(input,69,FOLLOW_69_in_functionCall1348);  
            stream_69.add(char_literal87);

            dbg.location(256,13);
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:13: ( expression ( ',' expression )* )?
            int alt33=2;
            try { dbg.enterSubRule(33);
            try { dbg.enterDecision(33);

            int LA33_0 = input.LA(1);

            if ( ((LA33_0>=ID && LA33_0<=FLOAT)||LA33_0==69||(LA33_0>=71 && LA33_0<=72)||LA33_0==87||LA33_0==91||(LA33_0>=95 && LA33_0<=96)) ) {
                alt33=1;
            }
            } finally {dbg.exitDecision(33);}

            switch (alt33) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:15: expression ( ',' expression )*
                    {
                    dbg.location(256,15);
                    pushFollow(FOLLOW_expression_in_functionCall1352);
                    expression88=expression();

                    state._fsp--;

                    stream_expression.add(expression88.getTree());
                    dbg.location(256,26);
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:26: ( ',' expression )*
                    try { dbg.enterSubRule(32);

                    loop32:
                    do {
                        int alt32=2;
                        try { dbg.enterDecision(32);

                        int LA32_0 = input.LA(1);

                        if ( (LA32_0==94) ) {
                            alt32=1;
                        }


                        } finally {dbg.exitDecision(32);}

                        switch (alt32) {
                    	case 1 :
                    	    dbg.enterAlt(1);

                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:28: ',' expression
                    	    {
                    	    dbg.location(256,28);
                    	    char_literal89=(Token)match(input,94,FOLLOW_94_in_functionCall1356);  
                    	    stream_94.add(char_literal89);

                    	    dbg.location(256,32);
                    	    pushFollow(FOLLOW_expression_in_functionCall1358);
                    	    expression90=expression();

                    	    state._fsp--;

                    	    stream_expression.add(expression90.getTree());

                    	    }
                    	    break;

                    	default :
                    	    break loop32;
                        }
                    } while (true);
                    } finally {dbg.exitSubRule(32);}


                    }
                    break;

            }
            } finally {dbg.exitSubRule(33);}

            dbg.location(256,49);
            char_literal91=(Token)match(input,70,FOLLOW_70_in_functionCall1366);  
            stream_70.add(char_literal91);



            // AST REWRITE
            // elements: expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 256:53: -> ^( FUNCTION[$x] ( expression )* )
            {
                dbg.location(256,56);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:56: ^( FUNCTION[$x] ( expression )* )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(256,59);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(FUNCTION, x), root_1);

                dbg.location(256,72);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:256:72: ( expression )*
                while ( stream_expression.hasNext() ) {
                    dbg.location(256,72);
                    adaptor.addChild(root_1, stream_expression.nextTree());

                }
                stream_expression.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(257, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "functionCall");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "functionCall"

    public static class identifier_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "identifier"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:262:1: identifier : ID -> ^( IDENTIFIER ID ) ;
    public final AntlrCalcEngineParser.identifier_return identifier() throws RecognitionException {
        AntlrCalcEngineParser.identifier_return retval = new AntlrCalcEngineParser.identifier_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token ID92=null;

        CommonTree ID92_tree=null;
        RewriteRuleTokenStream stream_ID=new RewriteRuleTokenStream(adaptor,"token ID");

        try { dbg.enterRule(getGrammarFileName(), "identifier");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(262, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:263:2: ( ID -> ^( IDENTIFIER ID ) )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:263:4: ID
            {
            dbg.location(263,4);
            ID92=(Token)match(input,ID,FOLLOW_ID_in_identifier1393);  
            stream_ID.add(ID92);



            // AST REWRITE
            // elements: ID
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 263:7: -> ^( IDENTIFIER ID )
            {
                dbg.location(263,10);
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:263:10: ^( IDENTIFIER ID )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                dbg.location(263,13);
                root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(IDENTIFIER, "IDENTIFIER"), root_1);

                dbg.location(263,24);
                adaptor.addChild(root_1, stream_ID.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(264, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "identifier");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "identifier"

    public static class number_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "number"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:265:1: number : ( INT | FLOAT );
    public final AntlrCalcEngineParser.number_return number() throws RecognitionException {
        AntlrCalcEngineParser.number_return retval = new AntlrCalcEngineParser.number_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token set93=null;

        CommonTree set93_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "number");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(265, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:266:2: ( INT | FLOAT )
            dbg.enterAlt(1);

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
            {
            root_0 = (CommonTree)adaptor.nil();

            dbg.location(266,2);
            set93=(Token)input.LT(1);
            if ( (input.LA(1)>=INT && input.LA(1)<=FLOAT) ) {
                input.consume();
                adaptor.addChild(root_0, (CommonTree)adaptor.create(set93));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(268, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "number");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "number"

    public static class booleanValue_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "booleanValue"
    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:269:1: booleanValue : (x= 'true' -> TRUE[$x] | x= 'false' -> FALSE[$x] );
    public final AntlrCalcEngineParser.booleanValue_return booleanValue() throws RecognitionException {
        AntlrCalcEngineParser.booleanValue_return retval = new AntlrCalcEngineParser.booleanValue_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token x=null;

        CommonTree x_tree=null;
        RewriteRuleTokenStream stream_96=new RewriteRuleTokenStream(adaptor,"token 96");
        RewriteRuleTokenStream stream_95=new RewriteRuleTokenStream(adaptor,"token 95");

        try { dbg.enterRule(getGrammarFileName(), "booleanValue");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(269, 1);

        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:270:2: (x= 'true' -> TRUE[$x] | x= 'false' -> FALSE[$x] )
            int alt34=2;
            try { dbg.enterDecision(34);

            int LA34_0 = input.LA(1);

            if ( (LA34_0==95) ) {
                alt34=1;
            }
            else if ( (LA34_0==96) ) {
                alt34=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 34, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(34);}

            switch (alt34) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:270:4: x= 'true'
                    {
                    dbg.location(270,5);
                    x=(Token)match(input,95,FOLLOW_95_in_booleanValue1434);  
                    stream_95.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 270:13: -> TRUE[$x]
                    {
                        dbg.location(270,16);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(TRUE, x));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:271:4: x= 'false'
                    {
                    dbg.location(271,5);
                    x=(Token)match(input,96,FOLLOW_96_in_booleanValue1446);  
                    stream_96.add(x);



                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 271:14: -> FALSE[$x]
                    {
                        dbg.location(271,17);
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(FALSE, x));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(272, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "booleanValue");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "booleanValue"

    // Delegated rules


 

    public static final BitSet FOLLOW_rootLevelStatement_in_root225 = new BitSet(new long[]{0x0200040000000002L});
    public static final BitSet FOLLOW_formulaDeclaration_in_rootLevelStatement236 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_classDeclaration_in_rootLevelStatement242 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_57_in_classDeclaration256 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_name_in_classDeclaration258 = new BitSet(new long[]{0x1400000000000000L});
    public static final BitSet FOLLOW_baseClassDeclaration_in_classDeclaration260 = new BitSet(new long[]{0x1400000000000000L});
    public static final BitSet FOLLOW_classStatementBlock_in_classDeclaration263 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_58_in_baseClassDeclaration288 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_name_in_baseClassDeclaration290 = new BitSet(new long[]{0x0800000000000000L});
    public static final BitSet FOLLOW_59_in_baseClassDeclaration292 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_expression_in_baseClassDeclaration294 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_60_in_classStatementBlock322 = new BitSet(new long[]{0x6000000000000000L,0x0000000000000008L});
    public static final BitSet FOLLOW_classLevelStatement_in_classStatementBlock324 = new BitSet(new long[]{0x6000000000000000L,0x0000000000000008L});
    public static final BitSet FOLLOW_61_in_classStatementBlock327 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_propertyDeclaration_in_classLevelStatement348 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_relationshipDeclaration_in_classLevelStatement353 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_name365 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_62_in_propertyDeclaration383 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_name_in_propertyDeclaration385 = new BitSet(new long[]{0x8000000000000000L,0x0000000000000007L});
    public static final BitSet FOLLOW_propertyModifiers_in_propertyDeclaration387 = new BitSet(new long[]{0x8000000000000000L});
    public static final BitSet FOLLOW_63_in_propertyDeclaration390 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_exclusivePropertyModifier_in_propertyModifiers413 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_propertyModifier_in_propertyModifiers428 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000007L});
    public static final BitSet FOLLOW_64_in_exclusivePropertyModifier450 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_propertyModifier0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_67_in_relationshipDeclaration478 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_name_in_relationshipDeclaration480 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_68_in_relationshipDeclaration482 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_relationshipJoinDeclaration_in_relationshipDeclaration484 = new BitSet(new long[]{0x8000000000000000L});
    public static final BitSet FOLLOW_63_in_relationshipDeclaration486 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_name_in_relationshipJoinDeclaration508 = new BitSet(new long[]{0x0800000000000000L});
    public static final BitSet FOLLOW_59_in_relationshipJoinDeclaration510 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_expression_in_relationshipJoinDeclaration512 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_entityChainNoFilter_in_formulaDeclaration552 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000010L});
    public static final BitSet FOLLOW_assignmentOp_in_formulaDeclaration554 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_expression_in_formulaDeclaration556 = new BitSet(new long[]{0x8000000000000000L});
    public static final BitSet FOLLOW_63_in_formulaDeclaration558 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_orExpr_in_expression593 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_andExpr_in_orExpr603 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000600L});
    public static final BitSet FOLLOW_orOp_in_orExpr607 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_andExpr_in_orExpr610 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000600L});
    public static final BitSet FOLLOW_equalityExpr_in_andExpr623 = new BitSet(new long[]{0x0000000000000002L,0x0000000000001800L});
    public static final BitSet FOLLOW_andOp_in_andExpr627 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_equalityExpr_in_andExpr630 = new BitSet(new long[]{0x0000000000000002L,0x0000000000001800L});
    public static final BitSet FOLLOW_relationalExpr_in_equalityExpr644 = new BitSet(new long[]{0x0000000000000002L,0x0000000000038010L});
    public static final BitSet FOLLOW_equalsOp_in_equalityExpr650 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_notEqualsOp_in_equalityExpr655 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_relationalExpr_in_equalityExpr660 = new BitSet(new long[]{0x0000000000000002L,0x0000000000038010L});
    public static final BitSet FOLLOW_additiveExpr_in_relationalExpr673 = new BitSet(new long[]{0x0000000000000002L,0x00000000003C0000L});
    public static final BitSet FOLLOW_ltOp_in_relationalExpr679 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_gtOp_in_relationalExpr684 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_lteOp_in_relationalExpr689 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_gteOp_in_relationalExpr694 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_additiveExpr_in_relationalExpr699 = new BitSet(new long[]{0x0000000000000002L,0x00000000003C0000L});
    public static final BitSet FOLLOW_multiplicativeExpr_in_additiveExpr713 = new BitSet(new long[]{0x0000000000000002L,0x0000000000C00000L});
    public static final BitSet FOLLOW_addOp_in_additiveExpr719 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_subtractOp_in_additiveExpr724 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_multiplicativeExpr_in_additiveExpr729 = new BitSet(new long[]{0x0000000000000002L,0x0000000000C00000L});
    public static final BitSet FOLLOW_unaryExpr_in_multiplicativeExpr743 = new BitSet(new long[]{0x0000000000000002L,0x0000000003006000L});
    public static final BitSet FOLLOW_multiplyOp_in_multiplicativeExpr749 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_divideOp_in_multiplicativeExpr754 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_modulusOp_in_multiplicativeExpr759 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_unaryExpr_in_multiplicativeExpr764 = new BitSet(new long[]{0x0000000000000002L,0x0000000003006000L});
    public static final BitSet FOLLOW_unaryNegationOp_in_unaryExpr779 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_negationExpr_in_unaryExpr783 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_notOp_in_negationExpr796 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_primaryExpr_in_negationExpr802 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_69_in_primaryExpr813 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_expression_in_primaryExpr816 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000040L});
    public static final BitSet FOLLOW_70_in_primaryExpr818 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_number_in_primaryExpr824 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_booleanValue_in_primaryExpr829 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_LITERAL_in_primaryExpr834 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_functionCall_in_primaryExpr839 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_entityChain_in_primaryExpr844 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_71_in_notOp862 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_72_in_notOp874 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_73_in_orOp892 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_74_in_orOp904 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_75_in_andOp921 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_76_in_andOp933 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_77_in_modulusOp951 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_78_in_modulusOp963 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_79_in_equalsOp982 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_68_in_equalsOp995 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_80_in_notEqualsOp1013 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_81_in_notEqualsOp1025 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_82_in_ltOp1042 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_83_in_gtOp1059 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_84_in_lteOp1076 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_85_in_gteOp1093 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_86_in_addOp1110 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_87_in_subtractOp1127 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_88_in_multiplyOp1144 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_89_in_divideOp1161 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_87_in_unaryNegationOp1178 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_68_in_assignmentOp1195 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_thisKeyword_in_entityChain1218 = new BitSet(new long[]{0x0000000000000002L,0x0000000004000000L});
    public static final BitSet FOLLOW_filteredEntity_in_entityChain1222 = new BitSet(new long[]{0x0000000000000002L,0x0000000004000000L});
    public static final BitSet FOLLOW_90_in_entityChain1228 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_filteredEntity_in_entityChain1231 = new BitSet(new long[]{0x0000000000000002L,0x0000000004000000L});
    public static final BitSet FOLLOW_entity_in_entityChainNoFilter1244 = new BitSet(new long[]{0x0000000000000002L,0x0000000004000000L});
    public static final BitSet FOLLOW_90_in_entityChainNoFilter1248 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_entity_in_entityChainNoFilter1251 = new BitSet(new long[]{0x0000000000000002L,0x0000000004000000L});
    public static final BitSet FOLLOW_entity_in_filteredEntity1265 = new BitSet(new long[]{0x0000000000000002L,0x0000000010000000L});
    public static final BitSet FOLLOW_criteria_in_filteredEntity1268 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_91_in_thisKeyword1281 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_entity1299 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_92_in_criteria1314 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_expression_in_criteria1316 = new BitSet(new long[]{0x0000000000000000L,0x0000000020000000L});
    public static final BitSet FOLLOW_93_in_criteria1318 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_functionCall1346 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000020L});
    public static final BitSet FOLLOW_69_in_functionCall1348 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001E0L});
    public static final BitSet FOLLOW_expression_in_functionCall1352 = new BitSet(new long[]{0x0000000000000000L,0x0000000040000040L});
    public static final BitSet FOLLOW_94_in_functionCall1356 = new BitSet(new long[]{0x00003C0000000000L,0x00000001888001A0L});
    public static final BitSet FOLLOW_expression_in_functionCall1358 = new BitSet(new long[]{0x0000000000000000L,0x0000000040000040L});
    public static final BitSet FOLLOW_70_in_functionCall1366 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_identifier1393 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_number0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_95_in_booleanValue1434 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_96_in_booleanValue1446 = new BitSet(new long[]{0x0000000000000002L});

}