using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class ProdSubArray
    {
        public int MaxProd(int []nums)
        {
            int[] max = new int[nums.Length];
            int[] min = new int[nums.Length];

            max[0] = min[0] = nums[0];
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    max[i] = Math.Max(nums[i], max[i - 1] * nums[i]);
                    min[i] = Math.Min(nums[i], min[i - 1] * nums[i]);
                }
                else
                {
                    max[i] = Math.Max(nums[i], min[i - 1] * nums[i]);
                    min[i] = Math.Min(nums[i], max[i - 1] * nums[i]);
                }

                result = Math.Max(result, max[i]);
            }

            return result;
        }
    }
    }

