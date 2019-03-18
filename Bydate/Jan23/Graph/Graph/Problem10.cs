using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem10
    {
        public int[] Dutch(int []arr)
        {
            int pivot = 1;
            int mid = 0;
            int low = 0;
            int high = arr.Length-1;
            while(mid <= high)
            {
                if(arr[mid]<pivot)
                {
                    Swap(arr,low, mid);
                    low++;
                    mid++;
                    
                }
                else if(arr[mid]> pivot)
                {
                    Swap(arr, mid, high);
                    --high;
                }
                else
                {
                    mid++;
                }
            }
            return arr;
        }
        public void Swap( int []arr,int low, int high)
        {
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;
        }
    }
}
