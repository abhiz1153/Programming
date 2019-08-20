using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagram
    {
        public void Anagram()
        {
            
                int k = 0;
                int[,] prime = new int[10, 1000];
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = i * 100 ; j < (i + 1) * 100; j++)
                        {
                            int count = 0;
                            for (int m = j; m > 0; m--)
                            {
                                if (j > 2)
                                {
                                    if (j % m == 0)
                                    {
                                        count++;
                                    }
                                }
                            }
                            if (count == 2)
                            {
                                prime[i, j] = j;
                            }
                        }
                        Console.WriteLine();
                    }
                    //// write primenumbers from the array
                    Console.WriteLine("prime numbers are : ");
                    int[] arr = new int[30];
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("prime numbers in between " + i * 100 + "   " + (i * 100 + 100));
                        //// condition to check the range
                        for (int j = i * 100 ; j < (i + 1) * 100; j++)
                        {

                            if (prime[i, j] != 0)
                            {
                                Console.Write(prime[i, j] + " ");
                                int temp = prime[i, j];
                                arr[k] = temp;
                                k++;
                            }
                        }
                        Console.WriteLine();
                    }
                    for (int x = 0; x < k; x++)
                    {
                        for (int y = x + 1; y < k; y++)
                        {
                            string str1 = arr[x].ToString();
                            String str2 = arr[y].ToString();
                            if (str1.Length == str2.Length)
                            {
                                char[] char1 = str1.ToCharArray();
                                char[] char2 = str2.ToCharArray();

                                Array.Sort(char1);
                                Array.Sort(char2);
                                string NewWord1 = new string(char1);
                                string NewWord2 = new string(char2);
                                for (int n = 0; n < char1.Length; n++)
                                {
                                    if (NewWord1 == NewWord2)
                                    {
                                        Console.WriteLine(" prime anagrams are  " + str1 + " " + str2);
                                    }
                                }
                            }
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
