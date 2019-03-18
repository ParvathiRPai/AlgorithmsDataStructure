using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class NonIncreasingOrder
    {
        public void GetAllNumbers(int x, int []arr, int currentSum, int CurrentIndex)
        {
            if(x==currentSum)
            {
                Print(arr, CurrentIndex);
                return;
            }
            int num = 1;
            while(num < x-currentSum && (CurrentIndex ==0 || num < arr[CurrentIndex-1]))
            {
                arr[CurrentIndex] = num;
                GetAllNumbers(x, arr, currentSum + num, CurrentIndex + 1);
                num++;
            }
        }
        public void Print(int[] arr, int currentIndex)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadKey();
            }
            
        }
    }
}
