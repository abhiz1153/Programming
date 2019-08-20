using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class Distance
    {
        Utility utility = new Utility();
        public void Dist()
        {
            try
            {
                Console.Write("Piont X ");
                double x = utility.double_number();
                Console.Write("Point Y ");
                double y = utility.double_number();

                double dist = Math.Sqrt(x * x + y * y);
                Console.WriteLine("Distance from (" + x + ", " + y + ") to the origin (0, 0) = " + dist);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
