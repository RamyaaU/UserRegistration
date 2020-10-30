using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationWithMSTest
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

        /// <summary>
        /// Emailids the validation.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public Boolean EmailidValidation(string email)
        {
            Regex regularExpression = new Regex("^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*[@][0-9A-Za-z]+[.][0-9A-Za-z]{2,3}$");
            if (regularExpression.IsMatch(email))
                return true;
            else
                return false;
        }
    }
}