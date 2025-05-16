using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Antlr4.Runtime;
using ProjAntlr4Test.antlr;
using Antlr4.Runtime.Tree;

namespace ProjAntlr4Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<string> ParseErrorList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            text = "FM { P1 'p1str' P2 'p2str' PREDICTION TRUE }";
            text = "FM { P1 'p1str' P2 'p2str' PREDICTION TRUE ";
        }

        private void BtnParse(object sender, RoutedEventArgs e)
        {
            parseText = "...";

            //start test
            string input = text;
            //ICharStream chartStream = CharStreams.fromString(text);
            //ITokenSource lexer = new HelloLexer(chartStream);
            var stream = new AntlrInputStream(input);
            var lexer = new HelloLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new HelloParser(tokens);
            parser.BuildParseTree = true;

            var MyL2 = new LexerErrorListener();
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(MyL2);

            var MyL1 = new MyHelloParseListener();
            parser.RemoveErrorListeners();
            parser.AddErrorListener(MyL1);

            var fmStartRule = parser.start_rule();

            parseText = fmStartRule.ToStringTree();

            MyHelloListener listener = new MyHelloListener();
            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(listener, fmStartRule);
        }

        #region Get/Set
        private string _text;
        private string _parseText;
        public string text
        {
            get { return _text; }
            set {_text = value; OnPropertyChanged();}
        }
        public string parseText
        {
            get { return _parseText; }
            set { _parseText = value; OnPropertyChanged(); }
        }
        #endregion
        #region 
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
