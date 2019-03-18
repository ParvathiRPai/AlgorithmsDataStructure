using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS9
    {
        public int RemoveDuplicates(int []arr)
        {
            List<int> l = new List<int>();
            for(int i=0; i<arr.Length;i++)
            {
                if(!l.Contains(arr[i]))
                {
                    l.Add(arr[i]);
                }
            }
            return l.Count;
        }
    }
}
