using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
	class Leetcode54_SpiralMatrix
	{
		public List<int> spiralOrder(int[][] matrix)
		{
			List<int> ans = new List<int>();
			if (matrix == null || matrix.Length == 0
				|| matrix[0] == null || matrix[0].Length == 0)
			{
				return ans;
			}
			int a = 0;
			int b = 0;
			int c = matrix.Length - 1;
			int d = matrix[0].Length - 1;
			while (a <= c && b <= d)
			{
				AddEdge(matrix, a++, b++, c--, d--, ans);
			}
			return ans;
		}

		public static void AddEdge(int[][] m, int a, int b, int c, int d, List<int> ans)
		{
			if (a == c)
			{
				for (int i = b; i <= d; i++)
				{
					ans.Add(m[a][i]);
				}
			}
			else if (b == d)
			{
				for (int i = a; i <= c; i++)
				{
					ans.Add(m[i][b]);
				}
			}
			else
			{
				int curC = b;
				int curR = a;
				while (curC != d)
				{
					ans.Add(m[a][curC]);
					curC++;
				}
				while (curR != c)
				{
					ans.Add(m[curR][d]);
					curR++;
				}
				while (curC != b)
				{
					ans.Add(m[c][curC]);
					curC--;
				}
				while (curR != a)
				{
					ans.Add(m[curR][b]);
					curR--;
				}
			}
		}
	}
}
