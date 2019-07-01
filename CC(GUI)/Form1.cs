using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CC_GUI_
{
    public partial class WndMain : Form
    {

        static Dictionary<string, string> operators;
        static Dictionary<string, string> dataTypes;
        static Dictionary<string, string> keywords;
        static Dictionary<string, string> symbols;
        static Dictionary<string, string> consoleMethods;

        public static void InitiateOperators()
        {
            operators = new Dictionary<string, string>
            {
                //Arthmetic Operators
                { "+", "Addition Operator" },
                {"-", "Subtraction Operator"},
                {"*", "Multiplication Operator/Pointer to a variable"},
                {"/", "Division Operator"},
                {"%", "Modulus Operator"},
                {"++", "Increment Operator"},
                {"--", "Decrement Operator"},
                //Relational Operators
                {"==", "Compare Operator"},
                {"!=", "Not Equal Operator"},
                {">", "Greater Than Operator"},
                {"<", "Less Than Operator"},
                {">=", "Greater Than Equal Operator"},
                {"<=", "Less Than Operator"},
                //Logical Operators
                {"&&", "AND Operator"},
                {"||", "OR Operator"},
                {"!", "NOT Operator"},
                //Bitwise Operators
                {"&", "Binary AND Operator/Returns the address of an variable"},
                {"|", "Binary OR Operator"},
                {"^", "Binary XOR"},
                {"~", "Binary Ones Operator"},
                {"<<", "Binary LeftOperator"},
                {">>", "Binary Right Operator"},
                //Assignment Operators
                {"=", "Assignmnet Operator"},
                {"+=", "Add & Assignment Operator"},
                {"-=", "Subtract & Assignment Operator"},
                {"*=", "Multiply & Assignment Operator"},
                {"/=", "Divide & Assignment Operator"},
                {"%=", "Modulus & Assignment Operator"},
                {"<<=", "Left Shift & Assignment Operator"},
                {">>=", "Right Shift & Assignment Operator"},
                {"&=", "Bitwise AND & Assignment Operator"},
                {"^=", "bitwise exclusive OR and assignment operator"},
                {"|=", "bitwise inclusive OR and assignment operator"},
                //Miscellaneous Operators
                {"sizeof()", "Returns the size of data type"},
                {"typeof()", "Retruns the type of a class"},
                //{"*", "Pointer to a variable"},
                {"? :", "Conditional Operator"},
                {"is", "Determines whether an object is of a certain type"},
                {"as", "Cast without raising an exception if the cast fails."},
            };
        }

        public static void InitiateDataTypes()
        {
            dataTypes = new Dictionary<string, string> { };
            dataTypes.Add("bool", "Returns true or false");
            dataTypes.Add("byte", "8-bit unsigned integer/ 0 to 255");
            dataTypes.Add("char", "16-bit Unicode character/ U +0000 to U +ffff");
            dataTypes.Add("decimal", "128-bit precise decimal values with 28-29 significant digits/ (-7.9x10^28 to 7.9x10^28)/10^0 to 28");
            dataTypes.Add("double", "64-bit double precision floating point type/ (+/-)5.0x10^-324 to (+/-)1.7x10^308");
            dataTypes.Add("float", "32-bit single precision floating point type/ -3.4x10^38 to +3.4x10^38");
            dataTypes.Add("int", "32-bit signed integer type/ -2,147,483,648 to 2,147,483,647");
            dataTypes.Add("long", "64-bit signed integer type/ -9,223,372,036,854,775,808 to +9,223,372,036,854,775,808");
            dataTypes.Add("sbyte", "8-bit signed integer type/ -32,768 to 32,767");
            dataTypes.Add("short", "16-bit signed integer type/ -32,768 to 32,767");
            dataTypes.Add("uint", "32-bit unsignedinteger type/ 0 to 4,294,967,295");
            dataTypes.Add("ulong", "64-bit unsigned integer type/ 0 to 18,446,744,073,709,551,615");
            dataTypes.Add("ushort", "16-bit unsigned integer type/ 0 to 65,535");
            dataTypes.Add("string", "");
        }

        public static void InititalizeKeyWords()
        {
            keywords = new Dictionary<string, string> { };
            keywords.Add("base", "Access Keyword");
            keywords.Add("this", "Access Keyword");
            keywords.Add("null", "Literal Keyword");
            keywords.Add("false", "Literal Keyword");
            keywords.Add("true", "Literal Keyword");
            keywords.Add("value", "Literal Keyword/ Contextual Keyword");
            keywords.Add("void", "Literal Keyword");
            keywords.Add("add", "Contextual Keywords");
            keywords.Add("var", "Contextual Keywords");
            keywords.Add("dynamic", "Contextual Keywords");
            keywords.Add("global", "Contextual Keywords");
            keywords.Add("set", "Contextual Keywords");
            keywords.Add("from", "Query Keywords");
            keywords.Add("where", "Query Keywords");
            keywords.Add("select", "Query Keywords");
            keywords.Add("group", "Query Keywords");
            keywords.Add("into", "Query Keywords");
            keywords.Add("orderby", "Query Keywords");
            keywords.Add("join", "Query Keywords");
            keywords.Add("let", "Query Keywords");
            keywords.Add("in", "Query Keywords");
            keywords.Add("on", "Query Keywords");
            keywords.Add("equals", "Query Keywords");
            keywords.Add("by", "Query Keywords");
            keywords.Add("ascending", "Query Keywords");
            keywords.Add("descending", "Query Keywords");
            keywords.Add("abstract", "");
            keywords.Add("event", "");
            keywords.Add("fixed", "");
            keywords.Add("if", "");
            keywords.Add("interval", "");
            keywords.Add("new", "");
            keywords.Add("override", "");
            keywords.Add("readonly", "");
            keywords.Add("try", "");
            keywords.Add("unsafe", "");
            keywords.Add("as", "");
            keywords.Add("case", "");
            keywords.Add("const", "");
            keywords.Add("do", "");
            keywords.Add("explicit", "");
            keywords.Add("implicit", "");
            keywords.Add("is", "");
            keywords.Add("params", "");
            keywords.Add("ref", "");
            keywords.Add("sizeof", "");
            keywords.Add("switch", "");
            keywords.Add("typeof", "");
            keywords.Add("volatile", "");
            keywords.Add("catch", "");
            keywords.Add("continue", "");
            keywords.Add("double", "");
            keywords.Add("extern", "");
            keywords.Add("for", "");
            keywords.Add("lock", "");
            keywords.Add("object", "");
            keywords.Add("private", "");
            keywords.Add("return", "");
            keywords.Add("stackalloc", "");
            keywords.Add("using", "");
            keywords.Add("while", "");
            keywords.Add("else", "");
            keywords.Add("foreach", "");
            keywords.Add("operator", "");
            keywords.Add("protected", "");
            keywords.Add("static", "");
            keywords.Add("throw", "");
            keywords.Add("break", "");
            keywords.Add("checked", "");
            keywords.Add("default", "");
            keywords.Add("enum", "");
            keywords.Add("finally", "");
            keywords.Add("goto", "");
            keywords.Add("interface", "");
            keywords.Add("namespace", "");
            keywords.Add("out", "");
            keywords.Add("public", "");
            keywords.Add("sealed", "");
            keywords.Add("unchecked", "");
            keywords.Add("virtual", "");
            //Special C# Identifiers
            keywords.Add("alias", "Special C# Identifiers");
            keywords.Add("get", "Special C# Identifiers");
            keywords.Add("async", "Special C# Identifiers");
            keywords.Add("await", "Special C# Identifiers");
            keywords.Add("nameof", "Special C# Identifiers");
            keywords.Add("partial", "Special C# Identifiers");
            keywords.Add("when", "Special C# Identifiers");
            keywords.Add("remove", "Special C# Identifiers");
            keywords.Add("yield", "Special C# Identifiers");
        }

        public static void InitializeSymbols()
        {
            symbols = new Dictionary<string, string>();
            symbols.Add("(", "");
            symbols.Add(")", "");
            symbols.Add(",", "");
            symbols.Add("'", "");
            symbols.Add('"'.ToString(), "");
            symbols.Add("{", "");
            symbols.Add("}", "");
            symbols.Add("[", "");
            symbols.Add("]", "");
        }

        public static void InitializeConsoleMethods()
        {
            consoleMethods = new Dictionary<string, string>();
            consoleMethods.Add("Console", "");
            consoleMethods.Add("Console.Beep", "");
            consoleMethods.Add("Console.Clear", "");
            consoleMethods.Add("Console.MoveAreBuffer", "");
            consoleMethods.Add("Console.Read", "");
            consoleMethods.Add("Console.ReadKey", "");
            consoleMethods.Add("Console.ReadLine", "");
            consoleMethods.Add("Console.Write", "");
            consoleMethods.Add("Console.WriteLine", "");

        }

        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = codeText.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)codeText.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)codeText.Font.Size;
            }
            else
            {
                w = 50 + (int)codeText.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1    
            int First_Index = codeText.GetCharIndexFromPosition(pt);
            int First_Line = codeText.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1    
            int Last_Index = codeText.GetCharIndexFromPosition(pt);
            int Last_Line = codeText.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox    
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 1; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }

        public WndMain()
        {
            InitializeComponent();
            InitiateOperators();
            InitiateDataTypes();
            InititalizeKeyWords();
            InitializeSymbols();
            InitializeConsoleMethods();
        }

        private void Tokenization()
        {
            string statement = codeText.Text;
            var lines = statement.Split('\n');

            List<string[]> tokens = new List<string[]>();

            foreach (var token in lines)
            {
                tokens.Add(token.Split(' '));
            }

            int jStarter = 0;
            var lineBreaker = 0;

            bool terminatorError = false;
            int lineNo = 0;

            for (var i = 0; i < tokens.Count; i++)
            {
                for (var k = 0; k < tokens[i].Length; k++)
                {
                    if (tokens[i][k] == ";")
                    {
                        terminatorError = false;
                        lineNo = 0;
                        lineBreaker = k;
                        for (var j = jStarter; j <= lineBreaker; j++)
                        {
                            if (keywords.ContainsKey(tokens[i][j]))
                            {
                                if (tokens[i][j].Contains(";"))
                                {
                                    tokenText.AppendText($"<keyword>, {tokens[i][j].Split(';')[0]}>");
                                    tokenText.AppendText("<terminal, ;>\n");
                                }
                                else
                                {
                                    tokenText.AppendText($"<keyword, {tokens[i][j]}>\n");
                                }

                            }
                            else if (operators.ContainsKey(tokens[i][j]))
                            {
                                if (tokens[i][j].Contains(";"))
                                {
                                    tokenText.AppendText($"<Operators>, {tokens[i][j].Split(';')[0]}>\n");
                                    tokenText.AppendText("<terminal, ;>\n");
                                }
                                else
                                {
                                    tokenText.AppendText($"<Operators, {tokens[i][j]}>\n");
                                }
                            }
                            else if (dataTypes.ContainsKey(tokens[i][j]))
                            {
                                if (tokens[i][j].Contains(";"))
                                {
                                    tokenText.AppendText($"<DataTypes>, {tokens[i][j].Split(';')[0]}>\n");
                                    tokenText.AppendText($"<DataTypes>, {tokens[i][j].Split(';')[0]}>\n");
                                }
                                else
                                {
                                    tokenText.AppendText($"<DataTypes, {tokens[i][j]}>\n");
                                }
                            }
                            else if (symbols.ContainsKey(tokens[i][j]))
                            {
                                if (tokens[i][j].Contains(";"))
                                {
                                    tokenText.AppendText($"<Symbol>, {tokens[i][j].Split(';')[0]}>\n");
                                    tokenText.AppendText("<terminal, ;>\n");
                                }
                                else
                                {
                                    tokenText.AppendText($"<Symbol, {tokens[i][j]}>\n");
                                }
                            }
                            else if (consoleMethods.ContainsKey(tokens[i][j]))
                            {
                                if (tokens[i][j].Contains(";"))
                                {
                                    tokenText.AppendText($"<Method/Function>, {tokens[i][j]}>\n");
                                    tokenText.AppendText("<terminal, ;>\n");
                                }
                                else
                                {
                                    tokenText.AppendText($"<Method/Function, {tokens[i][j]}>\n");
                                }
                            }
                            else
                            {
                                if (tokens[i][j].Contains(';'))
                                {
                                    var getType = CheckDataType(tokens[i][j].Split(';')[0]);
                                    tokenText.AppendText($"{getType}\n");
                                    tokenText.AppendText("<terminal, ;>\n");
                                }
                                else
                                {
                                    var getType = CheckDataType(tokens[i][j]);
                                    if (getType != null)
                                    {
                                        if (tokens[i][j].Contains(";"))
                                        {
                                            tokenText.AppendText($"<{getType}, {tokens[i][j].Split(';')[0]}>\n");
                                            tokenText.AppendText($"<{getType}, {tokens[i][j].Split(';')[0]}>\n");
                                        }
                                        else
                                        {
                                            tokenText.AppendText($"{getType}\n");
                                        }
                                    }
                                    else
                                    {
                                        if (tokens[i][j].Contains(";"))
                                        {
                                            tokenText.AppendText($"<Variable, {tokens[i][j].Split(';')[0]}>\n");
                                            tokenText.AppendText("<terminal, ;>\n");
                                        }
                                        else
                                        {
                                            tokenText.AppendText($"<Variable, {tokens[i][j]}>\n");
                                        }
                                    }
                                }
                            }
                        }
                        jStarter = i;
                    }
                    else
                    {
                        terminatorError = true;
                        lineNo = i;
                    }
                }
            }
            if (terminatorError)
            {
                errorRichTextbox.AppendText($"Error in Line {lineNo + 1}: Missing Terminatior ';' \n");
            }
        }

        private string CheckDataType(string input)
        {
            string result = null;

            if (!string.IsNullOrEmpty(input))
            {
                if (dataTypes.ContainsKey(input.ToLower()))
                {
                    MessageBox.Show("TEST");
                    tokenText.AppendText($"{dataTypes[input]}\n");
                }
                else if (int.TryParse(input, out int tryInt))
                {
                    result = $"<Integer, {input}>";
                }
                else if (float.TryParse(input, out float tryFloat))
                {
                    result = $"<Float, {input}>";
                }
                else if (bool.TryParse(input, out bool tryBool))
                {
                    result = $"<Bool, {input}>";
                }
                else if (double.TryParse(input, out double tryDouble))
                {
                    result = $"<Double, {input}>";
                }
            }

            return result;
        }

        private void SyntaxAnalysis()
        {
            string statement = codeText.Text;
            var lines = statement.Split('\n');

            List<string[]> tokens = new List<string[]>();

            foreach (var token in lines)
            {
                tokens.Add(token.Split(' '));
            }

            int jStarter = 0;
            int errorCorrection = 0;

            try
            {
                for (var i = 0; i < tokens.Count; i++)
                {
                    for (var k = 0; k < tokens[i].Length; k++)
                    {
                        //MessageBox.Show(tokens[i][k]);
                        if (tokens[i][k] == ";")
                        {
                            int lineBreaker = k;
                            for (var j = jStarter; j < lineBreaker; j++)
                            {
                                if (i > 1)
                                {
                                    errorCorrection++;
                                }
                                if (j >= lineBreaker)
                                {
                                    break;
                                }
                                //Initialization Error Detection.
                                if (dataTypes.ContainsKey(tokens[i][j - errorCorrection]))
                                {
                                    j++;
                                }
                                else
                                {
                                    errorRichTextbox.AppendText($"Error in Line {i + 1}: Expected a datatype\n");
                                    j++;
                                }
                                if (!dataTypes.ContainsKey(tokens[i][j - errorCorrection]) && !keywords.ContainsKey(tokens[i][j - errorCorrection]) && !symbols.ContainsKey(tokens[i][j - errorCorrection]) && !consoleMethods.ContainsKey(tokens[i][j - errorCorrection]))
                                {
                                    j++;
                                }
                                else
                                {
                                    errorRichTextbox.AppendText($"Error in Line {i + 1}: Expected a variable\n");
                                    j++;
                                }
                                if (operators.ContainsKey(tokens[i][j - errorCorrection]))
                                {
                                    j++;
                                }
                                else
                                {
                                    errorRichTextbox.AppendText($"Error in Line {i + 1}: Expected an operator\n");
                                    j++;
                                }
                            }
                            jStarter = i;
                        }
                    }
                }
            }
            catch (Exception)
            {
                errorRichTextbox.AppendText("Syntax Error");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tokenText.Text = "";
            errorRichTextbox.Text = "";
            Tokenization();
            SyntaxAnalysis();
            tokenText.Text = Regex.Replace(tokenText.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
        }

        private void WndMain_Load(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.OpenFileButton, "Open File");
            ToolTip1.SetToolTip(this.NewFileButton, "New File");
            ToolTip1.SetToolTip(this.SaveFileButton, "Save File");
            AddLineNumbers();
        }

        private void CodeText_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = codeText.GetPositionFromCharIndex(codeText.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void CodeText_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void CodeText_TextChanged(object sender, EventArgs e)
        {
            if (codeText.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void CodeText_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = codeText.Font;
            codeText.Select();
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            codeText.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            codeText.Text = "";
            errorRichTextbox.Text = "";
            tokenText.Text = "";
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var streamReader = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
                {
                    codeText.AppendText(streamReader.ReadToEnd());
                }
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName + ".txt", codeText.Text);
                    MessageBox.Show("FIle Saved");
                }
            }
        }
    }
}
