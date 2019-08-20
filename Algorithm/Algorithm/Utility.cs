using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Utility
    {
        public string String_Input()
        {
            Console.WriteLine("Enter the String");
            string s = Convert.ToString(Console.ReadLine());
            return s;
        }
        public int NumberInput()
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        public void InsertString(string[] arr)
        {
            int n = arr.Length;
            string temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((arr[i].CompareTo(arr[j]) > 0))
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }
        public void InsertInteger(int[] arr)
        {

            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public void BinaryInteger(int[] arr, int first, int last, int key)
        {
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (arr[mid] == key)
                {
                    Console.WriteLine(key + " is found at index: " + mid);
                    break;
                }
                else if (key > arr[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
                mid = (first + last) / 2;
                if (first > last)
                {
                    Console.WriteLine("Element is not found!");
                }
            }
        }
        public void BinaryString(string[] arr, int first, int last, string key)
        {
            
            int mid = (first + last) / 2;
            while (first <= last)
            {
                int res = key.CompareTo(arr[mid]);
                if (res == 0)
                {
                    Console.WriteLine(key + " Element is found at Index " + (mid + 1) );
                    break;
                }
                else if (res < 0)
                {
                    last = mid - 1; 
                }
                else
                {
                     first = mid + 1;
                   
                }
                mid = (first + last) / 2;
            }
            if (first > last)
            {
                Console.WriteLine("Element is not found!");
            }
        }
        public int[] BubbleSortInt(int[] arr, int len)
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public string[] BubbleSortStr(string[] str, int len)
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (str[j].CompareTo(str[i]) < 0)
                    {
                        string temp = str[j];
                        str[j] = str[i];
                        str[i] = temp;
                    }
                }
            }
            return str;
        }
        public void PrintArray(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine();
        }
        public void Sort(string[] arr, int l, int r)
        {
            if (l < r)
            {    //// Find the middle point 
                int m = (l + r) / 2;
                //// Sort first and second halves 
                this.Sort(arr, l, m);
                this.Sort(arr, m + 1, r);
                //// Merge the sorted halves 
                this.Merge(arr, l, m, r);
            }
        }
        public void Merge(string[ ] arr, int l, int m, int r)
        {
            ////Calculate length of two subarrays
            int n1 = m - l + 1;
            int n2 = r - m;
            string[] L = new string[n1];
            string[] R = new string[n2];
            ////move strings from left of mid in L subarray
            for (int i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            ////move strings from right of mid in R subarray
            for (int j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }
            ////Merge the temporary arrays
            int p = 0, n = 0;
            //// Initial index of merged sub array array 
            int k = l;
            while (p < n1 && n < n2)
            {
                if (L[p].CompareTo(R[n]) < 0)
                {
                    arr[k] = L[p];
                    p++;
                }
                else
                {
                    arr[k] = R[n];
                    n++;
                }

                k++;
            }
            //// Copy remaining elements of L[] if any 
            while (p < n1)
            {
                arr[k] = L[p];
                p++;
                k++;
            }
            ////Copy remaining elements of R[] if any */
            while (n < n2)
            {
                arr[k] = R[n];
                n++;
                k++;
            }
        }
        public void Notes(int change)
        {
            int[] arr = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            ////n_notes for no of notes of each currency & min_notes for no of minimum notes
            int n_notes, min_notes = 0;
            while (change > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    n_notes = change / arr[i];
                    change = change % arr[i];
                    min_notes += n_notes;
                    Console.WriteLine("No of " + arr[i] + " rupees notes : " + n_notes);
                }
            }
            Console.WriteLine("\n\nMinimum number of notes : " + min_notes);
        }
        public int Dayofweek(int d, int m, int y)
        {
            int y0, d0, m0, x;
            y0 = y - ((14 - m) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = m + (12 * ((14 - m) / 12)) - 2;
            d0 = (d + x + (31 * m0 / 12)) % 7;
            return d0;
        }


        public void FahrenheitToCelsius()
        {
            Console.WriteLine("Enter the Fahrenheit ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = ((f - 32) * 5 / 9);
            Console.WriteLine("If Fahrenheit = " + f + "f Then Celsius  = " + c + "c");
        }
        public void CelsiusToFahrenheit()
        {
            Console.WriteLine("Enter the Celcius");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = ((c * 9) / 5) + 32;
            Console.WriteLine("If Celsius = " + c + "f Then Fahrenheit =" + f + "f");
        }
        public double DoubleInput()
        {
            Console.WriteLine("Enter the Number");
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }
        public void Payment(double principal, double rate, int year)
        {
            int n = 12 * year;
            double r = rate / (12 * 100);
            double payment = (principal * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Monthly Payment is Rs" + payment + " /-");

        }
        public void NewtonSquare(double c)
        {
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - (c / t)) > epsilon * t)
                t = ((c / t) + t) / 2.0;
            Console.WriteLine("The Square Root of Given Number " + c + " is " + t);

        }
        public void DecimalNum(int n)
        {
            int i,s;
            s = n;
            int[] a = new int[10];
           
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("After converting Decimal Number "+s+" to Binary Number = ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
        
    }
}
