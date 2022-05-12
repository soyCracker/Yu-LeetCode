//1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_LeetCode.Problems
{
    public class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int tem = target - nums[i];
                if (dict.ContainsKey(tem))
                {
                    return new int[] { dict[tem], i };
                }
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }         
            }
            return new int[] { -1, -1 };
        }
    }
}
