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

        /// <summary>
        /// Search Person in City or State
        /// </summary>
        public void SearchPersonInCityOrState();

        /// <summary>
        /// View Person by City or State
        /// </summary>
        public void ViewPersonByCityOrState();

        /// <summary>
        /// Count Person by City or State
        /// </summary>
        public void CountOfPersonByCityOrState();

        /// <summary>
        /// Sort method.
        /// </summary>
        public void SortDetails();
    }
}
