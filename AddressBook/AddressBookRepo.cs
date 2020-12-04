using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        /// Created a Dictionary.
        /// </summary>
        Dictionary<string, AddressBookRepo> dictionary = new Dictionary<string, AddressBookRepo>();

        /// <summary>
        /// Assign person equals null. 
        /// </summary>
        private AddressBookModel addressBook = null;

        AddressBookRegex bookRegex = new AddressBookRegex();

        // <summary>
        /// Refactor to add multiple Address Book to the System. Each Address Book has a unique Name
        /// </summary>
        public void CreateMultipleAddressBook()
        {
            while (true)
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Use Existing Address Book");
                Console.WriteLine("3.Exit");

                String choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Enter the Name of Address Book");
                        string name = Console.ReadLine();
                        if (dictionary.ContainsKey(name))
                        {
                            Console.WriteLine("Already exists...");
                        }
                        else
                        {
                            AddressBookRepo addressBook = new AddressBookRepo();
                            dictionary.Add(name, addressBook);
                            Console.WriteLine("Address Book is Created...");
                            addressBook.AddressBookMenu();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Address book name: ");
                        string addressBookName = Console.ReadLine();
                        if (dictionary.ContainsKey(addressBookName))
                        {
                            dictionary[addressBookName].AddressBookMenu();
                        }
                        else
                        {
                            Console.WriteLine("Address book does not exists");
                        }
                        break;
                    case 3:
                        return;
                }
            }
        }

        /// <summary>
        /// AddressBook Menu.
        /// </summary>
        public void AddressBookMenu()
        {
            IAddressBookDetails addressBookDetails = new AddressBookRepo();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("\n---Welcome to Address Book Program!---");
                Console.WriteLine("***Enter Your Choice***");
                Console.WriteLine("1.Add Details");
                Console.WriteLine("2.Display Details");
                Console.WriteLine("3.Edit Details");
                Console.WriteLine("4.Delete Details");
                Console.WriteLine("5.Search Person in City or State");
                Console.WriteLine("6.View Person by City or State");
                Console.WriteLine("7.Count Person by City or State");
                Console.WriteLine("8.Exit");

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
                        Console.WriteLine("Enter First Name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string lastName = Console.ReadLine();
                        addressBookDetails.EditContact(firstName, lastName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name:");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string lastname = Console.ReadLine();
                        addressBookDetails.DeleteContact(firstname, lastname);
                        break;
                    case 5:
                        addressBookDetails.SearchPersonInCityOrState();
                        break;
                    case 6:
                        addressBookDetails.ViewPersonByCityOrState();
                        break;
                    case 7:
                        addressBookDetails.CountOfPersonByCityOrState();
                        break;
                    case 8:
                        return;
                }
            }
        }

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

            /// Ability to ensure there is no Duplicate Entry of the same Person in a particular Address Book
            foreach (AddressBookModel addressBook in list.FindAll(name => name.FirstName.Equals(firstName) && name.LastName.Equals(lastName)))
            {
                    Console.WriteLine("You entered the Duplicate Name...");
                    return;
            }
        
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            string zipCode = Console.ReadLine();
            bookRegex.ValidateZipCode(zipCode);

            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            bookRegex.ValidateMobileNumber(mobileNumber);

            Console.WriteLine("Enter Email ID:");
            string emailID = Console.ReadLine();
            bookRegex.ValidateEmail(emailID);

            Console.WriteLine("Your details are Added Successfully...");

            this.addressBook = new AddressBookModel(firstName, lastName, address, city, state, zipCode, mobileNumber, emailID);
            this.list.Add(this.addressBook);
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
            if (list.Count == 0)
            {
                Console.WriteLine("No Records in Address Book");
            }
        }

        /// <summary>
        /// Ability to edit existing contact person using their name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void EditContact(string firstName,string lastName)
        {
            int check = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName) && this.list[i].LastName.Equals(lastName))
                {
                    while (check == 0)
                    {
                        AddressBookModel addressBook = this.list[i];
                        Console.WriteLine(addressBook);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.Zip Code 5.Phone Number 6.Email ID 7.Exit");
                        string choice = Console.ReadLine();
                        int ch = Convert.ToInt32(choice);
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("enter new address");
                                string address = Console.ReadLine();
                                addressBook.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("enter new city");
                                string city = Console.ReadLine();
                                addressBook.City = city;
                                break;
                            case 3:
                                Console.WriteLine("enter new state");
                                string state = Console.ReadLine();
                                addressBook.State = state;
                                break;

                            case 4:
                                Console.WriteLine("enter new zipCode");
                                string zipCode = Console.ReadLine();
                                addressBook.ZipCode = zipCode;
                                break;

                            case 5:
                                Console.WriteLine("enter new phoneNumber");
                                string mobileNumber = Console.ReadLine();
                                addressBook.MobileNumber = mobileNumber;
                                break;

                            case 6:
                                Console.WriteLine("enter new Email ID");
                                string emailID = Console.ReadLine();
                                addressBook.EmailID = emailID;
                                break;

                            case 7:
                                check = 1;
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ability to delete a person using person's name 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void DeleteContact(string firstname,string lastname)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstname) && this.list[i].LastName.Equals(lastname))
                {
                    this.list[i] = null;
                }
            }
            Console.WriteLine("Your expected entry is deleted from records!");
        }

        /// <summary>
        /// Ability to Search person in City or State
        /// </summary>
        public void SearchPersonInCityOrState()
        {
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your First Name:");
                    String NameToSearchInCity = Console.ReadLine();
                    foreach (AddressBookModel addressBook in list.FindAll(e => e.FirstName == NameToSearchInCity))
                    {
                        Console.WriteLine("City of " + NameToSearchInCity + " is : " + addressBook.City);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your First Name:");
                    String nameToSearchInState = Console.ReadLine();
                    foreach (AddressBookModel addressBook in list.FindAll(e => e.FirstName == nameToSearchInState))
                    {
                        Console.WriteLine("State of " + nameToSearchInState + " is : " + addressBook.State);
                    }
                    break;
            }
        }

        /// <summary>
        /// View person by City or State
        /// </summary>
        public void ViewPersonByCityOrState()
        {
            Console.WriteLine("Enter your choice for viewing:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your city");
                    String city = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].City.Equals(city))
                            Console.WriteLine(list[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your state");
                    String state = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].State.Equals(state))
                            Console.WriteLine(list[i]);
                    }
                    break;
            }
        }

        /// <summary>
        /// Ability to Count person in a City or State
        /// </summary>
        public void CountOfPersonByCityOrState()
        {
            int count = 0;
            Console.WriteLine("Enter your Choice for Count Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (AddressBookModel addressBook in list.FindAll(c => c.City == city))
                    {
                        count = list.Count();
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (AddressBookModel addressBook in list.FindAll(c => c.State == state))
                    {
                        count = list.Count();
                    }
                    Console.WriteLine(count);
                    break;
            }
        }
    }
}
