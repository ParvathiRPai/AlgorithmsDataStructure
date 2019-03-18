using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class CatlanNumber
    {
        public int FindNumberofTrees(int n)
        {
            int[] T = new int[n+1];
            T[0] = 1;
            T[1] = 1;
            for(int i=2;i<=n;i++)
            {
                for(int j=1; j<=i; j++)
                {
                    T[i] += T[j - 1] * T[i - j];
                }
            }
            return T[n];
        }
    }
}
