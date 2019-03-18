using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS16
    {
        public int LengthofLongest(int[] arr)
        {
            int[] T = new int[arr.Length];
            for(int i=0; i<arr.Length;i++)
            {
                T[i] = 1;
            }
            for(int i=1;i<arr.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    if(arr[i]<T[j]+1)
                    {
                        T[i] = T[j] + 1;
                    }
                }
            }
            int max = 0; 
            for(int i=0; i<T.Length;i++)
            {
                if(max<T[i])
                {
                    max = T[i];
                }
            }
            return max;
        }
    }
}
