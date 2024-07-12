
namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "[";
            Console.WriteLine(Program.IsValid(s));
        }
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            char x = '(';
            char y = '{';
            char z = '[';
            char a;
            for(int i = 0; i < s.Length;i++)
            {
                a = s[i];
                if(a == x || a == y || a == z)
                {
                    stack.Push(a);
                }
                else if(stack.Count != 0)
                {
                    if((a  == ')' && stack.Peek() == x) || 
                        (a == '}' && stack.Peek() == y) ||
                         (a == ']' && stack.Peek() == z)) 
                        stack.Pop();
                    else
                    {
                        // if didn't find the closed by the same type of brackets.
                        // in the correct order
                        return false;
                    }
                }
                else
                {
                    // if Empty and there are the closed brackets
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
