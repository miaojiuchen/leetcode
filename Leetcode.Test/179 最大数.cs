using System;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_179_最大数
    {
        _179_最大数 C;

        [SetUp]
        public void Setup()
        {
            C = new _179_最大数();
        }

        [Test]
        public void Test()
        {
            var x = C.LargestNumber(new int[] { 3, 30, 34, 5, 9 });
            if (x == "9534330")
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.LargestNumber(new int[] { 0, 0 });
            if (x == "0")
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
