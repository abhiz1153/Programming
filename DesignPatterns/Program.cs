// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    /// <summary>
    /// Class for Main Programs
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            try
            {
                char choice;
                int choose;
                do
                {
                    Console.WriteLine("*****DESIGN PATTERNS*****");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Singleton Design Patterns");
                    Console.WriteLine("2. Factory Design Patterns");
                    Console.WriteLine("3. Prototype Design Patterns");
                    Console.WriteLine("4. Adapter Design Patterns");
                    Console.WriteLine("5. Facade Design Patterns");
                    Console.WriteLine("6. Proxy Design Patterns");
                    Console.WriteLine("7. Observer Design Pattern");
                    Console.WriteLine("8. Visitor Design Pattern");
                    Console.WriteLine("9. Mediator Design Pattern");
                    Console.WriteLine("10. Reflection");
                    Console.WriteLine("11. Annotation");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter which program you want to run");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            SingletonPatterns.SingletonTest.SingletonTestStart();
                            break;
                        case 2:
                            FactoryPattern.Company company = new FactoryPattern.Company();
                            company.CompanyAccountSections();
                            break;
                        case 3:
                            PrototypeDesignPattern.Prototype prototype = new PrototypeDesignPattern.Prototype();
                            prototype.PrototypePattern();
                            break;
                        case 4:
                            AdapterPattern.Adapter adapterObject = new AdapterPattern.Adapter();
                            adapterObject.adapter();
                            break;
                        case 5:
                            FacadePattern.MakeOrder  facadeObject = new FacadePattern.MakeOrder();
                            facadeObject.StartOrder();
                            break;
                        case 6:
                            ProxyPattern.ProxyPatterns proxyPattern = new ProxyPattern.ProxyPatterns();
                            proxyPattern.Pattern();
                            break;
                        case 7:
                            ObserverPattern.ObserverMain observer = new ObserverPattern.ObserverMain();
                            observer.ObserverPattern();
                            break;
                        case 8:
                            VisitorPattern.VisitorMain visitor = new VisitorPattern.VisitorMain();
                            visitor.VistorPattern();
                            break;
                        case 9:
                            MediatorPattern.MediatorMain mediator = new MediatorPattern.MediatorMain();
                            mediator.MediatorPattern();
                            break;
                        case 10:
                            ReflectionAndAnnotation.ReflectionClass reflectionClass = new ReflectionAndAnnotation.ReflectionClass();
                            reflectionClass.ReflectionMain();
                            break;
                        case 11:
                            ReflectionAndAnnotation.Annotation annotation = new ReflectionAndAnnotation.Annotation();
                            annotation.AnnotationMain();
                            break;




                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
