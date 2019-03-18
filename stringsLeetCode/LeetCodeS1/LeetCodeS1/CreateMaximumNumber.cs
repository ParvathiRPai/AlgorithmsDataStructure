using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class CreateMaximumNumber
    {
        public int[] CreateArray(int []arr1, int []arr2, int k)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;
            int[] result = new int[k];
            int index = 0;
            int i = 0;
            int j = 0;
            while(i<=n1 &&  j <=n2 && index <= k)
            {
                int[] max1 = GetFirstMaxIndex(arr1,i);
                int[] max2 = GetFirstMaxIndex(arr2,j);
                int m1 = 0;
                int m2 = 0;
                if(max1[m1] < max2[m2])
                {
                    result[index++] = max2[m2];
                    m2++;
                    j = result[m2];
                    j = j + 1;
                }
                else
                {
                    result[index++] = max1[m1];
                    m1++;
                    i = result[m1];
                    i = i + 1;
                }
            }
            while(i<= n1 && index <= k)
            {
                int[] max1 = GetFirstMaxIndex(arr1, i);
                int m1 = 0;
                result[index++] = max1[m1];
                m1++;
                i = result[m1];
                i = i + 1;
            }
            while(j<=n2 && index <= k)
            {
                int[] max2 = GetFirstMaxIndex(arr2, j);
                int m2 = 0;
                result[index++] = max2[m2];
                m2++;
                j = result[m2];
                j = j + 1;
            }

            return result;
            

        }
        public int[] GetFirstMaxIndex(int []arr, int start)
        {
            
            int[] res=new int[2];
            int max = 0;
            int index = 0;
            for(int i=start;i <arr.Length;i++)
            {
                 if(arr[i]>max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            int j = 0;
            res[j] = max;
            j++;
            res[j] = index;
            return res;
        }
    }
}
