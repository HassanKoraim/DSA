using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace Parenthesis_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsPar("([]"));
            // reverse("Hassan");
            // Console.WriteLine(s("([]"));
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            deleteMid(stack, 4);
        }
        public static void deleteMid(Stack<int> s, int sizeOfStack)
        {
            // code here
            int size = 0;
            if (sizeOfStack % 2 == 0) size = sizeOfStack / 2;
            else size = (sizeOfStack + 1) / 2;
            Stack<int> stack = new Stack<int>();
            int size2 = sizeOfStack;
            while (size2-- > 0)
            {
                if (size == size2)
                {
                    s.Pop();
                }
                else
                {
                    Console.WriteLine($"the top in s {s.Peek()}");
                    stack.Push(s.Peek());
                    Console.WriteLine($"the top in stack {stack.Peek()}");
                    s.Pop();
                }
            }
            for (int i = 0; i < sizeOfStack - 1; i++)
            {
                s.Push(stack.Peek());
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
        }
        public static bool s(string s)
        {
            Stack<char> stack = new Stack<char>();
            char x = '(';
            char y = '[';
            char z = '{';
            char a;
            for(int i = 0; i < s.Length; i++)
            {
                a = s[i];
                if(a == x || a== z || a == y) stack.Push(a);
                else if( stack.Count != 0)
                {
                    if ((stack.Peek() == x && s[i] == ')')
                    || (stack.Peek() == y && s[i] == ']')
                    || (stack.Peek() == z && s[i] == '}'))
                        stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
        public static string reverse(string s)
        {
            string str = "";
            for(int i = s.Length- 1; i >= 0; i--)
            {
                str += s[i];
            }
            return str;
        }
        public static bool IsPar(string s)
        {
            // {([])}  == })][({
            string str = reverse(s);
            // Console.WriteLine(str); // ][(  -- ([]
            int len = str.Length -1; //5
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i] + "  " + str[len]);
                if (str[len] == '(' && s[i] != '(' || str[len] == ')' && s[i] != ')'
                   || str[len] == '{' && s[i] != '{' || str[len] == '}' && s[i] != '}'
                   || str[len] == '[' && s[i] != '[' || str[len] == ']' && s[i] != ']')
                {
                    Console.WriteLine(s[i] + "  " + str[len]);
                        return false;
                }
                len--;
                //if (s[i] != str[--len])
                //    return false;
                //Console.WriteLine(s[i] + "  " + str[len]);
            }
            return true;
        }
    }
}
