using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class S12
    {
        public int Pivot(int []nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int min = 0;

            int max = nums.Length - 1;

            while (min <= max)
            {

                int mid = min + (max - min) / 2;

                if (mid < max && nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];

                }
                else
                if (mid > min && nums[mid - 1] > nums[mid])
                {
                    return nums[mid];
                }
                if (nums[min] < nums[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }


            }
            // is ordered 
            return nums[0];
        }
    }
}
