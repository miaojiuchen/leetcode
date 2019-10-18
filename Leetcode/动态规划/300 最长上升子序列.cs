using System;
using System.Linq;
using System.Collections.Generic;

namespace Leetcode
{
    public class _300_最长上升子序列
    {
        /// <summary>
        /// dp[i] = max of {
        ///     for j ∈ [0, j)
        ///         nums[i] > nums[j] ? (dp[j] + 1) : 1
        /// }
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var dp = new int[nums.Length + 1];
            dp[1] = 1;
            var ans = 1;
            for (var i = 2; i <= nums.Length; i++)
            {
                var max = 1;
                for (var j = 1; j < i; j++)
                {
                    if (nums[j - 1] < nums[i - 1])
                    {
                        if (dp[j] + 1 > max)
                        {
                            max = dp[j] + 1;
                        }
                    }
                }
                dp[i] = max;
                if (max > ans)
                {
                    ans = max;
                }
            }

            return ans;
        }
    }
}
