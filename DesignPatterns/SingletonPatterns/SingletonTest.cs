// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SingletinTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Public Calss for SingletonTest
    /// </summary>
    public class SingletonTest  
    {
        /// <summary>
        /// Singletons the test start.
        /// </summary>
        public static void SingletonTestStart()
        {
            try
            {
                Console.WriteLine("Eager Initialization");
                Parallel.Invoke(() => PrintTeacherDetails(), () => PrintStudentDetails());
                Console.WriteLine("\nLazy Initialization");
                Parallel.Invoke(() => PrintCompanyDetails(), () => PrintEmployeeDetails());
                Console.WriteLine("\nThread Safe Singleton");
                Parallel.Invoke(() => PrintRetailerDetails(), () => PrintCustomereDetails());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Prints the teacher details.
        /// </summary>
        public static void PrintTeacherDetails()
        {
            try
            {
                EagerInitialization teacher = EagerInitialization.GetInstance;
                teacher.PrintDetails("TEACHER");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Prints the student details.
        /// </summary>
        public static void PrintStudentDetails()
        {
            try
            {
                EagerInitialization student = EagerInitialization.GetInstance;
                student.PrintDetails("STUDENT");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Prints the company details.
        /// </summary>
        public static void PrintCompanyDetails()
        {
            try
            {
                LazyInitialization company = LazyInitialization.GetInstance;
                company.PrintDetails("COMPANY");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Prints the employee details.
        /// </summary>
        public static void PrintEmployeeDetails()
        {
            try
            {
                LazyInitialization employee = LazyInitialization.GetInstance;
                employee.PrintDetails("EMPLOYEE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Prints the retailer details.
        /// </summary>
        public static void PrintRetailerDetails()
        {
            try
            {
                ThreadSafeSingleton retailer = ThreadSafeSingleton.GetInstance;
                retailer.PrintDetails("RETAILER");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Prints the customere details.
        /// </summary>
        public static void PrintCustomereDetails()
        {
            try
            {
                ThreadSafeSingleton customer = ThreadSafeSingleton.GetInstance;
                customer.PrintDetails("CUSTOMER");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
