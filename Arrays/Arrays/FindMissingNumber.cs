using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class FindMissingNumber
    {
        public int MissingNumber(int[] arr)
        {
            int min = arr.Min();
            int max = arr.Max();
            
            for(int i=min;i<max;i++)
            {
             bool res = FindElement(arr, i); 
                if(!res)
                {
                    return i;
                }

            }
            return 0;
        }
        public bool FindElement(int []arr, int i)
        {
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[j]==i)
                {
                    return true;
                }
            }
            return false;
        }
      

    }
}
