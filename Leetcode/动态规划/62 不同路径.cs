using System;
namespace Leetcode
{
    public class _62_不同路径
    {
        public int UniquePaths(int m, int n)
        {
            var dp = new int[m + 1, n + 1];
            for (var j = 1; j <= n; j++)
            {
                for (var i = 1; i <= m; i++)
                {
                    if (i == 1)
                        dp[i, j] = 1;
                    else if (j == 1)
                        dp[i, j] = 1;
                    else
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
            return dp[m, n];
        }
    }
}
