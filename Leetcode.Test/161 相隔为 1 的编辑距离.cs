using System;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_161_相隔为1的编辑距离
    {
        _161_相隔为1的编辑距离 C;
        [SetUp]
        public void Setup()
        {
            C = new _161_相隔为1的编辑距离();
        }

        [Test]
        public void Test1()
        {
            var x = C.IsOneEditDistance("", "");
            if (x == false)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test()
        {
            var x = C.IsOneEditDistance("ab", "acb");
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.IsOneEditDistance("cab", "ad");
            if (x == false)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test3()
        {
            var x = C.IsOneEditDistance("1203", "1213");
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
