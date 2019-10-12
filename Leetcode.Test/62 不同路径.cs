
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace Leetcode.Test
{
    public class Test_62_不同路径
    {
        _62_不同路径 C;
        [SetUp]
        public void Setup()
        {
            C = new _62_不同路径();
        }

        [Test]
        public void Test()
        {

            var x = C.UniquePaths(3, 2);
            if (x == 3)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.UniquePaths(7, 3);
            if (x == 28)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
