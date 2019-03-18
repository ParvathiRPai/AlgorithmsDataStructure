using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS13
    {
        public int ClimbStairs(int n)
        {
            return NumberofWays(0, n);
        }
        public int NumberofWays(int i, int n)
        {
            if (i > n)
                return 0;
            if (i == n)
                return 1;
            return NumberofWays(i + 1, n) + NumberofWays(i + 2, n);
        }
    }
}
