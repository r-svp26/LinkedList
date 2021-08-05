using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Node
    {
        // variables
        public int data;
        public Node next;
        /// <summary>
        /// constructor is used to initialized the data.
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
