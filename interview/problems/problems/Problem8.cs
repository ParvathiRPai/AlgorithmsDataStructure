using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem8
    {
        public int[] MergeSortedArrays(int []arr1, int []arr2)
        {
            int count = 0; 
            for(int i=0; i < arr1.Length;i++)
            {
                if(arr1[i] != -1)
                {
                    count++;
                }
            }
            int l1 = arr1.Length - 1;
            int l2 = arr2.Length-1;
            int temp = count - 1;
            int LastIndex = l1 + l2-3;
            while(l2>=0)
            {
                if(l1>=0 && arr1[temp] >arr2[l2])
                {
                    arr1[LastIndex] = arr1[temp];
                    temp--;
                }
                else
                {
                    arr1[LastIndex] = arr2[l2];
                    l2--;
                }
                LastIndex--;
            }
            return arr1;
        }
    }
}
