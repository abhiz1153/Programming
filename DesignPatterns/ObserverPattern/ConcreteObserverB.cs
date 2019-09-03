// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ConcreteObserverB.cs" company="Bridgelabz">
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
    /// Class for ConcereteObserverB 
    /// </summary>
    /// <seealso cref="DesignPatterns.ObserverPattern.IObserver" />
    class ConcreteObserverB : IObserver
    {
        /// <summary>
        /// Updates the specified subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
