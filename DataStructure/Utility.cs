using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{

    class Utility
    {
        private DequeOperation<char> deque = new DequeOperation<char>();

        Node head = null;
        INode head1 = null;
        int value;
        public int RemainderValue;
        public void AddString(string data)
        {

            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                //Console.WriteLine(node.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                //Console.WriteLine(node.data);
            }
        }
        public void AddIntegers(int numbers)
        {

            INode nod = new INode(numbers);
            if (head1 == null)
            {
                head1 = nod;
                //Console.WriteLine(node.data);
            }
            else
            {
                INode temp = head1;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = nod;
                //Console.WriteLine(node.data);
            }
        }
        public void Display()
        {
            // Node head = null;
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "    ");
                temp = temp.next;
            }
        }
        public void DeleteString(string data)
        {

            Node temp = head;
            Node prev = head;
            if (temp == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            else if (temp.data == data)
            {
                head = temp.next;
                Console.WriteLine("Found");
                return;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        prev.next = temp.next;
                        Console.WriteLine("Found ");
                        Console.WriteLine("Deleting ...    " + temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }
        public int SearchString(string search)
        {
            // Function to Search the list.
            Node temp = head;

            // if the list is empty
            if (head.data == null)
            {
                Console.WriteLine("Nothing Found, List Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == search)
                    {
                        Console.WriteLine(search + " is in the list!");
                        return 1;
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine(search + " not in the list. ");
            return 0;


        }
        public int SearchIntegers(int search)
        {
            // Function to Search the list.
            INode temp = head1;

            // if the list is empty
            if (head1.data == 0)
            {
                Console.WriteLine("Nothing Found, List Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == search)
                    {
                        Console.WriteLine(search + " is in the list!");
                        return 1;
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine(search + " not in the list. ");
            return 0;
        }
        public void DeleteIntegers(int data)
        {

            INode temp = head1;
            INode prev = head1;
            if (temp == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            else if (temp.data == data)
            {
                head1 = temp.next;
                Console.WriteLine("Found");
                return;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        prev.next = temp.next;
                        Console.WriteLine("Found ");
                        Console.WriteLine("Deleting ...    " + temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }
        public void IsEmpty()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine(" Given arethemetic expression is balanced !!");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine("Given arethemetic expression is not balenced");
            }
        }
        public int DepositeCash(BankCashCounter bankCash)
        {
            int amount;
            do
            {
                Console.WriteLine("Enter the Amount you want to Deposite.");
                Console.WriteLine("NOTE:- Amount Should be Greater than 0 (ZERO) to Make an Deposite");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            while (amount < 0);
            {
                BankCashCounter.InitialAmount = BankCashCounter.InitialAmount + amount;
                Console.WriteLine("Transaction Succesfull Enter Amount had been sucessfully Deposite");
            }
            return BankCashCounter.InitialAmount;
        }
        public int WithDrawalCash(BankCashCounter bankCash)
        {
            Console.WriteLine("Available Balance Rs- " + BankCashCounter.InitialAmount);
            Console.WriteLine("Enter Amount to withdrawl");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= BankCashCounter.InitialAmount)
            {
                Console.WriteLine("Enter amount had Successfully Withdrawl");
                BankCashCounter.InitialAmount = BankCashCounter.InitialAmount - amount;
            }
            else
            {
                Console.WriteLine("ERROR !!! Enter amount more than cash avaiable in Account");
            }
            return BankCashCounter.InitialAmount;
        }
        public string StringInput()
        {
            string str;
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();
            return str;
        }
        public void AddFront(char c)
        {
            try
            {
                if (this.deque.Front == null)
                {
                    ////if no element in list
                    this.deque.Front.data = c;
                    this.deque.Rear = this.deque.Front;
                }
                else
                {
                    ////if element in list
                    Deque<char> tNode = null;
                    tNode.data = c;
                    tNode.next = this.deque.Front;
                    this.deque.Front.pre = tNode;
                    this.deque.Front = tNode;
                }

                this.deque.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddRear(char c)
        {
            try
            {
                if (this.deque.Front == null)
                {
                    ////if no element in list
                    Deque<char> tNode = new Deque<char>(c);
                    this.deque.Front = tNode;
                    this.deque.Rear = this.deque.Front;
                }
                else
                {
                    ////if element in list
                    Deque<char> tNode = new Deque<char>(c);
                    this.deque.Rear.next = tNode;
                    tNode.pre = this.deque.Rear;
                    this.deque.Rear = tNode;
                }

                this.deque.size++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public char RemoveFront()
        {
            if (this.deque.Front == null)
            {
                Console.WriteLine("No elements to delete");
            }
            else
            {
                this.deque.val = this.deque.Front.data;
                this.deque.Front = this.deque.Front.next;
            }

            this.deque.size--;
            return this.deque.val;
        }


        public char RemoveRear()
        {
            if (this.deque.Front == null)
            {
                Console.WriteLine("No element to delete");
            }
            else
            {
                this.deque.val = this.deque.Rear.data;
                this.deque.Rear = this.deque.Rear.pre;
                this.deque.Rear.next = null;
            }

            this.deque.size--;
            return this.deque.val;
        }
        public int GetSize()
        {
            return this.deque.size;
        }
        /// <summary>
        /// Searches the in hash.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="myArray">My array.</param>
        public int SearchInHash(int number, int[,] myArray)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (number == myArray[i, j])
                    {
                        value = i;
                    }
                }
            }
            return value;
        }
        /// <summary>
        /// Prints the hash array.
        /// </summary>
        /// <param name="myArray">My array.</param>
        public void PrintHashArray(int[,] myArray)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Remainders of the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public int Remainder(int number)
        {
            while (number > 9)
            {
                RemainderValue = number % 10;
                number = number / 10;
            }
            return RemainderValue;
        }
        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Counts the binary tree.
        /// </summary>
        /// <param name="numberOfElements">The number of elements.</param>
        /// <returns> returns the Count of Binary trees</returns>
        public static int CountBinaryTree(int numberOfElements)
        {
        
       
                int numerator = 0;
                int denominator = 0;

                ////to count no of binary trees for given no of elements
                numerator = FindFactorial(2 * numberOfElements);
                denominator = FindFactorial(numberOfElements + 1) * FindFactorial(numberOfElements);

                return numerator / denominator;
           

         }
        public static int FindFactorial(int num)
        {
               int fact = num;
                while(num > 1)
                {
                    fact = fact * (num - 1);
                    num--;
                }

            return fact;   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns>true</returns>
        //// return true if the given year is a leap year
        ////// <summary>
        /// Prints the calenderof given month in given year
        /// </summary>
        public static bool CheckLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                return true;
            }
            if (year % 400 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Days the specified month.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static int day(int month, int day, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }
    }
}