using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_algo.Leetcode
{
    internal class _35_Search_Insert_Position
    {
        internal static int SearchInsert(int[] nums, int target)
        {
            int result = 0;
            int length = nums.Length;
            if (target < nums[0]) return 0;
            if (target > nums[length - 1]) return length;

            int left = 0, right = length - 1;
            while (left < right)
            {
                int middle = (left + right) / 2;
                int current = nums[middle];
                if (current == target) return middle;
                else if (current > target) right = middle;
                else result = left = middle + 1;
            }

            return result;
        }
    }
}
