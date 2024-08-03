namespace Balanced_Binary_Tree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return CheckHeight(root) != -1;   //  if balanced or not
        }
        private int CheckHeight(TreeNode root)
        {
            if (root == null) return 0;
            int leftHeight = CheckHeight(root.left);
            if (leftHeight == -1) return -1;
            int rightHeight = CheckHeight(root.right);
            if (rightHeight == -1)return -1;
            if (Math.Abs(leftHeight - rightHeight) > 1) return -1;  // not balanced
            return Math.Max(leftHeight, rightHeight) + 1;
        }

       
    }
}
