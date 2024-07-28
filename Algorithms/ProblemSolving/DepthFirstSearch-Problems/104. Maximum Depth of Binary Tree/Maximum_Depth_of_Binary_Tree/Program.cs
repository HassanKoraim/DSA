namespace Maximum_Depth_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxDepth(root));
        }
    }
}
