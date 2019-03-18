using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class SumofPairs
    {
        public void Pairs(int []arr, int sum)
        {
            List<int> m = new List<int>();
            for(int i=0; i<arr.Length;i++)
            {
                int temp = sum - arr[i];
                if(m.Contains(temp))
                {
                    Console.WriteLine(arr[i] +" , "+ temp);
                }
                m.Add(arr[i]);
            }
        }
    }
}
