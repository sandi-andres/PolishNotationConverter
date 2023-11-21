using System.Collections.Generic;
using System.Linq;

namespace PolishNotationConverter
{
    internal class Converter
    {
        private Stack<char> stack = new Stack<char> ();
        private string infix;
        private string postfix;

        internal Converter(string infix)
        {
            this.infix = infix;
        }

        internal string ConvertPostfix()
        {
            string operators = "+–*/^%";
                
            stack.Push('(');
            infix += ')';

            while(stack.Count > 0)
            {
                foreach (char c in infix)
                {
                    string stringValue = c.ToString();

                    if(int.TryParse(stringValue, out int number))
                        postfix += stringValue;

                    else if (c == '(')
                        stack.Push(c);

                    else if (operators.Contains(c))
                    {
                        while (operators.Contains(stack.Peek()) && OperatorPrecedence(stack.Peek()) >= OperatorPrecedence(c))
                        {
                            postfix += stack.Pop();
                        }
                        stack.Push(c);
                    }

                    if (c == ')')
                    {
                        while (stack.Peek() != '(')
                            postfix += stack.Pop();

                        stack.Pop();
                    }
                }                               
            }
            return postfix;
        }
    
        private int OperatorPrecedence(char caracter)
        {
            Dictionary<int, string> precedence = new Dictionary<int, string>()
            { {3, "^"}, {2, "*/%"}, {1, "+–"} };

            int precedenceValue = 0;

            if (precedence[1].Contains(caracter))
                precedenceValue = 1;
            else if (precedence[2].Contains(caracter))
                precedenceValue = 2;
            else if (precedence[3].Contains(caracter))
                precedenceValue = 3;

            return precedenceValue;
        }
    }
}
