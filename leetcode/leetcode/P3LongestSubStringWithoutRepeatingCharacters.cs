using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P3LongestSubStringWithoutRepeatingCharacters
    {

        public void Run()
        {
            string input = "dig";
            var result = LengthOfLongestSubstring(input);

        }

        public int LengthOfLongestSubstring(string s)
        {
            int[] hashhelper = new int[300];

            for (int i = 0; i < 300; i++)
            {
                hashhelper[i] = -1;
            }

            List<char> bucket = new List<char>();

            int max = 0;
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int hashIndex = s[i] - 30;
                if (hashhelper[hashIndex] >= 0)
                {
                    var currentMax = i - start;
                    if (currentMax > max)
                    {
                        max = currentMax;
                    }

                    int clearIndex = start;
                    start = hashhelper[hashIndex] + 1;

                    for (int j = clearIndex; j < hashhelper[hashIndex]; j++)
                    {
                        hashhelper[s[j] - 30] = -1;
                    }
                }

                hashhelper[hashIndex] = i;
            }
            if (s.Length - start > max)
            {
                max = s.Length - start;
            }
            return max;
        }




    }
}
