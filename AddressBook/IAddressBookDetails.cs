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
    }
}
