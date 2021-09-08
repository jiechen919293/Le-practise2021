using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0 || s.Length % 2 == 1)
            {
                return false;
            }
            Stack<char> testStack = new Stack<char>();
            for (int i = 0; i <s.Length; i++)
            {
                if( s[i]=='('|| s[i] == '['|| s[i] == '{')
                {
                    testStack.Push(s[i]);
                }
                else
                {
                    if (testStack.Count == 0) return false;
                    if (s[i] == ')' && testStack.Pop() != '(') return false;
                    if (s[i] == '}' && testStack.Pop() != '{') return false;
                    if (s[i] == ']' && testStack.Pop() != '[') return false;

                }
            }
            return testStack.Count == 0 ? true : false;
        }
    }
}
