using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _33_搜索旋转排序数组
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            if (nums[0] > target)
            {
                for (var i = nums.Length - 1; i >= 0; i--)
                {
                    if (nums[i] == target)
                    {
                        return i;
                    }
                    if (i != nums.Length - 1 && nums[i] > nums[i + 1])
                    {
                        return -1;
                    }
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                if (i != 0 && nums[i] < nums[i - 1])
                {
                    return -1;
                }

            }

            return -1;
        }
    }
}
