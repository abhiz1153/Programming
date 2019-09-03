// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReflectionClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.ReflectionAndAnnotation
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    /// <summary>
    /// Class For ReflectionClass
    /// </summary>
    class ReflectionClass
    {
        /// <summary>
        /// Reflections the main.
        /// </summary>
        public void ReflectionMain()
        {
            Type T = Type.GetType(" DesignPatterns.ReflectionAndAnnotation.Employee");
            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Namespace Name = {0}", T.Namespace);
            Console.WriteLine("Class Name = {0}", T.Name);
            Console.WriteLine();
            Console.WriteLine("\nProperties in Employees");
            Console.WriteLine();
            PropertyInfo[] propertyInfo = T.GetProperties();
            foreach (PropertyInfo property in propertyInfo)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Methods in Employees");
            Console.WriteLine();
            MethodInfo[] methodInfo = T.GetMethods();
            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Constructors in Employees");
            Console.WriteLine();
            ConstructorInfo[] constructorInfo = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructorInfo)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}


