using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBookRepo : IAddressBookDetails
    {
        /// <summary>
        /// Created a list.
        /// </summary>
        private readonly List<AddressBookModel> list = new List<AddressBookModel>();

        /// <summary>
        /// Assign person equals null. 
        /// </summary>
        private AddressBookModel person = null;

        AddressBookRegex bookRegex = new AddressBookRegex();

        /// <summary>
        /// Ability to Add new Contact in Address Book
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            bookRegex.ValidateFirstName(firstName);
            
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            bookRegex.ValidateLastName(lastName);
            
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            string zipCode = Console.ReadLine();
            bookRegex.ValidateZipCode(zipCode);

            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            bookRegex.ValidateEmail(emailID);
            
            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            bookRegex.ValidateMobileNumber(mobileNumber);

            Console.WriteLine("Your details are Added Successfully...");

            this.person = new AddressBookModel(firstName, lastName, address, city, state, zipCode, mobileNumber, emailID);
            this.list.Add(this.person);
        }

        /// <summary>
        /// Display method.
        /// </summary>
        public void DisplayContacts()
        {
            foreach (AddressBookModel entry in this.list)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
