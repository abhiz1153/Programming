using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSortInteger
    {
        Utility utility = new Utility();
        public void BubbleInteger()
        {
            try
            {
                Console.Write("Size of Element ");
                int n = utility.NumberInput();
                int[] arr = new int[n];
                Console.WriteLine("Enter the Element of Number");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Entered Element are");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ");
                utility.BubbleSortInt(arr, n);
                Console.WriteLine("Sorted Array after applying Bubble Sort Algorithm");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
