using System;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_300_最长上升子序列
    {
        _300_最长上升子序列 C;
        [SetUp]
        public void Setup()
        {
            C = new _300_最长上升子序列();
        }

        [Test]
        public void Test()
        {
            var x = C.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            if (x == 4)
                Assert.Pass();
            else
                Assert.Fail();
        }


        [Test]
        public void Test2()
        {
            var x = C.LengthOfLIS(new int[] { 1, 3, 6, 7, 9, 4, 10, 5, 6 });
            if (x == 6)
                Assert.Pass();
            else
                Assert.Fail(x.ToString() + ", 6");
        }
    }
}
