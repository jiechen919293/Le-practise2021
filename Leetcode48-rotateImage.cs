using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    //You are given an n x n 2D matrix representing an image,
    //rotate the image by 90 degrees(clockwise).
    //You have to rotate the image in-place,
    //which means you have to modify the input 2D matrix directly.DO NOT allocate another 2D matrix and do the rotation.
    class Leetcode48_rotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int topR = 0;
            int topC = 0;
            int bottomR = matrix.Length - 1;
            int bottomC = matrix[0].Length - 1;
            while (topR < bottomC)
            {
                RotateEdge(matrix, topR++, topC++, bottomR--, bottomC--);
            }
       void RotateEdge(int[][] m, int tR, int tC, int bR, int bC)
        {
            int times = bC - tC;
            int temp ;
            for (int i = 0; i != times; i++)
            {
                temp = m[tR][tC + i];
                m[tR][tC + i] = m[bR - i][tC];
                m[bR - i][tC] = m[bR][bC - i];
                m[bR][bC - i] = m[tR + i][bC];
                m[tR + i][bC] = temp;
            } 
            }
        
        }
    }
}
