using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class ExceptionProblem
    {
        //For First NAme
        public void validateFirstName(string firstName)
        {
            string stringForFirstName = "^[A-Z][a-z]{3,}?";
            try
            {

                if (Regex.IsMatch(firstName, stringForFirstName))
                    Console.WriteLine(firstName + " is Valid");

                else
                    Console.WriteLine(firstName + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //For last NAme
        public void validateLastName(string lastName)
        {
            try
            {

                string stringForLastName = "^[A-Z][a-z]{3,}?";
                if (Regex.IsMatch(lastName, stringForLastName))
                    Console.WriteLine(lastName + " is Valid Lastname");
                else
                    Console.WriteLine(lastName + " is Invalid Lastname");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //For email
        public void validateEmailId(string emailID)

        {
            try
            {
                string stringForEmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
                if (Regex.IsMatch(emailID, stringForEmailId))
                    Console.WriteLine(emailID + " is Valid EmailId");
                else
                    Console.WriteLine(emailID + " is Invalid EmailId");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
