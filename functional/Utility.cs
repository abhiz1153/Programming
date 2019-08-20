using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{

    public class Utility
    {

        public String String_Input()
        {
            string name;
            Console.WriteLine("Enter the String");
            name = Console.ReadLine();

            return name;

        }
       
        public int Year()
        {
            Console.WriteLine("Enter the Year");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public int Number()
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public int[,] int_array(int m, int n)
        {

            int[,] arr = new int[m, n];
            Console.WriteLine("Enter an Element of Integer Array:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        public double[,] double_array(int m, int n)
        {

            double[,] arr = new double[m, n];
            Console.WriteLine("Enter an Element of Double Array:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());

                }
            }
            return arr;
        }
        public bool[,] boolean_array(int m, int n)
        {

            bool[,] arr = new bool[m, n];
            Console.WriteLine("Enter an Element Boolean of Array:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToBoolean(Console.ReadLine());

                }
            }
            return arr;

        }
        public int [] sum_array (int n)
         {
               int[] arr = { 0, -1, 2, -3, 1 };
               
               return arr;
              
        }
        public double double_number()
        {
            double f;
            Console.WriteLine("Enter the Number");
            f = Convert.ToDouble(Console.ReadLine());
            return f;
        }
    }
}
