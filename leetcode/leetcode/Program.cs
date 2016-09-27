using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = new P6ZigZag();
            var result = run.Convert("ABCDE", 3);

            Debug.Assert(result == "ACB");

        }
    }
}
