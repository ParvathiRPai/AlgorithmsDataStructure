using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MSP2
    {
        public int[] FindTarget(int []arr, int target)
        {
            List<int> set = new List<int>();
            int[] resut = new int[3];
            for(int i=0; i<arr.Length;i++)
            {
                int res = target - arr[i];
                if (!set.Contains(res))
                {
                    set.Add(arr[i]);
                }
                else
                {
                    int index = 0;
                    resut[index] = i;
                    int temp1 = set.IndexOf(res);
                    index++;
                   resut[index] = temp1;
                }
            }
            return resut;
        }
    }
}
