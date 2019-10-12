using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_1143_最长公共子序列
    {
        _1143_最长公共子序列 C;
        [SetUp]
        public void Setup()
        {
            C = new _1143_最长公共子序列();
        }

        [Test]
        public void Test()
        {
            var x = C.LongestCommonSubsequence("a", "n");
            if (x == 0)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test1()
        {
            var x = C.LongestCommonSubsequence("abcde", "ace");
            if (x == 3)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.LongestCommonSubsequence("abc", "abc");
            if (x == 3)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test3()
        {
            var x = C.LongestCommonSubsequence("abc", "def");
            if (x == 0)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test4()
        {
            var x = C.LongestCommonSubsequence("ezupkr", "ubmrapg");
            if (x == 2)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
