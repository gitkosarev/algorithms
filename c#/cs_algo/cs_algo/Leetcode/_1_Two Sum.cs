using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_algo.Leetcode
{
    internal static class _1_Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int arrayLength = nums.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                int num = nums[i];
                int dif = target - num;
                if (dict.ContainsKey(dif) && dict[dif] != i)
                {
                    result[0] = i;
                    result[1] = dict[dif];
                    break;
                }
                if (dict.ContainsKey(num))
                {
                    dict[num] = i;
                }
                else
                {
                    dict.Add(num, i);
                }
            }

            return result;
        }
    }
}
