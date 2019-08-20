using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BankCashCounter
    {
        Utility utility = new Utility();
       public static int InitialAmount = 40000;
        public void CashCounter()
        {
            try
            { char choice;
                int ch;
                do
                {
               
                    BankCashCounter bankdata = new BankCashCounter();
                    Console.WriteLine("What type of Transaction do you required ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Deposite Cash");
                    Console.WriteLine("2. Withdrawl Cash");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            utility.DepositeCash(bankdata);
                            Console.WriteLine("Update cash Availablie on your Bank after Deposite = Rs-" + InitialAmount);
                            break;
                        case 2:
                            utility.WithDrawalCash(bankdata);
                            Console.WriteLine("Your available Balance after Withdrawl = Rs- " + InitialAmount);
                            break;
                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

