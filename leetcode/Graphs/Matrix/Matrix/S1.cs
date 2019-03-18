using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class S1
    {
        public int Candies(int []arr)
        {
            int[] candies = new int[arr.Length];
             for(int i=0; i<arr.Length;i++)
            {
                candies[i] = 1;
            }
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < arr.Length; i++)
                {
                   
                    if (i != arr.Length-1 && arr[i] > arr[i + 1] && candies[i] <= candies[i + 1])
                    {
                        candies[i] = candies[i + 1] + 1;
                        flag = true;
                    }
                    else if (i >0  && arr[i] > arr[i - 1] && candies[i] <= candies[i - 1])
                    {
                        candies[i] = candies[i - 1] + 1;
                        flag = true;
                    }
                }
            }
            int sum = 0;
            for(int i=0; i<candies.Length;i++)
            {
                sum += candies[i];
            }
            return sum;
        }
    }
}
