using System;
using System.Collections.Generic;
using System.Text;
using Leetcode.tree;
using NUnit.Framework;

namespace Leetcode.Test.tree
{
    class Test_173_二叉搜索树迭代器
    {
        //_173_二叉搜索树迭代器 C;
        //[SetUp]
        //public void Setup()
        //{
        //    C = new _173_二叉搜索树迭代器();
        //}


        [Test]
        public void Test()
        {
            var tree = new _173_二叉搜索树迭代器.TreeNode(6);
            var cur = tree;
            cur.left = new _173_二叉搜索树迭代器.TreeNode(1);
            cur.right = new _173_二叉搜索树迭代器.TreeNode(9);

            cur = tree.left; // 1
            cur.right = new _173_二叉搜索树迭代器.TreeNode(4);
            cur = cur.right; // 4

            cur.left = new _173_二叉搜索树迭代器.TreeNode(2);
            cur.right = new _173_二叉搜索树迭代器.TreeNode(5);

            cur.left.right = new _173_二叉搜索树迭代器.TreeNode(3);

            cur = tree.right; // 9
            cur.left = new _173_二叉搜索树迭代器.TreeNode(7);
            cur.right = new _173_二叉搜索树迭代器.TreeNode(11);
            cur.left.right = new _173_二叉搜索树迭代器.TreeNode(8);

            cur = cur.right; // 11
            cur.left = new _173_二叉搜索树迭代器.TreeNode(10);
            cur.right = new _173_二叉搜索树迭代器.TreeNode(13);

            cur = cur.right; // 13
            cur.left = new _173_二叉搜索树迭代器.TreeNode(12);
            cur.right = new _173_二叉搜索树迭代器.TreeNode(14);

            var x = new _173_二叉搜索树迭代器.BSTIterator(tree);
            var serial = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var i = 0;
            while (x.HasNext())
            {
                if (x.Next() != serial[i++])
                {
                    Assert.Fail();
                    return;
                }
            }

            Assert.Pass();
        }

    }
}
