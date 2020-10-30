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
            //pattern for name
            Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
            //if regex matches with firstname
            //then returns true else false
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
            //pattern for name
            Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
            //if regex matches with lastname
            //then returns true else false
            if (regularExpression.IsMatch(lastName))
                return true;
            else
                return false;
        }
    }
}
