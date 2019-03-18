using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class DutchNationalFlagProblem
    { 
        public void Sort(int []arr)
        {
            int low = 0;
            int end = arr.Length-1;
            int pivot = 1;
            int mid = 0;
            while(mid <= end)
            {
                if(arr[mid]< pivot)
                {
                    swap(arr, low, mid);
                    ++low;
                    ++mid;
                }
                else if(arr[mid]>pivot)
                {
                    swap(arr, mid, end);
                       --end;
                }
                else
                {
                    ++mid;
                }
            }
           
        }
        public void swap(int []arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
