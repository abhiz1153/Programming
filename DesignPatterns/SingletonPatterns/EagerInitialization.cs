// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EagerInitialization.cs" company="Bridgelabz">
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
    /// Public sealed Calss for EagerInitialization
    /// </summary>
    public sealed class EagerInitialization
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;
        /// <summary>
        /// The instance
        /// </summary>
        private static readonly EagerInitialization instance = new EagerInitialization();
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static EagerInitialization GetInstance
        {
            get
            {
                return instance;
            }
        }
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
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
