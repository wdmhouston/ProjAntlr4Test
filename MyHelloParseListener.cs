using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAntlr4Test
{
    public class MyHelloParseListener: BaseErrorListener
    {
        public override void SyntaxError(
        TextWriter output, IRecognizer recognizer,
        IToken offendingSymbol, int line,
        int charPositionInLine, string msg,
        RecognitionException e)
        {
            string sourceName = recognizer.InputStream.SourceName;
            Console.WriteLine("line:{0} col:{1} src:{2} msg:{3}", line, charPositionInLine, sourceName, msg);
            if (e != null)
            {
                Console.WriteLine("----------1----------");
                Console.WriteLine(e);
                Console.WriteLine("----------1----------");
            }
        }
    }
    public class LexerErrorListener : IAntlrErrorListener<int>
    {
        public void SyntaxError(TextWriter output, 
            IRecognizer recognizer, 
            int offendingSymbol, 
            int line, 
            int charPositionInLine, 
            string msg, RecognitionException e)
        {
            string sourceName = recognizer.InputStream.SourceName;
            Console.WriteLine("line:{0} col:{1} src:{2} msg:{3}", line, charPositionInLine, sourceName, msg);
            if (e != null)
            {
                Console.WriteLine("----------2----------");
                Console.WriteLine(e);
                Console.WriteLine("----------2----------");
            }
        }
    }
}
