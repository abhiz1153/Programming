// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Company.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for Operator
    /// </summary>
    /// <seealso cref="DesignPatterns.FactoryPattern.Employee" />
    class Operator : Employee
    {
        /// <summary>
        /// The over time
        /// </summary>
        float OverTime;
        /// <summary>
        /// The payment
        /// </summary>
        double Payment;
        /// <summary>
        /// Initializes a new instance of the <see cref="Operator"/> class.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="employeeName">Name of the employee.</param>
        /// <param name="employeeSalary">The employee salary.</param>
        /// <param name="overTime">The over time.</param>
        /// <param name="payment">The payment.</param>
        public Operator(int employeeId, string employeeName, double employeeSalary, float overTime, double payment) : base (employeeId, employeeName, employeeSalary)
        {
            this.OverTime = overTime;
            this.Payment = payment;
        }
        /// <summary>
        /// Sets the ot.
        /// </summary>
        /// <param name="overTime">The over time.</param>
        public void SetOT(float overTime)
        {
            this.OverTime = overTime;
        }
        /// <summary>
        /// Gets the ot.
        /// </summary>
        /// <returns></returns>
        public float GetOT()
        {
            return this.OverTime;
        }
        /// <summary>
        /// Sets the payment.
        /// </summary>
        /// <param name="payment">The payment.</param>
        public void SetPayment(double payment)
        {
            this.Payment = payment;
        }
        /// <summary>
        /// Gets the payment.
        /// </summary>
        /// <returns></returns>
        public double GetPayment()
        {
            return this.Payment;
        }
        /// <summary>
        /// Totals the payment.
        /// </summary>
        /// <returns></returns>
        public override double TotalPayment()
        {
            return (this.GetSalary() + this.Payment);
        }
        /// <summary>
        /// Finals the display.
        /// </summary>
        /// <returns></returns>
        public string FinalDisplay()
        {
            return (base.Display() + "\nOperator Mothly Over Time Working :- "+this.OverTime+" hours \nOperator Monthly Extra Payment :- Rs. " +this.Payment);
        }
    }
}
