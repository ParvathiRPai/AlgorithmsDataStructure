using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MP3
    {
        public  int MaxProfit(int []arr)
        {
            int min = Int32.MaxValue;
            int maxprofit = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
                if(arr[i]-min> maxprofit)
                {
                    maxprofit = arr[i] - min;
                }
            }
            return maxprofit;
        }
    }
}
