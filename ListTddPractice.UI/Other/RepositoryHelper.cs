using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListTddPractice.UI.Other
{
    class RepositoryHelper
    {
        public static string Validate(string str, Mode mode)
        {
            if (mode == Mode.Numeric)
            {
                if (Regex.IsMatch(str, @"/^\d+$/") )
                {
                    int c = int.Parse(str);
                    if (c >= 0 && c <= 10000)
                    {
                        return str;
                    }
                }
            }

            if (mode == Mode.Alpha)
            {
                if (Regex.IsMatch(str, @"^[A-Za-z]+") && (str.Length < 10))
                {
                    return str;
                }
            }

            if (mode == Mode.Mixed)
            {
                if (str.Length > 10)
                {
                    return str;
                }
            }

            throw new Exception("Wrong value or wrong mode");
        }
    }
}
