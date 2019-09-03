// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FastFood.cs" company="Bridgelabz">
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
    /// Class For FastFood
    /// </summary>
    class FastFood 
    {
        /// <summary>
        /// The fastfood
        /// </summary>
        private List<Food> fastfood = new List<Food>();
        /// <summary>
        /// Attaches the specified food.
        /// </summary>
        /// <param name="food">The food.</param>
        public void Attach(Food food)
        {
             fastfood.Add(food);
        }
        /// <summary>
        /// Detaches the specified food.
        /// </summary>
        /// <param name="food">The food.</param>
        public void Detach(Food food)
        {
            fastfood.Remove(food);
        }
        /// <summary>
        /// Accepts the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Accept(IElement element)
        {
            foreach(Food food in fastfood)
            {
                food.Accept(element);
            }
            Console.WriteLine();
        }
    }
}
