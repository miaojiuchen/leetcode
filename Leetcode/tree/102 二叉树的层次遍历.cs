using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class _102_二叉树的层次遍历
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var dic = new Dictionary<int, List<int>>();
            var height = walk(root, 0, dic);
            var ans = new List<IList<int>>();

            for (var i = 0; i < height; i++)
            {
                ans.Add(dic[i]);
            }

            return ans;
        }

        public int walk(TreeNode node, int depth, Dictionary<int, List<int>> dic)
        {
            if (node == null)
            {
                return 0;
            }

            if (!dic.ContainsKey(depth))
            {
                dic[depth] = new List<int>();
            }

            dic[depth].Add(node.val);
            var leftHeight = walk(node.left, depth + 1, dic);
            var rightHeight = walk(node.right, depth + 1, dic);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
