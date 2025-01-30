using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LinkedList_()
        {
            head = null;
        }
        public void AddLast(T value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head =node;
                return;
            }
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }
    }
}