using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MP7
    {
        public int[] Product(int []arr)
        {
            int product = 1;
            int[] res = new int[arr.Length];
            for(int i=0; i<arr.Length;i++)
            {
                int m = i+1;
                while (m <= arr.Length - 1)
                {
                    product = product * arr[m];
                    m++;
                   
                }
                int j=0;
                while(j< i)
                {
                    product = product * arr[j];
                    j++;
                }
                res[i] = product;
                product = 1;
            }
            return res;
        }
    }
}
