using System;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program - Regex N-Unit Testing");
            Console.WriteLine("check LastName\n");

            UserRegistration userregistration = new UserRegistration();
            bool checklastname = userregistration.CheckLastName("Manapure");
            Console.WriteLine(checklastname);


        }
    }
}
