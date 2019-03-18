using System;
using System.Collections.Generic;
using System.Text;

namespace FindMinelement
{
    class Findminelesortedarr
    {
        public  int FindMin(int []arr,int start,int end)
        {
            int middle = (int) ((end-start+1) / 2);
           if(start==end)
            {
                return arr[start];
            }
           if( end-start==1)
            {
                return Math.Min(arr[start], arr[end]);
     
            }

            int minleft =FindMin(arr, start, middle);
            int minRight=FindMin(arr, middle + 1, end);
            return Math.Min(minleft,minRight);


        }
    }
}
