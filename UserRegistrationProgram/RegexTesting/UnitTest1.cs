using NUnit.Framework;
using UserRegistrationProgram;

namespace RegexTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckEmail()
        {
            string email = "manapure.vaibhav542@gmail.com";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckEmail(email);

            //Assert
            Assert.IsTrue(result);

        }
    }
}