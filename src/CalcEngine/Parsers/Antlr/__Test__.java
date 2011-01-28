import java.io.*;
import org.antlr.runtime.*;
import org.antlr.runtime.debug.DebugEventSocketProxy;


public class __Test__ {

    public static void main(String args[]) throws Exception {
        AntlrCalcEngineLexer lex = new AntlrCalcEngineLexer(new ANTLRFileStream("C:\\Users\\chris.edwards.BANCVUE\\Documents\\My Dropbox\\Development\\TEA CalcEngine\\DisassembledCalcEngine\\grammar\\test_expressions.txt", "UTF8"));
        CommonTokenStream tokens = new CommonTokenStream(lex);

        AntlrCalcEngineParser g = new AntlrCalcEngineParser(tokens, 49100, null);
        try {
            g.root();
        } catch (RecognitionException e) {
            e.printStackTrace();
        }
    }
}