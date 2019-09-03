// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPizza.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Shamra"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface pizza for getting variety of pizza
    /// </summary>
    public interface IPizza
    {
        /// <summary>
        /// Gets the veg pizza.
        /// </summary>
        void GetVegPizza();

        /// <summary>
        /// Gets the non veg pizza.
        /// </summary>
        void GetNonVegPizza();
    }
}