using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimePalindromeAnagram
    {
        public void Primeno()
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
                    Palindrome(i,1000);

                }
               
            }

        }

        public void Palindrome(int pl, int a)
        {
            int temp = 0, r, sum = 0;
            temp = pl;
            while (temp > 0)
            {
                r = temp % 10;
                sum = (sum * 10) + r;
                temp = temp / 10;

            }
            if (pl == sum)
            {

                Console.WriteLine(sum + " is Prime Number as well as Palindrome Between 0 to " + a);

            }
        }
     
    }
}

