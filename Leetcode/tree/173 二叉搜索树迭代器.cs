using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.tree
{
    public class _173_二叉搜索树迭代器
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class BSTIterator
        {
            private readonly Stack<TreeNode> s = new Stack<TreeNode>();

            public BSTIterator(TreeNode root)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }
            }

            /** @return the next smallest number */
            public int Next()
            {
                var node = s.Pop();

                var cur = node.right;
                while (cur != null)
                {
                    s.Push(cur);
                    cur = cur.left;
                }

                return node.val;
            }

            /** @return whether we have a next smallest number */
            public bool HasNext()
            {
                return s.Count > 0;
            }
        }
    }
}
