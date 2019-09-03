// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
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
    /// Public Abstract Class For Employee
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// The employee identifier
        /// </summary>
        int EmployeeId;
        /// <summary>
        /// The name
        /// </summary>
        string Name;
        /// <summary>
        /// The salary
        /// </summary>
        double Salary;
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="salary">The salary.</param>
        public Employee(int employeeId,string name,double salary)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Salary = salary;
        }
        /// <summary>
        /// Sets the identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void SetId(int id)
        {
            this.EmployeeId = id;
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this.EmployeeId;
        }
        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void SetName(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.Name;
        }
        /// <summary>
        /// Sets the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        public void SetSalary(double salary)
        {
            this.Salary = salary;
        }
        /// <summary>
        /// Gets the salary.
        /// </summary>
        /// <returns></returns>
        public double GetSalary()
        {
            return this.Salary;
        }
        /// <summary>
        /// Totals the payment.
        /// </summary>
        /// <returns></returns>
        public abstract double TotalPayment();
        /// <summary>
        /// Displays this instance.
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            return ("\nEmployee ID is :- " + this.EmployeeId + "\nEmployee Name :- " + this.Name + "\nSalary :- Rs. " + this.Salary);
        }
    }
}
