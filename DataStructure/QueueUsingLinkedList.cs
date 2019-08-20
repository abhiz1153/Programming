using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class QueueUsingLinkedList<T>
    {
        private LinkedList1<int> list1 = new LinkedList1<int>();
        private LinkedList1<string> list2 = new LinkedList1<string>();
        public LinkedList1<int> Enqueue(List<int> list, int anagramNumber)
        {
            this.list1 = this.list1.AddNodeAtLast1(list, anagramNumber, this.list1);
            return this.list1;
        }
        public LinkedList1<int> Dequeue(LinkedList1<int> list)
        {
            int value = list.DeleteFirst1();
            this.list1.AddNodeAtFirst(list, value);
            return this.list1;
        }
        public LinkedList1<string> Enqueue1(List<string> list , string anagramNumber)
        {
            this.list2 = this.list2.AddNodeAtLast1(list, anagramNumber, this.list2);
            return this.list2;
        }
    }
}
