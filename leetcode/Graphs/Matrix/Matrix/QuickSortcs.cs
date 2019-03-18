using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class QuickSortcs
    {
        public void QuickSort(int []arr, int left, int right)
        {
            int index = Partition(arr, left, right);
            if(left<index-1)
            {
                QuickSort(arr, left, index - 1);
            }
            else
            {
                QuickSort(arr, index, right - 1);
            }
        }
        public int Partition(int []arr, int left, int right)
        {
            int mid = (left + right) / 2;
            while(left <=right)
            {
                while (arr[left] < arr[mid]) left++;
                while (arr[right] > arr[mid]) right--;
                if( left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
