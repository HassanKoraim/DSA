namespace Implement_Stack_using_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            MyStack myStack = new MyStack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            Console.WriteLine($"This is the pop element {myStack.Pop()}");
            myStack.display();
        }
    }

    
}
