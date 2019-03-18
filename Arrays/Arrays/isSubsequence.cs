using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class isSubsequence
    {
        public Boolean FindIfSubsequence(string str1, string str2)
        {
            if(str1.Length==0  && str2.Length==0)
            {
                return true;
            }
            int i=0, j = 0;
           while(i < str1.Length && j<str2.Length)
            {
                if(str1[i]==str2[j])
                {
                    ++i;
                    ++j;
                }
                else
                {
                    i++;
                }
            }
            return j == str2.Count();
        }
    }
}
