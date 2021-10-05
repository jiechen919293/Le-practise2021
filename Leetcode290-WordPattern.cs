using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    // Given a pattern and a string s, find if s follows the same pattern.

    //Here follow means a full match, such that there is a bijection
    //between a letter in pattern and a non-empty word in s.

    //   Example 1:

    //Input: pattern = "abba", s = "dog cat cat dog"
    //Output: true
    //Example 2:

    //Input: pattern = "abba", s = "dog cat cat fish"
    //Output: false
    //Example 3:

    //Input: pattern = "aaaa", s = "dog cat cat dog"
    //Output: false
    //Example 4:

    //Input: pattern = "abba", s = "dog dog dog dog"
    //Output: false
    class Leetcode290_WordPattern
    {
        public void Main(string[] args)
        {
            string pattern = "abbc";
            string str = "dog cat cat fish";

            var res = WordPattern(pattern, str);
            Console.WriteLine(res);

        //
        }
        public bool WordPattern(string pattern, string s)
        {
            String[] test = s.Split(' ');
            if (pattern.Length != test.Length) return false;

            var dic = new Dictionary<int, string>();
            for (int i = 0; i < pattern.Length; i++)
            {

                if (!dic.ContainsKey(pattern[i]))
                {
                    if (dic.ContainsValue(test[i]))
                    {
                        return false;
                    }
                    dic[pattern[i]] = test[i];
                }
            }
            for (var i = 0; i < pattern.Length; i++)
            {
                //When different, the match fails
                if (dic[pattern[i]] != test[i]) return false;
            }
            return true;
        }
    }
}
