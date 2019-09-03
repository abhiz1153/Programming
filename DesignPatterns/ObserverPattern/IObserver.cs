// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IObserver.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Public Interface for IObserver
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the specified subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        void Update(ISubject subject);
    }
   
}
