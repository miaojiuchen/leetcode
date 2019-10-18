using System;
namespace Leetcode
{
    public class _189_旋转数组
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        public void Reverse(int[] nums, int i, int j)
        {
            while (i < j)
            {
                var tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                i++;
                j--;
            }
        }
    }
}
