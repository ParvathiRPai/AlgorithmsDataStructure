using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS12
    {
        public int FindArea(int []arr)
        {
            int max = 0;
            int l = 0;
            int h = arr.Length - 1;
            while(l < h)
            {
                max = Math.Max(max, Math.Min(arr[l], arr[h]) * (l - h));
                if(arr[l]<arr[h])
                {
                    l++;
                }
                else
                {
                    h--;
                }
            }
            return max;
        }
    }
}
