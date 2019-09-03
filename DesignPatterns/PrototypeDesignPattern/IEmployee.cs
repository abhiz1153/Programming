// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Public Interface For IEmployee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        IEmployee Clone();
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        string GetDetails();
    }
}
