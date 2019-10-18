using System;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_674_最长连续递增序列
    {
        _674_最长连续递增序列 C;
        [SetUp]
        public void Setup()
        {
            C = new _674_最长连续递增序列();
        }

        [Test]
        public void Test()
        {
            var x = C.FindLengthOfLCIS(new int[] { 1, 3, 5, 4, 7 });
            if (x == 3)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test2()
        {
            var x = C.FindLengthOfLCIS(new int[] { 2, 2, 2, 2, 2 });
            if (x == 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
