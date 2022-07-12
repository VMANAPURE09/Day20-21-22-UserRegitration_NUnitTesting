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
        //UC6: method that check password should have minimum 8 characters and atleast 1 UpperCase
        public bool CheckUserPassword(string password)
        {

            string PasswordPattern = @"^(?=.*[A-Z])[a-zA-Z]{8,}$";

            Regex Passwordregex = new Regex(PasswordPattern);

            return Passwordregex.IsMatch(password);
        }
    }
}
