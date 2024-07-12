namespace Remove_Duplicate_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Program.RemoveDuplicateLetters("bcabc"));
        }
        public static string RemoveDuplicateLetters(string s)
        {
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                int flag = 0;
                char c = s[i];
                while(stack1.Count > 0)
                {
                    if(c == stack1.Peek())  // the char is duplicate
                    {
                        flag++;
                    }
                    stack2.Push(stack1.Pop());
                }
                if (flag == 0) stack2.Push(c);
                var temp = stack2;
                stack2 = stack1;
                stack1 = stack2;
            }
            foreach (var c in stack1) { Console.WriteLine(c); }
            string? st = stack1.ToString();
            return st.Length == 0? "hassan" : st;

        }
    }
}
