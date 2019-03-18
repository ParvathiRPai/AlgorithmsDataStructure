using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS22
    {
        public int Longest(string s, int k)
        {
            int realK = k;
            int i = 0;
            int j = 0;
            int count = 0;
            int max = 0;
            int globalmax = 0;
            while (i < s.Length && j < s.Length && count <=k)
            {
                if(s[i]==s[j])
                {
                    j++;
                    max++;
                    globalmax = Math.Max(max, globalmax);
                }
                else if(s[i]!=s[j])
                {
                    if(count <= k)
                    {
                        count++;
                        k--;
                        j++;
                        max++;
                        globalmax = Math.Max(max, globalmax);
                    }
                    else if(count == k)
                    {
                        i++;
                        count =0;
                        max = 0;
                        k = realK;
                        j = i;
                    }
                }
                
            }
            return globalmax;
        }
    }
}
