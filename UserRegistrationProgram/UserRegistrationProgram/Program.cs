using System;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program - Regex N-Unit Testing");
            Console.WriteLine("check User Passowrd\n");

            UserRegistration userregistration = new UserRegistration();
            bool checkpassword = userregistration.CheckUserPassword("VAibhav12");
            Console.WriteLine(checkpassword);



        }
    }
}
