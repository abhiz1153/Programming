// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularExpressionMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace OOPs.RegularExpression
{
    /// <summary>
    /// Class for Regular Expression Demonstration
    /// </summary>
    class RegularExpressionMain
    {
        /// <summary>
        /// Regexes this instance.
        /// </summary>
        public void RegexEep()
        {
            try
            {
                ////Ask user to enter name
                Console.WriteLine("Enter Your First Name");
                string name = Console.ReadLine();
                ////validating enterd name have proper character 
                if (!Regex.IsMatch(name, @"[a-zA-Z]"))
                {
                    Console.WriteLine("Entered Wrong Input");
                }
                ////Ask user to enter Full name
                Console.WriteLine("Enter Your Full Name");
                string fullname = Console.ReadLine();

                ////validating enterd full name have proper character
                if (!Regex.IsMatch(fullname, @"[a-zA-Z]"))
                {
                    Console.WriteLine("Entered Wrong Input");
                }
                ////Ask user to enter mobile Number
                Console.WriteLine("Enter Your Mobile Number");
                string num = Console.ReadLine();

                ////validating enterd number have proper character
                if (!Regex.IsMatch(num, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Entered Wrong Input");
                }

                Check(name, fullname, num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Checks the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fullname">The fullname.</param>
        /// <param name="num">The number.</param>
        public void Check(string name, string fullname, string num)
        {
            //// path which holds an text message
            string text = File.ReadAllText(@"C:\Users\admin\source\repos\OOPs\OOPs\RegularExpression\Regex.txt");

            ////pattern for changing name 
            string patternname = "<<name>>";

            //// pattern for changing fullname
            string patternfullname = "<<full name>>";

            //// patern for changing mobile number
            string patternnum = "xxxxxxxxxx";

            //// pattern to change current date
            string patterndate = "01/01/2016";

            ////RegularExpressions class to replace the pattern with valid data
            text = Display(text, name, patternname);

            ////RegularExpressions class to replace the pattern with valid data
            text = Display(text, fullname, patternfullname);

            ////RegularExpressions class to replace the pattern with valid data
            text = Display(text, num, patternnum);

            ////format for getting today date
            string date = DateTime.Now.ToString("d-m-yyyy");

            ////RegularExpressions class to replace the pattern with valid data
            text = Display(text, date, patterndate);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(text);
        }
        /// <summary>
        /// Display the Match
        /// </summary>
        /// <param name="text"></param>
        /// <param name="exp"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string Display(string text, string exp, string pattern)
        {
            ////creating regex class object for passing pattern
            Regex rxg = new Regex(pattern);
            string newString = rxg.Replace(text, exp);
            return newString;
        }
    }
}
