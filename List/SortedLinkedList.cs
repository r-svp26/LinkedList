using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
   public class SortedLinkedList<T> where T : IComparable
    {
        public SortedNode<T> head = null;
        public SortedNode<T> tail = null;
        /// <summary>
        /// add the elements into list.
        /// </summary>
        /// <param name="data"></param>
		public void Add(SortedNode<T> newNode)
		{
			if (head == null)
			{
				head = newNode;
				tail = newNode;
			}
			else
			{
				tail.next = newNode;
				tail = newNode;
			}
		}
        /// <summary>
        /// sort the list in ascending order.
        /// </summary>
        public void SortOrderedList()
        {
            SortedNode<T> current = head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;

                    while (index != null)
                    {  
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        /// <summary>
        /// dis[lay the list.
        /// </summary>
        public void DisplaySort()
        {
            SortedNode<T> current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
