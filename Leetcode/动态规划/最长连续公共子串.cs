using System;
using System.Linq;

namespace Leetcode
{
    public class _最长连续公共子串
    {
        public int LongestCommonSubsequence(string s1, string s2)
        {
            var ans = 0;
            var dp = new int[s1.Length + 1, s2.Length + 1];
            for (var i = 1; i < s1.Length; i++)
            {
                for (var j = 1; j < s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        if (dp[i, j] > ans)
                        {
                            ans = dp[i, j];
                        }
                    }
                }
            }
            return ans;
        }
    }
}
