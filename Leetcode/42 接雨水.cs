
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _42_接雨水
    {
        public int Trap(int[] height)
        {
            if (height.Length < 2)
            {
                return 0;
            }

            var left_max = new int[height.Length];
            left_max[1] = height[0];
            for (var i = 2; i < height.Length; i++)
            {
                left_max[i] = Math.Max(left_max[i - 1], height[i - 1]);
            }

            var right_max = new int[height.Length];
            right_max[height.Length - 2] = height[height.Length - 1];
            for (var i = height.Length - 3; i >= 0; --i)
            {
                right_max[i] = Math.Max(right_max[i + 1], height[i + 1]);
            }

            var sum = 0;
            for (var i = 1; i <= height.Length - 2; i++)
            {
                var count = Math.Min(left_max[i], right_max[i]) - height[i];
                if (count > 0)
                {
                    sum += count;
                }
            }

            return sum;
        }

        public int Trap2(int[] height)
        {
            if (height.Length < 2)
            {
                return 0;
            }

            var changes = new int[height.Length - 1];
            for (var i = 0; i <= height.Length - 2; ++i)
            {
                changes[i] = height[i + 1] - height[i];
            }

            List<int> containerBottoms = new List<int>();
            for (var i = 0; i < changes.Length;)
            {
                if (changes[i] < 0)
                {
                    var end = i;
                    while (end < changes.Length && changes[end] <= 0)
                    {
                        end++;
                    }
                    containerBottoms.Add(end);
                    i = end + 1;
                }
                else
                {
                    i++;
                }
            }

            var sum = 0;
            for (var i = 0; i < containerBottoms.Count; i++)
            {
                var bottom = containerBottoms[i];

                var left = bottom - 1;
                while (left >= 0 && changes[left] <= 0)
                {
                    left--;
                }
                left++;
                var leftHeight = height[left];

                var right = bottom + 1;
                while (right <= changes.Length - 1 && changes[right] >= 0)
                {
                    right++;
                }
                if (right > height.Length - 1)
                {
                    continue;
                }
                var rightHeight = height[right];

                var h = Math.Min(leftHeight, rightHeight);
                sum += h * (right - left + 1);
                for (var j = left; j <= right; j++)
                {
                    sum -= height[j] > h ? h : height[j];
                }
            }

            return sum;
        }

    }
}