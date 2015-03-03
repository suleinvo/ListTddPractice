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
                int val = 0;
                if (int.TryParse(str, out val))
                {
                    if (val >= 0 && val <= 10000)
                    {
                        return str;
                    }
                }
            }

            if (mode == Mode.Alpha)
            {
                var onlyLetter = new string(str.Where(Char.IsLetter).ToArray());
                if (str == onlyLetter)
                {
                    return str;
                }
            }

            throw new Exception("Wrong value or wrong mode");
        }
    }
}
