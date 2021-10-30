using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class LeetCode1044_LongestDupSubstring
    {
        public string LongestDupSubstring(string s)
        {
            int len = s.Length;
            String result = "";
            int maxLen = 0;
            if (len <= 1)  return "";

            String[] strs = new String[len];  // 存放S的后缀字符串
            for (int i = 0; i < len; i++)
            {
                strs[i] = s.Substring(i, len);
            }
            Array.Sort(strs);  // 进行排序
            for (int i = 0; i < len - 1; i++)
            {  // 两个相邻字符串的最长公共前缀
                int tmp = lenTwoStr(strs[i], strs[i + 1]);
                if (tmp > maxLen)
                {
                    maxLen = tmp;
                    result = strs[i].Substring(0, maxLen);
                }
            }
            return result;
        }
        // 两个后缀子串的前缀最长公共子串
        public int lenTwoStr(String str1, String str2)
        {
            if (str1.Length == 0 || str2.Length == 0)
                return 0;
            int i = 0;
            while (i < str1.Length && i < str2.Length && str1[i] == str2[i])
                i++;
            return i;

        }
    }
}
