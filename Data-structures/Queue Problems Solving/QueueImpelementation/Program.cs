using QueueImplementation;

namespace QueueImplemention
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LQueue queue = new LQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //Console.WriteLine(queue.Peek());
          //  queue.Dequeue();
          //  Console.WriteLine(queue.Peek());
          //  queue.Dequeue();
          //  Console.WriteLine(queue.Peek());
        //    queue.Dequeue();
            queue.display();
             

            #region Test For Queue implementation using Array
            //AQueue queue = new AQueue(5);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue(); queue.Dequeue();
            //queue.Dequeue();
            //queue.display();
            #endregion

        }
    }
}
