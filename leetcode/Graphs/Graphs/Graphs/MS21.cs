using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS21
    {
        public int MaxLength(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int i = 0;
            int j = 0;
            int count = 0;
            int max = 0;
            while (i < s.Length && j<s.Length)
            {
                if(!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    count++;
                    max = Math.Max(count, max);
                }
                else
                {
                    set.Clear();
                    i++;
                    j = i;
                    count = 0;
                }
            }
            return max;
        }
    }
}
