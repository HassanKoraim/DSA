namespace GraphImpelementation
{
    public class LList<T> : List<T>
    {
        private Link<T> head;
        private Link<T> tail;
        private Link<T> curr;
        private int cnt;

        // constructor
        public LList()
        {
            curr = tail = head = new Link<T>(null);
            cnt = 0;
        }

        // Remove all Elements
        public void clear()
        {
            head.setNext(null);
            curr = tail = head = new Link<T>(null);
            cnt = 0;
        }

        // insert "it" in current postition
        public void append(T it)
        {
            var node = new Link<T>(it, curr); // next = curr
            curr = node;
            cnt++;

        }
        public void insert(Link<T> node)
        {
            if (head == null)
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
        public Link<T> getCurr() { return curr; }
        public void setCurr(Link<T> who) { curr = who; }
        public void MoveToStart()
        {
            curr = head;
        }
        public T getValue()
        {
            if (curr.getNext() == null) return default;
            return curr.getNext().getElement();
        }
        /** Move curr one step right; no change if now at end */
        public void Next()
        {
            if(curr != tail) curr = curr.getNext();
        }
        public void display()
        {
            curr = head.getNext();
            while (curr != null)
            {
                Console.WriteLine(curr.getElement());
                curr = curr.getNext();
            }
        }
    }
}
