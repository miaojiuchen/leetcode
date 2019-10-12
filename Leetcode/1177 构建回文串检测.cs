using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Leetcode
{
    public class _1177_构建回文串检测
    {
        public IList<bool> CanMakePaliQueries(string s, int[][] queries)
        {
            IList<bool> res = new List<bool>();

            var dic = window(s);

            foreach (var q in queries)
            {
                var k = q[2];
                if (k >= 13)
                    res.Add(true);
                else
                    res.Add(check(s, q[0], q[1], k, dic));
            }

            return res;
        }

        private Dictionary<int, Dictionary<char, int>> window(string s)
        {
            var dic = new Dictionary<int, Dictionary<char, int>>();
            dic[-1] = new Dictionary<char, int>();
            for (var i = 'a'; i <= 'z'; i++)
                dic[-1][i] = 0;

            for (var i = 0; i < s.Length; i++)
            {
                dic[i] = new Dictionary<char, int>(dic[i - 1]);
                dic[i][s[i]]++;
            }

            return dic;
        }

        private bool check(string s, int left, int right, int k, Dictionary<int, Dictionary<char, int>> dic)
        {
            var len = right - left + 1;

            var dirtyCount = 0;
            for (var i = 'a'; i <= 'z'; i++)
            {
                var charCount = dic[right][i] - dic[left][i] + (s[left] == i ? 1 : 0);
                if (charCount % 2 != 0)
                    dirtyCount++;
            }

            if (len % 2 == 0)
                return dirtyCount / 2 <= k;

            return (dirtyCount - 1) / 2 <= k;
        }
    }
}
