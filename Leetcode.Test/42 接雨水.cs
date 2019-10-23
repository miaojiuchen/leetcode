using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_42_接雨水
    {
        _42_接雨水 C;
        [SetUp]
        public void Setup()
        {
            C = new _42_接雨水();
        }

        [Test]
        public void Test()
        {
            var x = C.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });

            if (x == 6)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}