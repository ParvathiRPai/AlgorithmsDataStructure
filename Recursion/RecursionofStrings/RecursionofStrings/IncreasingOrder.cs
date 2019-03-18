using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class IncreasingOrder
    {
        public void Increasing(int start, string outs, int n)
        {
            if(n==0)
            {
                bool res = CheckIfIncreasing(outs);
                if (res == true)
                {
                    Console.WriteLine(res);
                    return;
                }
                
            }
            for(int i=0; i<=9; i++)
            {
                string str = outs + Convert.ToInt32(i);
                Increasing(i + 1, str, n - 1);
            }
        }

        public bool CheckIfIncreasing(string outs)
        {
            char[] ch = outs.ToCharArray();
 

             for(int i=0; i<outs.Length;i++)
            {
                if (ch.Length == 1)
                {
                    return true;
                }
                if (outs[i]<outs[i+1])
                {
                    return true;
                }
               
            }
            return false;
        }


    }
}
