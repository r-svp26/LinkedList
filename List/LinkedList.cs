using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class LinkedList
    {
        // variables
        internal Node head;
        /// <summary>
        /// add element into reverse order.
        /// </summary>
        /// <param name="data"></param>
        internal void AddElementInReverse(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        /// <summary>
        /// display the elements of linkedlist.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.Write("null");
        } 
    }
}
