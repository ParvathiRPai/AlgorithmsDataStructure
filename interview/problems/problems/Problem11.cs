using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem11
    {
        public void LessThan(int []arr, int N)
        {
            
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i] < N)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
