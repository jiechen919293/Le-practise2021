using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode26_removeElem
    {
        public int RemoveElement(int[] nums)
        {
			if (nums == null)
			{
				return 0;
			}
			if (nums.Length < 2)
			{
				return nums.Length;
			}
			int done = 0;
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] != nums[done])
				{
					nums[++done] = nums[i];
				}
			}
			return done + 1;
		}
	}
    
}
