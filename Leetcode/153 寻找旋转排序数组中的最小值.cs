using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _153_寻找旋转排序数组中的最小值
    {
        public int FindMin(int[] nums)
        {
            var start = 0;
            var end = nums.Length - 1;

            while (start < end)
            {
                var mid = (end + start) >> 1;

                if (nums[mid] > nums[end]) // 目标在右边
                {
                    start = mid + 1;
                }
                else // 目标在左边或者mid位置
                {
                    end = mid;
                }
            }

            return nums[start];
        }
    }
}
