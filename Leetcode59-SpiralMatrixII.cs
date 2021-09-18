using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode59_SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            int top = 0;
            int left = 0;
            int right = n ;
            int bottom = n;
            int num = 1;
            while (left<=right && top<=bottom)
            {
                for (int i = left; i < right; i++)
                {
                    result[top][i] = ++num;
                }
                top++;
                for (int i = top; i < bottom; i++)
                {
                    result[i][right] = ++num;
                }
                right--;
                for (int i = right; i >= left; i--)
                {
                    result[bottom][i] = ++num;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    result[i][left] = ++num;
                }
                left++;
            }

            return result;
        }

    }
}
