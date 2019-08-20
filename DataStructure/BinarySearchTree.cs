using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// Class for Search for Binary Tree
    /// </summary>
    class BinarySearchTree
    {
     
        /// <summary>
        /// Binaries the tree.
        /// </summary>
        public static void BinaryTree()
        {
            try
            {
                int num = 0;
                bool iterate = true;
                while(iterate)
                {
                    Console.WriteLine("Enter the Number of Elements");
                    string element = Console.ReadLine();
                    if(Utility.IsNumber(element)== false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }
                    num = Convert.ToInt32(element);
                    if (num < 0)
                    {
                        Console.WriteLine("Element Should be Greater than 0");
                        continue;
                    }
                    iterate = false;

                }

                int numBinaryTrees = Utility.CountBinaryTree(num);
                Console.WriteLine("Number of posslible of Binary Trees are = " +numBinaryTrees);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
