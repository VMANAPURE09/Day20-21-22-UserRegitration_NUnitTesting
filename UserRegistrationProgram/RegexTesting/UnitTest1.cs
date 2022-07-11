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
        public void CheckLastName()
        {
            string lastName = "Manapure";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckLastName(lastName);

            //Assert
            Assert.IsTrue(result);

        }
    }
}