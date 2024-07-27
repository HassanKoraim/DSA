//WebSite the Problem 
//https://leetcode.com/problems/binary-tree-inorder-traversal

namespace Tree_Inoreder
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
            IList<int> result = new List<int>();
            result = solution.InorderTraversal(root);
            foreach (int i in result) 
            {
                Console.WriteLine(i + " ");
            }
        }
    }

}
