




using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{

    public class Node
    {
        public string data;
        public Node next;
        ////constructor
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }


    }


    public class INode
    {
        public int data;
        public INode next;
        ////constructor
        public INode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class Node<T>
    {
        T data;
        Node<T> next;
        Node<T> previous;
        public Node()
        {
            this.next = null;
            this.previous = null;
        }
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
        public Node(T data, Node<T> next, Node<T> previous)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
        public void SetData(T data)
        {
            this.data = data;
        }
        public T GetData()
        {
            return this.data;
        }
        public void SetNext(Node<T> an)
        {
            this.next = an;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetPrevious(Node<T> bn)
        {
            this.previous = bn;
        }
    }
}
