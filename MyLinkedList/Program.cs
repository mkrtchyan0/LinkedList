using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new linked list of integers.
            LinkedList_<int> numbers = new LinkedList_<int>();

            // Add elements to the list.
            numbers.AddFirst(10);
            numbers.AddLast(20);
            numbers.AddLast(30);
            numbers.AddAfter(20, 25);

            // Display the length of the list.
            Console.WriteLine($"Length of the list: {numbers.FindLength()}");

            // Check if a specific element exists in the list.
            int searchValue = 25;
            if (numbers.Find(searchValue))
            {
                Console.WriteLine($"{searchValue} exists in the list.");
            }
            else
            {
                Console.WriteLine($"{searchValue} does not exist in the list.");
            }

            // Remove an element from the list.
            numbers.Remove(20);
            Console.WriteLine($"Length of the list after removal: {numbers.FindLength()}");
        }
    }
}