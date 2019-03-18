using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class Subsets
    {
        public void FindPowerSet(int []s, List<int> outs, int i)
        {
            if(i <0)
            {
                return;
            }

            outs.Add(s[i]);
            FindPowerSet(s, outs, i - 1);
            outs.Remove(outs.Count - 1);
            while(i >0 && s[i]==s[i-1])
            {
                i--;
            }
            FindPowerSet(s, outs, i - 1);
        }
    }
}
