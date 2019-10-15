using System;
namespace Leetcode
{
	public class _712_两个字符串的最小ASCII删除和
	{
		public int MinimumDeleteSum(string s1, string s2)
		{
            var maxSubAscii = maxAsciiSumCommonSubSequence(s1, s2);

            return sumAscii(s1) + sumAscii(s2) - 2 * maxSubAscii;
        }

        private int sumAscii(string s)
        {
            var sum = 0;
            foreach(var c in s)
            {
                sum += c;
            }
            return sum;
        }

		private int maxAsciiSumCommonSubSequence(string s1, string s2)
		{
			if (s1 == "" || s2 == "")
			{
				return 0;
			}

			var dp = new int[s1.Length + 1, s2.Length + 1];

			for (var i = 1; i <= s1.Length; i++)
			{
				for (var j = 1; j <= s2.Length; j++)
				{
					if (s1[i - 1] == s2[j - 1])
					{
						dp[i, j] = dp[i - 1, j - 1] + s1[i - 1];
					}
					else
					{
						dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
					}
				}
			}

			return dp[s1.Length, s2.Length];
		}
	}
}
