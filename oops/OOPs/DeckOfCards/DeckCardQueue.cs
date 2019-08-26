// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckCardsQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.DeckOfCards
{
    /// <summary>
    /// Class for DeckCardQueue 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DeckCardQueue<T>
    {
        /// <summary>
        /// The list
        /// </summary>
        public LinkedListQueue<T> list = new LinkedListQueue<T>();
        /// <summary>
        /// Enqueues the specified list1.
        /// </summary>
        /// <param name="list1">The list1.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public LinkedListQueue<T> Enqueue(List<T> list1, T number)
        {
            this.list = this.list.AddNodeAtLast1(list1, number, list);
            return this.list;
        }
        /// <summary>
        /// Dequeues the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="list1">The list1.</param>
        /// <returns></returns>
        public LinkedListQueue<T> Dequeue(LinkedListQueue<T> list, List<T> list1)
        {
            T number;
            number = list.DeleteFirst1();
               list.AddNodeAtFirst1(list1, number, list);
            return list;
        }
    }
}
