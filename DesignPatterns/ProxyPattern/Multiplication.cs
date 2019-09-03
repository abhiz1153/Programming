// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Multiplication.cs" company="Bridgelabz">
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
    /// Class for Multiplication
    /// </summary>
    /// <seealso cref="DesignPatterns.ProxyPattern.IResult" />
    class Multiplication : IResult
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
        /// Initializes a new instance of the <see cref="Multiplication"/> class.
        /// </summary>
        public Multiplication () { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Multiplication"/> class.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public Multiplication(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        /// <summary>
        /// Get Result as Double value
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            return A * B;
        }
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        public void Details()
        {
            Console.WriteLine("MULTIPLICATION OPERATION \n");
        }
    }
}
