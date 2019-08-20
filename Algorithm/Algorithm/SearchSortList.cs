using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class SearchSortList
    {
        public void SearchingSorting()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            {
                Console.WriteLine("MENU FOR SEARCH AND SORT LIST");
                Console.WriteLine("1. Binary Search Method for Integer ");
                Console.WriteLine("2. Binary Search Method for String");
                Console.WriteLine("3. Insertion Sort Method for Integer");
                Console.WriteLine("4. Insertion Sort Method for String");
                Console.WriteLine("5. Bubble Sort Method for Integer");
                Console.WriteLine("6. Bubble Sort Method for String");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter which program you want to run");
                Console.WriteLine("");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine(" ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearchIntegers binaryint = new BinarySearchIntegers();
                        binaryint.BinaryInt();
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds;
                        Console.WriteLine("Total Elapsed Time taken to  perform Execution= "+ (elapsedMs / 1000) + " sec");
                        break;
                    case 2:
                        BinarySearchString binarystr = new BinarySearchString();
                        binarystr.BinaryString();
                        watch.Stop();
                        var elapsedMs1 = watch.ElapsedMilliseconds;
                        Console.WriteLine("Total Elapsed Time taken to  perform Execution= "+ (elapsedMs1 / 1000) + " sec");
                        break;
                    case 3:
                        InsertionSortInteger insertionint = new InsertionSortInteger();
                        insertionint.InsertionInteger();
                        watch.Stop();
                        var elapsedMs2 = watch.ElapsedMilliseconds;
                        Console.WriteLine("Total Elapsed Time taken to  perform Execution= "+ (elapsedMs2 / 1000) + " sec");
                        break;
                    case 4:
                        InsertionSortString insertionstr = new InsertionSortString();
                        insertionstr.Insert();
                        watch.Stop();
                        var elapsedMs3 = watch.ElapsedMilliseconds;
                        Console.WriteLine("Total Elapsed Time taken to  perform Execution= "+ (elapsedMs3 / 1000) + " sec");
                        break;
                    case 5:
                        BubbleSortInteger bubbleint = new BubbleSortInteger();
                        bubbleint.BubbleInteger();
                        watch.Stop();
                        var elapsedMs4 = watch.ElapsedMilliseconds;
                        Console.WriteLine("Total Elapsed Time taken to  perform Execution= "+ (elapsedMs4 / 1000) + " sec");
                        break;
                    case 6:
                        BubbleSortString bubblestr = new BubbleSortString();
                        bubblestr.BubbleString();
                        watch.Stop();
                        var elapsedMs5 = watch.ElapsedMilliseconds;
                        Console.WriteLine("Total Elapsed Time taken to  perform Execution= "+ (elapsedMs5 / 1000) + " sec");
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}
