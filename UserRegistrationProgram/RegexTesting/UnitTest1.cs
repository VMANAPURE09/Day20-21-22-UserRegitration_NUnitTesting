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
        public void Test1()
        {
            string FirstName = "Vaibhav";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckFirsttName(FirstName);

            //Assert
            Assert.IsTrue(result);
        }
    }
}