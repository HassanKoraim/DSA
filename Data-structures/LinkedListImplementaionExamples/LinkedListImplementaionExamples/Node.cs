namespace LinkedListImplementaionExamples
{
    /** Singly linked list node */
    public class Node<T>
    {
        private T value;
        private Node<T> next;

        // Constructors
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

        public Node(T value , Node<T> Next)
        {
            this.value = value;
            this.next =Next;
        }
        public Node(Node<T> Next) { this.next = Next; }

        //Methods
        public Node<T> Next() { return this.next; }
        public Node<T> setNext (Node<T> Next) { return next = Next; }
        public T getValue()
        {
            return this.value;
        }


    }
}
