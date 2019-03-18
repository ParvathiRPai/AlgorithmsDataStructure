using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan22
{
    class Problem1
    {
        public int[] Sum(int[] arr, int target)
        {
            List<int> l = new List<int>();
            int[] res = new int[2];
            int index = 0;
            for(int i=0; i<arr.Length;i++)
            {
                int temp = target - arr[i];
                if (!l.Contains(temp))
                {
                    l.Add(arr[i]);
                }
                else
                {
                    res[index] = i;
                    index++;
                    res[index] = l.IndexOf(temp);
                    break;
                }
            }
            return res;
        }
    }
}
