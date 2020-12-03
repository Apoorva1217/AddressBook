using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBookModel
    {
        /// <summary>
        /// Ability to Create Contacts in Address Book
        /// </summary>
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long phoneNumber;
        private string emailID;

        public AddressBookModel(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string emailID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.emailID = emailID;
        }

        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Adderss { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public int ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public long PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }
        public string EmailID { get => this.emailID; set => this.emailID = value; }

        public override string ToString()
        {
            return "\n  FirstName    : " + this.firstName
                 + "\n  LastName     : " + this.lastName
                 + "\n  Address      : " + this.address
                 + "\n  City         : " + this.city
                 + "\n  State        : " + this.state
                 + "\n  ZipCode      : " + this.zipCode
                 + "\n  PhoneNumber  : " + this.phoneNumber
                 + "\n  EmailID      : " + this.emailID + "\n" +
                   "/*************************/";
        }
    }
}
