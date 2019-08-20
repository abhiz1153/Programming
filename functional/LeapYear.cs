using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class LeapYear
    {
        Utility utility = new Utility();
        public void Leap()
        {
            int n = utility.Year();
            int l = n.ToString().Length;


            if (l >= 4)
            {
                Boolean flag = false;
                if (n % 400 == 0)

                {

                    flag = true;

                }

                else if (n % 100 == 0)

                {

                    flag = false;

                }

                else if (n % 4 == 0)

                {

                    flag = true;

                }

                else

                {

                    flag = false;

                }

                if (flag)
                {
                    Console.WriteLine(n + " is a Leap Year");
                }
                else
                {
                    Console.WriteLine(n + " is not a Leap Year");
                }
            }
            else
                Console.WriteLine("Entered " + n + " is not an valid year");

            Console.ReadKey();
        }
    }
}


