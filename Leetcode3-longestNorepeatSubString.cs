using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode3_longestNorepeatSubString
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            if (s.Length == 0) return result;
            int[] temp = new int[256];
            int left = 0;
            int right = -1;
            while (left<s.Length)
            {
                if (right + 1 < s.Length && temp[s[right + 1] - 'a'] == 0)
                {
                    temp[s[right + 1] - 'a']++;
                    right++;
                }
                else
                {
                    temp[s[left] - 'a']--;
                        left++;
                }
                result = Math.Max(result, right - left - 1);
            }
            return result;

        }
    }
}
