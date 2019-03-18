using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class RobDp
    {
        public int Rob(int []arr)
        {
            int n = arr.Length;
            return Rbob(arr, n-1);
        }
        public int Rbob(int[] arr, int n)
        {
            if (n < 0)
            {
                return 0;
            }
            return Math.Max(Rbob(arr, n - 2) + arr[n], Rbob(arr, n - 1));
        }
    }
}
