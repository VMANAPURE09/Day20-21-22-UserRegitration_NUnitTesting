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

    }
}
