using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode69_Aqrt_x_
    {//Given a non-negative integer x, compute and return the square root of x.
     //Since the return type is an integer, the decimal digits are truncated,
     //and only the integer part of the result is returned.

     //Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.

            public int MySqrt(int x)
            {
            if (x == 0) return 0;
            if (x <= 3) return 1;
            long left = 1;
            long right = x;
            long medium = 0;
            long sqrt = 1;
            while (left<=right)
            {
                medium = (left + right) / 2;
                if (medium * medium <= x)
                {
                    sqrt = medium;
                    left = medium + 1;
                }
                else
                {
                    right = medium - 1;
                }
            }
            return (int)sqrt;
            }
        
    }
}
