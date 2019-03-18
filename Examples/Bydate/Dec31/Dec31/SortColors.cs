using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class SortColors
    {

        public int[] Sort(int[] arr)
        {
            int low = 0;
            int MidV = 1;
            int mid = 0;
            int n = arr.Length - 1;
            int high = arr.Length - 1;
            int temp = 0;
            while(mid<=high)
            {
                if(arr[mid]<=MidV)
                {
                    temp = arr[mid];
                    arr[mid] = arr[low];
                    arr[low] = temp;
                    mid++;
                    low++;
                }
                else if(arr[mid] > MidV)
                {
                    temp = arr[mid];
                    arr[mid] = arr[high];
                    arr[high] = temp;
                    high--;
                }
                else
                {
                    mid++;
                }
            }
            return arr;
           
        }
        public void Swap(int i, int j)
        {
            int temp = 0;
            temp = i;
            i= j;
            i = temp;
        }
       
     } 
}

