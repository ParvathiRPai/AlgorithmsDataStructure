using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class HeapSort
    {
        public void Sort(int []arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                HeapSort1(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                HeapSort1(arr, i, 0);
            }

        }
        public void HeapSort1(int []arr, int n, int i)
        {
            int largest = i;
            int left =2*i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;

            if(largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                HeapSort1(arr, n, largest);
            }
                 
        }
       

    }
}
