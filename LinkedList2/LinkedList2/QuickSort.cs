using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class QuickSort
    {
        public void Quick(int []arr, int low, int high)
        {
            int index = partion(arr, low, high);
            if (low < index - 1)
                Quick(arr, low, index - 1);
            if (index < high)
                Quick(arr, index, high);

        }
        public int partion(int[]arr, int low , int high)
        {
            int pivot = arr[0];
            while(low<=high)
            {
                while (arr[low] < pivot)
                    low++;
                while (pivot < arr[high])
                    high--;
                if(low<=high)
                {
                    swap(arr,low, high);
                    low++;
                    high--;
                }

            }
            return low;
        }
        public void swap(int []arr, int low, int high)
        {
            int temp = low;
            low = high;
            high = temp;
        }

        public int Power(int a, int n)
        {
            if (n == 0)
                return 1;
            int x = Power(a, n / 2);

                if(n%2 ==0)
            {
                return (x * x);
            }
                else
            {
                return (a * x * x);
            }
        }
    }
}
