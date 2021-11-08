using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    //Given an integer n, return the number of structurally unique BST's
    // (binary search trees) which has exactly n nodes of unique values from 1 to n.
    class Leetcode96_UniqueBInarySearchTree
    {
        public int NumTrees(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int[] nums = new int[n + 1];
            nums[0] = 1; nums[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    nums[i] = nums[i] + nums[j] * nums[i - 1 - j];
                }
            }
            return nums[n];
 
        }
    }
}
