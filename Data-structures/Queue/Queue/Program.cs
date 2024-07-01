namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AQueue queue = new AQueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue(); queue.Dequeue();
            queue.Dequeue();
            queue.display();

        }
    }
}
