using System;
using System.Linq;

namespace Leetcode
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var maxsum = nums[0];
            var sum = nums[0];

            foreach(var n in nums.Skip(1))
            {
                sum += n;
                if(sum < n)
                    sum = n;

                if (maxsum < sum)
                    maxsum = sum;
            }

            return maxsum;
        }
    }
}
