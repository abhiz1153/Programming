using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSortString
    {
        Utility utility = new Utility();
        public void BubbleString()
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
                }
                Console.WriteLine("Entered Element are");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(arr[i] + " ");
                utility.BubbleSortStr(arr, n);
                Console.WriteLine("Sorted Array after applying Bubble Sort Algorithm ");
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
