using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _962._Maximum_Width_Ramp
{
    public class Solution
    {
        public int MaxWidthRamp(int[] nums)
        {
            int n = nums.Length;
            int maxWidth = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                if (stack.Count == 0 || nums[i] < nums[stack.Peek()])
                {
                    stack.Push(i);
                }
            }
            for (int j = n - 1; j >= 0; j--)
            {
                while (stack.Count > 0 && nums[j] >= nums[stack.Peek()])
                {
                    maxWidth = Math.Max(maxWidth, j - stack.Pop());
                }
            }
            return maxWidth;
        }

    }
}
