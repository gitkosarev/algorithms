using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_algo.Leetcode
{
    internal static class _13_Roman_to_Integer
    {
        public static int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                int currentInt = dic[current];
                if ((i + 1) >= s.Length) result += currentInt;
                else
                {
                    char next = s[i + 1];
                    int nextInt = dic[next];
                    if (currentInt < nextInt) result -= currentInt;
                    else result += currentInt;
                }
            }
            return result;
        }
    }
}
