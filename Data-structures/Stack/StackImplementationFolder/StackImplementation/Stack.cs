using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public interface Stack<T>
    {
        /** Reinitialize the stack. The user is responsible for
reclaiming the storage used by the stack elements. */
        public void clear();
        /** Push an element onto the top of the stack.
@param it The element being pushed onto the stack. */
        public void push(T item);
        /** Remove and return the element at the top of the stack.
@return The element at the top of the stack. */
        public T pop();
        /** @return A copy of the top element. */
        public T topValue();
        /** @return The number of elements in the stack. */
        public int getLength();

    };
}
}
