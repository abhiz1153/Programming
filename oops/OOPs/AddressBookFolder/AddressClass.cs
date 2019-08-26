using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.AddressBookFolder
{
    public class AddressClass
    {
        private string name;
        private string city;
        private double number;
        private object email;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public double Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public object Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public AddressClass(string name,  string city, double number,object email)
        {
            this.name = name;
            this.city = city;
            this.number = number;
            this.email = email;
        }
        public static void CreateNewProfile(string name,  string city, double number, object email)
        {
            AddressClass address = new AddressClass(name,  city, number, email);
            NewProfile newProfile = JsonOperation.ReadJsonFile();
            newProfile.ProfileList.Add(address);           
            JsonOperation.WriteDataToFile(newProfile);
            Console.WriteLine("New Profile had been Created Succefully");
        }
        public static void DeleteProfile(string name)
        {
            NewProfile newProfile = JsonOperation.ReadJsonFile();
            List<AddressClass> address = newProfile.ProfileList;

            foreach(AddressClass profile in address)
            {
                if(profile.Name.Equals(name))
                {
                    address.Remove(profile);
                    JsonOperation.WriteDataToFile(newProfile);
                    Console.WriteLine(" Profile " + name + " is Deleted Successfully ");
                    Console.WriteLine("--------------------------------------------");
                    return;
                }
            }
            Console.WriteLine(" Profile " + name + " is not found");
           
        }
    }
}
