using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode986_IntervealListIntersections
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            int[][] result = new int[][] { };
            int i = 0;
            int j = 0;
            while(i<firstList.Length&& j < secondList.Length)
            {
                int left = Math.Max(firstList[i][0], secondList[j][0]);
                int right = Math.Min(firstList[i][1], secondList[j][1]);
                if (left <= right) { result.Append(new int[] { left, right }); };
                if (firstList[i][1] < secondList[j][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return result;
        }
    }
}
