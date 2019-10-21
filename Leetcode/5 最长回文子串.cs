
using System;
using System.Linq;
// using

namespace Leetcode
{
    public class _5_最长回文子串
    {
        public string LongestPalindrome(string s1)
        {
            var size = s1.Length;
            var s2 = new string(s1.Reverse().ToArray());
            var max = 0;

            var rightIndex = 0;

            var dp = new int[size + 1, size + 1];
            for (var i = 1; i <= size; i++)
            {
                for (var j = 1; j <= size; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;

                        if (dp[i, j] > max && isMirror((j - 1) - dp[i, j] + 1, i - 1, size))
                        {
                            max = dp[i, j];
                            rightIndex = i - 1;
                        }
                    }
                }
            }

            return s1.Substring(rightIndex - max + 1, max);
        }

        private bool isMirror(int i1, int i2, int size)
        {
            return i1 + i2 == size - 1;
        }
    }
}
