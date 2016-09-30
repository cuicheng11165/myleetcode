using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class P20ValidParentheses
    {

        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();

            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    {
                        st.Push(s[i]);
                    }
                    else
                    {
                        if (s[i] == ')')
                        {
                            var pop = st.Pop();
                            if (pop != '(')
                            {
                                return false;
                            }
                        }
                        else if (s[i] == ']')
                        {
                            var pop = st.Pop();
                            if (pop != '[')
                            {
                                return false;
                            }
                        }
                        else if (s[i] == '}')
                        {
                            var pop = st.Pop();
                            if (pop != '{')
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return st.Count == 0;
        }
    }
}
