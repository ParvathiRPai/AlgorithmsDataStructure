using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS10
    {
        public int Search(int []arr, int target)
        {
            int n = arr.Length - 1;
            int l = 0;
            int h = n;
            while(l < h)
            {
                int mid = (l + h) / 2;
                if(arr[mid]==target)
                {
                    return target;
                }
                if(arr[mid] <= arr[h])
                {
                    if(arr[mid]< target && target<=arr[h])
                    {
                        l = mid + 1;
                    }
                    else 
                    {
                        h = mid - 1;
                    }
                }
                else if(arr[mid]>=arr[h])
                {
                    if(arr[l]<=target && target<arr[mid])
                    {
                        h= mid - 1;
                    }
                    else 
                    {
                        l = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}
