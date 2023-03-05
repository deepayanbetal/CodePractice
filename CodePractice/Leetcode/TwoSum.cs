using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Leetcode
{
    
    internal class TwoSum
    {
        // Given an array of integers nums and an integers target, return indices of the two numbers 
        //such that they add up to target.
        //you may assume that each input would have exactly one solution, and you may not use the same
        //element twice.
        public int[] TwoSummethod(int[] nums, int target)
        {

            int arrayLength = nums.Length;
            if (nums == null || nums.Length < 2)
                return Array.Empty<int>();

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }


        public int palindromNumber(int num)
        {
            
            int r = 0;int sum = 0, temp;
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
                return sum;
            else
                return -1;
            
        }

    }
}
