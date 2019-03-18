using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class SumofSubsets
    {
        public void Sum(int []set, int l, int r, int sum=0)
        {
            if(l > r)
            {
                Console.WriteLine(sum);
                return;
            }
            Sum(set, l + 1, r, sum + set[l]);
            Sum(set, l + 1, r, sum);
           

        }
    }
}
