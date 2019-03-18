using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class ms14
    {
        public int FindNearest(int []arr, int amount)
        {
            int min = Int32.MaxValue;
            for(int i=0; i<arr.Length;i++)
            {
                int diff = amount - arr[i];
                if(min > diff)
                {
                    min = diff;
                }
            }
            return min;
        }

    }
}
