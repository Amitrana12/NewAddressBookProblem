using System;

namespace AddressBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Address Book Problem Solution By Amit Rana");
           
            /*addressBook.AddContact("Amit", "Rana", "Uttarakhand", "Rishikesh", "UK", "amirana14325@gmail.com", 495698, 8979325434);
            addressBook.AddContact("Sumit", "Rana", "Uttarakhand", "Rishikesh", "UK", "amirana14325@gmail.com", 495698, 8979325434);*/
            Program.AddcontactConsole();


           
        }
        public static void  AddcontactConsole()
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Zip Code :");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number :");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);
            addressBook.ViewContact();
        }
    }
}
