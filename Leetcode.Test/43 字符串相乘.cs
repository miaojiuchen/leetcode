using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_43_字符串相乘
    {
        _43_字符串相乘 C;
        [SetUp]
        public void Setup()
        {
            C = new _43_字符串相乘();
        }

        [Test]
        public void Test()
        {
            var x = C.Multiply("789", "456");

            if (x == "359784")
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.Multiply("123456789", "987654321");

            if (x == "121932631112635269")
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test3()
        {
            var x = C.Multiply("6913259244", "71103343");

            if (x == "491555843274052692")
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test4()
        {
            var x = C.Multiply("140", "712");

            if (x == "100940")
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
