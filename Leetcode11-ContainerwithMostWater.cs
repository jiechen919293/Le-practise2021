using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode11_ContainerwithMostWater
    {
        //Given n non-negative integers a1, a2, ..., an ,
        //where each represents a point at coordinate(i, ai). n vertical lines are drawn such
        //that the two endpoints of the line i is at(i, ai) and(i, 0). Find two lines, which,
        // together with the x-axis forms a container, such that the container contains the most water.
        public int MaxArea(int[] height)
        {
            int result = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                result = Math.Max(result, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return result;
        }
    }
}
