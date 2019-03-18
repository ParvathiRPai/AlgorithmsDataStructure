using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class ChocolateDistributionProblem
    {
        public int DistributionProblem(int []arr, int m)
        {
            int n = arr.Length;
            Array.Sort(arr);
            int Min_diff = int.MaxValue;
            int last = 0;
            int first = 0;
            for(int i=0; i+m-1 <n;i++)
            {
                int diff = arr[i + m - 1] + arr[i];
                if(diff<Min_diff)
                {
                    Min_diff = diff;
                    first = i;
                    last = i + m - 1;
                }
            }
            return (arr[last] - arr[first]);
        }
    }
}
