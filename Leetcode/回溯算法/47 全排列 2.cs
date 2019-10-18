using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class _47_全排列2
    {
        /// <summary>
        /// 有重复的全排列即普通的回溯全排列 + 剪枝
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> PermuteUnique(int[] nums)
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

            HashSet<int> unique = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (used[i])
                    continue;

                if (unique.Contains(nums[i]))
                {
                    continue;
                }

                unique.Add(nums[i]);

                used[i] = true;
                path.Push(nums[i]);

                res = res.Concat(walk(nums, used, path)).ToList();
                path.Pop();
                used[i] = false;
            }

            return res;
        }
    }
}
