/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */

namespace Implement_Queue_using_Stacks
{ 
    public class MyQueue
    {
        Stack<int> stack1,stack2,stack3;
        public MyQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
            stack3 = new Stack<int>();
        }

        public void Push(int x)
        {
            /*
             * The idea is to make stack2 to recive the new integer,
             * the stack1 to save the past element in the correct order as Queue,
             * the stack3 to reflect the stack1, hence to push again in stack2 to the correct
             * order as Queue
             */
            stack2.Push(x);
            while (stack1.Count > 0)
            {
                stack3.Push(stack1.Pop());
            }
            while (stack3.Count > 0) 
            {
                stack2.Push(stack3.Pop());
            }
            var temp = stack2;
            stack2 = stack1;
            stack1 = temp;
        }

        public int Pop()
        {
            return stack1.Pop();
        }

        public int Peek()
        {
            return stack1.Peek();
        }

        public bool Empty()
        {
            return stack1.Count == 0;
        }
       
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
