using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    //    Given an integer n, return an array ans of length n + 1 such that for each i(0 <= i <= n),
    //    ans[i] is the number of 1's in the binary representation of i.

    //Example 1:
    //Input: n = 2
    //Output: [0,1,1]
    //    Explanation:
    //0 --> 0
    //1 --> 1
    //2 --> 10

    //Example 2:
    //Input: n = 5
    //Output: [0,1,1,2,1,2]
    //    Explanation:
    //0 --> 0
    //1 --> 1
    //2 --> 10
    //3 --> 11
    //4 --> 100
    //5 --> 101
    class Leetcode338_CountingBits
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
           
            for (int i = 0; i <= n; i++)
            {
                result[i]= result[i >> 1] + (i & 1);
            }
            return result;
        }
    }
}
