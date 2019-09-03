// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Participant.cs" company="Bridgelabz">
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
    /// Class For Participant
    /// </summary>
    class Participant
    {
        /// <summary>
        /// The chatroom
        /// </summary>
        private Chatroom chatroom;
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        // Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Participant"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Participant(string name)
        {
            this.name = name;
        }
        // Gets participant name        
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return name; }
        }
        // Gets chatroom
        /// <summary>
        /// Gets or sets the chatroom.
        /// </summary>
        /// <value>
        /// The chatroom.
        /// </value>
        public Chatroom Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }
        // Sends message to given participant        
        /// <summary>
        /// Sends the specified to.
        /// </summary>
        /// <param name="to">To.</param>
        /// <param name="message">The message.</param>
        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }
        // Receives message from given participant
        /// <summary>
        /// Receives the specified from.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="message">The message.</param>
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",from, Name, message);
        }
    }
}
