// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Payments.cs" company="Bridgelabz">
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
    /// Class For Payments
    /// </summary>
    class Payments
    {
        /// <summary>
        /// Saleses this instance.
        /// </summary>
        public void Sales()
        {
            Console.WriteLine("Enter Sales Manager Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter " + name + " Employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + name + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + name + " Monthly Achieved Targert");
            int target = Convert.ToInt32(Console.ReadLine());
            double incentive = target * 500;

            SalesManagers managers = new SalesManagers(id, name, salary, target, incentive);
            Console.WriteLine(managers.FinalDisplay());
            Console.WriteLine("Total Monthly Payments :- Rs. "+(managers.TotalPayment()));
        }
        /// <summary>
        /// Productions this instance.
        /// </summary>
        public void Production()
        {
            Console.WriteLine("Enter Production Manager Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter " + name + " Employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + name + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + name + " Monthly Product Builds");
            int target = Convert.ToInt32(Console.ReadLine());
            double incentive = target * 50;

            ProductionManager managers = new ProductionManager(id, name, salary, target, incentive);
            Console.WriteLine(managers.FinalDisplay());
            Console.WriteLine("Total Monthly Payments :- Rs. " + (managers.TotalPayment()));
        }
        /// <summary>
        /// Operators the employee.
        /// </summary>
        public void OperatorEmployee()
        {
            Console.WriteLine("Enter Operator Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter " + name + " Employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + name + " Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter " + name + " Monthly Over Time Done");
            float ot = Convert.ToInt32(Console.ReadLine());
            double incentive = ot * 300;

            Operator operate = new Operator(id, name, salary, ot, incentive);
            Console.WriteLine(operate.FinalDisplay());
            Console.WriteLine("Total Monthly Payments :- Rs. " + (operate.TotalPayment()));
        }
    }
}
