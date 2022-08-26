using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReflectionAssignment
{
    internal class Patterns
    {
        //UC1
        public static string RegexFirstName = "^[A-Z]{1,}[a-z]{2,}$";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexFirstName);
        }

        //UC2
        public static string RegexLastName = "^[A-Z]{1,}[a-z]{3,}$";
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, RegexLastName);

        }

        //UC3
        public static string RegexEmail = "^[0-9a-zA-Z]+([+#%&_.][a-zA-Z0-9]+)*[@]{1}[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, RegexEmail);                  //checking   abc.xyz @bl.co.in
        }

        //UC4
        public static string RegexMobileNumber = "^[1-9]{2}[6-9]{1}[0-9]{9}$";
        public bool validateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, RegexMobileNumber);
        }

        //UC5
        public static string RegexPassword = "^[a-zA-Z]{8,}$";
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, RegexPassword);
        }

        //UC6
        public static string RegexPassword6 = "^[A-Z]{1,}[a-z]{7,}$";
        public bool validatePassword6(string Password6)
        {
            return Regex.IsMatch(Password6, RegexPassword6);
        }

        //UC7
        public static string RegexPassword7 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}$";
        public bool validatePassword7(string Password7)
        {
            return Regex.IsMatch(Password7, RegexPassword7);
        }

        //UC8
        public static string RegexPassword8 = "^[A-Z]{1,}[a-z]{5,}[0-9]{1,}[@#&*]{1}$";
        public bool validatePassword8(string Password8)
        {
            return Regex.IsMatch(Password8, RegexPassword8);
        }

        //UC9
        public static string RegexEmail9 = "^[0-9a-zA-Z]+([+#%&_.-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{3}([.][a-zA-Z]{2,3})?$";
        public bool validateEmail9(string Email9)
        {
            return Regex.IsMatch(Email9, RegexEmail9);
        }

    }
}
