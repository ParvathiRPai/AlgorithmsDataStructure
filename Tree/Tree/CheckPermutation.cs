using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class CheckPermutation
    {
        public bool IsPermuatation(string s, string t)
        {
            char[] c1 = s.ToCharArray();
            char[] c2 = t.ToCharArray();
            int[] set = new int[128];
            foreach(char ch in c1)
            {
                set[(int)ch]++;
                
            }
            foreach(char ch in c2)
            {
                set[(int)ch]--;
                if(set[(int)ch] <0 )
                {
                    return false;
                }

            }
            return true;
        }
    }
}
