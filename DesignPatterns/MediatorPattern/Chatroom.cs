// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Chatroom.cs" company="Bridgelabz">
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
    /// Class for Chatroom
    /// </summary>
    /// <seealso cref="DesignPatterns.MediatorPattern.AbstractChatroom" />
    class Chatroom : AbstractChatroom

    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
        /// <summary>
        /// Registers the specified participant.
        /// </summary>
        /// <param name="participant">The participant.</param>
        public override void Register(Participant participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }
        /// <summary>
        /// Sends the specified from.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="message">The message.</param>
        public override void Send(string from, string to, string message)
        {
            Participant participant = participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }

}
