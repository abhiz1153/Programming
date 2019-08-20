using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    

       public class OrderedList
        {
            Utility utility = new Utility();
            public void CallOrderedList()
            {
                try
                {
                    string data = File.ReadAllText(@"C:\Users\admin\source\repos\DataStructure\DataStructure\OrderedList.txt");
                    string[] arr = data.Split(',');
                     Array.Sort(arr);
                int[] numbers = new int[arr.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        numbers[i] = int.Parse(arr[i]);
                    }
                   
                    Console.WriteLine("Dispalyed list from linked list:");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(numbers[i]);
                        utility.AddIntegers(numbers[i]);
                    }
                    Console.WriteLine("Total length of the List: " + arr.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(" "); Console.WriteLine("Enter the Number to Search");
                    int search = Convert.ToInt32(Console.ReadLine());
                    utility.SearchIntegers(search);
                    int r = utility.SearchIntegers(search);
                    if (r == 1)
                    {
                        Console.WriteLine("Do you want to Delete " + search + " Number from the list Press 1 for Delete or 2 for Ignore");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (n == 1)
                        {
                            utility.DeleteIntegers(search);
                            // File.AllText(@"C:\Users\admin\Desktop\file.txt",search);
                            //  File.(@"C:\Users\admin\Desktop\file.txt",search);
                            utility.Display();
                        }

                        else
                            return;
                    }
                    else if (r == 0)
                    {
                        Console.WriteLine("Do you want to add " + search + " Number in the list Press 1 for Delete or 2 for Ignore");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            utility.AddIntegers(search);
                            string output = search.ToString();
                            File.WriteAllText(@"C:\Users\admin\source\repos\DataStructure\DataStructure\OrderedList.txt", output);
                            utility.Display();
                        }
                       
                            return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
