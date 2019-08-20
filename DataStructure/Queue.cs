using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Queue<T>
    {
        /// <summary>
        /// My list for store elements from queue
        /// </summary>
        List<T> myList;

        /// <summary>
        /// The front is for remove elements from queue
        /// </summary>
        private int front;

        /// <summary>
        /// The rear is for add elemnts into queue
        /// </summary>
        private int rear;

        /// <summary>
        /// The maximum
        /// </summary>
        private int maximum;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// </summary>
        public Queue()
        {
            this.front = 0;
            this.rear = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public Queue(int size)
        {
            this.myList = new List<T>(size);
            this.front = 0;
            this.rear = -1;
            this.maximum = size;
        }

        /// <summary>
        /// Inserts into queue.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertIntoQueue(T data)
        {
            try
            {
                if (this.rear == this.maximum - 1)
                {
                    Console.WriteLine("Queue is full ");
                }
                else
                {
                    this.myList[this.rear++] = data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Removes from queue.
        /// </summary>
        /// <returns>value which is removed from queue</returns>
        public int RemoveFromQueue()
        {
            if (this.front == this.rear + 1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int val = this.front;
                this.front++;
                return val;
            }
        }

        /// <summary>
        /// Prints the queue.
        /// </summary>
        public void PrintQueue()
        {
            try
            {
                if (this.front == this.rear + 1)
                {
                    Console.WriteLine("Queue is empty");
                }
                else
                {
                    foreach (T i in this.myList)
                    {
                        Console.WriteLine("data" + (this.front + 1) + "]-" + i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
