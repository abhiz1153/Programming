using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AddressBookFolder
{
    class Choice
    {
        public void Options()
        {
            try
            {
                char choice;
                int ch;
                do
                {
                    Console.WriteLine("*****WELCOME TO ADDRESS BOOK*****");
                    Console.WriteLine(" ");
                    Console.WriteLine(" WHAT YOU WANT TO PERFORM ");
                    Console.WriteLine("1. ADD NEW CONTACT ");
                    Console.WriteLine("2. EDIT CONTACT");
                    Console.WriteLine("3. DELETE CONTACT");
                    Console.WriteLine("4. DISPLAY ALL SAVED CONTACT ");
                    Console.WriteLine("5. EXIT ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter your Choice");
                    Console.WriteLine(" ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            AddressBookFolder.AddressBook create = new AddressBookFolder.AddressBook();
                            create.CreateProfile();
                            break;
                        case 4:
                            AddressBookFolder.AddressBook display = new AddressBookFolder.AddressBook();
                            display.DisplayProfile();
                            break;
                        
                        case 5:
                            return;
                    }
                    Console.WriteLine("Do you want to Continue then Press Y");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                while (choice == 'y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
