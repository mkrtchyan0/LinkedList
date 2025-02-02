namespace MyLinkedList
{
    // The Node class represents an element in the linked list.
    // Each node contains data of type T and a reference to the next node.
    public class Node<T>
    {
        public T Data; // Data stored in the node.
        public Node<T> Next; // Reference to the next node in the list.

        // Constructor to initialize the node with data and set the next reference to null.
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    // The LinkedList_ class implements a singly linked list.
    public class LinkedList_<T>
    {
        private Node<T> head; // Head of the list, pointing to the first node.

        // Constructor to initialize the linked list with an empty head.
        public LinkedList_()
        {
            head = null;
        }

        // AddLast method adds a new node with the specified value at the end of the list.
        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value); // Create a new node with the given value.

            // If the list is empty, set the new node as the head.
            if (head == null)
            {
                head = node;
                return;
            }

            // Traverse to the end of the list and add the new node.
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }

        // AddFirst method adds a new node with the specified value at the beginning of the list.
        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value); // Create a new node with the given value.

            // Set the new node's next reference to the current head.
            node.Next = head;
            // Update the head to point to the new node.
            head = node;
        }

        // Find method checks if a node with the specified data exists in the list.
        public bool Find(T node)
        {
            Node<T> current = head; // Start from the head of the list.

            // Traverse the list to find the node.
            while (current != null)
            {
                if (current.Data.Equals(node))
                {
                    return true; // Node found.
                }
                current = current.Next; // Move to the next node.
            }
            return false; // Node not found.
        }

        // FindLength method returns the number of nodes in the list.
        public int FindLength()
        {
            Node<T> current = head; // Start from the head of the list.
            int length = 0; // Initialize length counter.

            // Traverse the list to count the nodes.
            while (current != null)
            {
                length++;
                current = current.Next; // Move to the next node.
            }
            return length; // Return the total count.
        }

        // AddAfter method adds a new node with the specified value after the node with the specified data.
        public void AddAfter(T node, T value)
        {
            // If the list is empty, throw an exception.
            if (head == null)
                throw new InvalidOperationException("The list is empty.");

            var current = head; // Start from the head of the list.

            // Traverse the list to find the node.
            while (current != null)
            {
                if (current.Data.Equals(node))
                {
                    Node<T> newNode = new Node<T>(value); // Create a new node with the given value.
                    newNode.Next = current.Next; // Set the new node's next reference.
                    current.Next = newNode; // Insert the new node after the current node.
                    return;
                }
                current = current.Next; // Move to the next node.
            }
            // If the specified node is not found, throw an exception.
            throw new ArgumentException("The specified node was not found in the list.");
        }

        // RemoveFirst method removes the first node from the list.
        public void RemoveFirst()
        {
            // If the list is empty, throw an exception.
            if (head == null)
                throw new InvalidOperationException("The list is empty.");

            // Set the head to the next node, effectively removing the first node.
            head = head.Next;
        }

        // RemoveLast method removes the last node from the list.
        public void RemoveLast()
        {
            // If the list is empty, throw an exception.
            if (head == null)
                throw new InvalidOperationException("The list is empty.");

            // If the list has only one node, set the head to null.
            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node<T> last = head; // Start from the head of the list.

            // Traverse the list to find the second-to-last node.
            while (last.Next.Next != null)
            {
                last = last.Next;
            }
            // Set the second-to-last node's next reference to null, removing the last node.
            last.Next = null;
        }

        // Remove method removes the first node with the specified data from the list.
        public bool Remove(T node)
        {
            // If the list is empty, throw an exception.
            if (head == null)
                throw new InvalidOperationException("The list is empty.");

            // If the head node's data matches, remove the head node.
            if (head.Data.Equals(node))
            {
                head = head.Next;
                return true;
            }

            Node<T> current = head; // Start from the head of the list.

            // Traverse the list to find the node.
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(node))
                {
                    // Remove the node by updating the current node's next reference.
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next; // Move to the next node.
            }
            return false; // Node not found.
        }
    }
}
