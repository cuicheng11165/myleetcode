using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P5LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int currentLongest = 0;
            int startLocation = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var result = findLongestPalindrome(s, i, i);
                if (result[1] > currentLongest)
                {
                    currentLongest = result[1];
                    startLocation = result[0];
                }
                if (i + 1 < s.Length)
                {
                    var newresult = findLongestPalindrome(s, i, i + 1);
                    if (newresult[1] > currentLongest)
                    {
                        currentLongest = newresult[1];
                        startLocation = newresult[0];
                    }
                }
            }

            return s.Substring(startLocation, currentLongest);
        }

        private int[] findLongestPalindrome(string s, int midleft, int midright)
        {
            if (midleft != midright && s[midleft] != s[midright])
            {
                return new[] { midleft, 1 };
            }

            while (s[midleft] == s[midright])
            {
                midleft--;
                midright++;

                if (midleft < 0 || midright > s.Length - 1)
                {
                    break;
                }
            }

            return new[] { midleft + 1, midright - midleft - 1 };
        }


        public void Run()
        {
            var test = "abcdedcb";
            var result = LongestPalindrome(test);
        }
    }
}
