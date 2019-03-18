using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MSP5
    {
        public bool Duplicates(int []arr)
        {
            HashSet<int> s = new HashSet<int>();
            for(int i=0; i<arr.Length;i++)
            {
                if(s.Contains(arr[i]))
                {
                    return true;
                }
                else
                {
                    s.Add(arr[i]);
                }
            }
            return false;
        }
    }
}
