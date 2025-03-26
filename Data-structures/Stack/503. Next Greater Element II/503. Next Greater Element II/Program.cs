namespace _503._Next_Greater_Element_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int [5]{5,6,3,2,7 };
            Solution solution = new Solution();
            print(solution.NextGreaterElements3(nums));
        }
        private static void print(int[] a)
        {
            foreach(int num in a)
            {
                Console.WriteLine(num);
            }
        }
    }
}
