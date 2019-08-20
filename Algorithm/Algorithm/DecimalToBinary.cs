using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class DecimalToBinary
    {
        Utility utility = new Utility();
        public void Binary()
        {
            try
            {
                Console.Write("For Declimal to Binary Conversion ");
                int num = utility.NumberInput();
                utility.DecimalNum(num);            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
