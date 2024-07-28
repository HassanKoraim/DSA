using System;


namespace Maximum_Depth_of_Binary_Tree
{
    internal class Solution
    {
        int countLeft = 0;
        int countRight = 0;
        public int MaxDepth(TreeNode root)
        {

            if (root == null) return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
