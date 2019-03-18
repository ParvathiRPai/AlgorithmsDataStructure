using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class FindMedian
    {
        public double GetMedian(int []arr1, int []arr2)
        {
            int[] result = Merge(arr1, arr2);
            int n = result.Length;
           double median;
            if(n%2==0)
            {
                median = (double)(result[n / 2] + result[n / 2 - 1]) / 2;
            }
            else
            {
                median = result[n / 2];
            }
            return median;
        }


        public int[] Merge(int []arr1, int []arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j=0, index=0;
            while(i<arr1.Length && j<arr2.Length)
            {
                if(arr1[i]<arr2[j])
                {
                    result[index++] = arr1[i++];
                    
                }
                else
                {
                    result[index++] = arr2[j++];
                }
            }

            while(i<arr1.Length)
            {
                result[index++] = arr1[i++];
            }
            while(j<arr2.Length)
            {
                result[index++] = arr2[j++];
            }
            return result;
        }
    }
}
