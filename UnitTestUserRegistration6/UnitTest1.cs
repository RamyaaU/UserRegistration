using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestUserRegistration6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
