using System;
using System.Security.Cryptography.X509Certificates;
/*
 * This implementation Queue using Arrays
 * we use Array of integer data type 
 */

namespace QueueImplemention
{
    public class AQueue : Queue
    {
        //Data Members
        private int[] queue;
        private int front, rear, capacity;

        // Constructor
        public AQueue(int size)
        {
            queue = new int[size];
            capacity = size;
            front = rear = 0;
        }
        //Methods
        public bool isEmpty()
        {
            return front == rear;  // front and rear is equal 0 
        }
        public bool isFull()
        {
            return capacity == rear;
        }
        public void Enqueue(int item) {
            if (isFull()) 
            {
                Console.WriteLine("this array is full"); //overflow condition
            }
            else
            {
                queue[rear] = item;
                rear++;
            }
            
        }
        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("This array is Empty"); // underflow Condition
                return;
            }
            else
            {
                // shifting the element to the lift side, and replace the first element
                for(int i = 0; i < rear -1; i++) {
                    queue[i] = queue[i +1];        
                }
                //decrement rear
                rear--;
                // delete the last element by put value equal to 0 
                queue[rear] = 0;
            }
        }
        public int Peek()
        {
            return queue[front];
        }
        public void display()
        {
            if(isEmpty())
            {
                Console.WriteLine("didn't find any item to display!!");
               return;
            }
            else
            {
                for (int i = 0; i < rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
                return;
            }
            
        }
       

    }
}
