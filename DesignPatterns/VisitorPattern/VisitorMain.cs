// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VisitorMain.cs" company="Bridgelabz">
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
    /// Class For VisitorMain
    /// </summary>
    class VisitorMain
    {
        /// <summary>
        /// Vistors the pattern.
        /// </summary>
        public void VistorPattern()
        {
            FastFood fastFood = new FastFood();
            fastFood.Attach(new Pizza());
            fastFood.Attach(new Pasta());
            fastFood.Attach(new Burger());
            fastFood.Accept(new PriceVisitor());
            fastFood.Accept(new QuantityVisitor());
            Console.ReadKey();
        }
    }
}
