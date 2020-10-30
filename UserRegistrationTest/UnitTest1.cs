using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationWithMSTest;

namespace UnitTestUserRegistration
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
    }
}

           
