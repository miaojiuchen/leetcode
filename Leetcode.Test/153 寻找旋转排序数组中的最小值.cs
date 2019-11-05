using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_153_寻找旋转排序数组中的最小值
    {
        _153_寻找旋转排序数组中的最小值 c;

        [SetUp]
        public void Setup()
        {
            c = new _153_寻找旋转排序数组中的最小值();
        }


        [Test]
        public void Test()
        {
            var arr = new int[] { 3, 4, 5, 1, 2 };
            var min = c.FindMin(arr);

            if (min == 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }


        [Test]
        public void Test2()
        {
            var arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var min = c.FindMin(arr);

            if (min == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test3()
        {
            var arr = new int[] { 1 };
            var min = c.FindMin(arr);

            if (min == 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test4()
        {
            var arr = new int[] { 7, 0, 1, 2, 3, 4, 5, 6 };
            var min = c.FindMin(arr);

            if (min == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test5()
        {
            var arr = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            var min = c.FindMin(arr);

            if (min == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test6()
        {
            var arr = new int[] { 2, 1 };
            var min = c.FindMin(arr);

            if (min == 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test7()
        {
            var arr = new int[] { 5, 1, 2, 3, 4 };
            var min = c.FindMin(arr);

            if (min == 1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
