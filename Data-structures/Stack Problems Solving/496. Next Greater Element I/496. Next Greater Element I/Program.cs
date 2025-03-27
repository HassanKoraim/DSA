namespace _496._Next_Greater_Element_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[3] { 4, 1, 2 };
            int[] nums2 = new int[4] { 1, 3,4, 2 };
            Solution solution = new Solution();
            solution.NextGreaterElement(nums1, nums2);
            SolutionByStack solutionbystack  = new SolutionByStack();
            solutionbystack.NextGreaterElement(nums1, nums2);

        }
    }
}
