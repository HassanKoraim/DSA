using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496._Next_Greater_Element_I
{
    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] ans = new int[nums1.Length];
            for(int i = 0; i < nums1.Length; i++)
            {
                bool IsAppend = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        if (j == nums2.Length - 1) ans[i] = -1;
                        else
                        {
                            for (int k = j + 1; k < nums2.Length; k++)
                            {
                                if (nums2[k] > nums2[j])
                                {
                                    ans[i] = nums2[k];
                                    IsAppend = true;
                                    break;
                                }
                            }
                            if (!IsAppend)
                            {
                                ans[i] = -1;
                                IsAppend = true;
                            }
                        }
                        break;
                    }
                }
            }
            return ans; 
        }
    }
}
