using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS20
    {
        public bool Jump(int []arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > max) { return false; }
                max = Math.Max(arr[i] + i, max);
            }
            return true;

        }
    }
}
