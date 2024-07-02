using LinkedListImplementaionExamples;
using QueueImplemention;
using System;

namespace QueueImplementation
{
    public class LQueue : Queue
    {
        Node<int>? head,  curr, tail;
        public LQueue()
        {
             head = curr = tail = new Node<int>(null);
        }

        public bool isEmpty()
        {

            return head == null;
        }

        public bool isFull()
        {
            return false; // the linkedlist is dynamic memory
        }

        public void Enqueue(int item)
        {
            Node<int>? newNode = new Node<int>(item, null);
            if(isEmpty()) 
            {
                head = curr = tail = newNode;
            }
            else
            {
                
                tail?.setNext(newNode);
                tail = newNode;
            }
        }

        public void Dequeue()
        {
            if(!isEmpty())
            {
                head = head?.Next();
            }
            else
            {
                Console.WriteLine("This Queue is Empty");
                return;
            }
        }

        public int Peek()
        {
            if (!isEmpty())
                return head.getValue();
            else return -1;
        }
        public void display()
        {
            curr = head?.Next();
            while(curr != null) 
            {
                Console.WriteLine(curr.getValue());
                curr = curr.Next();
            }
        }
    }
}
