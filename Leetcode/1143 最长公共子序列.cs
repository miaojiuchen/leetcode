using System;
namespace Leetcode
{
    public class _1143_最长公共子序列
    {
        /// <summary>
        /// 本题使用动态规划，递推方程有两个
        /// 第一个比较好理解 if s1[i] == s2[i] then dp[i][j] = dp[i-1][j-1]+1 就是末尾相同字母的话，下一个最长公共子序列必然长度+1
        /// 第二个需要理解一下 else dp[i][j] = max(dp[i-1][j], dp[i][j-1]) 
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        public int LongestCommonSubsequence(string text1, string text2)
        {
            if (text1 == "" || text2 == "")
                return 0;

            var dp = new int[text1.Length + 1, text2.Length + 1];

            for (var i = 1; i <= text1.Length; i++)
            {
                for (var j = 1; j <= text2.Length; j++)
                {
                    if (text1[i-1] == text2[j-1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            return dp[text1.Length, text2.Length];
        }
    }
}
