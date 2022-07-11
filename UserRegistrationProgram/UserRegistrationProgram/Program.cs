using System;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program - Regex N-Unit Testing");
            Console.WriteLine("check MobileNo\n");

            UserRegistration userregistration = new UserRegistration();
            bool checkmobnum = userregistration.CheckMobileNumber("91 9933222454");
            Console.WriteLine(checkmobnum);


        }
    }
}
