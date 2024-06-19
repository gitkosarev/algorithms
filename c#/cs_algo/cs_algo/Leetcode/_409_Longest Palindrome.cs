using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_algo.Leetcode
{
    internal static class _409_Longest_Palindrome
    {
        internal static int LongestPalindrome(string s)
        {
            int result = 0;
            int length = s.Length;
            bool isMiddleExist = length % 2 != 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < length; i++)
            {
                char c = s[i];
                if (dict.ContainsKey(c)) dict[c]++;
                else dict.Add(c, 1);
            }
            foreach (int value in dict.Values)
            {
                int remainder = value % 2;
                if (remainder > 0) isMiddleExist = true;
                int count = value - remainder;
                if (count / 2 > 0) result += count;
            }
            if (isMiddleExist) result++;
            if (result == 0) result = 1;
            return result;
        }
    }
}
