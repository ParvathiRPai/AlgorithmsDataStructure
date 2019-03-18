using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem917
    {
        public char[]  Reverse(string s)
        {
            char[] c = s.ToCharArray();
            int i = 0;
            int j = c.Length-1;
            char temp;
            while(i<j && j>i)
            {
                if(c[i]=='-')
                {
                    i++;
                }
                if(c[j]=='-')
                {
                    j--;
                }
                temp = c[i];
                c[i] = c[j];
                c[j] = temp;
                i++;
                j--;
            }
            return c;
        }
    }
}
