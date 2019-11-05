using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.动态规划
{
    public class _174_地下城游戏
    {
        /// <summary>
        /// 正向动态规划行不通，因为牵涉到加血，所以当前剩余血量会影响下一个格子的结果（即
        /// 只能从后往前推
        /// </summary>
        /// <param name="dungeon"></param>
        /// <returns></returns>
        public int CalculateMinimumHP(int[][] dungeon)
        {
            var m = dungeon.Length;
            var n = dungeon[0].Length;

            var dp = new int[m, n];

            dp[m - 1, n - 1] = Math.Max(-dungeon[m - 1][n - 1], 0);
            for (var i = m - 2; i >= 0; --i)
            {
                var col = n - 1;
                dp[i, col] = Math.Max(dp[i + 1, col] - dungeon[i][col], 0);
            }

            for (var i = n - 2; i >= 0; --i)
            {
                var row = m - 1;
                dp[row, i] = Math.Max(dp[row, i + 1] - dungeon[row][i], 0);
            }

            for (var i = m - 2; i >= 0; --i)
            {
                for (var j = n - 2; j >= 0; --j)
                {
                    dp[i, j] = Math.Max(Math.Min(dp[i + 1, j], dp[i, j + 1]) - dungeon[i][j], 0);
                }
            }

            return dp[0, 0] + 1;
        }
    }
}
