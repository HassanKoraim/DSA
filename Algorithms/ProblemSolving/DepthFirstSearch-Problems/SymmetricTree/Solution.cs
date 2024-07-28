namespace SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if(root == null) return true;
            return ISmirror(root.left, root.right);
         
        }
        public bool ISmirror(TreeNode rootLeft, TreeNode rootRight)
        {
            if(rootLeft == null && rootRight == null) return true;
            if(rootLeft == null || rootRight == null) return false;
            if (rootLeft.val != rootRight.val) return false;
            return (ISmirror(rootLeft.right, rootRight.left) && ISmirror(rootLeft.left , rootRight.right));
        }
    }

}
