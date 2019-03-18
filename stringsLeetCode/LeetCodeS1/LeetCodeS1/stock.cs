using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class stock
    {
        public int MaxProfit(int []arr)
        {
            int min = 2147483647;
            int max = 0; 
            for(int i=0; i< arr.Length;i++)
            {
                if( min > arr[i])
                {
                    min = arr[i]; 
                }
                else if(arr[i]-min>max)
                {
                    max =arr[i]-min;
                }
            }
            return max;
        }
    }
}
