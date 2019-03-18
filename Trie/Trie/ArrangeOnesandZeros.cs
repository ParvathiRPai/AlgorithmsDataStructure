using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class ArrangeOnesandZeros
    {
        public void Sort(int []arr)
        {
            int start1 = 0;
            int end1 = arr.Length-1;
            int start2 = arr.Length-1;
            int end2 = 0;
            int index1 = 0;
            int index2 = arr.Length-1;
            while(start1<=end1 && end2<=start2)
            {
               if(arr[index1]==0 && arr[index2]==1)
                {
                    index1++;
                    index2--;
                }
               else if(arr[index1]==1 && arr[index2]==0)
                {
                    Swap(arr[index1], arr[index2]);
                    index1++;
                    index2--;
                }
               else if(arr[index1]==0 && arr[index2]==0)
                {
                    index1++;
                }
                else if (arr[index1] == 1 && arr[index2] == 1)
                {
                    index2--;
                }

            }
        }
        public void Swap(int index1,int index2)
        {
            int temp = index1;
            index1 = index2;
            index2 = temp;
        }
    }
}
