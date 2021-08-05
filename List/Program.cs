using System;

namespace List
{
    class Program
    {
        /// <summary>
        /// entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("-----------------");
            int value = linkedList.Search(30);
            linkedList.InsertAtParticularPosition(value + 1,40);
            linkedList.Display();
        }
    }
}
