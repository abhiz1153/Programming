using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   public class HashingFunction
    {
        Utility utility = new Utility();
        public  int[,] Hashlist = new int [10,10];
        public int[,] CalculateHash(List<int> list)
        {
            foreach(int element in list)
            {
                int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eight = 0, ninth = 0, tenth = 0;

                if (utility.Remainder(element) == 0)
                {
                    Hashlist[0, first] = element;
                    first++;
                }
                else if (utility.Remainder(element) == 1)
                {
                    Hashlist[1, second] = element;
                    second++;
                }
                else if (utility.Remainder(element) == 2)
                {
                    Hashlist[2, third] = element;
                    third++;
                }
                else if (utility.Remainder(element) == 3)
                {
                    Hashlist[3, fourth] = element;
                    fourth++;
                }
                else if (utility.Remainder(element) == 4)
                {
                    Hashlist[4, fifth] = element;
                    fifth++;
                }
                else if (utility.Remainder(element) == 5)
                {
                    Hashlist[5, sixth] = element;
                    sixth++;
                }
                else if (utility.Remainder(element) == 6)
                {
                    Hashlist[6, seventh] = element;
                    seventh++;
                }
                else if (utility.Remainder(element) == 7)
                {
                    Hashlist[7, eight] = element;
                    eight++;
                }
                else if (utility.Remainder(element) == 8)
                {
                    Hashlist[8, ninth] = element;
                    ninth++;
                }
                else if (utility.Remainder(element) == 9)
                {
                    Hashlist[9, tenth] = element;
                    tenth++;
                }
            }
            return Hashlist;
        }
    }
}
