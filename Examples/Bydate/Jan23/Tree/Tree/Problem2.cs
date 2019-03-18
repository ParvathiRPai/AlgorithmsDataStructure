using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Problem2
    {
        public int Sorted(int []arr, int target)
        {
            int high = arr.Length-1;
            int low = 0;
            while(low<=high)
            {
                int mid = (high+low) / 2;
                if(arr[mid]==target)
                {
                    return mid;
                }
                if(arr[mid]>arr[low])
                {
                    if(target>arr[mid] && target<= arr[low])
                    {
                        high = mid-1;
                    }
                    else
                    {
                        low = mid;
                    }
                    
                }
                else if(arr[high]>arr[mid])
                {
                    if(target>arr[mid] && target<=arr[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid;
                    }

                }
            }
            return -1;
        }
    }
}
