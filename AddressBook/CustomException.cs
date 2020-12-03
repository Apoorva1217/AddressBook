using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class CustomException : Exception 
    {
        /// <summary>
        /// Enum for exception type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_FIRST_NAME, INVALID_LAST_NAME, INVALID_ZIP_CODE, INVALID_EMAIL, INVALID_PASSWORD, INVALID_MOBILE_NUMBER
        }

        /// <summary>
        /// Creating 'type' variable of type ExceptionType
        /// </summary>
        ExceptionType type;
        readonly string message;

        /// <summary>
        /// Parameterized constructor sets the exception type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}
