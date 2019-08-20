using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class HarmonicNumber
    {
        Utility utility = new Utility();
        public void Harmonic()
        {
            try
            {
                double sum = 0, i;
                int num = utility.Number();

                if (num > 0)
                {
                    for (i = 1; i <= num; i++)
                    {
                        sum = sum + 1 / i;
                        if (i == 1)
                            Console.WriteLine("1");
                        else
                            Console.WriteLine("1/" + i);

                        Console.WriteLine("The sum of series =" + sum);


                    }
                }
                else
                    Console.WriteLine("Enter the Valid number");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}
