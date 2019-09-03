// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PizzaProvider.cs" company="Bridgelabz">
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
    /// class pizza provider provides order for customer
    /// </summary>
    /// <seealso cref="DesignPatterns.FacadePattern.IPizza" />
    class PizzaProvider : IPizza
    {
        /// <summary>
        /// Gets the veg pizza.
        /// </summary>
        public void GetVegPizza()
        {
            try
            {
                Console.WriteLine("Getting Veg Pizza.");
                Console.WriteLine("Your Order Placed Successfully...");
                Console.WriteLine("");
                Console.WriteLine("Thank You \n Please Visit Again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Gets the non veg pizza.
        /// </summary>
        public void GetNonVegPizza()
        {
            try
            {
                GetNonVegToppings();
                Console.WriteLine("Getting Non Veg Pizza.");
                Console.WriteLine("Your Order Placed Successfully...");
                Console.WriteLine("");
                Console.WriteLine("Thank You \n Please Visit Again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// Gets the non veg toppings.
        /// </summary>
        private void GetNonVegToppings()
        {
            try
            {
                Console.WriteLine("Getting Non Veg Pizza Toppings.");
                Console.WriteLine("Your Order Placed Successfully...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}