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
        //UC9:Check the Email That should Clear All Email Sample
        public bool CheckEmailSample(string password)
        {

            string EmailPattern = @"^([a-z]{3}([\.\+\-0-9]*)@[a-z0-9]{1,}.[a-z]{3,}[.a-z]*)";

            Regex Emailregex = new Regex(EmailPattern);

            return Emailregex.IsMatch(password);
        }
    }
}
