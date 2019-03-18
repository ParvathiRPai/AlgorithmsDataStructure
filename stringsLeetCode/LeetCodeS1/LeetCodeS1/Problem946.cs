using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem946
    {
        public int Unique(int[] arr)
        {
            List<int> unique = new List<int>();
    
            int i = 0;
            int count = 0;
      
            while(i < arr.Length)
            { 
                if (!unique.Contains(arr[i]))
                {
                    unique.Add(arr[i]);
                    i++;
                }
                else 
                {
                   
                    count++;
                    arr[i] = arr[i] + 1;
                }
            }
            return count;
        }
    }
}
