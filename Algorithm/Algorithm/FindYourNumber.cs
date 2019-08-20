using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class FindYourNumber
    {
        public void FindNumber()
        {
            {
                int[] arr = new int[] { 2, 255, 1, 9, 10, 250, 4, 3, 117, 27, 54, 10, 43, 72, 189 };
                char ch;
                int first = 0, last = arr.Length - 1;
                Console.WriteLine("Think one Number: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\nEnter 1 if you are done with it.....");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Array.Sort(arr);
                    while (first <= last)
                    {
                        int mid = (first + last) / 2;
                        Console.WriteLine("Is your number less than or equal to " + arr[mid] + "?(y/n) : ");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch == 'y' || ch == 'Y')
                        {
                            last = mid;
                            Console.WriteLine("Is " + arr[mid] + " your number?(y/n) : ");
                            ch = Convert.ToChar(Console.ReadLine());
                            if (ch == 'y' || ch == 'Y')
                            {
                                Console.WriteLine("Thank you for playing this game...");
                                break;
                            }
                        }
                        else
                        {
                            first = mid;
                            Console.WriteLine("Is " + arr[mid] + " your number?(y/n) : ");
                            ch = Convert.ToChar(Console.ReadLine());
                            if (ch == 'y' || ch == 'Y')
                            {
                                Console.WriteLine("Thank you for playing this game...");
                                break;
                            }
                        }
                        mid = (first + last) / 2;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered wrong input. Exiting....");
                }

            }
        }
    }
}