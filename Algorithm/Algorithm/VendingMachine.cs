using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class VendingMachine
    {
        Utility utility = new Utility();
        public void Vending()
        {
            try
            {
                Console.Write("Change to be Return ");
                int change = utility.NumberInput();
                utility.Notes(change);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
