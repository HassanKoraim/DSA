using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496._Next_Greater_Element_I
{
    public class SolutionByStack
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int,int> nextGreater = new Dictionary<int,int>();
            Stack<int> stack = new Stack<int>();
            foreach (int num in nums2)
            {
                while (stack.Count > 0 && num > stack.Peek())
                {
                    nextGreater[stack.Pop()] = num;
                }
                stack.Push(num);
            }
            while(stack.Count > 0)
            {
                nextGreater[stack.Pop()] = -1;
            }
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = nextGreater[nums1[i]];
            }
            return result;
        }
    }
}
