using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class SortedNode<T>
    {
        public T data;
        public SortedNode<T> next;

        public SortedNode(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
