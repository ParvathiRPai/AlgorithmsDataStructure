using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS3
    {
        public int RomanToInt(string s)
        {
            int n = s.Length;
            Dictionary<char, int> d = new Dictionary<char, int>()
            {
                {'I',1 },
                { 'V',5 },
                { 'X',10 },
                { 'L',50},
                { 'C',100},
                { 'D',500 },
                { 'M',1000 },

            };
            int res = d[s[n - 1]];
            for(int i=n-2;i>=0;i--)
            {
                int current = d[s[i]];
                int post = d[s[i + 1]];
                if(current < post)
                {
                    res -= current;
                }
                else
                {
                    res += current;
                }

            }
            return res;

        }
    }
}
