using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestUserRegistration7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "Ramya";
            //Act
            bool var = pattern.FirstNameValidation(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        public void TestLastName()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "Uday";
            //Act
            bool var = pattern.LastNameValidation(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        public void TestEmailId()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "abc.xyz@yahoo.com";
            //Act
            bool var = pattern.EmailidValidation(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        public void TestMobileNumber()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "91 9988776655";
            //Act
            bool var = pattern.MobileNumberValidation(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        //Password Rule 1 -Minimum 8 Character
        public void TestPasswordRule1()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "asdfghjkl";
            //Act
            bool var = pattern.PasswordValidationRule1(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        //Password Rule 2 -Atleast One Upper Character
        public void TestPasswordRule2()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "Asdfghjkl";
            //Act
            bool var = pattern.PasswordValidationRule2(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        //Password Rule 3 -Atleast One Number
        public void TestPasswordRule3()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "A22sdfghjkl";
            //Act
            bool var = pattern.PasswordValidationRule3(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        //Password Rule 4 -Atleast One Special Character
        public void TestPasswordRule4()
        {
            //Arrange
            Validation pattern = new Validation();
            bool expected = true;
            string input = "A22@#sdfghjkl";
            //Act
            bool var = pattern.PasswordValidationRule4(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
        [TestMethod]
        [DataRow("ramya@gmail.com", true)]
        [DataRow("ramya-1947@gmail.com", true)]
        [DataRow("ramya@.com.in", false)]
        [DataRow("ramya@yahoo.com",true)]
        [DataRow("ramya-100@yahoo.com",true)]
        [DataRow("ramya.100@yahoo.com",true)]
        [DataRow("ramya111@abc.com",true)]
        [DataRow("ramya-100@abc.net",true)]
        [DataRow("ramya.100@abc.com.au", true)]
        [DataRow("ramya@1.com", true)]
        [DataRow("ramya+100@gmail.com", true)]
        [DataRow("ramya.//@abc.in", false)]
        [DataRow("ramya.//!@abc.in", false)]
        [DataRow("ramya.@abc.in.net.au", false)]
        //All Email Samples
        public void TestEmails(string input, bool expected)
        {
            //Arrange
            Validation pattern = new Validation();

            //Act
            bool var = pattern.ValidateEmailSet(input);
            //Assert
            Assert.AreEqual(expected, var);
        }
    }
}