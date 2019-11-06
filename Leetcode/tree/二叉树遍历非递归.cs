using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.tree
{
    public class 二叉树遍历非递归
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var ans = new List<int>();

            var stack = new Stack<TreeNode>();

            var cur = root;
            while(cur != null || stack.Count > 0)
            {
                while(cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                var node = stack.Pop();
                ans.Add(node.val);
                cur = node.right;
            }

            return ans;
        }
    }
}
