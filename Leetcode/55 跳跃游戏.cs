using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class _55_跳跃游戏
    {
        public bool CanJump(int[] nums)
        {
            var loc = nums.Length - 1;

            for (var i = loc - 1; i >= 0; --i)
            {
                if (i + nums[i] >= loc)
                {
                    loc = i;
                }
            }

            return loc == 0;
        }
    }
}
