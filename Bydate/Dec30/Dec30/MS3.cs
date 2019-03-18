using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    class MS3
    {
        public float FindMedian(int []arr1, int []arr2)
        {
            int[] res = SortMerge(arr1, arr2);
            if (res.Length % 2 != 0)
            {
                return res[res.Length / 2];
            }
            else
            {
                float middle = (res[res.Length / 2] + res[res.Length/ 2-1]) / 2;
                return middle;
            }
           
        }
        public int[]SortMerge(int []arr1, int []arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];
            int index = 0, i=0, j=0;
            while(i<arr1.Length && j < arr2.Length)
            {
                if(arr1[i]< arr2[j])
                {
                    res[index++] = arr1[i];
                    i++;
                }
                else
                {
                    res[index++] = arr2[j];
                    j++;
                }
            }
            while(i <= arr1.Length-1)
            {
                res[index++] = arr1[i];
                i++;
            }
            while(j<=arr2.Length-1)
            {
                res[index++] = arr2[j];
                j++;
            }
            return res;
        }
    }
}
