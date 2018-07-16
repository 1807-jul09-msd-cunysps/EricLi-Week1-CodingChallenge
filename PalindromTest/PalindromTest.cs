using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromTest
{
    public static class Palindrom
    {
        public static bool Test(string palindrome)
        {
            if (palindrome.Length <= 1)
            {
                return true;
            }
            else if (palindrome[0].Equals(palindrome[palindrome.Length - 1]))
            {
                return Test(palindrome.Substring(1, palindrome.Length - 2));
            }
            else
                return false;
        }
    }
}
