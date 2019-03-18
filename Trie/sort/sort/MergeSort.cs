using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class QuickSort
    {
        public void Sort(int []arr, int left, int right)
        {
            int index = Quick(arr, left, right);
            if (left < index - 1)
                Sort(arr, left, index - 1);
            else if (right > index)
                Sort(arr, index, right);

        }
       public int Quick(int []arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while(left <right)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                        if(left <=right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
        
    }
}
