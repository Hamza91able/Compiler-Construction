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

            Regex testRegex = new Regex(@",(?!\d\d\d(?!\d)|\s)");

            var tokens = statement.Split(' ');

            foreach (var token in tokens)
            {

                if (keywords.ContainsKey(token))
                {
                    if (token.Contains(";"))
                    {
                        tokenText.AppendText($"<keyword>, {token.Split(';')[0]}>");
                        tokenText.AppendText("<terminal, ;>\n");
                    }
                    else
                    {
                        tokenText.AppendText($"<keyword, {token}>\n");
                    }

                }
                else if (operators.ContainsKey(token))
                {
                    if (token.Contains(";"))
                    {
                        tokenText.AppendText($"<Operators>, {token.Split(';')[0]}>\n");
                        tokenText.AppendText("<terminal, ;>\n");
                    }
                    else
                    {
                        tokenText.AppendText($"<Operators, {token}>\n");
                    }
                }
                else if (dataTypes.ContainsKey(token))
                {
                    if (token.Contains(";"))
                    {
                        tokenText.AppendText($"<DataTypes>, {token.Split(';')[0]}>\n");
                        tokenText.AppendText($"<DataTypes>, {token.Split(';')[0]}>\n");
                    }
                    else
                    {
                        tokenText.AppendText($"<DataTypes, {token}>\n");
                    }
                }
                else if (symbols.ContainsKey(token))
                {
                    if (token.Contains(";"))
                    {
                        tokenText.AppendText($"<Symbol>, {token.Split(';')[0]}>\n");
                        tokenText.AppendText("<terminal, ;>\n");
                    }
                    else
                    {
                        tokenText.AppendText($"<Symbol, {token}>\n");
                    }
                }
                else if (consoleMethods.ContainsKey(token))
                {
                    if (token.Contains(";"))
                    {
                        tokenText.AppendText($"<Method/Function>, {token}>\n");
                        tokenText.AppendText("<terminal, ;>\n");
                    }
                    else
                    {
                        tokenText.AppendText($"<Method/Function, {token}>\n");
                    }
                }
                else
                {
                    if (token.Contains(';'))
                    {
                        var getType = CheckDataType(token.Split(';')[0]);
                        tokenText.AppendText($"{getType}\n");
                        tokenText.AppendText("<terminal, ;>\n");
                    }
                    else
                    {
                        var getType = CheckDataType(token);
                        if (getType != null)
                        {
                            if (token.Contains(";"))
                            {
                                tokenText.AppendText($"<{getType}, {token.Split(';')[0]}>\n");
                                tokenText.AppendText($"<{getType}, {token.Split(';')[0]}>\n");
                            }
                            else
                            {
                                tokenText.AppendText($"{getType}\n");
                            }
                        }
                        else
                        {
                            if (token.Contains(";"))
                            {
                                tokenText.AppendText($"<Variable, {token.Split(';')[0]}>\n");
                                tokenText.AppendText("<terminal, ;>\n");
                            }
                            else
                            {
                                tokenText.AppendText($"<Variable, {token}>\n");
                            }
                        }
                    }
                }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            tokenText.Text = "";
            Tokenization();
        }
    }
}
