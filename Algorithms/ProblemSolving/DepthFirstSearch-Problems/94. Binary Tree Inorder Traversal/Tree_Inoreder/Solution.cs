namespace Tree_Inoreder
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            InorderTraversalHelper(root, result);
            return result;
        }
        public void InorderTraversalHelper(TreeNode root, IList<int> result)
        {
            // Base Case
            if (root == null)
            {
                return;
            }
            InorderTraversalHelper(root.left,result);
            result.Add(root.val);
            InorderTraversalHelper(root.right, result);
        }
    }
}
