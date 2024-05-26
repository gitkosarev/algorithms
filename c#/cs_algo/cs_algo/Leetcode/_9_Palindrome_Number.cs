using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_algo.Leetcode
{
    internal static class _9_Palindrome_Number
    {
        public static bool IsPalindrome(int x)
        {
            bool result = false;
            if (x < 0) { return false; }
            else if (x == 0) { return true; }
            else
            {
                string text = x.ToString();
                string mirror = String.Empty;
                foreach (char ch in text)
                {
                    mirror = ch + mirror;
                }
                result = long.Parse(mirror) == (long)x;
            }

            return result;
        }
    }
}
