using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P17LetterCombination
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return result;
            }
            String[] mapping = new String[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            List<int> bigNumber = new List<int>();
            for (int i = 0; i < digits.Length; i++)
            {
                bigNumber.Add(0);
            }


            while (true)
            {
                StringBuilder sb = new StringBuilder(digits.Length);
                for (int j = 0; j < bigNumber.Count; j++)
                {
                    sb.Append(mapping[digits[j] - '0'][bigNumber[j]]);
                }
                result.Add(sb.ToString());

                bigNumber[0]++;
                for (int i = 0; i < bigNumber.Count; i++)
                {
                    if (bigNumber[i] > mapping[digits[i] - '0'].Length - 1)
                    {
                        if (i == bigNumber.Count - 1)
                        {
                            return result;
                        }
                        bigNumber[i] = 0;
                        bigNumber[i + 1]++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }



    }
}
