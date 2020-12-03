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
        public const string zipcodePattern = "^[0-9]{6}$";

        /// <summary>
        /// Regex pattern for Email ID
        /// </summary>
        public static string mailIDPattern = "^[0-9a-zA-Z]+([+_.-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{2,3}){1,2}$";

        /// <summary>
        /// Regex pattern for Mobile Number
        /// </summary>
        public static string mobileNumberPattern = "^[0-9]{10}";

        /// <summary>
        /// Validate  First Name
        /// </summary>
        /// <param name="firstName"></param>
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, namePattern))
            {
                return;
            }
            else
            {
                Console.WriteLine("FirstName should have minimum 3 characters starting with Captital letter");
                throw new CustomException(CustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid First Name");
            }
        }

        /// <summary>
        /// Validate Last Name
        /// </summary>
        /// <param name="lastName"></param>
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, namePattern))
            {
                return;
            }
            else
            {
                Console.WriteLine("LastName should have minimum 3 characters starting with Captital letter");
                throw new CustomException(CustomException.ExceptionType.INVALID_LAST_NAME, "Invalid Last Name");
            }
        }

        /// <summary>
        /// Validate Zip Code
        /// </summary>
        /// <param name="zipCode"></param>
        public void ValidateZipCode(string zipCode)
        {
            if (Regex.IsMatch(zipCode, zipcodePattern))
            {
                return;
            }
            else
            {
                Console.WriteLine("ZipCode must have 6 digits");
                throw new CustomException(CustomException.ExceptionType.INVALID_ZIP_CODE, "Invalid Zip Code");
            }
        }

        /// <summary>
        /// Validate Email ID
        /// </summary>
        /// <param name="emailID"></param>
        public void ValidateEmail(string emailID)
        {
            if (Regex.IsMatch(emailID, mailIDPattern))
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid Email ID");
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid Email ID");
            }
        }

        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <param name="mobileNumber"></param>
        public void ValidateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, mobileNumberPattern))
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
                throw new CustomException(CustomException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile Number");
            }
        }
    }
}
