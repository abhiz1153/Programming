// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ConcreteObserverA.cs" company="Bridgelabz">
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
    /// Class for ConcreteObserverA
    /// </summary>
    /// <seealso cref="DesignPatterns.ObserverPattern.IObserver" />
    class ConcreteObserverA : IObserver
    {
        /// <summary>
        /// Updates the specified subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
