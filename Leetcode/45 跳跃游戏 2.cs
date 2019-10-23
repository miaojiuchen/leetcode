using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class _45_跳跃游戏_2
    {
        public int Jump2(int[] nums)
        {
            return count(nums, nums.Length - 1);
        }

        public int count(int[] nums, int loc)
        {
            if (loc == 0)
            {
                return 0;
            }

            for (var i = 0; i < loc; i++)
            {
                if (i + nums[i] >= loc)
                {
                    loc = i;
                }
            }

            return 1 + count(nums, loc);
        }

        public int Jump(int[] nums)
        {
            var step = 1;
            var farest = nums[0];
            var start = 1;

            while (farest < nums.Length - 1)
            {
                var end = farest;
                for (var i = start; i <= end; ++i)
                {
                    if (i + nums[i] > farest)
                    {
                        farest = i + nums[i];
                    }
                }
                step++;
                start = end + 1;
            }

            return step;
        }
    }
}
