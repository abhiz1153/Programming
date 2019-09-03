// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IResult.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ProxyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Public Interface IResult
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        void Details();
        /// <summary>
        /// Get Result as Double value  
        /// </summary>
        /// <returns></returns>
        double GetResult();
    }
}
