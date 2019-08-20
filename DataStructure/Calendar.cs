using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// Class to print given month and year
    /// </summary>
    class Calendar
    {
        /// <summary>
        /// Prints the calendar.
        /// </summary>
        public static void PrintCalendar()
        {
            try
            {
                int month = 0, year = 0;
                bool ValiditionforMonth = true;
                // month (Jan = 1, Dec = 12)
                while (ValiditionforMonth)
                {
                    Console.WriteLine("Enter the Month in Number");
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
                    ValiditionforMonth = false;
                }
                bool ValidationforYear = true;
                // year
                while (ValidationforYear)
                {
                    Console.WriteLine("Enter the Year");
                    string stringYear = Console.ReadLine();
                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Year");
                        continue;
                    }
                    if (stringYear.Length < 4)
                    {
                        Console.WriteLine("Invalid Year");
                        Console.Read();
                        return;
                    }
                    year = Convert.ToInt32(stringYear);
                    ValidationforYear = false;
                    
                }
                
                string[] monthName = { " ", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberofDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                // Cheak Leap Year
                if (month == 2 && Utility.CheckLeapYear(year)) numberofDays[month] = 29;
                Console.WriteLine("\t\t\t" + monthName[month] + "\t" + year);
                Console.WriteLine("S\tM\tTu\tW\tTh\tF\tSa");
                // Week Day where Month Starts
                int d = Utility.day(month, 1, year);
                // Print the Calendar
                for(int j = 0;j<d; j++)
                {
                    Console.Write(" \t");
                }
                for(int i=1;i<=numberofDays[month];i++)
                {
                    Console.Write(i+ " \t");
                    if (((i + d) % 7 == 0) || (i == numberofDays[month]))
                        Console.WriteLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
