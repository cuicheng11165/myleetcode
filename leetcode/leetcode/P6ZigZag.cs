using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P6ZigZag
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            List<StringBuilder> innerArray = new List<StringBuilder>(numRows);
            for (int i = 0; i < numRows; i++)
            {
                innerArray.Add(new StringBuilder());
            }

            int currentRow = 0;
            int currentPos = 0;
            int stringPos = 0;
            while (stringPos < s.Length)
            {
                //Down
                while (stringPos < s.Length && currentRow < innerArray.Count)
                {
                    var currentChar = s[stringPos];
                    var builder = innerArray[currentRow];

                    for (int i = builder.Length; i < currentPos; i++)
                    {
                        builder.Append(' ');
                    }
                    builder.Append(currentChar);
                    stringPos++;
                    currentRow++;
                }

                currentRow--;

                //upright
                while (stringPos < s.Length && --currentRow >= 0)
                {
                    var currentChar = s[stringPos];
                    var builder = innerArray[currentRow];

                    for (int i = builder.Length; i < currentPos; i++)
                    {
                        builder.Append(' ');
                    }
                    builder.Append(currentChar);
                    stringPos++;
                }
                currentRow += 2;
                currentPos--;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var build in innerArray)
            {
                for (int i = 0; i < build.Length; i++)
                {
                    if (build[i] != ' ')
                    {
                        sb.Append(build[i]);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
