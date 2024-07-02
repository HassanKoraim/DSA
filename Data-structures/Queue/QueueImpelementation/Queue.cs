using System;
namespace QueueImplemention
{
    public interface Queue
    {
        bool isEmpty();
        bool isFull();
        void Enqueue(int item);
        void Dequeue();
        int Peek();
    }
}

