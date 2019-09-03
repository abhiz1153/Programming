
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ThreadSafeSingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Public Seal Class For ThreadSafeSingleton
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        /// <summary>
        /// The object
        /// </summary>
        private static readonly object obj = new object();
        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafeSingleton instance = null;
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new ThreadSafeSingleton();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        /// <summary>
        /// Prints the details.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
