using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSortInteger
    {
        Utility utility = new Utility();
        public void InsertionInteger()
        {
            try
            { 
                     
            Console.Write("Size of Array ");
                int n = utility.NumberInput();
                int[] arr = new int[n];            

            Console.WriteLine("Enter the Element Number");
            for (int i = 0; i < n; i++)
            {
                    arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            utility.InsertInteger(arr);

            Console.WriteLine("Sorted Number of Element after performing Insertion Sort Algorithm ");
                for (int i = 0; i < arr.Length; i++)
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
