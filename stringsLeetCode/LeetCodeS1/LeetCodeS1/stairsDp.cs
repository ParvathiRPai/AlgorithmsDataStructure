using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class stairsDp
    {
        public int Stairs(int N)
        {
            return FindStairs(N, 0);
        }
        public int FindStairs(int N, int i)
        {
            if (i > N)
                return 0;
            if (i == N)
                return 1;
            return FindStairs(N, i + 1) + FindStairs(N, i + 2);
        }
    }
}
