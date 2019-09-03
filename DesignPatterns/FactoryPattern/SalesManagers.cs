// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SalesManagers.cs" company="Bridgelabz">
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
    /// Class For SalesManagers
    /// </summary>
    /// <seealso cref="DesignPatterns.FactoryPattern.Employee" />
    class SalesManagers : Employee
    {
        /// <summary>
        /// The target
        /// </summary>
        int Target;
        /// <summary>
        /// The incentive
        /// </summary>
        double Incentive;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesManagers"/> class.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="employeeName">Name of the employee.</param>
        /// <param name="employeeSalary">The employee salary.</param>
        /// <param name="target">The target.</param>
        /// <param name="incentive">The incentive.</param>
        public SalesManagers(int employeeId, string employeeName, double employeeSalary, int target, double incentive) : base(employeeId, employeeName, employeeSalary)
        {
            this.Target = target;
            this.Incentive = incentive;
        }
        /// <summary>
        /// Sets the target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void SetTarget(int target)
        {
            this.Target = target;
        }
        /// <summary>
        /// Gets the target.
        /// </summary>
        /// <returns></returns>
        public int GetTarget()
        {
            return this.Target;
        }
        /// <summary>
        /// Sets the incentive.
        /// </summary>
        /// <param name="incentive">The incentive.</param>
        public void SetIncentive(double incentive)
        {
            this.Incentive = incentive;
        }
        /// <summary>
        /// Gets the incentive.
        /// </summary>
        /// <returns></returns>
        public double GetIncentive()
        {
            return this.Incentive;
        }
        /// <summary>
        /// Totals the payment.
        /// </summary>
        /// <returns></returns>
        public override double TotalPayment()
        {
            return this.GetSalary() + this.Incentive;
        }
        /// <summary>
        /// Finals the display.
        /// </summary>
        /// <returns></returns>
        public string FinalDisplay()
        {
            return (base.Display() + "\nMonthly Target Achived :-" + this.Target + "\nSales Manager Monthly Incentive is :- Rs. " + this.Incentive);
        }   
    }
}
