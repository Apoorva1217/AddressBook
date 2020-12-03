using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!");
            IAddressBookDetails addressBookDetails = new AddressBookRepo();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("---Welcome to Address Book Program!---");
                Console.WriteLine("***Enter Your Choice***");
                Console.WriteLine("1.Add Details");
                Console.WriteLine("2.Display Details");
                Console.WriteLine("3.Exit");

                string choice = Console.ReadLine();
                int ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:
                        addressBookDetails.AddContact();
                        break;
                    case 2:
                        addressBookDetails.DisplayContacts();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
