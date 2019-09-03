// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Inputs.cs" company="Bridgelabz">
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
    /// Class for Inputs of Protype Patterns
    /// </summary>
    class Inputs
    {
        /// <summary>
        /// Saleses this instance.
        /// </summary>
        public void Sales()
        {
            //Enter First Sales Managers Details.
            Console.WriteLine("Enter Company Name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter First Sales Manager ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter " + firstName + " Employee ID");
            int firstId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + firstName + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + firstName + " Monthly Achieved Targert");
            int target = Convert.ToInt32(Console.ReadLine());
            double incentive = target * 500;
            double totalPayments = incentive + salary;
            //Enter Second Sales Managers Details
            Console.WriteLine("Enter Second Sales Manager");
            string secondName = Console.ReadLine();
            Console.WriteLine("Enter " + secondName + " Employee ID");
            int secondId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + secondName + " Monthly Achieved Targert");
            int target1 = Convert.ToInt32(Console.ReadLine());
            double incentive1 = target1 * 500;
            double payment = incentive1 + salary;
            Console.WriteLine("EmployeeID\tCompanyName\tEmployeeName\tSalary\tTarget\tIntensive\tTotalPayment");
            //Creating Sales Managers Object as manager For First Sale Manager 
            SalesManagers manager = new SalesManagers();
            manager.CompanyName = companyName;
            manager.EmployeeID = firstId;
            manager.EmployeeName = firstName;
            manager.Salary = salary;
            manager.Target = target;
            manager.Incentive = incentive;
            manager.TotalPayment = totalPayments;
           //Creating Sales Managers Object as managerCopy for Second Managers 
           //By Using .Clone() it Copy the details of manager object to mangerCopy object 
            SalesManagers managerCopy = (SalesManagers)manager.Clone();
            managerCopy.EmployeeName = secondName;
            managerCopy.EmployeeID = secondId;
            managerCopy.Target = target1;
            managerCopy.Incentive = incentive1;
            managerCopy.TotalPayment = payment;
            Console.WriteLine(manager.GetDetails());
            Console.WriteLine(managerCopy.GetDetails());
           
        }
        /// <summary>
        /// Operators the employee.
        /// </summary>
        public void OperatorEmployee()
        {
            //Enter First Operator Employee Details.
            Console.WriteLine("Enter Company Name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter First Operator Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter " + firstName + " Employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + firstName + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + firstName + " Monthly Over Time Done");
            float ot1 = Convert.ToInt32(Console.ReadLine());
            double incentive1 = ot1 * 300;
            //Enter Second Operator Employee Details.
            Console.WriteLine("Enter Second Operator Name");
            string secondName = Console.ReadLine();
            Console.WriteLine("Enter " + secondName + " Employee ID");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + secondName + " Monthly Over Time Done");
            float ot2 = Convert.ToInt32(Console.ReadLine());
            double incentive2 = ot2 * 30;
            Console.WriteLine("\tEmployee_ID\tCompany_Name\tEmployee_Name\tSalary\tOverTime\tIntensive\tTotalPayment");
            Operator operatorObject = new Operator();
            operatorObject.CompanyName = companyName;
            operatorObject.EmployeeID = id;
            operatorObject.EmployeeName = firstName;
            operatorObject.Salary = salary;
            operatorObject.OverTime = ot1;
            operatorObject.Incentive = incentive1;
            operatorObject.TotalPayments = incentive1 * salary;           
            Operator operatorObjectCopy = (Operator)operatorObject.Clone();
            operatorObjectCopy.EmployeeID = id2;
            operatorObjectCopy.EmployeeName = secondName;
            operatorObjectCopy.OverTime = ot2;
            operatorObjectCopy.Incentive = incentive2;
            operatorObjectCopy.TotalPayments = incentive2 * salary;
            Console.WriteLine(operatorObject.GetDetails());
            Console.WriteLine(operatorObjectCopy.GetDetails());
        }
    }
}
