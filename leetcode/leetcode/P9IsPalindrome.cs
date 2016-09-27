using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P9IsPalindrome
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            var xString = x.ToString();

            for (int i = 0; i < xString.Length - 1 - i; i++)
            {
                if (xString[i] != xString[xString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
