using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    //Given an array of non-negative integers nums, you are initially positioned at the first index of the array.

    //Each element in the array represents your maximum jump length at that position.

    //Your goal is to reach the last index in the minimum number of jumps.

    //You can assume that you can always reach the last index.
    class Leetcode45_jumpGame2
    {

        public int Jump(int[] nums)
        {

            if (nums == null || nums.Length == 0) return 0;

            int result = 0;
            int current = 0;
            int next = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                if (current < i)
                {
                    result++;
                    current = next;
                }
                next = Math.Max(next, i + nums[i]);
            }
            return result;

        }

        static void Main(string[] args)
        {
            // output of the text to the user
            Console.WriteLine("I am start in C#.");
            //wait for enter
            // Console.ReadLine();
            string text = "we had a very special class there.";
            bool mytest = text.Contains("very");
            Console.WriteLine(mytest);
            //true;
        }




    }
}
