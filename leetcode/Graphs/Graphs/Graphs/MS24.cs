using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS24
    {
        public bool IsAnagram(string s, string t)
        {
            char[] cs = s.ToCharArray();
            char[] ts = t.ToCharArray();

            Array.Sort(cs);
            Array.Sort(ts);
            for(int i=0; i<s.Length;i++)
            {
                if(cs[i]!=ts[i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
