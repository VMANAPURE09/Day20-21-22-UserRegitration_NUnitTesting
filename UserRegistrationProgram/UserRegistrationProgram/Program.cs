using System;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program - Regex N-Unit Testing");
            Console.WriteLine("Check Email Sample\n");

            UserRegistration userregistration = new UserRegistration();
            bool Checkemailsample = userregistration.CheckEmailSample("abc.100@abc.com.au");
            Console.WriteLine(Checkemailsample);



        }
    }
}
