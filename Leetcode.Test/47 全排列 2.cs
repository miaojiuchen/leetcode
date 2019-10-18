using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_47_全排列2
    {
        _47_全排列2 C;
        [SetUp]
        public void Setup()
        {
            C = new _47_全排列2();
        }

        [Test]
        public void Test()
        {
            var x = C.PermuteUnique(new int[] { 1, 1, 2 });
            x = x.OrderBy(path => path[0]).ThenBy(path => path[1]).ThenBy(path => path[2]).ToList();

            var target = new List<List<int>>()
            {
                new List<int>{1,1,2 },
                new List<int>{1,2,1 },
                new List<int>{2,1,1 },
            };

            if (x.Count != target.Count)
            {
                Assert.Fail();
                return;
            }

            for (var i = 0; i < x.Count; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (x[i][j] != target[i][j])
                    {
                        Assert.Fail();
                        return;
                    }
                }

            }

            Assert.Pass();
        }
    }
}
