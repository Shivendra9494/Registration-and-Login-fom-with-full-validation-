using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mobiloitte2.Behaviours
{
    public static class RegexPage
    {
        public static Regex PasswordRegex()
        {
            return new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=])(?=\\S+$).{8,}$");
        }
        public static Regex FirstNameRegex()
        {
            return new Regex("^([A-Z][a-z]{1,10})$");
        }
        public static Regex EmailRegex()
        {
            return new Regex(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z-]+)*@"
                + "[A-Za-z-]+(\\.[A-Za-z]+)*(\\.[A-Za-z]{2,})$");
        }
        public static Regex PhoneRegex()
        {
            return new Regex(@"^[0-9]{10}$");
        }
        public static Regex OTP()
        {
            return new Regex(@"1234");
        }

    }
}
