using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P16ThreeSumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int currentResult = 0;
            int minAbsValue = int.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right - 1)
                {
                    if ((nums[i] + nums[left] + nums[right]) < target)
                    {
                        CompareAndReset(ref currentResult, ref minAbsValue, target, nums[i] + nums[left] + nums[right]);
                        left++;
                    }
                    else if ((nums[i] + nums[left] + nums[right]) > target)
                    {
                        CompareAndReset(ref currentResult, ref minAbsValue, target, nums[i] + nums[left] + nums[right]);
                        right--;
                    }
                    else
                    {
                        break;
                    }
                }

                CompareAndReset(ref currentResult, ref minAbsValue, target, nums[i] + nums[left] + nums[right]);
            }

            return currentResult;
        }

        private void CompareAndReset(ref int currentResult, ref int minAbsValue, int target, int tmpTarget)
        {
            var currentAbs = Math.Abs(target - tmpTarget);
            if (currentAbs < minAbsValue)
            {
                minAbsValue = currentAbs;
                currentResult = tmpTarget;
            }
        }
    }
}
