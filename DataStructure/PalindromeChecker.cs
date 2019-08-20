using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeChecker
    {
        DequeOperation<char> operation = new DequeOperation<char>(); 
        Utility utility = new Utility();
        public void Palindrome()
        {
            try
            {
                
                char [] s = utility.StringInput().ToLower().ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    utility.AddRear(c);
                }
                int flag = 0;
                while (utility.GetSize() > 1)
                {
                    if (utility.RemoveFront() != utility.RemoveRear())
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Entered String is Plaindrome");
                }
                else
                {
                    Console.WriteLine("Entered String is not Plaindrome");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
