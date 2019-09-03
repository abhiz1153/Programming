// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISandwitch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface sandwitch for abstract method to getting sandwitch variety 
    /// </summary>
    interface ISandwitch
    {
        /// <summary>
        /// Gets the garlic sandwitch.
        /// </summary>
        void GetGarlicSandwitch();

        /// <summary>
        /// Gets the cheesy sandwitch.
        /// </summary>
        void GetCheesySandwitch();
    }
}