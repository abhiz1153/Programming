using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class Quadratic
    {
        Utility utility = new Utility();
        public void QuadraticEquation()
        {
            try
            {
                Console.Write("Value A ");
                double a = utility.double_number();
                Console.Write("Value B ");
                double b = utility.double_number();
                Console.Write("Value c ");
                double c = utility.double_number();

                double result = (b * b) - 4 * (a * c);

                if (result > 0.0)
                {
                    double r1 = (-b + Math.Sqrt(result)) / (2.0 * a);
                    double r2 = (-b - Math.Sqrt(result)) / (2.0 * a);
                    Console.WriteLine("The roots are " + r1 + " and " + r2);
                }
                else if (result == 0.0)
                {
                    double r1 = -b / (2.0 * a);
                    Console.WriteLine("The root is " + r1);
                }
                else
                {
                    Console.WriteLine("The equation has no real roots.");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
