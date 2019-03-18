using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MoveZeroToEnd
    {
        public int[] ZeroEnd(int []arr)
        {
            Queue<int> q = new Queue<int>();
            int zeros = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    zeros++;
                }
                else
                {
                    q.Enqueue(arr[i]);
                }
            }
            int[] res = new int[arr.Length];
            int m = 0;
            while(q.Count >0)
            {
                int r = q.Dequeue();
                res[m] = r;
                m++;
            }
            return res;
           
        }
    }
}
