using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS10
    {
        public int StrStr(string hay, string needle)
        {
           
            for(int i=0; i<needle.Length;i++)
            {
                for(int j=0; j<hay.Length;j++)
                {
                    if(needle[i]==hay[j])
                    {
                        return j;
                    }
                }
            }
            return -1;
        }
    }
}
