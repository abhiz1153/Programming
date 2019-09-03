// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Subject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    /// <summary>
    /// Puublic class for Subject
    /// </summary>
    /// <seealso cref="DesignPatterns.ObserverPattern.ISubject" />
    public class Subject : ISubject
    {
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public int State { get; set; } = -0;
        /// <summary>
        /// The observers
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();
        /// <summary>
        /// Attaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject : Attach an Observer");
            this.observers.Add(observer);
        }
        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
            Console.WriteLine("Subject : Dettach an Observer");
        }
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            Console.WriteLine("Subject : Notifying Observers...");
            foreach(var observer in observers)
            {
                observer.Update(this);
            }
        }
        /// <summary>
        /// Somes the business logic.
        /// </summary>
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
