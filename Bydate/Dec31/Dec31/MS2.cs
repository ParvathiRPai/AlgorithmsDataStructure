using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS2
    {
        public long SToI(string Num)
        {
            long res = 0;
            var sign = 1;
            Num = Num.Trim();
            int index = 0;
            if(Num[0]=='+' || Num[0]=='-')
            {
                sign = Num[0] == '+' ? '+' : '-';
                index++;
            }
            while(index<Num.Length)
            {
                res = res * 10 + Num[index]-'0';
                index++;
      
            }
            return sign*res;

        }
    }
}
