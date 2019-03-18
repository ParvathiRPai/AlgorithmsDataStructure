using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan22
{
    class Problem4
    {
        public int FindPeak(int []arr)
        {
            int i = 0;
            
            while(i<arr.Length)
            {
                if(arr[i]<arr[i+1])
                {
                    i++;
                }
                else
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
