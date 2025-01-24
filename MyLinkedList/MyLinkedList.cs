using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class LinkedList_<T>
    {
        private T[] linkedList;
        private int defaultLength = 4;
        private int currentIndex = 0;

        public LinkedList_()
        {
            linkedList = new T[defaultLength];
        }
        public void  AddLast(T value)
        {
            if (currentIndex >= linkedList.Length)
            {
                var newLinkedList = linkedList;
                linkedList = new T[linkedList.Length * 2];
                int index = 0;

                foreach (var item in newLinkedList)
                {
                    linkedList[index] = newLinkedList[index];
                    index++;
                }                
            }
            linkedList[currentIndex] = value;
            currentIndex++;
        }
        public void AddFirst(T value)
        {
            if (currentIndex >= linkedList.Length)
            {
                var newLinkedList = linkedList;
                linkedList = new T[linkedList.Length * 2];
                int indexer = 0;

                foreach (var item in newLinkedList)
                {
                    linkedList[indexer] = newLinkedList[indexer];
                    indexer++;
                }
            }
            var oldList = new T[linkedList.Length];
            for (int i = 0; i < currentIndex; i++)
            {
                oldList[i] = linkedList[i];
            }
            linkedList[0] = value;
            var index = 1;
            foreach (var item in oldList)
            {
                linkedList[index] = item;
                index++;
                if (index == linkedList.Length)
                    break;
            }  
            currentIndex++;
        }
        public void AddAfter(T value)
        {
            var indexOfValue = linkedList[].ToList().IndexOf(value);

            var oldList = new T[linkedList.Length];
            for (int i = 0; i < currentIndex; i++)
            {
                oldList[i] = linkedList[i];
            }
            linkedList[indexOfValue] = value;
            var index = 0;
            foreach (var item in oldList)
            {
                if (index == indexOfValue)
                {
                    continue;
                }
                linkedList[index] = item;
                index++;
                if (index == linkedList.Length)
                    break;
            }
            currentIndex++;
        }
    }
}
