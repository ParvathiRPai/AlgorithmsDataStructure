using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class WithoutConsecutiveOnes
    {
        public void CountStrings(int n, string outs, int last)
        {
             if(n==0)
            {
                Console.WriteLine(outs);
                return;
            }
            CountStrings(n - 1, outs + '0', 0);
            if (last == 0)
                CountStrings(n - 1, outs + '1', 1);
        }

    }
}
