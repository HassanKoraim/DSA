namespace Path_Sum2
{
    public class Solution
    {
        public IList<IList<int>> PathSum(TreeNode root , int targetSum)
        {
            IList<IList<int>> Paths = new List<IList<int>>();
            IList<int> CurrentPath = new List<int>();
            DFS(root, CurrentPath, Paths , targetSum);
            return Paths;
        }
        public void DFS(TreeNode node, IList<int> CurrentPath, IList<IList<int>> Paths , int targetSum)
        {
            if(node == null) return;
            // Add the current node to the path
            CurrentPath.Add(node.val);
            // If it's a leaf node, add the path to the list of paths
            if (node.left == null && node.right == null)
            {
                foreach (var item in CurrentPath)
                {
                    targetSum -= item;

                }
                // check the path is right or not, if true add the path to Paths
                if (targetSum == 0) Paths.Add(new List<int>(CurrentPath));
            }
            else
            {
                DFS(node.left, CurrentPath, Paths , targetSum);
                DFS(node.right, CurrentPath, Paths, targetSum);
            }

            // Backtrack: remove the current node from the path
            CurrentPath.RemoveAt(CurrentPath.Count - 1);
        }
    }
}
