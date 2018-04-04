using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] brackets = new String[] { "({}{[]})({)}", "{[(])}", "{{[[(())]]}}" };
            

            foreach (String setOfBrackets in brackets)
            {
                if (isMatching(setOfBrackets))
                {
                    Debug.WriteLine("YES");
                }
                else
                {
                    Debug.WriteLine("NO");
                }
            }
        }

        private static Boolean isMatching(String expression)
        {
            Stack<char> bracketStack = new Stack<char>();

            foreach(char bracket in expression)
            {
                if (bracket == '(')
                {
                    bracketStack.Push(')');
                }
                else if (bracket == '{')
                {
                    bracketStack.Push('}');
                }
                else if (bracket == '[')
                {
                    bracketStack.Push(']');
                }
                else
                {
                    if (bracketStack.Count == 0 || bracket != bracketStack.Peek())
                    {
                        return false;
                    }

                    bracketStack.Pop();
                }
            }

            if (bracketStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
