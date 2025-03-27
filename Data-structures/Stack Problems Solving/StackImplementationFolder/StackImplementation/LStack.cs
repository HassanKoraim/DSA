using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    /** Linked stack implementation */
    public class LStack<T> : Stack<T>
    {
        private Node<T> top;
        private int size;
        /** Constructors */
        public LStack() { top = null; size = 0; }
        public LStack(int size) { top = null; this.size = size; }
        /** Reinitialize stack */
        public void clear() { top = null; size = 0; }
        /** Put "it" on stack */
        public void push(T item)
        {
            top = new Node<T>(item, top);
            size++;
        }
        /** Remove "it" from stack */
        public T pop()
        {
            T it = top.getValue();
            top = top.Next();
            size--;
            return it;
        }
        /** @return Top value */
        public T topValue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked Stack is empty");
                return default;
            }
            return top.getValue();
        }
        /** @return Stack length */
        public int getLength()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        /* print the value in Linked Stack */
        public void print()
        {
            if (!IsEmpty())
            {
                Node<T> curr = top;
                while (curr != null)
                {
                    Console.WriteLine(curr.getValue());
                    curr = curr.Next();
                }
            }
            else
            {
                Console.WriteLine("The Linked Stack is empty");
            }

        }
    }
}
