using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class MaxLengthofSubArray
    {
        public int MaxLength( int []arr1, int []arr2)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            while(i<arr1.Length && j < arr2.Length)
            {
                if(arr1[i] !=arr2[j])
                {
                    i++;
                }
                else if(arr1[i]==arr2[j])
                {
                    count++;
                    i++;
                    j++;
                }
            }

            return count;

        }
    }
}
