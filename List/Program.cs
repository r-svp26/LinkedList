using System;

namespace List
{
    class Program
    {
        static readonly LinkedList linkedList = new LinkedList();
        static readonly SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
        /// <summary>
        /// view the linked list operations.
        /// </summary>
        public static void LinkedListView()
        {
            Console.WriteLine("<-------LinkedList------->");
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            int value = linkedList.Search(30);
            linkedList.InsertAtParticularPosition(value + 1, 40);
            linkedList.Display();
            int foundKey = linkedList.Search(40);
            linkedList.DeleteAtParticularPosition(foundKey);
            linkedList.Size();
            Console.WriteLine("<------------------------>\n");
        }
        /// <summary>
        /// view the sorted operations.
        /// </summary>
        public static void SortedLinkedListView()
        {
            Console.WriteLine("<----SortedLinkedList---->");
            sortedLinkedList.Add(new SortedNode<int>(70));
            sortedLinkedList.Add(new SortedNode<int>(40));
            sortedLinkedList.Add(new SortedNode<int>(30));
            sortedLinkedList.Add(new SortedNode<int>(56));
            Console.WriteLine("LinkedList before sorting");
            sortedLinkedList.DisplaySort();
            sortedLinkedList.SortOrderedList();
            Console.WriteLine("LinkedList after sorting");
            sortedLinkedList.DisplaySort();
            Console.WriteLine("<------------------------>");
        }
        /// <summary>
        /// entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.LinkedListView();
            Program.SortedLinkedListView();
        }
    }
}
