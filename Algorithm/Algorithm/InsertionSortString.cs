using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSortString
    {
        Utility utility = new Utility();
        public void Insert()
        {
            try
            {
                int i = 0;
                Console.Write("Size of Array ");
                int n = utility.NumberInput();
                string[] arr = new string[n];

                Console.WriteLine("Enter the Element Strings");
                for (i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToString(Console.ReadLine());

                }

                
                utility.InsertString(arr);
                Console.WriteLine("Sorted String after performing Insertion Sort Algorithm ");
                for (i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" " + arr[i] + " ");

                }
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
            
        }

    }
}
