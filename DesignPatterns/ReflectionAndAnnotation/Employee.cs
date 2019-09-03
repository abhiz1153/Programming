// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ReflectionAndAnnotation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    /// <summary>
    /// Public For Class Employee 
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }
        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        [Required]               
        public string EmployeeName { get; set; }
        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>
        /// The designation.
        /// </value>
        public string Designation { get; set; }
        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public double Salary { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="employeeName">Name of the employee.</param>
        /// <param name="designation">The designation.</param>
        /// <param name="salary">The salary.</param>
        public Employee(int employeeID, string employeeName, string designation, double salary)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.Designation = designation;
            this.Salary = salary;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.EmployeeID = 0;
            this.EmployeeName = string.Empty;
            this.Designation = string.Empty;
            this.Salary = 0;

        }
        /// <summary>
        /// Prints the identifier.
        /// </summary>
        public void PrintID()
        {
            Console.WriteLine("Employee ID = {0}", this.EmployeeID);
        }
        /// <summary>
        /// Prints the name.
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine("Employee Name = {0}", this.EmployeeName);
        }
        /// <summary>
        /// Prints the designation.
        /// </summary>
        public void PrintDesignation()
        {
            Console.WriteLine("Employee Designation = {0}", this.Designation);
        }
        /// <summary>
        /// Prints the salary.
        /// </summary>
        public void PrintSalary()
        {
            Console.WriteLine("Employee Salary = {0}", this.Salary);
        }

    }
}
