using System;
using NUnit.Framework;

namespace Leetcode.Test.tree
{
    public class Test_105_从前序和中序遍历序列构造二叉树
    {

        _105_从前序和中序遍历序列构造二叉树 C;
        [SetUp]
        public void Setup()
        {
            C = new _105_从前序和中序遍历序列构造二叉树();
        }


        [Test]
        public void Test()
        {
            var x = C.BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });
            Console.WriteLine(x.val);
        }

        [Test]
        public void Test2()
        {
            var x = C.BuildTree(new int[] { 3, 9, 4, 6, 8, 1, 20, 15, 7, 2 }, new int[] { 4, 9, 8, 6, 1, 3, 15, 20, 2, 7 });
            Console.WriteLine(x.val);
        }

    }
}
