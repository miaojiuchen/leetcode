
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
                    containerBottoms.Add(end + 1);
                    i = end + 1;
                }
                else
                {
                    i++;
                }
            }

            return 0;
        }

    }
}