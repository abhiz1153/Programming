using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure
{
    

    public class UnOrderedList
    {
        Utility utility = new Utility();
        public void CallUnOrderedList()
        {

            try
            {
                string text = File.ReadAllText(@"C:\Users\admin\Desktop\Demo.txt");
                string[] arr = text.Split(' ');
               
                Console.WriteLine("Dispalyed list from linked list:");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                    utility.AddString(arr[i]);
                }
                Console.WriteLine("Total length of the List: " + arr.Length);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter a word to Search");
                string search = Console.ReadLine();
                utility.SearchString(search);
                int r = utility.SearchString(search);
                if (r == 1)
                {
                    Console.WriteLine("Do you want to Delete " + search + " word from the list Press 1 for Delete or 2 for Ignore");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        utility.DeleteString(search);

                       // File.AllText(@"C:\Users\admin\Desktop\file.txt",search);
                        //  File.(@"C:\Users\admin\Desktop\file.txt",search);
                        utility.Display();
                        File.WriteAllText(@"C:\Users\admin\Desktop\result.text", search);
                    }

                    else
                        return;
                }
                else if (r == 0)
                {
                    Console.WriteLine("Do you want to add " + search + " word in the list Press 1 for Delete or 2 for Ignore");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        utility.AddString(search);
                        File.WriteAllText(@"C:\Users\admin\Desktop\Demo.txt", search);
                        utility.Display();
                    }
                    else
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
