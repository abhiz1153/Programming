using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Anagram
    {
        Utility utility = new Utility();
        public void anagram()
        {
            string str1 = utility.String_Input();
            string str2 = utility.String_Input();

            char[] s1 = str1.ToLower().ToCharArray();
            char[] s2 = str2.ToLower().ToCharArray();
          

            Array.Sort(s1);
            Array.Sort(s2);
            string word1 = new string(s1);
            string word2 = new string(s2);

            if (word1==word2)
                Console.WriteLine(str1 + " and " + str2 + " are Anagram");
            else
                Console.WriteLine(str1 + " and " + str2 + " are not Anagram");

        }
    }
}