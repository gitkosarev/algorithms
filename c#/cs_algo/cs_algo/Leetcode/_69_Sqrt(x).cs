using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_algo.Leetcode
{
    internal class _69_Sqrt_x_
    {
        internal static int MySqrt(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            long input = x;
            long result = 0;
            long left = 0, right = input;
            while (left < right)
            {
                long mid = (left + right) / 2;
                long current = mid * mid;
                if (current == input) return (int)mid;
                else if (current > input) right = mid;
                else
                {
                    result = mid;
                    left = (int)mid + 1;
                }
            }
            return (int)result;
        }
    }
}
