using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevesringKthNodeofLinkedList
{
    class FindTarget
    {
        public int GetIndexofTargetNumber(int []arr, int target)
        {
      
            int mid = arr[arr.Length / 2];
            int midindex = arr.Length / 2;
            if(mid==target)
            {
                return target;
            }
            if(mid<target)
            {
                for(int i=midindex+1;i<arr.Length;i++)
                {
                    if(arr[i]==target)
                    {
                        return i;
                    }
                   
                }
            }
            else if(mid >target)
            {
                for(int i=0; i<midindex-1; i++)
                {
                    if(arr[i]==target)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
