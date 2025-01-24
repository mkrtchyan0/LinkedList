using System.Security.Cryptography.X509Certificates;

namespace MyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList_<int> linkedList = new LinkedList_<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(5);
        }
    }
}
