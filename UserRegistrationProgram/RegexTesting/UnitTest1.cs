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
        public void ChecKEmailSample()
        {
            string EmailSample = "abc.100@abc.com.au";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckEmailSample(EmailSample);


            //Assert
            Assert.IsTrue(result);

        }
    }
}