using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class SplitArray
    {
        public void Split(int []arr)
        {
           
            int m = 0;

            for(int q=0;q< arr.Length;q++)
            {
                if(arr[q] > arr[q+1])
                {
                    m = q + 1;
                    break;
                }
                
            }
            int result = 0;
            int startPartOne = 0;
            int endPartOne = m - 1;
            int startPartTwo = m;
            int endPartTwo = arr.Length - 1;

            int i = startPartOne;
            int j = startPartTwo;

            while(i <= endPartOne && j<= endPartTwo)
            {
                if(arr[i] < arr[j])
                {
                    i++;
                }
                if(arr[i] > arr[j])
                {
                   
                    result++;
                    j++;
                }
            }
        }
    }
}
