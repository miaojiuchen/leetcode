using System;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_583_两个字符串的删除操作
    {
        _583_两个字符串的删除操作 C;
        [SetUp]
        public void Setup()
        {
            C = new _583_两个字符串的删除操作();
        }

        [Test]
        public void Test()
        {
            var x = C.MinDistance("sea", "eat");
            if (x == 2)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
