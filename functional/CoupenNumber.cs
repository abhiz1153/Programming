using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class CouponNumber
    {
        Utility utility = new Utility();
        public void Coupon()
        {
            try
            {
                Console.Write("Coupon Ending ");
                int total = utility.Number();
                Console.Write("How many Ticket You want ");
                int num = utility.Number();
                Random rand = new Random();
                for (int i = 1; i <= num; i++)
                {
                    int t = rand.Next(1, total);
                    Console.WriteLine(t);
                    Console.WriteLine(" ");

                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
