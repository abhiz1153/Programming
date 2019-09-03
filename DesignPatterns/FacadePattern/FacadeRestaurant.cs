// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadeRestaurant.cs" company="Bridgelabz">
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
    /// class facade restaurant for getting order for customer
    /// </summary>
    public class FacadeRestaurant
    {
        /// <summary>
        /// The pizza is reference of pizza interface
        /// </summary>
        private IPizza pizza;

        /// <summary>
        /// The sandwitch is the reference of sandwitch interface
        /// </summary>
        private ISandwitch sandwitch;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacadeRestaurant"/> class.
        /// </summary>
        public FacadeRestaurant()
        {
            pizza = new PizzaProvider();
            sandwitch = new SandwitchProvider();
        }

        /// <summary>
        /// Orders the veg pizza.
        /// </summary>
        public void OrderVegPizza()
        {
            pizza.GetVegPizza();
        }

        /// <summary>
        /// Orders the non veg pizza.
        /// </summary>
        public void OrderNonVegPizza()
        {
            pizza.GetNonVegPizza();
        }

        /// <summary>
        /// Orders the garlic sadnwitch.
        /// </summary>
        public void OrderGarlicSadnwitch()
        {
            sandwitch.GetGarlicSandwitch();
        }

        /// <summary>
        /// Orders the chees garlic sandwitch.
        /// </summary>
        public void OrderCheesGarlicSandwitch()
        {
            sandwitch.GetCheesySandwitch();
        }
    }
}
