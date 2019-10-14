using System;
namespace Leetcode
{
    public class _64_最小路径和
    {
        /// <summary>
        /// DP问题，一般来说，dp[i, j] = min(dp[i-1, j], dp[i, j-1]) + val
        /// 对于边缘的点，特殊处理，一定使用左侧或上侧的路径
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int MinPathSum(int[][] grid)
        {
            var m = grid.Length;
            if (m == 0)
                return 0;
            var n = grid[0].Length;

            var dp = new int[n + 1, m + 1];

            for (var j = 1; j <= m; j++)
            {
                for (var i = 1; i <= n; i++)
                {
                    var point = grid[j - 1][i - 1];
                    if (i == 1)
                        dp[i, j] = dp[i, j - 1] + point;
                    else if (j == 1)
                        dp[i, j] = dp[i - 1, j] + point;
                    else
                        dp[i, j] = Math.Min(dp[i, j - 1], dp[i - 1, j]) + point;
                }
            }
            return dp[n, m];
        }
    }
}
