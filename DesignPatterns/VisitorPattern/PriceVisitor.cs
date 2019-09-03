// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PriceVisitor.cs" company="Bridgelabz">
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
    /// Class For PriceVisitor 
    /// </summary>
    class PriceVisitor : IElement
    {
        /// <summary>
        /// Class Visit
        /// </summary>
        /// <param name="visitor"></param>
        public void Visit(Visitor visitor)
        {
            Food food = visitor as Food;
            food.Price = food.Price * 1.10;
            Console.WriteLine("{0} : {1}'s new Price : {2:C}", food.GetType().Name, food.Name, food.Price);
        }
    }
}
