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
        public bool CheckEmail(string email)
        {

            string EmailPattern = @"^[a-z][a-zA-Z0-9._-]{3,20}@[a-z]{3,10}.(com)$";

            Regex Emailregex = new Regex(EmailPattern);

            return Emailregex.IsMatch(email);
        }
    }
}
