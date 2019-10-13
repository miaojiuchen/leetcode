﻿using System;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_3_无重复字符的最长字串
    {
        _3_无重复字符的最长字串 C;
        [SetUp]
        public void Setup()
        {
            C = new _3_无重复字符的最长字串();
        }


        [Test]
        public void Test()
        {
            var x = C.LengthOfLongestSubstring("abcabcbb");
            if (x == 3)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test1()
        {
            var x = C.LengthOfLongestSubstring("bbbbb");
            if (x == 1)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.LengthOfLongestSubstring("pwwkew");
            if (x == 3)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
