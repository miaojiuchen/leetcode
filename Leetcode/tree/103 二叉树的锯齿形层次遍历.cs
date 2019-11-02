using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.tree
{
    public class _103_二叉树的锯齿形层次遍历
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var ans = new List<IList<int>>();
            if (root == null)
            {
                return ans;
            }

            var level = new List<TreeNode>();
            var next = new List<TreeNode> { root };

            var order = 1;

            while (next.Count != 0)
            {
                level = next;
                if (order == 1)
                {
                    ans.Add(level.Select(x => x.val).ToList()); // zig
                }
                else
                {
                    ans.Add(level.Select(x => x.val).Reverse().ToList()); // zag
                }

                next = new List<TreeNode>();
                for (var i = 0; i < level.Count; ++i)
                {
                    var n = level[i];
                    if (n.left != null)
                    {
                        next.Add(n.left);
                    }
                    if (n.right != null)
                    {
                        next.Add(n.right);
                    }
                }

                order = 1 - order;
            }

            return ans;
        }
    }
}
