using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class _3_无重复字符的最长字串
    {
        public int LengthOfLongestSubstring(string s)
        {
            var result = 0;
            var left = 0;
            var right = 0;

            var set = new HashSet<char>();

            while (left < s.Length && right < s.Length)
            {
                if(!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    right++;
                    if (right - left > result)
                        result = right - left;   
                }else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }

            return result;
        }
    }
}
