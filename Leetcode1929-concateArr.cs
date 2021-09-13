using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
 //Given an integer array nums of length n,
 //you want to create an array ans of length 2n where ans[i] == nums[i]
 //and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

//Specifically, ans is the concatenation of two nums arrays.
//Return the array ans.
    class Leetcode1929_concateArr
    {
        public int[] GetConcatenation(int[] nums)
        {
            //use tool cannot pass the test
            //     int[] ans = nums;
            //      ans.Append(..nums);
            int[] ans = new int[nums.Length * 2];
            for (int i = 0; i < nums.length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }
            return ans;
        }
    }
}
