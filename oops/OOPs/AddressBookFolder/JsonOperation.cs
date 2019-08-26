using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPs.AddressBookFolder
{
    class JsonOperation
    {
        public static NewProfile ReadJsonFile()
        {
            string path = @"C:\Users\admin\source\repos\OOPs\OOPs\AddressBookFolder\Address.json";
            ////checks Wheather File Exist or Not.
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);

                ////Getting the NewAccount Object from the  JSon String.
                NewProfile profile = JsonConvert.DeserializeObject<NewProfile>(jsonData);

                return profile;
            }

            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new NewProfile();
            }
        }
        public static void WriteDataToFile(NewProfile newProfile)
        {
            //// Json file path
            string path = (@"C:\Users\admin\source\repos\OOPs\OOPs\AddressBookFolder\Address.json");
            ////Converting NewProfile Object to Json String
            string jsonAdddressBook = JsonConvert.SerializeObject(newProfile);
            ////Wrinting Json String to file.
            System.IO.File.WriteAllText(path, jsonAdddressBook);
        }
    }
}
