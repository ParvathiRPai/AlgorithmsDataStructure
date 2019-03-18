using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS9
    {
        public int FindMin(int []arr)
        {
            int l = 0;
            int h = arr.Length - 1;
            while(l<h)
            {
                int mid = (l + h) / 2;
                if(arr[mid] > arr[mid+1])
                {
                    return arr[mid+1];
                }
                if(arr[mid-1]> arr[mid])
                {
                    return arr[mid];
                }
  
                if(arr[mid]>arr[0])
                {
                    l = mid + 1;
                }
                else
                {
                    h = mid - 1;
                }
            }
            return -1;

        }
    }
}
