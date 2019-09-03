// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PAbstractChatroom.cs" company="Bridgelabz">
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
    /// Abstract Class For AbstractChartroom
    /// </summary>
    abstract class AbstractChatroom
    {
        /// <summary>
        /// Registers the specified participant.
        /// </summary>
        /// <param name="participant">The participant.</param>
        public abstract void Register(Participant participant);
        /// <summary>
        /// Sends the specified from.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="message">The message.</param>
        public abstract void Send(string from, string to, string message);
    }
}
