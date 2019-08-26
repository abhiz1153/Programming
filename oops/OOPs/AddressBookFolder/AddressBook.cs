using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AddressBookFolder
{
    class AddressBook
    {
        /// <summary>
        /// Creates the profile.
        /// </summary>
        public void CreateProfile()
        {
            
            string name = null;
            string city = null;
            double number = 0;
            string email = null;

           
            while (true)
            {
                Console.WriteLine("Enter Profile Name to create new Profile");
                name = Console.ReadLine();

                if (Utility.ContainsCharacter(name))
                {
                    Console.WriteLine("No Character Allowed");
                    continue;
                }

                if (Utility.ContainsDigit(name))
                {
                    Console.WriteLine("No Digits Allowed");
                    continue;
                }

                if (Utility.CheckString(name))
                {
                    Console.WriteLine("You should Specify a name");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Enter City Name of " +name);
                city = Console.ReadLine();

                if (Utility.ContainsCharacter(city))
                {
                    Console.WriteLine("No Character Allowed");
                    continue;
                }

                if (Utility.ContainsDigit(city))
                {
                    Console.WriteLine("No Digits Allowed");
                    continue;
                }

                if (Utility.CheckString(city))
                {
                    Console.WriteLine("You should Specify a name");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter the Number of " + name);
                string num = Console.ReadLine();             
                number = Convert.ToDouble(num);
                break;
            }
            while (true)
            {
                Console.WriteLine("Enter Email ID of " + name);
                email = Console.ReadLine();

                break;
            }


        }
        public void DisplayProfile()
        {
            NewProfile newProfile = JsonOperation.ReadJsonFile();
            List<AddressClass> profilelist = newProfile.ProfileList;
           
            Console.WriteLine(" ");
            Console.WriteLine("_______________________________________________________________________________________________________________________________________________________________________________________________ ");
            Console.WriteLine("Name\tCity\tNumber\tEmail-ID");
            Console.WriteLine("_______________________________________________________________________________________________________________________________________________________________________________________________ ");
            foreach (var address in profilelist)
            {
                Console.WriteLine(address.Name + "\t" + address.City + "\t" + address.Number + "\t" + address.Email);
                Console.WriteLine("_______________________________________________________________________________________________________________________________________________________________________________________________ ");

            }

        }

    }
}
