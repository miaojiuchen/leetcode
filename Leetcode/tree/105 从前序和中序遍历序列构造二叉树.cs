using System;
namespace Leetcode
{
    public class _105_从前序和中序遍历序列构造二叉树
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        private int[] preorder;
        private int[] inorder;

        /// <summary>
        /// 前序遍历 preorder = [3, 9, 20, 15, 7]
        /// 中序遍历 inorder = [9, 3, 15, 20, 7]
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        public TreeNode BuildTree(int[] _preorder, int[] _inorder)
        {

            preorder = _preorder;
            inorder = _inorder;

            return build(0, preorder.Length - 1, 0, inorder.Length - 1);
        }

        public TreeNode build(int pre_from, int pre_to, int in_from, int in_to)
        {
            if (pre_from > pre_to || pre_to >= preorder.Length || in_to >= preorder.Length)
            {
                return null;
            }

            var rootVal = preorder[pre_from];
            var root = new TreeNode(rootVal);

            var left_in_to = in_from;
            var right_pre_from = pre_from + 1;
            while (left_in_to < preorder.Length && inorder[left_in_to] != rootVal)
            {
                left_in_to++;
                right_pre_from++;
            }
            left_in_to--;


            root.left = build(pre_from + 1, right_pre_from - 1, in_from, left_in_to);
            root.right = build(right_pre_from, pre_to, left_in_to + 2, in_to);

            return root;
        }
    }
}
