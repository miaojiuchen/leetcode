using System;
using NUnit.Framework;
using System.Diagnostics;

namespace Leetcode.Test
{
    public class Test_55_跳跃游戏
    {
        _55_跳跃游戏 C;

        [SetUp]
        public void Setup()
        {
            C = new _55_跳跃游戏();
        }

        [Test]
        public void Test()
        {
            var x = C.CanJump(new int[] { 2, 3, 1, 1, 4 });
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            var x = C.CanJump(new int[] { 3, 2, 1, 0, 4 });
            if (x == false)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test3()
        {
            var x = C.CanJump(new int[] { 1, 4, 5, 2, 3, 3, 2 });
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test4()
        {
            var sw = new Stopwatch();
            sw.Start();
            var x = C.CanJump(new int[] { 2, 0, 6, 9, 8, 4, 5, 0, 8, 9, 1, 2, 9, 6, 8, 8, 0, 6, 3, 1, 2, 2, 1, 2, 6, 5, 3, 1, 2, 2, 6, 4, 2, 4, 3, 0, 0, 0, 3, 8, 2, 4, 0, 1, 2, 0, 1, 4, 6, 5, 8, 0, 7, 9, 3, 4, 6, 6, 5, 8, 9, 3, 4, 3, 7, 0, 4, 9, 0, 9, 8, 4, 3, 0, 7, 7, 1, 9, 1, 9, 4, 9, 0, 1, 9, 5, 7, 7, 1, 5, 8, 2, 8, 2, 6, 8, 2, 2, 7, 5, 1, 7, 9, 6 });
            sw.Stop();
            var y = sw.ElapsedMilliseconds;
            if (x == false)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test5()
        {
            var x = C.CanJump(new int[] { 2, 0 });
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        public void Test6()
        {
            var x = C.CanJump(new int[] { 2, 0, 0 });
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }


        [Test]
        public void Test7()
        {
            var x = C.CanJump(new int[] { 1, 2, 0, 1 });
            if (x == true)
                Assert.Pass();
            else
                Assert.Fail();
        }

    }
}
