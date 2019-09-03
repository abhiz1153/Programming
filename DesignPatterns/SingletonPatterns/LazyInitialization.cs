// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LazyInitialization.cs" company="Bridgelabz">
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
    /// Public Sealed Class for LazyInitalization
    /// </summary>
    public sealed class LazyInitialization
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        /// <summary>
        /// The instance
        /// </summary>
        private static readonly Lazy<LazyInitialization> instance = new Lazy<LazyInitialization>(() => new LazyInitialization());
        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
        {
            counter++; 
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static LazyInitialization GetInstance
        {
            get
            {

                return instance.Value;
            }
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
