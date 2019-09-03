// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Visitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Abstract Class For Visitor
    /// </summary>
    abstract class Visitor
    {
        /// <summary>
        /// Accepts the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public abstract void Accept(IElement element);
        
    }
}
