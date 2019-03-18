using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MP4
    {
        public int GetMAxSum(int []arr)
        {
            int sum = 0;
            int max = Int32.MinValue;
           
            for(int i=0; i<arr.Length;i++)
            {
                sum = sum + arr[i];
               if(arr[i] > sum)
                {
                    sum = arr[i];
                }
               if(max<sum)
                {
                    max = sum;
                }

            }
            return max;
        }
    }
}
