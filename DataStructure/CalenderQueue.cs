using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CalenderQueue
    {
        /// <summary>
        /// The list1 object of linkedlist class
        /// </summary>
        public LinkedList1<int> list1 = new LinkedList1<int>();

        /// <summary>
        /// The string list1
        /// </summary>
        public LinkedList1<string> stringList1 = new LinkedList1<string>();

        /// <summary>
        /// The intlist2
        /// </summary>
        public List<int> intlist2 = new List<int>();

        /// <summary>
        /// The list2
        /// </summary>
        public List<string> list2 = new List<string>();

        /// <summary>
        /// The queue object1
        /// </summary>
        public QueueUsingLinkedList<int> queueObject1 = new QueueUsingLinkedList<int>();

        /// <summary>
        /// The queue object2
        /// </summary>
        public QueueUsingLinkedList<string> queueObject2 = new QueueUsingLinkedList<string>(); 
        /// <summary>
        /// Prints the calender.
        /// </summary>
        public void PrintCalenderQueue()
        {
            try
            {
                // Queue<int> queueForInt = new Queue<int>();
                //Queue<string> queueForString = new Queue<string>();

                int month = 0;
                int year = 0;

                bool validationForMonth = true;
                //// month (Jan = 1, Dec = 12)
                while (validationForMonth)
                {
                    Console.WriteLine("Enter the month");
                    string stringMonth = Console.ReadLine();
                    if (Utility.IsNumber(stringMonth) == false)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    month = Convert.ToInt32(stringMonth);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    validationForMonth = false;
                }

                bool validationForYear = true;
                //// year
                while (validationForYear)
                {
                    Console.WriteLine("Enter the year");
                    string stringYear = Console.ReadLine();

                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Year");
                        continue;
                    }

                    if (stringYear.Length < 4)
                    {
                        Console.WriteLine("e Year");
                        Console.Read();
                        return;
                    }
                    year = Convert.ToInt32(stringYear);
                    validationForYear = false;
                }

                //// months[i] = name of month i
                String[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                //// days[i] = number of days in month i
                int[] numberOfdays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] days = { "S", "M", "T", "W", "Th", "F", "Sat" };


                //// check for leap year
                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfdays[month] = 29;
                }
                //// print calendar header for month and year
                Console.WriteLine("\t\t\t" + months[month] + "\t" + year);
                Console.WriteLine("S\tM\tTu\tW\tTh\tF\tS");

                //// week day where month starts
                int d = Utility.day(month, 1, year);

                //// print the calendar
                for (int j = 0; j < d; j++)
                {
                    Console.Write(" \t");
                }
                for (int i = 1; i <= numberOfdays[month]; i++)
                {

                    list1 = queueObject1.Enqueue(intlist2, i);

                }
                for (int i = 0; i < days.Length; i++)
                {
                    //queueForString.InsertIntoQueue(days[i]);
                    stringList1 = queueObject2.Enqueue1(list2, days[i]);
                }
                stringList1.Print();

                Console.WriteLine();

                ////print space before date
                for (int i = 0; i < d; i++)
                {
                    Console.Write("\t");
                }

                for (int i = 1; i <= numberOfdays[month]; i++)
                {
                    try
                    {

                        Console.Write(i + "\t");
                        if (((i + d) % 7 == 0) || (i == numberOfdays[month]))
                            Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


