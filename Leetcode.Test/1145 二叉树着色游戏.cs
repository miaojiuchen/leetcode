using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_145_二叉树着色游戏
    {
        _1145_二叉树着色游戏 C = new _1145_二叉树着色游戏();

        [Test]
        public void Test1()
        {
            var root = new _1145_二叉树着色游戏.TreeNode(1);
            var cursor = root;
            cursor.left = new _1145_二叉树着色游戏.TreeNode(2);
            cursor.right = new _1145_二叉树着色游戏.TreeNode(3);

            cursor = root.left;
            cursor.left = new _1145_二叉树着色游戏.TreeNode(4);
            cursor.right = new _1145_二叉树着色游戏.TreeNode(5);

            cursor = root.right;
            cursor.left = new _1145_二叉树着色游戏.TreeNode(6);
            cursor.right = new _1145_二叉树着色游戏.TreeNode(7);

            cursor = root.left.left;
            cursor.left = new _1145_二叉树着色游戏.TreeNode(8);
            cursor.right = new _1145_二叉树着色游戏.TreeNode(9);

            cursor = root.left.right;
            cursor.left = new _1145_二叉树着色游戏.TreeNode(10);
            cursor.right = new _1145_二叉树着色游戏.TreeNode(11);


            var result = C.BtreeGameWinningMove(root, 11, 3);
            if(result != true)
            {
                Assert.Fail();
            } else
            {
                Assert.Pass();
            }
        }
    }
}
