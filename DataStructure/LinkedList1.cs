using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{ /// <summary>
  /// class for create Linkedlist and perform operation on Linkedlist
  /// </summary>
  /// <typeparam name="T"></typeparam>
    public class LinkedList1<T>
    {
        /// <summary>
        /// The head holds the Adress of 1st node
        /// </summary>
        private Node<T> head;

        /// <summary>
        /// The node count for counting numbers of node
        /// </summary>
        private int nodeCount;
        T val;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList1{T}"/> class.
        /// To inititialize to head=null and node count=0
        /// </summary>
        public LinkedList1()
        {
            this.head = null;
            this.nodeCount = 0;
        }

        /// <summary>
        /// Gets the first node from linkedlist.
        /// </summary>
        /// <returns> returns first node of list</returns>
        public Node<T> GetFirstNode()
        {
            return this.head;
        }

        /// <summary>
        /// Gets the last node from linkedlist.
        /// </summary>
        /// <returns> returns the last node</returns>
        public Node<T> GetLastNode()
        {
            Node<T> currentNode = this.head;
            try
            {
                while (currentNode.GetNext() != null)
                {
                    currentNode = currentNode.GetNext();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return currentNode;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        /// <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return this.head == null;
        }

        /// <summary>
        /// Adds the node at last of linkedlist.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddNodeAtLast(T data)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null, null);
                    this.nodeCount++;
                }
                else
                {
                    Node<T> currentNode = this.head;
                    Node<T> newNode = new Node<T>(data, null);
                    while (currentNode.GetNext() != null)
                    {
                        currentNode = currentNode.GetNext();
                    }
                    currentNode.SetNext(newNode);
                    this.nodeCount++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public LinkedList1<T> AddNodeAtLast1(List<T> list, T data, LinkedList1<T> list1)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null, null);
                    this.nodeCount++;
                    return list1;
                }
                else
                {
                    Node<T> currentNode = this.head;
                    Node<T> newNode = new Node<T>(data, null);
                    while (currentNode.GetNext() != null)
                    {
                        currentNode = currentNode.GetNext();
                    }
                    currentNode.SetNext(newNode);
                    this.nodeCount++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list1;
        }

        /// <summary>
        /// Adds the node at first position of likedlist.
        /// </summary>
        /// <param name="data">The data.</param>
        public LinkedList1<T> AddNodeAtFirst(LinkedList1<T> list, T data)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null);
                    return list;
                }
                else
                {
                    Node<T> newNode = new Node<T>(data, null);
                    newNode.SetNext(this.head);
                    this.head = newNode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
        public LinkedList1<T> AddNodeAtFirst1(List<T> list, T data, LinkedList1<T> list1)
        {
            try
            {
                if (this.IsEmpty())
                {
                    this.head = new Node<T>(data, null);
                    return list1;
                }
                else
                {
                    Node<T> newNode = new Node<T>(data, null);
                    newNode.SetNext(this.head);
                    this.head = newNode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return list1;
        }


        /// <summary>
        /// Pushes the specified data at first position.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(LinkedList1<T> list, T data)
        {
            this.AddNodeAtFirst(list, data);
        }

        /// <summary>
        /// Pops this instance at first position from linked list.
        /// </summary>
        /// <returns></returns>
        public bool Pop()
        {
            return this.DeleteFirst();
        }

        /// <summary>
        /// Deletes the first node from linkedlist.
        /// </summary>
        /// <returns></returns>
        public bool DeleteFirst()
        {

            if (this.IsEmpty())
            {
                Console.WriteLine("Linked list is already empty");
                return false;
            }
            else if (this.head.GetNext() == null)
            {
                this.head = null;
                return true;
            }
            else
            {
                Node<T> currentNode = this.head;
                Console.WriteLine(head.GetData());
                head = currentNode.GetNext();
                GC.Collect();
                return true;
            }
        }

        /// <summary>
        /// Deletes the first node.
        /// </summary>
        /// <returns></returns>
        public T DeleteFirst1()
        {


            Node<T> currentNode = this.head;
            T val = head.GetData();
            head = currentNode.GetNext();
            GC.Collect();


            return val;

        }

        /// <summary>
        /// Deletes the last node from linkedlist.
        /// </summary>
        public void DeleteLast()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Linked list is already empty");
                return;
            }
            else if (this.head.GetNext() == null)
            {
                this.head = null;
                return;
            }
            else
            {
                Node<T> currentNode = this.head;
                while (currentNode.GetNext().GetNext() != null)
                {
                    currentNode = currentNode.GetNext();
                }
                currentNode.SetNext(null);
                return;
            }
        }

        /// <summary>
        /// Deletes node at specific position from linkedlist.
        /// </summary>
        /// <param name="data">The data.</param>
        public void DeleteAtPosition(T data)
        {
            Node<T> currentNode = this.head;
            while (currentNode != null)
            {
                if (this.IsEmpty())
                {
                    Console.WriteLine("Linked list is already empty");
                    return;
                }
                else if (currentNode == head && currentNode.GetData().Equals(data))
                {
                    head = currentNode.GetNext();
                    GC.Collect();
                    break;
                }
                else if (currentNode.GetNext().GetData().Equals(data))
                {
                    currentNode.SetNext(currentNode.GetNext().GetNext());
                    GC.Collect();
                    break;
                }
                else
                {
                    currentNode = currentNode.GetNext();
                }

            }
        }

        /// <summary>
        /// Prints the linkedlist.
        /// </summary>
        public void Print()
        {
            try
            {
                if (this.IsEmpty())
                {
                    Console.WriteLine("Linked list is empty");
                }
                else
                {
                    Node<T> currenrNode = this.head;
                    while (currenrNode != null)
                    {
                        Console.WriteLine(currenrNode.GetData() + "");
                        currenrNode = currenrNode.GetNext();
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this data or word is contains in linklist or not.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        /// <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool Contains(T word)
        {
            try
            {
                Node<T> currentNode = head;
                if (head == null)
                {
                    DeleteFirst1();
                    return true;
                }
                while (currentNode != null)
                {
                    if (currentNode.GetData().Equals(word))
                    {
                        return true;
                    }
                    currentNode = currentNode.GetNext();
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Writes text to file.
        /// </summary>
        /// <returns></returns>
        public string WriteToFile()
        {
            string string1 = null;
            Node<T> temp = this.head;
            while (temp != null)
            {
                string1 += (temp.GetData() + "\n");
                temp = temp.GetNext();
            }

            return string1;
        }

    }
}