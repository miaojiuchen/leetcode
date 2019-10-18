using System;
namespace Leetcode
{
    public class _674_最长连续递增序列
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            return div(nums, 0, nums.Length - 1);
        }

        private int div(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return 1;
            }

            var mid = (left + right) / 2;
            var leftMax = div(nums, left, mid);
            var rightMax = div(nums, mid + 1, right);
            var lrMax = Math.Max(leftMax, rightMax);

            var p1 = mid;
            var p2 = mid + 1;
            var v1 = nums[p1];
            var v2 = nums[p2];
            if (v1 >= v2)
            {
                return Math.Max(leftMax, rightMax);
            }

            var crossMax = 2;
            p1--;
            p2++;

            while (left <= p1 && nums[p1] < v1)
            {
                v1 = nums[p1];
                p1--;
                crossMax++;
            }

            while (p2 <= right && nums[p2] > v2)
            {
                v2 = nums[p2];
                p2++;
                crossMax++;
            }

            return Math.Max(lrMax, crossMax);
        }
    }
}
