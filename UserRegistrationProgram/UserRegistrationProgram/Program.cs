using System;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program - Regex N-Unit Testing");
            Console.WriteLine("check EmailId\n");

            UserRegistration userregistration = new UserRegistration();
            bool checkemailid = userregistration.CheckEmail("manapure.vaibhav542@gmai;");
            Console.WriteLine(checkemailid);


        }
    }
}
