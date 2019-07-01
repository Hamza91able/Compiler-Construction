﻿using System;
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
            var lines = statement.Split('\n');

            List<string[]> tokens = new List<string[]>();

            foreach (var token in lines)
            {
                tokens.Add(token.Split(' '));
            }

            int jStarter = 0;
            var lineBreaker = 0;

            for (var i = 0; i < tokens.Count; i++)
            {
                for (var k = 0; k < tokens[i].Length; k++)
                {
                    if (tokens[i][k] == ";")
                    {
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
                                    tokenText.AppendText($"<Symbol, {tokens[j]}>\n");
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

        private void SyntaxAnalysis()
        {
            // Case Initialization
            // datatype variable operator value
            string statement = codeText.Text;
            var lines = statement.Split('\n');

            List<string[]> tokens = new List<string[]>();

            foreach (var token in lines)
            {
                tokens.Add(token.Split(' '));
            }

            int jStarter = 0;

            for (var i = 0; i < tokens.Count; i++)
            {
                for (var k = 0; k < tokens[i].Length; k++)
                {
                    if (tokens[i][k] == ";")
                    {
                        int lineBreaker = k;
                        for (var j = jStarter; j <= lineBreaker; j++)
                        {
                            if (dataTypes.ContainsKey(tokens[i][j]))
                            {
                                j++;
                            }
                            else
                            {
                                errorRichTextbox.AppendText($"Error in Line : Expected a datatype\n");
                                j++;
                            }
                            if (!dataTypes.ContainsKey(tokens[i][j]) && !keywords.ContainsKey(tokens[i][j]) && !symbols.ContainsKey(tokens[i][j]) && !consoleMethods.ContainsKey(tokens[i][j]))
                            {
                                j++;
                            }
                            else
                            {
                                errorRichTextbox.AppendText("Error in Line{#}: Expected a variable\n");
                                j++;
                            }
                            if (operators.ContainsKey(tokens[i][j]))
                            {
                                j++;
                            }
                            else
                            {
                                errorRichTextbox.AppendText("Error in Line{#}: Expected an operator");
                                j++;
                            }
                        }
                        jStarter = i;
                    }
                }
            }

            /*  for (var i = 0; i < tokens.Length; i++)
              {
                  if (tokens[i] == ";")
                  {
                      lineBreaker = i;
                      for (var j = jStarter; j < lineBreaker; j++)
                      {
                          if (dataTypes.ContainsKey(tokens[j]))
                          {
                              j++;
                          } 
                          else
                          {
                              errorRichTextbox.AppendText($"Error in Line : Expected a datatype\n");
                              j++;
                          }
                          if (!dataTypes.ContainsKey(tokens[j]) && !keywords.ContainsKey(tokens[j]) && !symbols.ContainsKey(tokens[j]) && !consoleMethods.ContainsKey(tokens[j]))
                          {
                              j++;
                          }
                          else
                          {
                              errorRichTextbox.AppendText("Error in Line{#}: Expected a variable\n");
                              j++;
                          }
                          if (operators.ContainsKey(tokens[j]))
                          {
                              j++;
                          }
                          else
                          {
                              errorRichTextbox.AppendText("Error in Line{#}: Expected an operator");
                              j++;
                          }
                      }
                      jStarter = i;
                  }
              }*/


            /*if (!dataTypes.ContainsKey(tokens[0]) && !keywords.ContainsKey(tokens[0]) && !symbols.ContainsKey(tokens[0]) && !consoleMethods.ContainsKey(tokens[0]))
            {
                errorRichTextbox.AppendText($" Error in Line: The type or namespace '{tokens[0]}' could not be found ");
            }

            // Initilization
            if (dataTypes.ContainsKey(tokens[0]))
            {
                try
                {
                    if (!dataTypes.ContainsKey(tokens[0]))
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected a datatype\n");
                    }
                    if (dataTypes.ContainsKey(tokens[1]) || keywords.ContainsKey(tokens[1]) || symbols.ContainsKey(tokens[1]) || consoleMethods.ContainsKey(tokens[1]))
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected a variable\n");
                    }
                    if (!operators.ContainsKey(tokens[2]))
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected an operator");
                    }
                    if (dataTypes.ContainsKey(tokens[3]) || keywords.ContainsKey(tokens[3]) || symbols.ContainsKey(tokens[3]) || consoleMethods.ContainsKey(tokens[3]))
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected a variable\n");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    MessageBox.Show("Error in Line{#}: Invalid Expression Term");
                }
            }

            // If
            if (tokens[0] == "if" || tokens[0] == "If" || tokens[0] == "IF")
            {
                try
                {
                    var endCurlyBraces = tokens[tokens.Length - 1];

                    if (tokens[1] != "(")
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected (\n");
                    }
                    if (operators.ContainsKey(tokens[2]))
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Invalid Condition\n");
                    }
                    if (tokens[3] != ")")
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected )\n");
                    }
                    if (tokens[4] != "{")
                    {
                        errorRichTextbox.AppendText("Error in Line{#}: Expected {\n");
                    }
                    if (endCurlyBraces != "}")
                    {
                        errorRichTextbox.AppendText("Error in Line{#}:asdf Expected }\n");
                    }
                    if (dataTypes.ContainsKey(tokens[5]))
                    {
                        if (!dataTypes.ContainsKey(tokens[5]))
                        {
                            errorRichTextbox.AppendText("Error in Line{#}: Expected a datatype\n");
                        }
                        if (dataTypes.ContainsKey(tokens[6]) || keywords.ContainsKey(tokens[6]) || symbols.ContainsKey(tokens[6]) || consoleMethods.ContainsKey(tokens[6]))
                        {
                            errorRichTextbox.AppendText("Error in Line{#}: Expected a variable\n");
                        }
                        if (!operators.ContainsKey(tokens[7]))
                        {
                            errorRichTextbox.AppendText("Error in Line{#}: Expected an operator");
                        }
                        if (dataTypes.ContainsKey(tokens[8]) || keywords.ContainsKey(tokens[8]) || symbols.ContainsKey(tokens[8]) || consoleMethods.ContainsKey(tokens[8]))
                        {
                            errorRichTextbox.AppendText("Error in Line{#}: Expected a variable\n");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

            }*/
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tokenText.Text = "";
            errorRichTextbox.Text = "";
            SyntaxAnalysis();
            Tokenization();
        }
    }
}
