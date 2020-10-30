using System;

namespace UserRegistrationWithMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference
            Validation val = new Validation();
            Console.WriteLine("Welcome to User registration");
            Console.WriteLine("Enter the first name of the user");
            String firstName = Console.ReadLine();
            //if firstname doesn't match with val then it 
            //returns the prompt
            while (!val.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid First Name with first letter as Capital");
                firstName = Console.ReadLine();
            }


        }
    }
}