using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _921._Minimum_Add_to_Make_Parentheses_Valid
{
    public class Solution
    {
        public int MinAddToMakeValid(string s)
        {
            char[] c = s.ToCharArray();
            int n = s.Length;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < n; i++)
            {
                if (stack.Count > 0)
                {
                    if (c[i] == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c[i]);
                    }
                }
                else
                {
                    stack.Push(c[i]);
                }

            }
            return stack.Count;
        }
        // anthor solution and optimization
        public int MinAddToMakeValid_WithTwoCounters(string s)
        {
            int open = 0; // count of unmatched open parentheses '('
            int additional = 0; // count of unmatched close parentheses ')'

            foreach (char c in s)
            {
                if (c == '(')
                {
                    open++;
                }
                else // c == ')'
                {
                    if (open > 0)
                    {
                        open--;
                    }
                    else
                    {
                        additional++;
                    }
                }
            }
            return additional + open; // total unmatched parentheses
        }
    }
}
