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
        private AddressBookModel addressBook = null;

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
    }
}
