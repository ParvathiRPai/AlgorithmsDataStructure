using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class Intersection
    {
        public int[] FindIntersection(int[] arr, int[] arr1)
        {
            int[] res = new int[arr1.Length];
            
            for(int i=0; i<arr1.Length;i++)
            {
                for(int j=i;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        res[i] = arr[j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return res;
        }

    }
}
