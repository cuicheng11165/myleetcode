using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P18FourSum
    {
        public IList<IList<int>> ThreeSum(int[] nums, int target)
        {
            IList<IList<int>> lists = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return lists;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                var currentSum = target - nums[i];//

                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] > currentSum)
                    {
                        right--;
                    }
                    else if (nums[left] + nums[right] < currentSum)
                    {
                        left++;
                    }
                    else
                    {
                        lists.Add(new List<int> { nums[i], nums[left], nums[right] });
                        right--;
                        left++;

                        while (nums[right] == nums[right + 1] && left < right)
                        {//当前元素和前一个相同就跳过，避免重复
                            right--;
                        }
                        while (nums[left] == nums[left - 1] && left < right)
                        {//当前元素和前一个相同就跳过，避免重复
                            left++;
                        }
                    }
                }
            }

            return lists;
        }

      
    }
}
