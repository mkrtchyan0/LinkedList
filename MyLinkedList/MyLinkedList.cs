namespace MyLinkedList
{
    public class Node
    {
        public object Data;
        public Node Next;

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
    public class LinkedList_<T>
    {
        private Node head;
        private Node copyOfHead;
        public LinkedList_()
        {
            head = null;
        }
        public void AddLast(T value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
                return;
            }
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }
        public void AddFirst(T value)
        {
            copyOfHead = head;
            Node node = new Node(value);

            head = node;
            head.Next = copyOfHead;
        }
        public void RemoveFirst()
        {
            head = copyOfHead;
        }
        public void AddAfter(object node, T value)
        {
            Node newNode = new Node(value);
            var current = head;
            while (current.Data != node)
            {
                current = current.Next;
            }
            current.Next = newNode;
            current = current.Next;
            newNode.Next = current;
        }
    }
}