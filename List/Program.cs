using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddElementInReverse(70);
            linkedList.AddElementInReverse(30);
            linkedList.AddElementInReverse(56);
            linkedList.Display();

        }
    }
}
