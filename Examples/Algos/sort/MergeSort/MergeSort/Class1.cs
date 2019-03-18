using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort 
    {
        static void MergSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergSort(input, low, middle);
                MergSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }

        }
            
    }
}
