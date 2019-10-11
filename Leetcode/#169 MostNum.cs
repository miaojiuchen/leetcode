using System;
namespace Leetcode
{
    public class MostNum
    {
        public int MajorityElement(int[] nums)
        {
            return majorityElement(nums, 0, nums.Length - 1);
        }

        private int majorityElement(int[] nums, int left, int right)
        {
            if (left == right)
                return nums[left];

            var mid = (right - left) / 2 + left;

            var leftME = majorityElement(nums, left, mid);
            var rightME = majorityElement(nums, mid + 1, right);

            if (leftME == rightME)
                return leftME;

            var leftCount = countNumInRange(nums, leftME, left, right);
            var rightCount = countNumInRange(nums, rightME, left, right);

            return leftCount > rightCount ? leftME : rightME;
        }

        private int countNumInRange(int[] nums, int n, int left, int right)
        {
            var count = 0;
            while (left <= right)
            {
                if (nums[left++] == n)
                    count++;
            }
            return count;
        }
    }
}
