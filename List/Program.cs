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
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("-----------------");
            linkedList.InsertAtParticularPosition(1,30);
            linkedList.Display();
        }
    }
}
