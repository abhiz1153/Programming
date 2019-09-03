// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SalesManagers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for SalesManagers
    /// </summary>
    /// <seealso cref="DesignPatterns.PrototypeDesignPattern.IEmployee" />
    class SalesManagers : IEmployee
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }
        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public double Salary { get; set; }
        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        public int Target { get; set; }
        /// <summary>
        /// Gets or sets the incentive.
        /// </summary>
        /// <value>
        /// The incentive.
        /// </value>
        public double Incentive { get; set; }
        /// <summary>
        /// Gets or sets the total payment.
        /// </summary>
        /// <value>
        /// The total payment.
        /// </value>
        public double TotalPayment { get; set; }
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public string GetDetails()
        {
            
            return string.Format("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6} ",EmployeeID, CompanyName, EmployeeName, Salary, Target, Incentive,TotalPayment);
        }      
       
    }
}
