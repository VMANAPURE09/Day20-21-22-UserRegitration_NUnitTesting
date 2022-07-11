using System;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program - Regex N-Unit Testing");
            Console.WriteLine("\n");

            UserRegistration userregistration = new UserRegistration();
            bool checkFirstname = userregistration.CheckFirsttName("Vaibhav");
            Console.WriteLine(checkFirstname);

        }
    }
}
