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
        public void CheckMobileNumber()
        {
            string mobnumber = "91 9764510067";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckMobileNumber(mobnumber);

            //Assert
            Assert.IsTrue(result);

        }
    }
}