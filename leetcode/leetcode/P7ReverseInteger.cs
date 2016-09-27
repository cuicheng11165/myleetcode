using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P7ReverseInteger
    {
        public int Reverse(int x)
        {
            var tmpResult = x;
            var currentNumber = x % 10;
            var result = 0;

            while (tmpResult != 0)
            {
                if (result > 0 && (result > (int.MaxValue - currentNumber) / 10) || (result < 0 && result < (int.MinValue - currentNumber) / 10))
                {
                    return 0;
                }
                result = result * 10 + currentNumber;
                tmpResult = tmpResult / 10;
                currentNumber = tmpResult % 10;
            }

            return result;
        }


        public int Reverse1(int x)
        {
            try
            {
           
                var xString = Math.Abs(x).ToString().ToCharArray();

                for (int i = 0; i < xString.Length - 1 - i; i++)
                {
                    char tmp;
                    tmp = xString[i];
                    xString[i] = xString[xString.Length - 1 - i];
                    xString[xString.Length - 1 - i] = tmp;
                }
                int value = 0;

                value = int.Parse(new string(xString));

                return x > 0 ? value : 0 - value;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
