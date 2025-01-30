using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList_<int> myList = new LinkedList_<int>();

            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.AddLast(4);
            myList.AddLast(5);
            myList.AddLast(6);
        }
    }
}
