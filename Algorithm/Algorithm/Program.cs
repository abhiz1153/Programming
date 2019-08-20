using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ALGORITHM PROGRAMS");
            Console.WriteLine("1.  Anagram");
            Console.WriteLine("2.  Prime");
            Console.WriteLine("3.  Prime Palindrome Anagram");
            Console.WriteLine("4.  Search and Sort List");
            Console.WriteLine("5.  Insertion Sort String");
            Console.WriteLine("6.  Bubble Sort Number");
            Console.WriteLine("7.  Merge Sort");
            Console.WriteLine("8.  Vending Machine");
            Console.WriteLine("9.  Day of Week");
            Console.WriteLine("10. Temperature Conversion");
            Console.WriteLine("11. Monthly Payment");
            Console.WriteLine("12. Square Root Using Newton's Method");
            Console.WriteLine("13. Binary to Decimal Number");
            Console.WriteLine("14. Guessing an Number");
            Console.WriteLine("15. Reading a Text From a File");
            Console.WriteLine("");
            Console.WriteLine("Enter which program you want to run");
            Console.WriteLine("");
            Console.WriteLine("Enter your Choice");
            Console.WriteLine(" ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Anagram anaObj = new Anagram();
                    anaObj.anagram();
                    break;
                case 2:
                    Prime primeObj = new Prime();
                    primeObj.prime();
                    break;
                case 3:
                    PrimePalindromeAnagram ppaObj = new PrimePalindromeAnagram();
                    ppaObj.Primeno();
                    break;
                case 4:
                    SearchSortList searchsort = new SearchSortList();
                    searchsort.SearchingSorting();
                    break;
                case 5:
                    InsertionSortString insertionsortObj = new InsertionSortString();
                    insertionsortObj.Insert();
                    break;
                case 6:
                    BubbleSortInteger bubbleInt = new BubbleSortInteger();
                    bubbleInt.BubbleInteger();
                    break;
                case 7:
                    MergeSort merge = new MergeSort();
                    merge.Merge();
                    break;
                case 8:
                    VendingMachine machine = new VendingMachine();
                    machine.Vending();
                    break;
                case 9:
                    DayOfWeek day = new DayOfWeek();
                    day.Week();
                    break;
                case 10:
                    TemperaturConversion temperaturObj = new TemperaturConversion();
                    temperaturObj.Temperature();
                    break;
                case 11:
                    MonthlyPayment monthlyObj = new MonthlyPayment();
                    monthlyObj.Payment();
                    break;
                case 12:
                    SquareRootNewton squareObj = new SquareRootNewton();
                    squareObj.SquareRoot();
                    break;
                case 13:
                    DecimalToBinary decimalObj = new DecimalToBinary();
                    decimalObj.Binary();
                    break;
                case 14:
                    FindYourNumber find = new FindYourNumber();
                    find.FindNumber(); 
                    break;
                case 15:
                    SearchTextFile searchText = new SearchTextFile();
                    searchText.TextFile();
                    break;
                default: 
                    break;
            }
        }
    }
}
