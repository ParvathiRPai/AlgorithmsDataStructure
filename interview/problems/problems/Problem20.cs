using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem20
    {
        public int FindPivot(int []arr)
        {
            int start = 0;
            int end = arr.Length;
            while(start < end)
            {
                int mid = start + end / 2;

                if(mid < end && arr[mid] > arr[mid+1])
                {
                    return mid;
                }
                if(mid > start && arr[mid] < arr[mid-1])
                {
                    return mid - 1;
                }
                if(arr[start] >= arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
           
        }
        
    }
}
