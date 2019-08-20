using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class TemperaturConversion
    {
        Utility utility = new Utility();
        public void Temperature()
        {
            try
            {
                Console.WriteLine("Temperature Conversion");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("Enter First or Second");
                Console.WriteLine(" ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Utility celObj = new Utility();
                        celObj.CelsiusToFahrenheit();
                        break;
                    case 2:
                        Utility fahObj = new Utility();
                        fahObj.FahrenheitToCelsius();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}