using System;
namespace Leetcode
{
    public class _338_比特位计数
    {
        /// <summary>
        /// 观察前16个数的二进制可以发现：奇数的popup count为前一个数+1，偶数与该数除以2的pc相等
        /// 可以得到递推方程：dp[i] = dp[i/2] (偶数) || dp[i-1]+1 (奇数)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int[] CountBits(int num)
        {
            var dp = new int[num + 1];
            for (var i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                    dp[i] = dp[i / 2];
                else
                    dp[i] = dp[i - 1] + 1;
            }
            return dp;
        }
    }
}
