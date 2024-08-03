namespace Balanced_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Solution solution = new Solution();
            Console.WriteLine(solution.IsBalanced(root));
            Console.WriteLine(solution.checkLevel(root));
        }
    }
}
