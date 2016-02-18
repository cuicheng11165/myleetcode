using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P1TwoSum
    {
        //https://leetcode.com/problems/two-sum/

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashhelper = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashhelper.ContainsKey(nums[i]))
                {
                    return new[] { hashhelper[nums[i]] + 1, i + 1 };
                }
                else
                {
                    hashhelper[target - nums[i]] = i;
                }
            }
            throw new Exception();
        }
    }
}
