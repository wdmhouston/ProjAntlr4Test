using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using ProjAntlr4Test.antlr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAntlr4Test
{
    public class MyHelloListener : IHelloListener
    {
        public void EnterBoolean([NotNull] HelloParser.BooleanContext context)
        {
            //throw new NotImplementedException();
            //var v = Boolean.Parse(context.GetText());
            //Console.WriteLine("v=" + v.ToString());
        }

        public void EnterEveryRule(ParserRuleContext ctx)
        {
            //throw new NotImplementedException();
        }

        public void EnterFm_block([NotNull] HelloParser.Fm_blockContext context)
        {
            //throw new NotImplementedException();
            //Console.WriteLine(context.GetText());
            var keyword = context.GetChild(0).GetText();
            var value = context.GetChild(1).GetText();
            Console.WriteLine(keyword + ": " + value);
            var parent = context.Parent as HelloParser.Fm_sectionContext;
        }

        public void EnterFm_section([NotNull] HelloParser.Fm_sectionContext context)
        {
            //throw new NotImplementedException();
            Console.WriteLine("FM");
        }

        public void EnterStart_rule([NotNull] HelloParser.Start_ruleContext context)
        {
            //throw new NotImplementedException();
        }

        public void EnterSub_ents([NotNull] HelloParser.Sub_entsContext context)
        {
            //throw new NotImplementedException();
        }

        public void ExitBoolean([NotNull] HelloParser.BooleanContext context)
        {
            //throw new NotImplementedException();
        }

        public void ExitEveryRule(ParserRuleContext ctx)
        {
            //throw new NotImplementedException();
        }

        public void ExitFm_block([NotNull] HelloParser.Fm_blockContext context)
        {
            //throw new NotImplementedException();
        }

        public void ExitFm_section([NotNull] HelloParser.Fm_sectionContext context)
        {
            //throw new NotImplementedException();
            Console.WriteLine("FM");
        }

        public void ExitStart_rule([NotNull] HelloParser.Start_ruleContext context)
        {
            //throw new NotImplementedException();
        }

        public void ExitSub_ents([NotNull] HelloParser.Sub_entsContext context)
        {
            //throw new NotImplementedException();
        }

        public void VisitErrorNode(IErrorNode node)
        {
            //throw new NotImplementedException();
            Console.WriteLine(node.GetText());
        }

        public void VisitTerminal(ITerminalNode node)
        {
            //throw new NotImplementedException();
        }
    }
}
