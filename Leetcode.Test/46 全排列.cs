using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_46_全排列
    {
        _46_全排列 C;
        [SetUp]
        public void Setup()
        {
            C = new _46_全排列();
        }

        [Test]
        public void Test()
        {
            var x = C.Permute(new int[] { 1, 2, 3 });
            x = x.OrderBy(path => path[0]).ThenBy(path => path[1]).ThenBy(path => path[2]).ToList();

            var target = new List<List<int>>()
            {
                new List<int>{1,2,3 },
                new List<int>{1,3,2 },
                new List<int>{2,1,3 },
                new List<int>{2,3,1 },
                new List<int>{3,1,2 },
                new List<int>{3,2,1 }
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
