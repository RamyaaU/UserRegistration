using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestUserRegistration2
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
    }
}
