using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode70_LOOPsolution_1_
    {
		public int ClimbStairs(int n)
		{

			if (n == 1 || n == 2)
			{
				return n;
			}

			int[][] arr = {new int[]{1,1 },new int[]{ 2,2}};

			int[][] res = matrixPower(arr, n - 2);
			return 2 * res[0][0] + res[1][0];

		}


		public static int[][] matrixPower(int[][] m, int p)
		{
			int[][] res = { new int[m.Length],new int[m[0].Length] };
			for (int i = 0; i < res.Length; i++)
			{
				res[i][i] = 1;
			}

			// res = 矩阵中的1
			int[][] tmp = m;// 矩阵1次方
			for (; p != 0; p >>= 1)
			{
				if ((p & 1) != 0)
				{
					res = muliMatrix(res, tmp);
				}
				tmp = muliMatrix(tmp, tmp);
			}
			return res;
		}

		// 两个矩阵乘完之后的结果返回
		public static int[][] muliMatrix(int[][] m1, int[][] m2)
		{
			int[][] res = { new int[m1.Length],new int[m2[0].Length]} ;
			for (int i = 0; i < m1.Length; i++)
			{
				for (int j = 0; j < m2[0].Length; j++)
				{
					for (int k = 0; k < m2.Length; k++)
					{
						res[i][j] += m1[i][k] * m2[k][j];
					}
				}
			}
			return res;
		}
	}
}
