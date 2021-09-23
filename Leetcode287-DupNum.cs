using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    //  Given an array of integers nums containing n + 1 integers where each integer is in the range[1, n] inclusive.

    //There is only one repeated number in nums, return this repeated number.

    //You must solve the problem without modifying the array nums and uses only constant extra space.



    class Leetcode287
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 4, 2, 2 };
             Leetcode287 test = new Leetcode287();
            int b = test.FindDuplicate(nums);
        
            Console.WriteLine(b);
            Console.ReadKey();

        }
        public int FindDuplicate(int[] nums)
        {
            int fast = 0;
            int slow = 0;
            if (nums.Length <= 2) return nums[0];
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            slow = 0;

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }
        public int FindDuplicate2(int[] nums)
        {
            
            int result = nums[0];
            if (nums.Length <= 2) return nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (Array.IndexOf(nums, nums[i]) != Array.LastIndexOf(nums, nums[i]))
                {
                    return nums[i];
                }
            }

            return result;


        }
    }
}
