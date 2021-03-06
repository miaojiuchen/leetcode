﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class _46_全排列
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            return walk(nums, new bool[nums.Length], new Stack<int>());
        }

        private IList<IList<int>> walk(int[] nums, bool[] used, Stack<int> path)
        {
            var res = new List<IList<int>>();

            if (path.Count == nums.Length)
            {
                res.Add(path.ToList());
                return res;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if(used[i])
                    continue;

                used[i] = true;
                path.Push(nums[i]);
                res = res.Concat(walk(nums, used, path)).ToList();
                used[i] = false;
                path.Pop();
            }

            return res;
        }
    }
}
