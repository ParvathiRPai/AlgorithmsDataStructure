using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class S3
    {
        public int MaxProfit1(int []arr)
        {
            int max = 0; 
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=1; j<arr.Length;j++)
                {
                    int profit = arr[j] - arr[i];
                    if(profit>max)
                    {
                        max = profit;
                    }
                }
            }
            return max;
        }
        public int MaxProfit2(int []arr)
        {
            int min = Int32.MaxValue;
            int max = 0; 
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
                if(arr[i]-min>max)
                {
                    max = arr[i]-min;
                }
            }
            return max;
        }
        public int MaxProfit3(int []arr, int k)
        {
            List<int> l = new List<int>();
            int valley = arr[0];
            int peak = arr[0];
            int max = 0;
            int i = 0; 
            while(i<arr.Length-1)
            {
                while (i < arr.Length - 1 && arr[i] >= arr[i + 1])
                    i++;
                valley = arr[i];
                while (i < arr.Length - 1 && arr[i] <= arr[i + 1])
                    i++;
                peak = arr[i];

                max = peak - valley;
                l.Add(max);
            }
            List<int> globalMax = l.OrderBy(x => x).ToList();
            int res = 0;
            int index = 0;
            while(index < k)
            {
                res += globalMax[globalMax.Count - 1];
                index++;
            }

            return res;
        }
    }
}
