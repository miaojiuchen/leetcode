using System;

namespace Leetcode.tree
{
    public class _106_从中序与后序遍历序列构造二叉树
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        private int[] _inorder;
        private int[] _postorder;

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            _inorder = inorder;
            _postorder = postorder;

            return build(0, 0, postorder.Length);
        }

        private TreeNode build(int from_in, int from_post, int count)
        {
            if (count == 0)
            {
                return null;
            }

            var rootVal = _postorder[from_post + count - 1];
            var root = new TreeNode(rootVal);

            var leftCount = 0;
            var cur = from_in;
            while (cur < _inorder.Length && _inorder[cur] != rootVal)
            {
                leftCount++;
                cur++;
            }

            var rightCount = count - leftCount - 1;


            root.left = build(from_in, from_post, leftCount);
            root.right = build(from_in + leftCount + 1, from_post + leftCount, rightCount);

            return root;
        }
    }
}
