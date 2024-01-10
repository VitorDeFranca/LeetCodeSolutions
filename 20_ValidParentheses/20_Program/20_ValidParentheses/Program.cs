using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidParentheses
{
    public class Program
    {
        static void Main(string[] args)
        {
            IsValid("()");
            IsValid("() [] {}");
            IsValid("(]");

        }

        public static bool IsValid(string s)
        {
            if (s.Length % 2 == 1) return false;

            char[] cs = s.Replace(" ", "").ToCharArray();
            Stack<char> stack = new Stack<char>();


            for (int i = 0; i < cs.Length; i++)
            {
                if (cs[i] == '(' || cs[i] == '[' || cs[i] == '{')
                {
                    stack.Push(cs[i]);
                }
                else
                {
                    if (stack.Count == 0) return false;


                    if (stack.Peek() == '(')
                    {
                        if ((int)cs[i] != ((int)stack.Peek() + 1)) return false;
                    }

                    if (stack.Peek() == '[' || stack.Peek() == '{')
                    {
                        if ((int)cs[i] != ((int)stack.Peek() + 2)) return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;

        }
    }
}
