namespace LinkedListImplementaionExamples
{
    public class LList<T> : List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        protected Node<T> curr;
        private int cnt;

        // constructor
        public LList()
        {
            curr = tail = head = new Node<T> (null);
            cnt = 0;
        }
        
        // Remove all Elements
        public void clear()
        {
            head.setNext(null);
            curr = tail = head = new Node<T>(null);
            cnt = 0;
        }

        // insert "it" in current postition
        public void append(T it)
        {
            var node = new Node<T> (it,curr); // next = curr
            curr = node;
            cnt++;

        }
        public void insert(Node<T> node)
        {
        if (head  == null)
            {
                head = curr = tail = node;
                cnt++;
            }
            else
            {
                tail.setNext(node);
                tail = node;
                cnt++;
            }
            
        }
        public void display()
        {
            curr = head.Next();
            while (curr != null)
            {
                Console.WriteLine(curr.getValue());
                curr = curr.Next();
            }
        }
    }
}
