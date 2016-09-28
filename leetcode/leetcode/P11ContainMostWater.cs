using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P11ContainMostWater
    {
        public int MaxArea(int[] height)
        {
            int max = 0;
            int maxLeftPos = 0;
            int maxRightPos = height.Length - 1;

            while (maxLeftPos < maxRightPos)
            {
                var cur = Math.Min(height[maxLeftPos], height[maxRightPos]) * (maxRightPos - maxLeftPos);

                if (cur > max)
                {
                    max = cur;
                }

                if (height[maxLeftPos] < height[maxRightPos])
                {
                    maxLeftPos++;
                }
                else
                {
                    maxRightPos--;
                }
            }
            return max;
        }
    }
}
