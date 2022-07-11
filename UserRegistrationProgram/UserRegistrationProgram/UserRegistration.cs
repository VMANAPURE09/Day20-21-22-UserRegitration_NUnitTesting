using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class UserRegistration
    {
        public bool CheckLastName(string lastName)
        {

            string LastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            Regex lastnameregex = new Regex(LastNamePattern);

            return lastnameregex.IsMatch(lastName);
        }
    }
}
