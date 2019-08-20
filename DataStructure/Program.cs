using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("Data Structure");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. On Ordered List");
                    Console.WriteLine("2. Ordered List");
                    Console.WriteLine("3. Simple Balanced Parentheses");
                    Console.WriteLine("4. Simulate Banking Cash Counter");
                    Console.WriteLine("5. Palindrome Checker ");
                    Console.WriteLine("6. Hashing Function to search a Number in a slot");
                    Console.WriteLine("7. Number of Binary Search Tree");
                    Console.WriteLine("8. Calendar");
                    Console.WriteLine("9. Display Calendar Using Queue");
                    Console.WriteLine("10. Prime Numbers in a 2D Array");
                    Console.WriteLine("");
                    Console.WriteLine("Enter which program you want to run");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            UnOrderedList unOrdered = new UnOrderedList();
                            unOrdered.CallUnOrderedList();
                            break;
                        case 2:
                            OrderedList orderedList = new OrderedList();
                            orderedList.CallOrderedList();
                            break;
                        case 3:
                            BalancedParentheses balancedParentheses = new BalancedParentheses();
                            balancedParentheses.CheckExpressionParanthesis();
                            break;
                        case 4:
                            BankCashCounter bank = new BankCashCounter();
                            bank.CashCounter();
                            break;
                        case 5:
                            PalindromeChecker checker = new PalindromeChecker();
                            checker.Palindrome();
                            break;
                        case 6:
                            InputForHashing input = new InputForHashing();
                            input.StartHashing();
                            break;
                        case 7:
                            BinarySearchTree.BinaryTree();
                            break;
                        case 8:
                            Calendar.PrintCalendar();
                            break;
                        case 9:
                            CalenderQueue calenderQueue = new CalenderQueue();
                            calenderQueue.PrintCalenderQueue();
                            break;
                        case 10:
                            PrimeNumber.Prime2DOperation();
                            break;
                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
