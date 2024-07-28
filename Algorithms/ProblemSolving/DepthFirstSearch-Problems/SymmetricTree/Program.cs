namespace SymmetricTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.right.right = new TreeNode(3);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(4);
            Console.WriteLine(s.IsSymmetric(root));
        }
    }

}
