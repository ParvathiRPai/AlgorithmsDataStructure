using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class LongestFibanociiSequence
    {
        public int LengthFib(int []arr)
        {
            HashSet<int> h = new HashSet<int>();
            foreach(int i in arr)
            {
                h.Add(i);
            }
            int ans = 0;
            for(int i=0; i < arr.Length;i++)
            {
                for(int j=i+1; j< arr.Length;j++)
                {
                    int x = arr[j];
                    int y = arr[j] + arr[i];
                    int length = 2;
                    while(h.Contains(y))
                    {
                        int temp = y;
                        y += x;
                        x = temp;
                        ans = Math.Max(ans, ++length);
                    }
                }
            }
            return ans >= 3 ? ans : 0;
        }
    }
}
