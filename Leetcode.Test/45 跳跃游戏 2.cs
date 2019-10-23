using System;
using NUnit.Framework;
using System.Diagnostics;

namespace Leetcode.Test
{
    public class Test_45_跳跃游戏_2
    {
        _45_跳跃游戏_2 C;

        [SetUp]
        public void Setup()
        {
            C = new _45_跳跃游戏_2();
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 2, 3, 1, 1, 4 };

            var x = C.Jump(arr);
            if (x == 2)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test()
        {
            var arr = new int[1000];
            var i = 999;
            while (i != -1)
            {
                arr[i] = 1;
                --i;
            }

            var x = C.Jump(arr);
            if (x == 999)
                Assert.Pass();
            else
                Assert.Fail();
        }

    }
}
