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
            Regex rgxA = new Regex(@"^[a-zA-Z]+$");
            Regex rgxN = new Regex(@"^\d+$");

            if (mode == Mode.Numeric && long.Parse(str) <= int.MaxValue)
            {
                if (rgxN.IsMatch(str)) return str;
            }

            if (mode == Mode.Alpha)
            {
                if (rgxA.IsMatch(str) && str.Length < 256) return str;
            }

            throw new Exception("Wrong value or wrong mode");
        }
    }
}
