using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P8StringToInt
    {
        public int MyAtoi(string str)
        {
            bool minus = false;
            bool minusInited = false;
            bool takingNumber = false;
            bool takingPlus = false;
            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!takingPlus && !takingNumber && str[i] == ' ')
                {
                    continue;
                }
                else if (!takingPlus && !takingNumber && !minusInited && str[i] == '+')
                {
                    minus = false;
                    minusInited = true;
                }
                else if (!takingPlus && !takingNumber && !minusInited && str[i] == '-')
                {
                    minus = true;
                    minusInited = true;
                }
                else if (str[i] <= '9' && str[i] >= '0')
                {
                    takingNumber = true;
                    int currentPo = minus ? '0' - str[i] : str[i] - '0';
                    if (minus && int.MinValue - currentPo > result * 10)
                    {
                        return int.MinValue;
                    }
                    if ((!minus && int.MaxValue - currentPo < result * 10))
                    {
                        return int.MaxValue;
                    }
                    result = result * 10 + currentPo;
                }
                else if (takingNumber)
                {
                    break;
                }
                else
                {
                    return 0;
                }
            }
            return result;
        }


    }
}
