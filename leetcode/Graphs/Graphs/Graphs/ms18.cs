using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class ms18
    {
       
        public int Combinations(int []arr, int target)
        {
            if (target < 0)
                return 0;
            if (target == 0)
                return 1;
            else
            {
                int res = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    res += Combinations(arr, target - arr[i]);
                }
                return res;
            }
         
        }
      
    }
}
