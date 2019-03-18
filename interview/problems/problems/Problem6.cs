using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem6
    {
        public void GetPair(int []arr, int sum)
        {
           
            HashSet<int> s = new HashSet<int>();
            for(int i=0; i<arr.Length;i++)
            {
                int temp = sum - arr[i];
                if(temp >0 && s.Contains(temp))
                {
                    Console.WriteLine("Pair with given sum " +
                          sum + " is (" + arr[i] +
                               ", " + temp + ")");
                }
                s.Add(arr[i]);
            }
        }
    }
}
