using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P4MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int total = nums1.Length + nums2.Length;

            int medianIndex = total / 2;

            if (total % 2 == 0)
            {
                --medianIndex;
            }


            int currentIndex1 = 0;
            int currentIndex2 = 0;

            int cur = 0;

            double result = 0;

            while (cur <= medianIndex)
            {
                if (nums1.Length == currentIndex1)
                {
                    int pos = medianIndex - cur;

                    currentIndex2 += pos;
                    cur += pos;
                    result = nums2[currentIndex2];
                    ++currentIndex2;
                    break;
                }

                if (nums2.Length == currentIndex2)
                {
                    int pos = medianIndex - cur;

                    currentIndex1 += pos;
                    cur += pos;
                    result = nums1[currentIndex1];
                    ++currentIndex1;
                    break;
                }

                if (nums1[currentIndex1] < nums2[currentIndex2])
                {
                    if (cur == medianIndex)
                    {
                        result = nums1[currentIndex1];
                        currentIndex1++;
                        break;
                    }

                    currentIndex1++;
                    cur++;
                    continue;
                }


                if (cur == medianIndex)
                {
                    result = nums2[currentIndex2];
                    currentIndex2++;
                    break;
                }

                currentIndex2++;
                cur++;
            }

            if (total % 2 == 0)
            {
                if (currentIndex1 >= nums1.Length || (currentIndex2 < nums2.Length && nums1[currentIndex1] >= nums2[currentIndex2]))
                {
                    result = ((double)(result + nums2[currentIndex2])) / 2;
                }
                else if (currentIndex2 >= nums2.Length || (currentIndex1 < nums1.Length && nums1[currentIndex1] <= nums2[currentIndex2]))
                {
                    result = ((double)(result + nums1[currentIndex1])) / 2;
                }
            }

            return result;
        }

        internal void Run()
        {
            var n1 = new int[0];
            var n2 = new[] { 2, 3 };


            var result = FindMedianSortedArrays(n1, n2);


        }
    }
}
