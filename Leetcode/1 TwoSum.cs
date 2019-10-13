using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class __1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var other = target - nums[i];
                if(dic.ContainsKey(other))
                {
                    return new int[]{ i, dic[other] };
                }
                dic[nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
