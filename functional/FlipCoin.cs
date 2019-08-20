using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{

    class FlipCoin
    {
        Utility utility = new Utility();

        public void Flip()
        {
            try
            {
                float head = 0, tail = 0;
                Console.Write("How many time you want to Flip a Coin So ");
                Random rnd = new Random();
                int num = utility.Number();
                for (int i = 1; i <= num; i++)
                {
                    if(rnd.NextDouble()>0.5)
                    {
                        head++;
                    }
                    else
                        tail++;
                }
                Console.WriteLine("Total Number of Head = " + head);
                Console.WriteLine("Total Number of Tail = " + tail);


                float h = (head / num) * 100;
                float t = (tail / num) * 100;
                Console.WriteLine("Percentage of Head = " + h + "%");
                Console.WriteLine("Percentage of Tail = " + t + "%");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
