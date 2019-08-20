using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class SumOfThree
    {
        Utility utility = new Utility();
        public void Sum()
        {
            int n = utility.Number();
            int[] intArray = new int[n];
            intArray = utility.sum_array(n);
            bool b = false;
            Array.Sort(intArray);
            for (int i = 0; i < n - 1; i++)
            {
                int j = i + 1;
                int k = n - 1;
                int x = intArray[i];
                while (j < k)
                {
                    if (x + intArray[j] + intArray[k] == 0)
                    {
                        Console.WriteLine(x + "  " + intArray[j] + "  " + intArray[k]);
                        j++;
                        k--;
                        b = true;
                    }
                    else if (x + intArray[j] + intArray[k] < 0)
                        j++;
                    else
                        k--;
                }
            }
            if (b == false)
                Console.WriteLine("no triple found");
            Console.ReadKey();
        }
    }
}


