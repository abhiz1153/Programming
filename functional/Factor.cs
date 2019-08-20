using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{

    class Factor
    {
        Utility utility = new Utility();
        public void PrimeFactor()
        {
            int num = utility.Number();
            for (int i = 2; i < num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if (num > 2)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}

