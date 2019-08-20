using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySearchString
    {
        Utility utility = new Utility();
        public void BinaryString()
        {
            try
            {
                Console.Write("Size of Element ");
                int n = utility.NumberInput();
                string[] arr = new string[n];
                Console.WriteLine("Enter the Element of String");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Console.ReadLine();
                } Console.WriteLine("Entered Element are");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ");
               
                Console.WriteLine("Enter the Element to Search ");
                string key = Console.ReadLine();
                int first = 0, last = arr.Length-1;
                utility.BinaryString(arr, first, last, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
