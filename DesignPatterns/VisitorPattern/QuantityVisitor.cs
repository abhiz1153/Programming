// --------------------------------------------------------------------------------------------------------------------
// <copyright file=QuantityVisitor.cs" company="Bridgelabz">
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
    /// Class for QuantityVisitor
    /// </summary>
    /// <seealso cref="DesignPatterns.VisitorPattern.IElement" />
    class QuantityVisitor : IElement
    {
        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Visit(Visitor visitor)
        {
            Food food = visitor as Food;
            food.Quantity = food.Quantity + 3;
            Console.WriteLine("{0} : {1}'s New Food Quantity : {2}" ,food.GetType().Name,food.Name,food.Quantity);
        }
    }
}
