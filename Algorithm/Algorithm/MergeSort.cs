using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {
        Utility utility = new Utility();
        public void Merge()
        {
            try
            {
                Console.Write("Size of String ");
                int n = utility.NumberInput();
                string[] arr = new string[n];
                Console.WriteLine("Enter the String");
                for(int i=0;i<n;i++)
                {
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("Entered Strings");
                utility.PrintArray(arr);
                utility.Sort(arr, 0,arr.Length - 1);
                Console.WriteLine("After Sorting ");
                utility.PrintArray(arr);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
