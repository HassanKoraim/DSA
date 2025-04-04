using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2696_MinStringLength
{
    public class Solution
    {
        public int MinLength(string s)
        {
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(stack.Count > 0)
                {
                    if ((s[i] == 'B' && s[stack.Peek()] == 'A') || (s[i] == 'D' && s[stack.Peek()] == 'C'))
                    {
                        stack.Pop();
                        continue;
                    }
                  
                }  
                    stack.Push(i);
            }
            return stack.Count;
        }
    }
}
