using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Company_Management_System
{
    public sealed class Miscellaneous
    {
        private Miscellaneous()
        {

        }

        public static void Shutdown()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Environment.Exit(1);
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public sealed class Validation
        {
            public static bool MatchString(string input)
            {
                return Regex.IsMatch(input, @"^[A-Za-z ]+$");
            }

            public static bool MatchStringWithDot(string input)
            {
                return Regex.IsMatch(input, @"^[A-Za-z .]+$");
            }

            public static bool MatchStringNumbers(string input)
            {
                return Regex.IsMatch(input, @"^[a-zA-Z0-9 ]+$");
            }

            public static bool MatchStringNumberUnderscore(string input)
            {
                return Regex.IsMatch(input, @"A[a-zA-Z0-9_]+$");
            }
        }
    }
}