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
        public bool CheckFirsttName(string FirstName)
        {

            string FirsttNamePattern = @"^[A-Z]{1}[a-z]{2,}$";

            Regex Firsttnameregex = new Regex(FirsttNamePattern);

            return Firsttnameregex.IsMatch(FirstName);
        }
    }
}
