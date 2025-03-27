using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _503._Next_Greater_Element_II
{
    public class Solution
    {

        public int[] NextGreaterElements(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            Array.Fill(result, -1);
            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < 2 * n; i++)
            {
                int index = i % n;
                while (stack.Count > 0 && nums[index] > nums[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    result[prevIndex] = nums[index];
                }
                if(i < n) stack.Push(index);

            }
            return result;
        }
        public int[] NextGreaterElements2(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            Array.Fill(result, -1);
            Stack<int> stack = new Stack<int>();
            for (int i = 2 * n - 1; i >= 0; i--)
            {
                int index = i % n;
                while (stack.Count > 0 && nums[index] >= nums[stack.Peek()])
                {
                    stack.Pop();
                }
                if (stack.Count > 0) result[index] = nums[stack.Peek()];
                stack.Push(index);

            }
            return result;
        }
        public int[] NextGreaterElements3(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            // Initialize result array with -1 (default if no greater element found)
            Array.Fill(result, -1);

            // Traverse the array twice to simulate the circular array behavior
            for (int i = 0; i < 2 * n; i++)
            {
                int index = i % n; // Circular index

                // Maintain a decreasing monotonic stack
                while (stack.Count > 0 && nums[stack.Peek()] < nums[index])
                {
                    int prevIndex = stack.Pop();
                    result[prevIndex] = nums[index]; // Update the result for the previous index
                }

                // Push the index onto the stack only in the first pass
                if (i < n)
                {
                    stack.Push(index);
                }
            }

            return result;
        }
    }
}
