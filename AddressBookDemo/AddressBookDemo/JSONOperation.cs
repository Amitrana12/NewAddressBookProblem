using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookDemo
{
     class JSONOperation
    {
        string filePath = @"C:\Users\amit rana\Desktop\NewAddressBook\NewAddressBookProblem\AddressBookDemo\AddressBookData.Json";
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            string json = "";
            foreach (AddressBook obj in addressBookDictionary.Values)
            {
                foreach (Contact contact in obj.addressBook.Values)
                {
                    json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of JSON File");
            var json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            Console.WriteLine(contact.ToString());
        }
    }
}