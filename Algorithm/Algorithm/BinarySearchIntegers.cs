using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySearchIntegers
    {
        Utility utility = new Utility();
        public void BinaryInt()
        {
            try
            {
                Console.Write("Size of Element ");
                int n = utility.NumberInput();
                int[] arr = new int[n];
                Console.WriteLine("Enter the Element ");
                for(int i=0;i<n;i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Entered Element are");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ");
                Console.WriteLine("Enter the Element to Search ");
                int key = Convert.ToInt32(Console.ReadLine());
                int first = 0, last = arr.Length-1;
                utility.BinaryInteger(arr, first, last, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
