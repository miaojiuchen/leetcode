using System;
using System.Collections.Generic;

namespace Leetcode
{
    /// <summary>
    /// 滑动窗口法 或者 双指针
    /// </summary>
    public class _3_无重复字符的最长字串
    {
        public int LengthOfLongestSubstring(string s)
        {
            var left = 0;
            var max = 0;

            var dic = new Dictionary<char, int>();

            var pointer = 0;

            while (pointer < s.Length)
            {
                while (pointer < s.Length && !dic.ContainsKey(s[pointer]))
                {
                    dic.Add(s[pointer], pointer);
                    pointer++;
                }

                max = (pointer - left) > max ? pointer - left : max;

                if (pointer == s.Length)
                    return max;

                for (var i = left; i < dic[s[pointer]]; i++)
                {
                    dic.Remove(s[i]);
                }

                left = dic[s[pointer]] + 1;
                dic[s[pointer]] = pointer;
                pointer++;
            }

            return max;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            var result = 0;
            var left = 0;
            var right = 0;

            var set = new HashSet<char>();

            while (left < s.Length && right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    right++;
                    if (right - left > result)
                        result = right - left;
                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }
            }

            return result;
        }
    }
}
