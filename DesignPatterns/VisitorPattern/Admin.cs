// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Admin.cs" company="Bridgelabz">
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
    /// Class Pizza
    /// </summary>
    /// <seealso cref="DesignPatterns.VisitorPattern.Food" />
    class Pizza : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pizza"/> class.
        /// </summary>
        public Pizza() :base ("Veggie Pizza",100.0,10)
        { }

    }
    /// <summary>
    /// Class Pasta 
    /// </summary>
    /// <seealso cref="DesignPatterns.VisitorPattern.Food" />
    class Pasta : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pasta"/> class.
        /// </summary>
        public Pasta() :base ("Corn Pasta" , 50.0, 5) { }
    }
    /// <summary>
    /// Class Burger
    /// </summary>
    /// <seealso cref="DesignPatterns.VisitorPattern.Food" />
    class Burger : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Burger"/> class.
        /// </summary>
        public Burger() :base("Veg Burger",20.0,25) { }
    }
}
