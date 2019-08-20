using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
        /// <summary>
        /// class for input for hashing
        /// </summary>
        public class InputForHashing
        {
            /// <summary>
            /// The mylist for store the elemnts
            /// </summary>
            public List<int> mylist = new List<int>();

            /// <summary>
            /// The myarr
            /// </summary>
            int[,] myarr = new int[10, 10];


            /// <summary>
            /// Starts the hashing.
            /// </summary>
            public void StartHashing()
            {
                HashingFunction hash = new HashingFunction();
                Utility utility = new Utility();
            string data = File.ReadAllText(@"C:\Users\admin\source\repos\DataStructure\DataStructure\OrderedList.txt");
            string[] element = data.Split(',');
            int[] numbers = new int[element.Length];
                for (int n = 0; n < element.Length; n++)
                {
                    numbers[n] = int.Parse(element[n]);
                }
                ////foreach loop for traversing thorughtout list
                foreach (int intData in numbers)
                {
                    mylist.Add(intData);
                }
                myarr = hash.CalculateHash(mylist);
                utility.PrintHashArray(myarr);
                Console.WriteLine("enter the number which you want");
                int serachNum = Convert.ToInt32(Console.ReadLine());
                int value = utility.SearchInHash(serachNum, myarr);
                Console.WriteLine(" value found at " + value + "th index ");
                Console.ReadKey();
            }
        }
    }
