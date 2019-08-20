using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Deque<T>
    {
        public T data;
        public Deque<T> next;
        public Deque<T> pre;

        public Deque()
        {
            this.next = null;
            this.pre = null;
        }
        public Deque(T val)
        {
            this.data = val;
            this.next = null;
            this.pre = null;
        }
    }
}
