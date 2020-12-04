using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public interface IAddressBookDetails
    {
        /// <summary>
        /// Add method.
        /// </summary>
        public void AddContact();

        /// <summary>
        /// Display method.
        /// </summary>
        public void DisplayContacts();

        /// <summary>
        /// Edit Contact method.
        /// </summary>
        public void EditContact(string firstName,string lastName);

        /// <summary>
        /// Delete Contact method.
        /// </summary>
        public void DeleteContact(string firstName, string lastName);
    }
}
