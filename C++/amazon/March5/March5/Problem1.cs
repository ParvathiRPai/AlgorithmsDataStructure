using System;
using System.Collections.Generic;
using System.Text;

namespace March5
{
    class Problem1
    {
        public int [] GetIndexForTarget(int []arr, int target)
        {
            List<int> list = new List<int>();
            int[] res = new int[2];
            for(int i=0; i<arr.Length;i++)
            {
                int temp = target - arr[i];
                if(!list.Contains(temp))
                {
                    list.Add(arr[i]);
                }
                else
                {
                    int temp1 = list.IndexOf(temp);
                    int index = 0;
                    res[index] = temp1;
                    index++;
                    res[index] = i;
                    return res;
                }

            }
            return res;
        }
    }
}
