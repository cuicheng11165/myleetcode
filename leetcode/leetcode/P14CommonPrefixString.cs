using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P14CommonPrefixString
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < strs[0].Length; j++)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (j >= strs[i].Length || strs[i][j] != strs[0][j])
                    {
                        return sb.ToString();
                    }
                }
                sb.Append(strs[0][j]);
            }
            return sb.ToString();
        }
    }
}
