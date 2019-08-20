using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class SquareRootNewton
    {
        Utility utility = new Utility();
        public void SquareRoot()
        {
            try
            {
                Console.Write("Only Non Negative Number. So ");
                int num = utility.NumberInput();
                if (num >= 0)
                    utility.NewtonSquare(num);
                else
                    Console.WriteLine("Invalid Input Enter Positive Number");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
