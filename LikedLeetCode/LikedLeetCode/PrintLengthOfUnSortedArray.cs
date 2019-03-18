using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class PrintLengthOfUnSortedArray
    {
        public void PrintUnsortedIndeces(int []arr)
        {
            int index1 = 0;
            int n = arr.Length;
            int index2 = n;
            for (int i=0; i<n;i++)
            {
                if(arr[i] <arr[i+1])
                {
                    index1++;
                }
                else
                {
                    break;
                }
            }
            for(int j=n-1; j >0; j--)
            {
                if(arr[j]>arr[j-1])
                {
                    index2--;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
