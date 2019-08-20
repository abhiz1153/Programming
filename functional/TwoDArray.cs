using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class TwoDArray
    {
        Utility utility = new Utility();


        public void TwoD()
        {
            int m = 0;
            int n = 0;
            Console.Write("Row ");
            m = utility.Number();
            Console.Write("Column ");
            n = utility.Number();

            int[,] Integer_Array = new int[m, n];
            Integer_Array = utility.int_array(m, n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Integer_Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double[,] Double_Array = new double[m, n];
            Double_Array = utility.double_array(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Double_Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            bool[,] Boolean_Array = new bool[m, n];
            Boolean_Array = utility.boolean_array(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Boolean_Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}