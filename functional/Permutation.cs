using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class Permutation
    {
        Utility utility = new Utility();
        public void permutation()
        {
            string str = utility.String_Input();
            int n = str.Length;
            permute(str, 0, n - 1);
        }

        private void permute(String str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);

            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                  
                }
            }
         Console.ReadKey();
        }


        public String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
   