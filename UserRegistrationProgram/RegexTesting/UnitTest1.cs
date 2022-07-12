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
        public void CheckUserPassword()
        {
            string password = "VAibhavM";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckUserPassword(password);

            //Assert
            Assert.IsTrue(result);

        }
    }
}