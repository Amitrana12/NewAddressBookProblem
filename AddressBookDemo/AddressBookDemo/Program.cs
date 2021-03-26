using System;

namespace AddressBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Address Book Problem Solution By Amit Rana");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Amit", "Rana", "Uttarakhand", "Rishikesh", "UK", "amirana14325@gmail.com", 495698, 8979325434);
            addressBook.ViewContact();
        }
    }
}
