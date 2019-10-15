using System;
namespace Leetcode
{
    public class _583_两个字符串的删除操作
    {
        public int MinDistance(string word1, string word2)
        {
            return word1.Length + word2.Length - 2 * longestCommonSubSequence(word1, word2);
        }

        public int longestCommonSubSequence(string word1, string word2)
        {
            /*
             * if( dp[i] == dp[j] ) {
             *      dp[i, j] = dp[i-1, j-1] + 1
             * }
             * else {
             *      dp[i, j] = max(dp[i-1, j], dp[i, j-1]) + 1
             * }
             */
            if (word1 == "" || word2 == "")
            {
                return 0;
            }

            var dp = new int[word1.Length + 1, word2.Length + 1];

            for (var i = 1; i <= word1.Length; i++)
            {
                for (var j = 1; j <= word2.Length; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[word1.Length, word2.Length];
        }
    }
}
