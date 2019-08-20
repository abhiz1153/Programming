using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MonthlyPayment
    {
        Utility utility = new Utility();
        public void Payment()
        {
            try
            {
                Console.Write("Principal ");
                double P = utility.DoubleInput();
                Console.Write("Year ");
                int Y = utility.NumberInput();
                Console.Write("Rate of Intrest ");
                double R = utility.DoubleInput();
                utility.Payment(P, R, Y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
