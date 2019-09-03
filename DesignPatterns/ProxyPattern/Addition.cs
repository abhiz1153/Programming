// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Addition.cs" company="Bridgelabz">
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
    /// Class for Addition
    /// </summary>
    /// <seealso cref="DesignPatterns.ProxyPattern.IResult" />
    class Addition : IResult
    {
        /// <summary>
        /// Gets or sets a.
        /// </summary>
        /// <value>
        /// a.
        /// </value>
        public double A { get; set; }
        /// <summary>
        /// Gets or sets the b.
        /// </summary>
        /// <value>
        /// The b.
        /// </value>
       public double B { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Addition" /> class.
        /// </summary>
        public Addition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Addition" /> class.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public Addition(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        public void Details()
        {
            Console.WriteLine("Addition");
        }
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {

            return A + B;
        }

    }
}
