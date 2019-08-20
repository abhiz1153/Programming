using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class WindChill
    {
        Utility utility = new Utility();
        public void Wind()
        {
            try
            {
                double w = 0;
                Console.Write("Enter the Temperature(in Fahrenheit) ");
                double t = utility.double_number();

                if (t > 50)
                    Console.WriteLine("Please Enter the Temperature in Between (-50 to 50)");
                else
                    Console.Write("Enter the Wind Speed(in miles per hour):- ");
                double v = utility.double_number();
                if (v > 120)
                    Console.WriteLine("Please Enter the wind speed between (3 to 120)");
                else
                {
                    w = 35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * (Math.Pow(v, 0.16));
                    Console.WriteLine("The Weather=" + w);
                }
                if (w < 20)
                    Console.WriteLine("Climate is COOL");
                else if (w < 30)
                    Console.WriteLine("Climate is OK TYPE NOT TOO COOL NOT TOO HOT");
                else
                    Console.WriteLine("Climate is HOT");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
