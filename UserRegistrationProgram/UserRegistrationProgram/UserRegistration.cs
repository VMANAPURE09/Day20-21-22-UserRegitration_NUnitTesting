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
        //UC8: Check the Password that should have min 8 characters with atleast 1 UpperCase,1 NumericNumber & 1 SpecialCharcter
        public bool CheckUserPassword(string password)
        {

            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[@#$!%^&-+=()])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            Regex Passwordregex = new Regex(PasswordPattern);

            return Passwordregex.IsMatch(password);
        }
    }
}
