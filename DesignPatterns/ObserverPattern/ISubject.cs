// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ISubject.cs" company="Bridgelabz">
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
    /// Public Interface for ISubject
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Attach(IObserver observer);
        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Detach(IObserver observer);
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }
}
