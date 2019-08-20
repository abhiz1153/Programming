using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class DayOfWeek
    {
        Utility utility = new Utility();
        public void Week()
        {
            try
            {
                int day = 0, month = 0, year = 1;
                 Console.Write("Day(dd) ");
                 day = utility.NumberInput();
                if (day >= 1 && day <= 31)
                {
                    Console.Write("Month(mm) ");
                    month = utility.NumberInput();
                }
                else
                    Console.WriteLine("Please Enter Day between 1 to 31 ");
                
                if(month >= 1 && month <= 12)
                {
                    Console.Write("Year(yyyy) ");
                    year = utility.NumberInput();
                }
                else
                    Console.WriteLine("Please Enter Month between 1 to 12 ");
                if(year >= 1000 && year <= 9999)
                {
                    int n = utility.Dayofweek(day, month, year);
                    
                    string [] days= { "Sunday", "Monday", "Tuseday", "Wendesday", "Thursday", "Friday", "Saturday" };
                    Console.WriteLine("Date " +day+"/"+month+"/"+year+" -- is --" +days[n]);
                }
                else
                    Console.WriteLine("Please Enter proper Year ");


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
