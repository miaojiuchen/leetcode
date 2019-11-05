using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leetcode
{
    public class _165_比较版本号
    {
        public int CompareVersion(string version1, string version2)
        {
            var arr1 = version1.Split('.').Select(x => int.Parse(x)).ToList();
            var arr2 = version2.Split('.').Select(x => int.Parse(x)).ToList();

            var len = Math.Max(arr1.Count, arr2.Count);


            var diff = len - arr1.Count;
            while (diff != 0)
            {
                arr1.Add(0);
                diff--;
            }

            diff = len - arr2.Count;
            while (diff != 0)
            {
                arr2.Add(0);
                diff--;
            }

            for (var i = 0; i < len; ++i)
            {
                if (arr1[i] > arr2[i])
                {
                    return 1;
                }
                else if (arr1[i] < arr2[i])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
