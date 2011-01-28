// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g 2011-01-28 15:05:31

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class AntlrCalcEngineLexer extends Lexer {
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
    public static final int RELATIONSHIP=8;
    public static final int T__89=89;
    public static final int T__88=88;
    public static final int WS=50;
    public static final int T__71=71;
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

    public AntlrCalcEngineLexer() {;} 
    public AntlrCalcEngineLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public AntlrCalcEngineLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g"; }

    // $ANTLR start "T__57"
    public final void mT__57() throws RecognitionException {
        try {
            int _type = T__57;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:3:7: ( 'class' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:3:9: 'class'
            {
            match("class"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public final void mT__58() throws RecognitionException {
        try {
            int _type = T__58;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:4:7: ( ':' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:4:9: ':'
            {
            match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public final void mT__59() throws RecognitionException {
        try {
            int _type = T__59;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:5:7: ( 'where' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:5:9: 'where'
            {
            match("where"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public final void mT__60() throws RecognitionException {
        try {
            int _type = T__60;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:6:7: ( '{' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:6:9: '{'
            {
            match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public final void mT__61() throws RecognitionException {
        try {
            int _type = T__61;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:7:7: ( '}' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:7:9: '}'
            {
            match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public final void mT__62() throws RecognitionException {
        try {
            int _type = T__62;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:8:7: ( 'property' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:8:9: 'property'
            {
            match("property"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public final void mT__63() throws RecognitionException {
        try {
            int _type = T__63;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:9:7: ( ';' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:9:9: ';'
            {
            match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public final void mT__64() throws RecognitionException {
        try {
            int _type = T__64;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:10:7: ( 'primarykey' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:10:9: 'primarykey'
            {
            match("primarykey"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public final void mT__65() throws RecognitionException {
        try {
            int _type = T__65;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:11:7: ( 'calculated' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:11:9: 'calculated'
            {
            match("calculated"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public final void mT__66() throws RecognitionException {
        try {
            int _type = T__66;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:12:7: ( 'abstract' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:12:9: 'abstract'
            {
            match("abstract"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public final void mT__67() throws RecognitionException {
        try {
            int _type = T__67;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:13:7: ( 'relationship' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:13:9: 'relationship'
            {
            match("relationship"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public final void mT__68() throws RecognitionException {
        try {
            int _type = T__68;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:14:7: ( '=' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:14:9: '='
            {
            match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public final void mT__69() throws RecognitionException {
        try {
            int _type = T__69;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:15:7: ( '(' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:15:9: '('
            {
            match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public final void mT__70() throws RecognitionException {
        try {
            int _type = T__70;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:16:7: ( ')' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:16:9: ')'
            {
            match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public final void mT__71() throws RecognitionException {
        try {
            int _type = T__71;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:17:7: ( 'not' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:17:9: 'not'
            {
            match("not"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public final void mT__72() throws RecognitionException {
        try {
            int _type = T__72;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:18:7: ( '!' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:18:9: '!'
            {
            match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public final void mT__73() throws RecognitionException {
        try {
            int _type = T__73;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:19:7: ( 'or' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:19:9: 'or'
            {
            match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public final void mT__74() throws RecognitionException {
        try {
            int _type = T__74;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:20:7: ( '||' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:20:9: '||'
            {
            match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public final void mT__75() throws RecognitionException {
        try {
            int _type = T__75;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:21:7: ( 'and' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:21:9: 'and'
            {
            match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public final void mT__76() throws RecognitionException {
        try {
            int _type = T__76;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:22:7: ( '&&' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:22:9: '&&'
            {
            match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public final void mT__77() throws RecognitionException {
        try {
            int _type = T__77;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:23:7: ( 'mod' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:23:9: 'mod'
            {
            match("mod"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public final void mT__78() throws RecognitionException {
        try {
            int _type = T__78;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:24:7: ( '%' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:24:9: '%'
            {
            match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public final void mT__79() throws RecognitionException {
        try {
            int _type = T__79;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:25:7: ( '==' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:25:9: '=='
            {
            match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public final void mT__80() throws RecognitionException {
        try {
            int _type = T__80;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:26:7: ( '!=' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:26:9: '!='
            {
            match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public final void mT__81() throws RecognitionException {
        try {
            int _type = T__81;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:27:7: ( '<>' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:27:9: '<>'
            {
            match("<>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public final void mT__82() throws RecognitionException {
        try {
            int _type = T__82;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:28:7: ( '<' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:28:9: '<'
            {
            match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public final void mT__83() throws RecognitionException {
        try {
            int _type = T__83;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:29:7: ( '>' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:29:9: '>'
            {
            match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public final void mT__84() throws RecognitionException {
        try {
            int _type = T__84;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:30:7: ( '<=' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:30:9: '<='
            {
            match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__84"

    // $ANTLR start "T__85"
    public final void mT__85() throws RecognitionException {
        try {
            int _type = T__85;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:31:7: ( '>=' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:31:9: '>='
            {
            match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__85"

    // $ANTLR start "T__86"
    public final void mT__86() throws RecognitionException {
        try {
            int _type = T__86;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:32:7: ( '+' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:32:9: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__86"

    // $ANTLR start "T__87"
    public final void mT__87() throws RecognitionException {
        try {
            int _type = T__87;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:33:7: ( '-' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:33:9: '-'
            {
            match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__87"

    // $ANTLR start "T__88"
    public final void mT__88() throws RecognitionException {
        try {
            int _type = T__88;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:34:7: ( '*' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:34:9: '*'
            {
            match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__88"

    // $ANTLR start "T__89"
    public final void mT__89() throws RecognitionException {
        try {
            int _type = T__89;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:35:7: ( '/' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:35:9: '/'
            {
            match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__89"

    // $ANTLR start "T__90"
    public final void mT__90() throws RecognitionException {
        try {
            int _type = T__90;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:36:7: ( '.' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:36:9: '.'
            {
            match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__90"

    // $ANTLR start "T__91"
    public final void mT__91() throws RecognitionException {
        try {
            int _type = T__91;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:37:7: ( 'this' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:37:9: 'this'
            {
            match("this"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__91"

    // $ANTLR start "T__92"
    public final void mT__92() throws RecognitionException {
        try {
            int _type = T__92;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:38:7: ( '[' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:38:9: '['
            {
            match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__92"

    // $ANTLR start "T__93"
    public final void mT__93() throws RecognitionException {
        try {
            int _type = T__93;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:39:7: ( ']' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:39:9: ']'
            {
            match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__93"

    // $ANTLR start "T__94"
    public final void mT__94() throws RecognitionException {
        try {
            int _type = T__94;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:40:7: ( ',' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:40:9: ','
            {
            match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__94"

    // $ANTLR start "T__95"
    public final void mT__95() throws RecognitionException {
        try {
            int _type = T__95;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:41:7: ( 'true' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:41:9: 'true'
            {
            match("true"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__95"

    // $ANTLR start "T__96"
    public final void mT__96() throws RecognitionException {
        try {
            int _type = T__96;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:42:7: ( 'false' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:42:9: 'false'
            {
            match("false"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__96"

    // $ANTLR start "LITERAL"
    public final void mLITERAL() throws RecognitionException {
        try {
            int _type = LITERAL;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:2: ( DQUOT (~ DQUOT )* DQUOT | SQUOT (~ SQUOT )* SQUOT )
            int alt3=2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0=='\"') ) {
                alt3=1;
            }
            else if ( (LA3_0=='\'') ) {
                alt3=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 3, 0, input);

                throw nvae;
            }
            switch (alt3) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:4: DQUOT (~ DQUOT )* DQUOT
                    {
                    mDQUOT(); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:10: (~ DQUOT )*
                    loop1:
                    do {
                        int alt1=2;
                        int LA1_0 = input.LA(1);

                        if ( ((LA1_0>='\u0000' && LA1_0<='!')||(LA1_0>='#' && LA1_0<='\uFFFF')) ) {
                            alt1=1;
                        }


                        switch (alt1) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:280:10: ~ DQUOT
                    	    {
                    	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='-')||(input.LA(1)>='/' && input.LA(1)<='\uFFFF') ) {
                    	        input.consume();

                    	    }
                    	    else {
                    	        MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        recover(mse);
                    	        throw mse;}


                    	    }
                    	    break;

                    	default :
                    	    break loop1;
                        }
                    } while (true);

                    mDQUOT(); 

                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:281:4: SQUOT (~ SQUOT )* SQUOT
                    {
                    mSQUOT(); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:281:10: (~ SQUOT )*
                    loop2:
                    do {
                        int alt2=2;
                        int LA2_0 = input.LA(1);

                        if ( ((LA2_0>='\u0000' && LA2_0<='&')||(LA2_0>='(' && LA2_0<='\uFFFF')) ) {
                            alt2=1;
                        }


                        switch (alt2) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:281:10: ~ SQUOT
                    	    {
                    	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='.')||(input.LA(1)>='0' && input.LA(1)<='\uFFFF') ) {
                    	        input.consume();

                    	    }
                    	    else {
                    	        MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        recover(mse);
                    	        throw mse;}


                    	    }
                    	    break;

                    	default :
                    	    break loop2;
                        }
                    } while (true);

                    mSQUOT(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "LITERAL"

    // $ANTLR start "SQUOT"
    public final void mSQUOT() throws RecognitionException {
        try {
            int _type = SQUOT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:285:2: ( '\\'' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:285:4: '\\''
            {
            match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SQUOT"

    // $ANTLR start "DQUOT"
    public final void mDQUOT() throws RecognitionException {
        try {
            int _type = DQUOT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:288:2: ( '\"' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:288:4: '\"'
            {
            match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "DQUOT"

    // $ANTLR start "ID"
    public final void mID() throws RecognitionException {
        try {
            int _type = ID;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:291:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:291:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            if ( (input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:291:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            loop4:
            do {
                int alt4=2;
                int LA4_0 = input.LA(1);

                if ( ((LA4_0>='0' && LA4_0<='9')||(LA4_0>='A' && LA4_0<='Z')||LA4_0=='_'||(LA4_0>='a' && LA4_0<='z')) ) {
                    alt4=1;
                }


                switch (alt4) {
            	case 1 :
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
            	    {
            	    if ( (input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop4;
                }
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public final void mINT() throws RecognitionException {
        try {
            int _type = INT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:5: ( ( '0' .. '9' )+ )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:7: ( '0' .. '9' )+
            {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:7: ( '0' .. '9' )+
            int cnt5=0;
            loop5:
            do {
                int alt5=2;
                int LA5_0 = input.LA(1);

                if ( ((LA5_0>='0' && LA5_0<='9')) ) {
                    alt5=1;
                }


                switch (alt5) {
            	case 1 :
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:294:7: '0' .. '9'
            	    {
            	    matchRange('0','9'); 

            	    }
            	    break;

            	default :
            	    if ( cnt5 >= 1 ) break loop5;
                        EarlyExitException eee =
                            new EarlyExitException(5, input);
                        throw eee;
                }
                cnt5++;
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "FLOAT"
    public final void mFLOAT() throws RecognitionException {
        try {
            int _type = FLOAT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT )
            int alt12=3;
            alt12 = dfa12.predict(input);
            switch (alt12) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )?
                    {
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:9: ( '0' .. '9' )+
                    int cnt6=0;
                    loop6:
                    do {
                        int alt6=2;
                        int LA6_0 = input.LA(1);

                        if ( ((LA6_0>='0' && LA6_0<='9')) ) {
                            alt6=1;
                        }


                        switch (alt6) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:10: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt6 >= 1 ) break loop6;
                                EarlyExitException eee =
                                    new EarlyExitException(6, input);
                                throw eee;
                        }
                        cnt6++;
                    } while (true);

                    match('.'); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:25: ( '0' .. '9' )*
                    loop7:
                    do {
                        int alt7=2;
                        int LA7_0 = input.LA(1);

                        if ( ((LA7_0>='0' && LA7_0<='9')) ) {
                            alt7=1;
                        }


                        switch (alt7) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:26: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    break loop7;
                        }
                    } while (true);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:37: ( EXPONENT )?
                    int alt8=2;
                    int LA8_0 = input.LA(1);

                    if ( (LA8_0=='E'||LA8_0=='e') ) {
                        alt8=1;
                    }
                    switch (alt8) {
                        case 1 :
                            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:298:37: EXPONENT
                            {
                            mEXPONENT(); 

                            }
                            break;

                    }


                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:9: '.' ( '0' .. '9' )+ ( EXPONENT )?
                    {
                    match('.'); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:13: ( '0' .. '9' )+
                    int cnt9=0;
                    loop9:
                    do {
                        int alt9=2;
                        int LA9_0 = input.LA(1);

                        if ( ((LA9_0>='0' && LA9_0<='9')) ) {
                            alt9=1;
                        }


                        switch (alt9) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:14: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt9 >= 1 ) break loop9;
                                EarlyExitException eee =
                                    new EarlyExitException(9, input);
                                throw eee;
                        }
                        cnt9++;
                    } while (true);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:25: ( EXPONENT )?
                    int alt10=2;
                    int LA10_0 = input.LA(1);

                    if ( (LA10_0=='E'||LA10_0=='e') ) {
                        alt10=1;
                    }
                    switch (alt10) {
                        case 1 :
                            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:299:25: EXPONENT
                            {
                            mEXPONENT(); 

                            }
                            break;

                    }


                    }
                    break;
                case 3 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:300:9: ( '0' .. '9' )+ EXPONENT
                    {
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:300:9: ( '0' .. '9' )+
                    int cnt11=0;
                    loop11:
                    do {
                        int alt11=2;
                        int LA11_0 = input.LA(1);

                        if ( ((LA11_0>='0' && LA11_0<='9')) ) {
                            alt11=1;
                        }


                        switch (alt11) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:300:10: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt11 >= 1 ) break loop11;
                                EarlyExitException eee =
                                    new EarlyExitException(11, input);
                                throw eee;
                        }
                        cnt11++;
                    } while (true);

                    mEXPONENT(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FLOAT"

    // $ANTLR start "COMMENT"
    public final void mCOMMENT() throws RecognitionException {
        try {
            int _type = COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt16=2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0=='/') ) {
                int LA16_1 = input.LA(2);

                if ( (LA16_1=='/') ) {
                    alt16=1;
                }
                else if ( (LA16_1=='*') ) {
                    alt16=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 16, 0, input);

                throw nvae;
            }
            switch (alt16) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    match("//"); 

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:14: (~ ( '\\n' | '\\r' ) )*
                    loop13:
                    do {
                        int alt13=2;
                        int LA13_0 = input.LA(1);

                        if ( ((LA13_0>='\u0000' && LA13_0<='\t')||(LA13_0>='\u000B' && LA13_0<='\f')||(LA13_0>='\u000E' && LA13_0<='\uFFFF')) ) {
                            alt13=1;
                        }


                        switch (alt13) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:14: ~ ( '\\n' | '\\r' )
                    	    {
                    	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\uFFFF') ) {
                    	        input.consume();

                    	    }
                    	    else {
                    	        MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        recover(mse);
                    	        throw mse;}


                    	    }
                    	    break;

                    	default :
                    	    break loop13;
                        }
                    } while (true);

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:28: ( '\\r' )?
                    int alt14=2;
                    int LA14_0 = input.LA(1);

                    if ( (LA14_0=='\r') ) {
                        alt14=1;
                    }
                    switch (alt14) {
                        case 1 :
                            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:304:28: '\\r'
                            {
                            match('\r'); 

                            }
                            break;

                    }

                    match('\n'); 
                    _channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:305:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    match("/*"); 

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:305:14: ( options {greedy=false; } : . )*
                    loop15:
                    do {
                        int alt15=2;
                        int LA15_0 = input.LA(1);

                        if ( (LA15_0=='*') ) {
                            int LA15_1 = input.LA(2);

                            if ( (LA15_1=='/') ) {
                                alt15=2;
                            }
                            else if ( ((LA15_1>='\u0000' && LA15_1<='.')||(LA15_1>='0' && LA15_1<='\uFFFF')) ) {
                                alt15=1;
                            }


                        }
                        else if ( ((LA15_0>='\u0000' && LA15_0<=')')||(LA15_0>='+' && LA15_0<='\uFFFF')) ) {
                            alt15=1;
                        }


                        switch (alt15) {
                    	case 1 :
                    	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:305:42: .
                    	    {
                    	    matchAny(); 

                    	    }
                    	    break;

                    	default :
                    	    break loop15;
                        }
                    } while (true);

                    match("*/"); 

                    _channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:308:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:308:9: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            if ( (input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            _channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "STRING"
    public final void mSTRING() throws RecognitionException {
        try {
            int _type = STRING;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:5: ( '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:8: '\"' ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            match('\"'); 
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:12: ( ESC_SEQ | ~ ( '\\\\' | '\"' ) )*
            loop17:
            do {
                int alt17=3;
                int LA17_0 = input.LA(1);

                if ( (LA17_0=='\\') ) {
                    alt17=1;
                }
                else if ( ((LA17_0>='\u0000' && LA17_0<='!')||(LA17_0>='#' && LA17_0<='[')||(LA17_0>=']' && LA17_0<='\uFFFF')) ) {
                    alt17=2;
                }


                switch (alt17) {
            	case 1 :
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:14: ESC_SEQ
            	    {
            	    mESC_SEQ(); 

            	    }
            	    break;
            	case 2 :
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:316:24: ~ ( '\\\\' | '\"' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop17;
                }
            } while (true);

            match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "CHAR"
    public final void mCHAR() throws RecognitionException {
        try {
            int _type = CHAR;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:5: ( '\\'' ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) ) '\\'' )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:8: '\\'' ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) ) '\\''
            {
            match('\''); 
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:13: ( ESC_SEQ | ~ ( '\\'' | '\\\\' ) )
            int alt18=2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0=='\\') ) {
                alt18=1;
            }
            else if ( ((LA18_0>='\u0000' && LA18_0<='&')||(LA18_0>='(' && LA18_0<='[')||(LA18_0>=']' && LA18_0<='\uFFFF')) ) {
                alt18=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 18, 0, input);

                throw nvae;
            }
            switch (alt18) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:15: ESC_SEQ
                    {
                    mESC_SEQ(); 

                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:319:25: ~ ( '\\'' | '\\\\' )
                    {
                    if ( (input.LA(1)>='\u0000' && input.LA(1)<='&')||(input.LA(1)>='(' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF') ) {
                        input.consume();

                    }
                    else {
                        MismatchedSetException mse = new MismatchedSetException(null,input);
                        recover(mse);
                        throw mse;}


                    }
                    break;

            }

            match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "EXPONENT"
    public final void mEXPONENT() throws RecognitionException {
        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:10: ( ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:12: ( 'e' | 'E' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            if ( input.LA(1)=='E'||input.LA(1)=='e' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:22: ( '+' | '-' )?
            int alt19=2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0=='+'||LA19_0=='-') ) {
                alt19=1;
            }
            switch (alt19) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:
                    {
                    if ( input.LA(1)=='+'||input.LA(1)=='-' ) {
                        input.consume();

                    }
                    else {
                        MismatchedSetException mse = new MismatchedSetException(null,input);
                        recover(mse);
                        throw mse;}


                    }
                    break;

            }

            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:33: ( '0' .. '9' )+
            int cnt20=0;
            loop20:
            do {
                int alt20=2;
                int LA20_0 = input.LA(1);

                if ( ((LA20_0>='0' && LA20_0<='9')) ) {
                    alt20=1;
                }


                switch (alt20) {
            	case 1 :
            	    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:323:34: '0' .. '9'
            	    {
            	    matchRange('0','9'); 

            	    }
            	    break;

            	default :
            	    if ( cnt20 >= 1 ) break loop20;
                        EarlyExitException eee =
                            new EarlyExitException(20, input);
                        throw eee;
                }
                cnt20++;
            } while (true);


            }

        }
        finally {
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "HEX_DIGIT"
    public final void mHEX_DIGIT() throws RecognitionException {
        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:326:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:326:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            if ( (input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F')||(input.LA(1)>='a' && input.LA(1)<='f') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

        }
        finally {
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "ESC_SEQ"
    public final void mESC_SEQ() throws RecognitionException {
        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:330:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UNICODE_ESC | OCTAL_ESC )
            int alt21=3;
            int LA21_0 = input.LA(1);

            if ( (LA21_0=='\\') ) {
                switch ( input.LA(2) ) {
                case '\"':
                case '\'':
                case '\\':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                    {
                    alt21=1;
                    }
                    break;
                case 'u':
                    {
                    alt21=2;
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
                    alt21=3;
                    }
                    break;
                default:
                    NoViableAltException nvae =
                        new NoViableAltException("", 21, 1, input);

                    throw nvae;
                }

            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 21, 0, input);

                throw nvae;
            }
            switch (alt21) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:330:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    match('\\'); 
                    if ( input.LA(1)=='\"'||input.LA(1)=='\''||input.LA(1)=='\\'||input.LA(1)=='b'||input.LA(1)=='f'||input.LA(1)=='n'||input.LA(1)=='r'||input.LA(1)=='t' ) {
                        input.consume();

                    }
                    else {
                        MismatchedSetException mse = new MismatchedSetException(null,input);
                        recover(mse);
                        throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:331:9: UNICODE_ESC
                    {
                    mUNICODE_ESC(); 

                    }
                    break;
                case 3 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:332:9: OCTAL_ESC
                    {
                    mOCTAL_ESC(); 

                    }
                    break;

            }
        }
        finally {
        }
    }
    // $ANTLR end "ESC_SEQ"

    // $ANTLR start "OCTAL_ESC"
    public final void mOCTAL_ESC() throws RecognitionException {
        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt22=3;
            int LA22_0 = input.LA(1);

            if ( (LA22_0=='\\') ) {
                int LA22_1 = input.LA(2);

                if ( ((LA22_1>='0' && LA22_1<='3')) ) {
                    int LA22_2 = input.LA(3);

                    if ( ((LA22_2>='0' && LA22_2<='7')) ) {
                        int LA22_4 = input.LA(4);

                        if ( ((LA22_4>='0' && LA22_4<='7')) ) {
                            alt22=1;
                        }
                        else {
                            alt22=2;}
                    }
                    else {
                        alt22=3;}
                }
                else if ( ((LA22_1>='4' && LA22_1<='7')) ) {
                    int LA22_3 = input.LA(3);

                    if ( ((LA22_3>='0' && LA22_3<='7')) ) {
                        alt22=2;
                    }
                    else {
                        alt22=3;}
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 22, 1, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 22, 0, input);

                throw nvae;
            }
            switch (alt22) {
                case 1 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:14: ( '0' .. '3' )
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:15: '0' .. '3'
                    {
                    matchRange('0','3'); 

                    }

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:25: ( '0' .. '7' )
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:26: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:36: ( '0' .. '7' )
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:337:37: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;
                case 2 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:14: ( '0' .. '7' )
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:15: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }

                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:25: ( '0' .. '7' )
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:338:26: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;
                case 3 :
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:339:9: '\\\\' ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:339:14: ( '0' .. '7' )
                    // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:339:15: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;

            }
        }
        finally {
        }
    }
    // $ANTLR end "OCTAL_ESC"

    // $ANTLR start "UNICODE_ESC"
    public final void mUNICODE_ESC() throws RecognitionException {
        try {
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:344:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:344:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
            {
            match('\\'); 
            match('u'); 
            mHEX_DIGIT(); 
            mHEX_DIGIT(); 
            mHEX_DIGIT(); 
            mHEX_DIGIT(); 

            }

        }
        finally {
        }
    }
    // $ANTLR end "UNICODE_ESC"

    public void mTokens() throws RecognitionException {
        // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:8: ( T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | T__94 | T__95 | T__96 | LITERAL | SQUOT | DQUOT | ID | INT | FLOAT | COMMENT | WS | STRING | CHAR )
        int alt23=50;
        alt23 = dfa23.predict(input);
        switch (alt23) {
            case 1 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:10: T__57
                {
                mT__57(); 

                }
                break;
            case 2 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:16: T__58
                {
                mT__58(); 

                }
                break;
            case 3 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:22: T__59
                {
                mT__59(); 

                }
                break;
            case 4 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:28: T__60
                {
                mT__60(); 

                }
                break;
            case 5 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:34: T__61
                {
                mT__61(); 

                }
                break;
            case 6 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:40: T__62
                {
                mT__62(); 

                }
                break;
            case 7 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:46: T__63
                {
                mT__63(); 

                }
                break;
            case 8 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:52: T__64
                {
                mT__64(); 

                }
                break;
            case 9 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:58: T__65
                {
                mT__65(); 

                }
                break;
            case 10 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:64: T__66
                {
                mT__66(); 

                }
                break;
            case 11 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:70: T__67
                {
                mT__67(); 

                }
                break;
            case 12 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:76: T__68
                {
                mT__68(); 

                }
                break;
            case 13 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:82: T__69
                {
                mT__69(); 

                }
                break;
            case 14 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:88: T__70
                {
                mT__70(); 

                }
                break;
            case 15 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:94: T__71
                {
                mT__71(); 

                }
                break;
            case 16 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:100: T__72
                {
                mT__72(); 

                }
                break;
            case 17 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:106: T__73
                {
                mT__73(); 

                }
                break;
            case 18 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:112: T__74
                {
                mT__74(); 

                }
                break;
            case 19 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:118: T__75
                {
                mT__75(); 

                }
                break;
            case 20 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:124: T__76
                {
                mT__76(); 

                }
                break;
            case 21 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:130: T__77
                {
                mT__77(); 

                }
                break;
            case 22 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:136: T__78
                {
                mT__78(); 

                }
                break;
            case 23 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:142: T__79
                {
                mT__79(); 

                }
                break;
            case 24 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:148: T__80
                {
                mT__80(); 

                }
                break;
            case 25 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:154: T__81
                {
                mT__81(); 

                }
                break;
            case 26 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:160: T__82
                {
                mT__82(); 

                }
                break;
            case 27 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:166: T__83
                {
                mT__83(); 

                }
                break;
            case 28 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:172: T__84
                {
                mT__84(); 

                }
                break;
            case 29 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:178: T__85
                {
                mT__85(); 

                }
                break;
            case 30 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:184: T__86
                {
                mT__86(); 

                }
                break;
            case 31 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:190: T__87
                {
                mT__87(); 

                }
                break;
            case 32 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:196: T__88
                {
                mT__88(); 

                }
                break;
            case 33 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:202: T__89
                {
                mT__89(); 

                }
                break;
            case 34 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:208: T__90
                {
                mT__90(); 

                }
                break;
            case 35 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:214: T__91
                {
                mT__91(); 

                }
                break;
            case 36 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:220: T__92
                {
                mT__92(); 

                }
                break;
            case 37 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:226: T__93
                {
                mT__93(); 

                }
                break;
            case 38 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:232: T__94
                {
                mT__94(); 

                }
                break;
            case 39 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:238: T__95
                {
                mT__95(); 

                }
                break;
            case 40 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:244: T__96
                {
                mT__96(); 

                }
                break;
            case 41 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:250: LITERAL
                {
                mLITERAL(); 

                }
                break;
            case 42 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:258: SQUOT
                {
                mSQUOT(); 

                }
                break;
            case 43 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:264: DQUOT
                {
                mDQUOT(); 

                }
                break;
            case 44 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:270: ID
                {
                mID(); 

                }
                break;
            case 45 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:273: INT
                {
                mINT(); 

                }
                break;
            case 46 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:277: FLOAT
                {
                mFLOAT(); 

                }
                break;
            case 47 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:283: COMMENT
                {
                mCOMMENT(); 

                }
                break;
            case 48 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:291: WS
                {
                mWS(); 

                }
                break;
            case 49 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:294: STRING
                {
                mSTRING(); 

                }
                break;
            case 50 :
                // C:\\Projects\\CalcEngine\\src\\CalcEngine\\Parsers\\Antlr\\AntlrCalcEngine.g:1:301: CHAR
                {
                mCHAR(); 

                }
                break;

        }

    }


    protected DFA12 dfa12 = new DFA12(this);
    protected DFA23 dfa23 = new DFA23(this);
    static final String DFA12_eotS =
        "\5\uffff";
    static final String DFA12_eofS =
        "\5\uffff";
    static final String DFA12_minS =
        "\2\56\3\uffff";
    static final String DFA12_maxS =
        "\1\71\1\145\3\uffff";
    static final String DFA12_acceptS =
        "\2\uffff\1\2\1\1\1\3";
    static final String DFA12_specialS =
        "\5\uffff}>";
    static final String[] DFA12_transitionS = {
            "\1\2\1\uffff\12\1",
            "\1\3\1\uffff\12\1\13\uffff\1\4\37\uffff\1\4",
            "",
            "",
            ""
    };

    static final short[] DFA12_eot = DFA.unpackEncodedString(DFA12_eotS);
    static final short[] DFA12_eof = DFA.unpackEncodedString(DFA12_eofS);
    static final char[] DFA12_min = DFA.unpackEncodedStringToUnsignedChars(DFA12_minS);
    static final char[] DFA12_max = DFA.unpackEncodedStringToUnsignedChars(DFA12_maxS);
    static final short[] DFA12_accept = DFA.unpackEncodedString(DFA12_acceptS);
    static final short[] DFA12_special = DFA.unpackEncodedString(DFA12_specialS);
    static final short[][] DFA12_transition;

    static {
        int numStates = DFA12_transitionS.length;
        DFA12_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA12_transition[i] = DFA.unpackEncodedString(DFA12_transitionS[i]);
        }
    }

    class DFA12 extends DFA {

        public DFA12(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;
        }
        public String getDescription() {
            return "297:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );";
        }
    }
    static final String DFA23_eotS =
        "\1\uffff\1\42\1\uffff\1\42\2\uffff\1\42\1\uffff\2\42\1\55\2\uffff"+
        "\1\42\1\60\1\42\2\uffff\1\42\1\uffff\1\65\1\67\3\uffff\1\71\1\72"+
        "\1\42\3\uffff\1\42\1\102\1\105\1\uffff\1\107\1\uffff\7\42\2\uffff"+
        "\1\42\2\uffff\1\121\1\42\11\uffff\3\42\11\uffff\6\42\1\147\1\42"+
        "\1\151\1\uffff\1\152\3\42\1\106\4\uffff\1\106\5\uffff\6\42\1\uffff"+
        "\1\42\2\uffff\1\175\1\176\1\42\10\uffff\1\u0084\1\42\1\u0086\4\42"+
        "\2\uffff\1\u008b\5\uffff\1\42\1\uffff\4\42\3\uffff\5\42\2\uffff"+
        "\1\42\1\u009b\1\42\1\u009d\2\42\1\uffff\1\42\1\uffff\1\42\1\u00a2"+
        "\1\u00a3\1\42\2\uffff\1\42\1\u00a6\1\uffff";
    static final String DFA23_eofS =
        "\u00a7\uffff";
    static final String DFA23_minS =
        "\1\11\1\141\1\uffff\1\150\2\uffff\1\162\1\uffff\1\142\1\145\1\75"+
        "\2\uffff\1\157\1\75\1\162\2\uffff\1\157\1\uffff\2\75\3\uffff\1\52"+
        "\1\60\1\150\3\uffff\1\141\2\0\1\uffff\1\56\1\uffff\1\141\1\154\1"+
        "\145\1\151\1\163\1\144\1\154\2\uffff\1\164\2\uffff\1\60\1\144\11"+
        "\uffff\1\151\1\165\1\154\2\0\2\uffff\2\0\3\uffff\1\163\1\143\1\162"+
        "\1\160\1\155\1\164\1\60\1\141\1\60\1\uffff\1\60\1\163\1\145\1\163"+
        "\5\0\1\47\4\0\1\uffff\1\163\1\165\2\145\1\141\1\162\1\uffff\1\164"+
        "\2\uffff\2\60\1\145\1\uffff\3\0\1\uffff\3\0\1\60\1\154\1\60\2\162"+
        "\1\141\1\151\2\uffff\1\60\4\0\1\uffff\1\141\1\uffff\1\164\1\171"+
        "\1\143\1\157\1\uffff\2\0\1\164\1\171\1\153\1\164\1\156\2\0\1\145"+
        "\1\60\1\145\1\60\1\163\1\144\1\uffff\1\171\1\uffff\1\150\2\60\1"+
        "\151\2\uffff\1\160\1\60\1\uffff";
    static final String DFA23_maxS =
        "\1\175\1\154\1\uffff\1\150\2\uffff\1\162\1\uffff\1\156\1\145\1"+
        "\75\2\uffff\1\157\1\75\1\162\2\uffff\1\157\1\uffff\1\76\1\75\3\uffff"+
        "\1\57\1\71\1\162\3\uffff\1\141\2\uffff\1\uffff\1\145\1\uffff\1\141"+
        "\1\154\1\145\1\157\1\163\1\144\1\154\2\uffff\1\164\2\uffff\1\172"+
        "\1\144\11\uffff\1\151\1\165\1\154\2\uffff\2\uffff\2\uffff\3\uffff"+
        "\1\163\1\143\1\162\1\160\1\155\1\164\1\172\1\141\1\172\1\uffff\1"+
        "\172\1\163\1\145\1\163\5\uffff\1\47\4\uffff\1\uffff\1\163\1\165"+
        "\2\145\1\141\1\162\1\uffff\1\164\2\uffff\2\172\1\145\1\uffff\3\uffff"+
        "\1\uffff\3\uffff\1\172\1\154\1\172\2\162\1\141\1\151\2\uffff\1\172"+
        "\4\uffff\1\uffff\1\141\1\uffff\1\164\1\171\1\143\1\157\1\uffff\2"+
        "\uffff\1\164\1\171\1\153\1\164\1\156\2\uffff\1\145\1\172\1\145\1"+
        "\172\1\163\1\144\1\uffff\1\171\1\uffff\1\150\2\172\1\151\2\uffff"+
        "\1\160\1\172\1\uffff";
    static final String DFA23_acceptS =
        "\2\uffff\1\2\1\uffff\1\4\1\5\1\uffff\1\7\3\uffff\1\15\1\16\3\uffff"+
        "\1\22\1\24\1\uffff\1\26\2\uffff\1\36\1\37\1\40\3\uffff\1\44\1\45"+
        "\1\46\3\uffff\1\54\1\uffff\1\60\7\uffff\1\27\1\14\1\uffff\1\30\1"+
        "\20\2\uffff\1\31\1\34\1\32\1\35\1\33\1\57\1\41\1\42\1\56\5\uffff"+
        "\1\51\1\53\2\uffff\1\52\1\51\1\55\11\uffff\1\21\16\uffff\1\51\6"+
        "\uffff\1\23\1\uffff\1\17\1\25\3\uffff\1\61\3\uffff\1\62\12\uffff"+
        "\1\43\1\47\5\uffff\1\1\1\uffff\1\3\4\uffff\1\50\17\uffff\1\6\1\uffff"+
        "\1\12\4\uffff\1\11\1\10\2\uffff\1\13";
    static final String DFA23_specialS =
        "\40\uffff\1\2\1\1\35\uffff\1\16\1\7\2\uffff\1\27\1\30\21\uffff"+
        "\1\33\1\5\1\31\1\6\1\32\1\uffff\1\4\1\23\1\22\1\34\17\uffff\1\11"+
        "\1\24\1\21\1\uffff\1\15\1\17\1\14\12\uffff\1\12\1\20\1\26\1\13\10"+
        "\uffff\1\10\1\25\5\uffff\1\3\1\0\22\uffff}>";
    static final String[] DFA23_transitionS = {
            "\2\44\2\uffff\1\44\22\uffff\1\44\1\16\1\40\2\uffff\1\23\1\21"+
            "\1\41\1\13\1\14\1\30\1\26\1\36\1\27\1\32\1\31\12\43\1\2\1\7"+
            "\1\24\1\12\1\25\2\uffff\32\42\1\34\1\uffff\1\35\1\uffff\1\42"+
            "\1\uffff\1\10\1\42\1\1\2\42\1\37\6\42\1\22\1\15\1\17\1\6\1\42"+
            "\1\11\1\42\1\33\2\42\1\3\3\42\1\4\1\20\1\5",
            "\1\46\12\uffff\1\45",
            "",
            "\1\47",
            "",
            "",
            "\1\50",
            "",
            "\1\51\13\uffff\1\52",
            "\1\53",
            "\1\54",
            "",
            "",
            "\1\56",
            "\1\57",
            "\1\61",
            "",
            "",
            "\1\62",
            "",
            "\1\64\1\63",
            "\1\66",
            "",
            "",
            "",
            "\1\70\4\uffff\1\70",
            "\12\73",
            "\1\74\11\uffff\1\75",
            "",
            "",
            "",
            "\1\76",
            "\42\100\1\101\71\100\1\77\uffa3\100",
            "\47\104\1\106\64\104\1\103\uffa3\104",
            "",
            "\1\73\1\uffff\12\43\13\uffff\1\73\37\uffff\1\73",
            "",
            "\1\110",
            "\1\111",
            "\1\112",
            "\1\114\5\uffff\1\113",
            "\1\115",
            "\1\116",
            "\1\117",
            "",
            "",
            "\1\120",
            "",
            "",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\122",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\123",
            "\1\124",
            "\1\125",
            "\42\106\1\126\4\106\1\132\10\106\4\130\4\131\44\106\1\132"+
            "\5\106\1\132\3\106\1\132\7\106\1\132\3\106\1\132\1\106\1\132"+
            "\1\127\uff8a\106",
            "\42\100\1\101\71\100\1\77\uffa3\100",
            "",
            "",
            "\42\106\1\137\4\106\1\133\10\106\4\135\4\136\44\106\1\137"+
            "\5\106\1\137\3\106\1\137\7\106\1\137\3\106\1\137\1\106\1\137"+
            "\1\134\uff8a\106",
            "\47\106\1\140\uffd8\106",
            "",
            "",
            "",
            "\1\141",
            "\1\142",
            "\1\143",
            "\1\144",
            "\1\145",
            "\1\146",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\150",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\153",
            "\1\154",
            "\1\155",
            "\0\156",
            "\60\106\12\157\7\106\6\157\32\106\6\157\uff99\106",
            "\42\100\1\101\15\100\10\160\44\100\1\77\uffa3\100",
            "\42\100\1\101\15\100\10\161\44\100\1\77\uffa3\100",
            "\42\100\1\101\71\100\1\77\uffa3\100",
            "\1\162",
            "\60\106\12\163\7\106\6\163\32\106\6\163\uff99\106",
            "\47\106\1\140\10\106\10\164\uffc8\106",
            "\47\106\1\140\10\106\10\165\uffc8\106",
            "\47\106\1\140\uffd8\106",
            "",
            "\1\166",
            "\1\167",
            "\1\170",
            "\1\171",
            "\1\172",
            "\1\173",
            "",
            "\1\174",
            "",
            "",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\177",
            "",
            "\60\106\12\u0080\7\106\6\u0080\32\106\6\u0080\uff99\106",
            "\42\100\1\101\15\100\10\u0081\44\100\1\77\uffa3\100",
            "\42\100\1\101\71\100\1\77\uffa3\100",
            "",
            "\60\106\12\u0082\7\106\6\u0082\32\106\6\u0082\uff99\106",
            "\47\106\1\140\10\106\10\u0083\uffc8\106",
            "\47\106\1\140\uffd8\106",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\u0085",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\u0087",
            "\1\u0088",
            "\1\u0089",
            "\1\u008a",
            "",
            "",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\60\106\12\u008c\7\106\6\u008c\32\106\6\u008c\uff99\106",
            "\42\100\1\101\71\100\1\77\uffa3\100",
            "\60\106\12\u008d\7\106\6\u008d\32\106\6\u008d\uff99\106",
            "\47\106\1\140\uffd8\106",
            "",
            "\1\u008e",
            "",
            "\1\u008f",
            "\1\u0090",
            "\1\u0091",
            "\1\u0092",
            "",
            "\60\106\12\u0093\7\106\6\u0093\32\106\6\u0093\uff99\106",
            "\60\106\12\u0094\7\106\6\u0094\32\106\6\u0094\uff99\106",
            "\1\u0095",
            "\1\u0096",
            "\1\u0097",
            "\1\u0098",
            "\1\u0099",
            "\42\100\1\101\71\100\1\77\uffa3\100",
            "\47\106\1\140\uffd8\106",
            "\1\u009a",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\u009c",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\u009e",
            "\1\u009f",
            "",
            "\1\u00a0",
            "",
            "\1\u00a1",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            "\1\u00a4",
            "",
            "",
            "\1\u00a5",
            "\12\42\7\uffff\32\42\4\uffff\1\42\1\uffff\32\42",
            ""
    };

    static final short[] DFA23_eot = DFA.unpackEncodedString(DFA23_eotS);
    static final short[] DFA23_eof = DFA.unpackEncodedString(DFA23_eofS);
    static final char[] DFA23_min = DFA.unpackEncodedStringToUnsignedChars(DFA23_minS);
    static final char[] DFA23_max = DFA.unpackEncodedStringToUnsignedChars(DFA23_maxS);
    static final short[] DFA23_accept = DFA.unpackEncodedString(DFA23_acceptS);
    static final short[] DFA23_special = DFA.unpackEncodedString(DFA23_specialS);
    static final short[][] DFA23_transition;

    static {
        int numStates = DFA23_transitionS.length;
        DFA23_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA23_transition[i] = DFA.unpackEncodedString(DFA23_transitionS[i]);
        }
    }

    class DFA23 extends DFA {

        public DFA23(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;
        }
        public String getDescription() {
            return "1:1: Tokens : ( T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | T__94 | T__95 | T__96 | LITERAL | SQUOT | DQUOT | ID | INT | FLOAT | COMMENT | WS | STRING | CHAR );";
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            IntStream input = _input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA23_148 = input.LA(1);

                        s = -1;
                        if ( (LA23_148=='\'') ) {s = 96;}

                        else if ( ((LA23_148>='\u0000' && LA23_148<='&')||(LA23_148>='(' && LA23_148<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA23_33 = input.LA(1);

                        s = -1;
                        if ( (LA23_33=='\\') ) {s = 67;}

                        else if ( ((LA23_33>='\u0000' && LA23_33<='&')||(LA23_33>='(' && LA23_33<='[')||(LA23_33>=']' && LA23_33<='\uFFFF')) ) {s = 68;}

                        else if ( (LA23_33=='\'') ) {s = 70;}

                        else s = 69;

                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA23_32 = input.LA(1);

                        s = -1;
                        if ( (LA23_32=='\\') ) {s = 63;}

                        else if ( ((LA23_32>='\u0000' && LA23_32<='!')||(LA23_32>='#' && LA23_32<='[')||(LA23_32>=']' && LA23_32<='\uFFFF')) ) {s = 64;}

                        else if ( (LA23_32=='\"') ) {s = 65;}

                        else s = 66;

                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA23_147 = input.LA(1);

                        s = -1;
                        if ( (LA23_147=='\"') ) {s = 65;}

                        else if ( (LA23_147=='\\') ) {s = 63;}

                        else if ( ((LA23_147>='\u0000' && LA23_147<='!')||(LA23_147>='#' && LA23_147<='[')||(LA23_147>=']' && LA23_147<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA23_92 = input.LA(1);

                        s = -1;
                        if ( ((LA23_92>='\u0000' && LA23_92<='/')||(LA23_92>=':' && LA23_92<='@')||(LA23_92>='G' && LA23_92<='`')||(LA23_92>='g' && LA23_92<='\uFFFF')) ) {s = 70;}

                        else if ( ((LA23_92>='0' && LA23_92<='9')||(LA23_92>='A' && LA23_92<='F')||(LA23_92>='a' && LA23_92<='f')) ) {s = 115;}

                        if ( s>=0 ) return s;
                        break;
                    case 5 : 
                        int LA23_87 = input.LA(1);

                        s = -1;
                        if ( ((LA23_87>='0' && LA23_87<='9')||(LA23_87>='A' && LA23_87<='F')||(LA23_87>='a' && LA23_87<='f')) ) {s = 111;}

                        else if ( ((LA23_87>='\u0000' && LA23_87<='/')||(LA23_87>=':' && LA23_87<='@')||(LA23_87>='G' && LA23_87<='`')||(LA23_87>='g' && LA23_87<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 6 : 
                        int LA23_89 = input.LA(1);

                        s = -1;
                        if ( (LA23_89=='\"') ) {s = 65;}

                        else if ( (LA23_89=='\\') ) {s = 63;}

                        else if ( ((LA23_89>='0' && LA23_89<='7')) ) {s = 113;}

                        else if ( ((LA23_89>='\u0000' && LA23_89<='!')||(LA23_89>='#' && LA23_89<='/')||(LA23_89>='8' && LA23_89<='[')||(LA23_89>=']' && LA23_89<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 7 : 
                        int LA23_64 = input.LA(1);

                        s = -1;
                        if ( (LA23_64=='\"') ) {s = 65;}

                        else if ( (LA23_64=='\\') ) {s = 63;}

                        else if ( ((LA23_64>='\u0000' && LA23_64<='!')||(LA23_64>='#' && LA23_64<='[')||(LA23_64>=']' && LA23_64<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 8 : 
                        int LA23_140 = input.LA(1);

                        s = -1;
                        if ( ((LA23_140>='0' && LA23_140<='9')||(LA23_140>='A' && LA23_140<='F')||(LA23_140>='a' && LA23_140<='f')) ) {s = 147;}

                        else if ( ((LA23_140>='\u0000' && LA23_140<='/')||(LA23_140>=':' && LA23_140<='@')||(LA23_140>='G' && LA23_140<='`')||(LA23_140>='g' && LA23_140<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 9 : 
                        int LA23_111 = input.LA(1);

                        s = -1;
                        if ( ((LA23_111>='0' && LA23_111<='9')||(LA23_111>='A' && LA23_111<='F')||(LA23_111>='a' && LA23_111<='f')) ) {s = 128;}

                        else if ( ((LA23_111>='\u0000' && LA23_111<='/')||(LA23_111>=':' && LA23_111<='@')||(LA23_111>='G' && LA23_111<='`')||(LA23_111>='g' && LA23_111<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 10 : 
                        int LA23_128 = input.LA(1);

                        s = -1;
                        if ( ((LA23_128>='0' && LA23_128<='9')||(LA23_128>='A' && LA23_128<='F')||(LA23_128>='a' && LA23_128<='f')) ) {s = 140;}

                        else if ( ((LA23_128>='\u0000' && LA23_128<='/')||(LA23_128>=':' && LA23_128<='@')||(LA23_128>='G' && LA23_128<='`')||(LA23_128>='g' && LA23_128<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 11 : 
                        int LA23_131 = input.LA(1);

                        s = -1;
                        if ( (LA23_131=='\'') ) {s = 96;}

                        else if ( ((LA23_131>='\u0000' && LA23_131<='&')||(LA23_131>='(' && LA23_131<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 12 : 
                        int LA23_117 = input.LA(1);

                        s = -1;
                        if ( (LA23_117=='\'') ) {s = 96;}

                        else if ( ((LA23_117>='\u0000' && LA23_117<='&')||(LA23_117>='(' && LA23_117<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 13 : 
                        int LA23_115 = input.LA(1);

                        s = -1;
                        if ( ((LA23_115>='\u0000' && LA23_115<='/')||(LA23_115>=':' && LA23_115<='@')||(LA23_115>='G' && LA23_115<='`')||(LA23_115>='g' && LA23_115<='\uFFFF')) ) {s = 70;}

                        else if ( ((LA23_115>='0' && LA23_115<='9')||(LA23_115>='A' && LA23_115<='F')||(LA23_115>='a' && LA23_115<='f')) ) {s = 130;}

                        if ( s>=0 ) return s;
                        break;
                    case 14 : 
                        int LA23_63 = input.LA(1);

                        s = -1;
                        if ( (LA23_63=='\"') ) {s = 86;}

                        else if ( (LA23_63=='u') ) {s = 87;}

                        else if ( ((LA23_63>='0' && LA23_63<='3')) ) {s = 88;}

                        else if ( ((LA23_63>='4' && LA23_63<='7')) ) {s = 89;}

                        else if ( (LA23_63=='\''||LA23_63=='\\'||LA23_63=='b'||LA23_63=='f'||LA23_63=='n'||LA23_63=='r'||LA23_63=='t') ) {s = 90;}

                        else if ( ((LA23_63>='\u0000' && LA23_63<='!')||(LA23_63>='#' && LA23_63<='&')||(LA23_63>='(' && LA23_63<='/')||(LA23_63>='8' && LA23_63<='[')||(LA23_63>=']' && LA23_63<='a')||(LA23_63>='c' && LA23_63<='e')||(LA23_63>='g' && LA23_63<='m')||(LA23_63>='o' && LA23_63<='q')||LA23_63=='s'||(LA23_63>='v' && LA23_63<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 15 : 
                        int LA23_116 = input.LA(1);

                        s = -1;
                        if ( (LA23_116=='\'') ) {s = 96;}

                        else if ( ((LA23_116>='0' && LA23_116<='7')) ) {s = 131;}

                        else if ( ((LA23_116>='\u0000' && LA23_116<='&')||(LA23_116>='(' && LA23_116<='/')||(LA23_116>='8' && LA23_116<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 16 : 
                        int LA23_129 = input.LA(1);

                        s = -1;
                        if ( (LA23_129=='\"') ) {s = 65;}

                        else if ( (LA23_129=='\\') ) {s = 63;}

                        else if ( ((LA23_129>='\u0000' && LA23_129<='!')||(LA23_129>='#' && LA23_129<='[')||(LA23_129>=']' && LA23_129<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 17 : 
                        int LA23_113 = input.LA(1);

                        s = -1;
                        if ( (LA23_113=='\"') ) {s = 65;}

                        else if ( (LA23_113=='\\') ) {s = 63;}

                        else if ( ((LA23_113>='\u0000' && LA23_113<='!')||(LA23_113>='#' && LA23_113<='[')||(LA23_113>=']' && LA23_113<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 18 : 
                        int LA23_94 = input.LA(1);

                        s = -1;
                        if ( ((LA23_94>='0' && LA23_94<='7')) ) {s = 117;}

                        else if ( (LA23_94=='\'') ) {s = 96;}

                        else if ( ((LA23_94>='\u0000' && LA23_94<='&')||(LA23_94>='(' && LA23_94<='/')||(LA23_94>='8' && LA23_94<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 19 : 
                        int LA23_93 = input.LA(1);

                        s = -1;
                        if ( ((LA23_93>='0' && LA23_93<='7')) ) {s = 116;}

                        else if ( (LA23_93=='\'') ) {s = 96;}

                        else if ( ((LA23_93>='\u0000' && LA23_93<='&')||(LA23_93>='(' && LA23_93<='/')||(LA23_93>='8' && LA23_93<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 20 : 
                        int LA23_112 = input.LA(1);

                        s = -1;
                        if ( (LA23_112=='\"') ) {s = 65;}

                        else if ( (LA23_112=='\\') ) {s = 63;}

                        else if ( ((LA23_112>='0' && LA23_112<='7')) ) {s = 129;}

                        else if ( ((LA23_112>='\u0000' && LA23_112<='!')||(LA23_112>='#' && LA23_112<='/')||(LA23_112>='8' && LA23_112<='[')||(LA23_112>=']' && LA23_112<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 21 : 
                        int LA23_141 = input.LA(1);

                        s = -1;
                        if ( ((LA23_141>='0' && LA23_141<='9')||(LA23_141>='A' && LA23_141<='F')||(LA23_141>='a' && LA23_141<='f')) ) {s = 148;}

                        else if ( ((LA23_141>='\u0000' && LA23_141<='/')||(LA23_141>=':' && LA23_141<='@')||(LA23_141>='G' && LA23_141<='`')||(LA23_141>='g' && LA23_141<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 22 : 
                        int LA23_130 = input.LA(1);

                        s = -1;
                        if ( ((LA23_130>='0' && LA23_130<='9')||(LA23_130>='A' && LA23_130<='F')||(LA23_130>='a' && LA23_130<='f')) ) {s = 141;}

                        else if ( ((LA23_130>='\u0000' && LA23_130<='/')||(LA23_130>=':' && LA23_130<='@')||(LA23_130>='G' && LA23_130<='`')||(LA23_130>='g' && LA23_130<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 23 : 
                        int LA23_67 = input.LA(1);

                        s = -1;
                        if ( (LA23_67=='\'') ) {s = 91;}

                        else if ( (LA23_67=='u') ) {s = 92;}

                        else if ( ((LA23_67>='0' && LA23_67<='3')) ) {s = 93;}

                        else if ( ((LA23_67>='4' && LA23_67<='7')) ) {s = 94;}

                        else if ( (LA23_67=='\"'||LA23_67=='\\'||LA23_67=='b'||LA23_67=='f'||LA23_67=='n'||LA23_67=='r'||LA23_67=='t') ) {s = 95;}

                        else if ( ((LA23_67>='\u0000' && LA23_67<='!')||(LA23_67>='#' && LA23_67<='&')||(LA23_67>='(' && LA23_67<='/')||(LA23_67>='8' && LA23_67<='[')||(LA23_67>=']' && LA23_67<='a')||(LA23_67>='c' && LA23_67<='e')||(LA23_67>='g' && LA23_67<='m')||(LA23_67>='o' && LA23_67<='q')||LA23_67=='s'||(LA23_67>='v' && LA23_67<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 24 : 
                        int LA23_68 = input.LA(1);

                        s = -1;
                        if ( (LA23_68=='\'') ) {s = 96;}

                        else if ( ((LA23_68>='\u0000' && LA23_68<='&')||(LA23_68>='(' && LA23_68<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
                    case 25 : 
                        int LA23_88 = input.LA(1);

                        s = -1;
                        if ( (LA23_88=='\"') ) {s = 65;}

                        else if ( (LA23_88=='\\') ) {s = 63;}

                        else if ( ((LA23_88>='0' && LA23_88<='7')) ) {s = 112;}

                        else if ( ((LA23_88>='\u0000' && LA23_88<='!')||(LA23_88>='#' && LA23_88<='/')||(LA23_88>='8' && LA23_88<='[')||(LA23_88>=']' && LA23_88<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 26 : 
                        int LA23_90 = input.LA(1);

                        s = -1;
                        if ( (LA23_90=='\"') ) {s = 65;}

                        else if ( (LA23_90=='\\') ) {s = 63;}

                        else if ( ((LA23_90>='\u0000' && LA23_90<='!')||(LA23_90>='#' && LA23_90<='[')||(LA23_90>=']' && LA23_90<='\uFFFF')) ) {s = 64;}

                        if ( s>=0 ) return s;
                        break;
                    case 27 : 
                        int LA23_86 = input.LA(1);

                        s = -1;
                        if ( ((LA23_86>='\u0000' && LA23_86<='\uFFFF')) ) {s = 110;}

                        else s = 70;

                        if ( s>=0 ) return s;
                        break;
                    case 28 : 
                        int LA23_95 = input.LA(1);

                        s = -1;
                        if ( (LA23_95=='\'') ) {s = 96;}

                        else if ( ((LA23_95>='\u0000' && LA23_95<='&')||(LA23_95>='(' && LA23_95<='\uFFFF')) ) {s = 70;}

                        if ( s>=0 ) return s;
                        break;
            }
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 23, _s, input);
            error(nvae);
            throw nvae;
        }
    }
 

}