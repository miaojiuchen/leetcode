using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_33_搜索旋转排序数组
    {
        _33_搜索旋转排序数组 c;

        [SetUp]
        public void Setup()
        {
            c = new _33_搜索旋转排序数组();
        }


        [Test]
        public void Test()
        {
            var arr = new int[] { 3, 4, 5, 1, 2 };
            var min = c.Search(arr, 5);

            if (min == 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }


        [Test]
        public void Test0()
        {
            var arr = new int[] { 3, 4, 5, 0, 1 };
            var min = c.Search(arr, 2);

            if (min == -1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test1()
        {
            var arr = new int[] { 1, 2 };
            var min = c.Search(arr, 2);

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
