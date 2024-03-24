using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    class Validation
    {
        //pattern to match First name where 1st letter is caps and next 2 to 9 letters are small
        private string PatName { get; set; } = @"^[A-Z][a-z]{2,9}$";

        public bool IsName(string firstName)
        {
            if (Regex.IsMatch(firstName,PatName)) return true;
            else return false;
        }
    }
}
