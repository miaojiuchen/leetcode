using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Leetcode
{
    public class _179_最大数
    {
        public class MyComparable : IComparer<string>
        {
            public int Compare(string s1, string s2)
            {
                return string.Compare(s1 + s2, s2 + s1);
            }
        }


        public string LargestNumber(int[] nums)
        {
            var snums = nums.Select(x => x.ToString());

            var order = snums.OrderByDescending(x => x, new MyComparable()).ToArray();

            var ans = string.Concat(order);
            if (ans.All(x => x == '0'))
            {
                ans = "0";
            }
            return ans;
        }
    }
}
