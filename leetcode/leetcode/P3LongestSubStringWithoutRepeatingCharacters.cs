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
            string input = "cddcfc";
            var result = LengthOfLongestSubstring(input);
        }

        public int LengthOfLongestSubstring(string s)
        {

            Dictionary<char, int> hashhelper = new Dictionary<char, int>();
            int max = 0;
            int currentMax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (hashhelper.ContainsKey(s[i]))
                {
                    var index = hashhelper[s[i]];
                    if (currentMax > max)
                    {
                        max = currentMax;
                        currentMax = 0;
                    }
                    i = hashhelper[s[i]];
                    hashhelper.Clear();
                    continue;
                }
                else
                {
                    hashhelper.Add(s[i], i);
                }
                currentMax++;

            }
            if (currentMax > max)
            {
                max = currentMax;
            }
            return max;
        }




    }
}
