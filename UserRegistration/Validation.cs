﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        /// <summary>
        /// Firsts the name validation.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public Boolean FirstNameValidation(string firstName)
        {
            Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
            if (regularExpression.IsMatch(firstName))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Lasts the name validation.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public Boolean LastNameValidation(string lastName)
        {

            Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
            if (regularExpression.IsMatch(lastName))
                return true;
            else
                return false;
        }
        public Boolean EmailidValidation(string email)
        {
            Regex regularExpression = new Regex("^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*[@][0-9A-Za-z]+[.][0-9A-Za-z]{2,3}$");
            if (regularExpression.IsMatch(email))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Mobiles the number validation.
        /// </summary>
        /// <param name="mobileNo">The mobile no.</param>
        /// <returns></returns>
        public Boolean MobileNumberValidation(string mobileNo)
        {
            Regex regularExpression = new Regex("^[0-9]{2,3}\\s[1-9]{10}$");
            if (regularExpression.IsMatch(mobileNo))
                return true;
            else
                return false;
        }
        public Boolean PasswordValidationRule1(string password1)
        {
            Regex regularExpression = new Regex(@"(^[A-Za-z0-9]{8,}$)");    //UC6 Password Rule 1
            if (regularExpression.IsMatch(password1))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Passwords the validation rule2.
        /// </summary>
        /// <param name="password2">The password2.</param>
        /// <returns></returns>
        public Boolean PasswordValidationRule2(string password2)
        {
            Regex regularExpression = new Regex(@"(^(?=.*[A-Z])[A-Za-z0-9@#-+]{8,}$)"); //UC6 Password Rule 2
            if (regularExpression.IsMatch(password2))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Passwords the validation rule3.
        /// </summary>
        /// <param name="password3">The password3.</param>
        /// <returns></returns>
        public Boolean PasswordValidationRule3(string password3)
        {
            Regex regularExpression = new Regex(@"(^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9@#-+]{8,}$)"); //UC7 Password Rule 3
            if (regularExpression.IsMatch(password3))
                return true;
            else
                return false;
        }
    }
}
   