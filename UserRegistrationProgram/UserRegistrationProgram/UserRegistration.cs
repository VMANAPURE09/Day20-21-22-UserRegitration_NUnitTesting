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
        public bool CheckMobileNumber(string mobilenumber)
        {

            string MobileNumberPattern = @"^[1-9]{2,}[' '][7-9]{1}[0-9]{9}$";

            Regex MobileNumberregex = new Regex(MobileNumberPattern);

            return MobileNumberregex.IsMatch(mobilenumber);
        }
    }
}
