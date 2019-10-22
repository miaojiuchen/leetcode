using System;
namespace Leetcode
{
    public class _1145_二叉树着色游戏
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool BtreeGameWinningMove(TreeNode root, int n, int x)
        {
            int left = 0;
            int right = 0;

            dfs(root, x, ref left, ref right);

            var remain = n - left - right - 1;

            var need = n / 2;

            return remain > need || left > need || right > need;
        }

        private int dfs(TreeNode node, int x, ref int left, ref int right)
        {
            if(node == null)
                return 0;

            var lCount = dfs(node.left, x, ref left, ref right);
            var rCount = dfs(node.right, x, ref left, ref right);
            if (node.val == x)
            {
                left = lCount;
                right = rCount;
            }
            return lCount + rCount + 1;
        }
    }
}
