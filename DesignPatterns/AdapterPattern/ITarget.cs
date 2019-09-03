// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ITarget.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Publiv Interface ITarget
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns></returns>
        List<string> GetEmployeeList();
    }
}
