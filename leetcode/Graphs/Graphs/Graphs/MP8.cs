using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MP8
    {
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int preMax = nums[0];
            int preMin = nums[0];
            int globalMax = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                var cmin = 0;
                var cmax = 0;
                if(nums[i]==0)
                {
                    cmin = 0;
                    cmax = 0;
                }
                if(nums[i] <0)
                {
                    cmax = Math.Max(nums[i], nums[i] * preMin);
                    cmin = Math.Max(nums[i], nums[i] * preMax);
                }
                if(nums[i]>0)
                {
                    cmax = Math.Max(nums[i], nums[i] * preMax);
                    cmin = Math.Max(nums[i], nums[i] * preMin);

                }
                preMax = cmax;
                preMin = cmin;
                globalMax = Math.Max(globalMax, preMax);
            }
            return globalMax;
        }
    }
}
