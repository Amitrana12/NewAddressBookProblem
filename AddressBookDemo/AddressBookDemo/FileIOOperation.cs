using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookDemo
{
     class FileIOOperation
    {
        private string filePath = @"C:\Users\amit rana\Desktop\NewAddressBook\NewAddressBookProblem\AddressBookDemo\AddressBookData.txt";
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (AddressBook addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}