using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P10RegexMatch
    {
        //public int i = 0;
        public bool IsMatch(string s, string p)
        {
            var result = new bool[s.Length + 1][];
            for (int j = 0; j < result.Length; j++)
            {
                result[j] = new bool[p.Length + 1];
            }

            return MatchInternal(s, p, result);
        }


        private bool MatchInternal(string sString, string pString, bool[][] tmpResult)
        {
            for (int s = 0; s < sString.Length; s++)
            {
                for (int p = 0; p < pString.Length; p++)
                {
                    if (s > 0 && !tmpResult[s - 1][p] && !(p > 1 && tmpResult[s - 1][p - 1]))
                    {
                        continue;
                    }
                    if (sString[s] == pString[p] || pString[p] == '.')
                    {
                        tmpResult[s][p] = true;
                        if (p + 1 < pString.Length && pString[p + 1] == '*')
                        {
                            tmpResult[s][++p] = true;
                            continue;
                        }
                    }
                    else
                    {
                        if (p + 1 < pString.Length && pString[p + 1] == '*')
                        {
                            tmpResult[s][++p] = true;
                            continue;
                        }
                    }

                }
            }
            return tmpResult[sString.Length - 1][pString.Length - 1];
        }


    }
}


