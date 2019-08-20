using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Prime
    {
        Utility utility = new Utility();
        public void prime()
        {
            String primeNumbers = "";
            for (int i = 1; i <= 1000; i++)
            {
                int counter = 0;
                for (int num = i; num >= 1; num--)
                {
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    }
                }
                if (counter == 2)
                {
                     primeNumbers = primeNumbers + i + " ";
                }
            }
            Console.WriteLine("Prime numbers from 1 to 1000 are :");
            Console.WriteLine(primeNumbers);

        }
    }
}
