namespace GraphImpelementation
{
    public class Link<T>
    {
        private T element;        // Value for this node
        private Link<T> next;     // Pointer to next node in list

        // Constructors
        public Link(T it, Link<T> nextval)
        { element = it; next = nextval; }
        public Link(Link<T> nextval) { next = nextval; }

        public Link<T> getNext() { return next; }  // Return next field
        public Link<T> setNext(Link<T> nextval) // Set next field
        { return next = nextval; }     // Return element field
        public T getElement() { return element; }  // Set element field
        public T setElement(T it) { return element = it; }
    }
}
