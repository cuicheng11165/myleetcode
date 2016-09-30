using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P18FourSum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);

            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        if (nums[i] + nums[j] + nums[left] + nums[right] < target)
                        {
                            left++;
                            while (nums[left] == nums[left - 1] && left < right)
                            {
                                left++;
                            }
                        }
                        else if (nums[i] + nums[j] + nums[left] + nums[right] > target)
                        {
                            right--;
                            while (nums[right] == nums[right + 1] && left < right)
                            {
                                right--;
                            }
                        }
                        else
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;
                            while (nums[left] == nums[left - 1] && left < right)
                            {
                                left++;
                            }
                            while (nums[right] == nums[right + 1] && left < right)
                            {
                                right--;
                            }
                        }
                    }
                }
            }
            return result;
        }

    }
}
