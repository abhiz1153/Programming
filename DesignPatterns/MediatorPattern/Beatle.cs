// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Beatle.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.MediatorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Beatle
    /// </summary>
    /// <seealso cref="DesignPatterns.MediatorPattern.Participant" />
    class Beatle : Participant
    {
        // Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Beatle"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Beatle(string name) : base(name)    { }
        /// <summary>
        /// Receives the specified from.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="message">The message.</param>
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
