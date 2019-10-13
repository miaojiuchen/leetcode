
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Leetcode.Test
{
    public class Test_64_最小路径和
    {
        _64_最小路径和 C;
        [SetUp]
        public void Setup()
        {
            C = new _64_最小路径和();
        }

        [Test]
        public void Test()
        {
            var arr = new int[][] {
                new int[]{ 1,3,1 },
                new int[]{ 1,5,1},
                new int[]{ 4,2,1},
            };
            var x = C.MinPathSum(arr);
            if (x == 7)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var arr = new int[][] {
                new int[]{ 1,2,5 },
                new int[]{ 3,2,1}
            };
            var x = C.MinPathSum(arr);
            if (x == 6)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
