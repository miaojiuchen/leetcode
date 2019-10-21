using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_5_最长回文子串
    {
        _5_最长回文子串 C;
        [SetUp]
        public void Setup()
        {
            C = new _5_最长回文子串();
        }

        [Test]
        public void Test()
        {
            var x = C.LongestPalindrome("caba");

            if (x == "aba")
                Assert.Pass();
            else
                Assert.Fail();
        }


        [Test]
        public void Test2()
        {
            var x = C.LongestPalindrome("abc435cba");

            if (x == "a")
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
