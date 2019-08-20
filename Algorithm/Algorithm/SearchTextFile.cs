using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace Algorithm
{
    class SearchTextFile
    {
        Utility utility = new Utility();
        public void TextFile()
        {
            try
            {
                string text = File.ReadAllText(@"C:\Users\admin\Desktop\file.txt");
                string[] arr = text.Split(' ');
               
                foreach(string str in arr)
                    Console.WriteLine(str + "  ");
                
                Console.WriteLine("Enter the Element to Search ");
                string key = Console.ReadLine();
                int first = 0, last =arr.Length-1;
                utility.BinaryString(arr, first, last, key);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
