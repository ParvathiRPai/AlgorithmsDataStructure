using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class quicksort
    {
        public void Quick(int []arr, int left, int right)
        {
            int index = partion(arr, left, right);
           
            if (left < index - 1)
               Quick(arr, left, index - 1);
            if (index < right)
                Quick(arr, index, right);
        }
        public int partion(int []arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while(left <= right)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                if(left<=right)
                {
                    int temp = left;
                    left = right;
                    right = temp;
                    left++;
                    right--;
                }

            }
            return left;
        }
    }
}
