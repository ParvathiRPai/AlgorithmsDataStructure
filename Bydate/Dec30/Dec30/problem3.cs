using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    class problem3
    {
        public int LongestIncresingSubsequence(int []arr)
        {
            int[] T = new int[arr.Length];
            for(int i=0; i< arr.Length;i++)
            {
                T[i] = 1;
            }
            for(int i=1;i<arr.Length;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(arr[j]<arr[i])
                    {
                        if(T[j]+1 > T[i])
                        {
                            T[i] = T[j] + 1;
                        }
                    }
                }
            }
            int max = 0;
            for(int m=0; m<= T.Length-1;m++)
            {
                if(arr[m]> max)
                {
                    max = T[m];
                }
            }
            return max;
        }
    }
}
