using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int max = 1;
            int prev = 1;
            int next = 1;
            for(int i=0; i<nums.Length;i++)
            {
                if (!set.Contains(nums[i]))
                    continue;
                set.Remove(nums[i]);
                next = nums[i] + 1;
                prev = nums[i] - 1;
                while(set.Contains(next))
                {
                    set.Remove(next);
                    next++;
                }
                while(set.Contains(prev))
                {
                    set.Remove(prev);
                    prev--;
                }
                max = next - prev + 1 > max ? next - prev - 1 : max;
            }
            return max;
        }
    }
}


