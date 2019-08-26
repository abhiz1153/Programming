// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
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
    /// Class for Node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// The data
        /// </summary>
        T data;
        /// <summary>
        /// The next
        /// </summary>
        Node<T> next;
        /// <summary>
        /// The previous
        /// </summary>
        Node<T> previous;
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        public Node()
        {
            this.next = null;
            this.previous = null;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        /// <param name="previous">The previous.</param>
        public Node(T data, Node<T> next,Node<T> previous)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetData(T data)
        {
            this.data = data;
        }
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns> data </returns>
        public T GetData()
        {
            return this.data;
        }
        /// <summary>
        /// Sets the next.
        /// </summary>
        /// <param name="nextnode">The nextnode.</param>
        public void SetNext(Node<T> nextnode)
        {
            this.next = nextnode;
        }
        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <returns> next </returns>
        public Node<T> GetNext()
        {
            return this.next;
        }
        /// <summary>
        /// Sets the prevoius.
        /// </summary>
        /// <param name="previousnode">The previousnode.</param>
        public void SetPrevoius(Node<T> previousnode)
        {
            this.previous = previousnode;
        }
        /// <summary>
        /// Gets the previous.
        /// </summary>
        /// <returns></returns>
        public Node<T> GetPrevious()
        {
            return this.previous;
        }
    }
}
