using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode58_lengthofLastWord
    {
        //            var list = s.Trim().Split(' ');
         //   return list.Last().Length;
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int result = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                if(s[i]==' ')
                {
                 return result;
                }
                else
                {
                    result++;
                }
               
            }
            return result;
        }
    
    }
 
}
