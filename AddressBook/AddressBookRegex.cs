using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public class AddressBookRegex
    {
        /// <summary>
        /// Regex pattern for First Name
        /// </summary>
        public static string namePattern = "^[A-Z][a-z]{2,}$";

        /// <summary>
        /// Regex pattern for Zip code
        /// </summary>
        public const string zipcode = "^[0-9]{6}$";

        /// <summary>
        /// Regex pattern for Email ID
        /// </summary>
        public static string mailIDPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";

        /// <summary>
        /// Regex pattern for Mobile Number
        /// </summary>
        public static string mobileNumberPattern = "^[1-9]{2}[ ][0-9]{10}";

        /// <summary>
        /// Validate First Name with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, namePattern) ? "Valid First Name" :
           throw new CustomException(CustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid First Name");

        /// <summary>
        /// Validate Last Name with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid Last Name" :
           throw new CustomException(CustomException.ExceptionType.INVALID_LAST_NAME, "Invalid Last Name");

        /// <summary>
        /// Validate Last Name with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateZipCode = x => Regex.IsMatch(x, namePattern) ? "Valid Zip Code" :
           throw new CustomException(CustomException.ExceptionType.INVALID_ZIP_CODE, "Invalid Zip Code");

        /// <summary>
        /// Validate Email ID with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid Email ID" :
           throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid Email ID");

        /// <summary>
        /// Validate Mobile Number with Lambda Expression
        /// </summary>
        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid Mobile Number" :
           throw new CustomException(CustomException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile Number");
    }
}
