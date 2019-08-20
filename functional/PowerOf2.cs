using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class PowerOf2
    {
        Utility utility = new Utility();
        public void Power()
        {
            try
            {
                int result = 1;
                int num = utility.Number();
                int i = 1;
                while (i <= num)
                {
                    result = result * num;
                    Console.WriteLine(num + " ^ " + i + " result " + result);
                    i++;
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