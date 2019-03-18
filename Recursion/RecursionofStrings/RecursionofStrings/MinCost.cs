using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class MinCost
    {
        public int Min(int x, int y, int z)
        {
            if (x < y)
            {
                return (x < z) ? x : z;
            }
            else
            {
                return (y < z) ? y : z;
            }
        }
        public int FindMinDistance(int [ , ]set, int m, int n)
        {
            if (n < 0 || m < 0)
                return Math.Min(n, m);
            else if (m == 0 && n == 0)
                return set[m,n];
            else
                return set[m,n]+Min(FindMinDistance(set, m - 1, n - 1), FindMinDistance(set, m, n - 1), FindMinDistance(set, n - 1, m));
        }
    }
}
