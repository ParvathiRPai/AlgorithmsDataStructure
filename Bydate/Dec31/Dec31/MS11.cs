using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS11
    {
        public int Search(int []arr, int k)
        {
            int l = 0;
            int h = arr.Length-1;
            while(l<=h)
            {
                int mid = (l + h) / 2;
                if (arr[mid] == k)
                    return mid;
                if(arr[l]<arr[mid])
                {
                    if(arr[l]<=k && k <arr[mid])
                    {
                        h = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }

                }
                else
                {
                    if(arr[mid]< k && k <=arr[h])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        h = mid-1;
                    }

                }

            }
            return -1;
        }
    }
}
