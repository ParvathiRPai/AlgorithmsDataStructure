using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem66
    {
        public int[] AddPlusOne(int []arr)
        {
        
            int carry = 1;
            for(int i=arr.Length-1; i >= 0;i--)
            {
                
                int sum= arr[i] + carry;
                if(sum < 10)
                {
                    arr[i] = sum;
                    return arr;
                 
                }
                else
                {
                    arr[i] = 0;
                    carry = 1;
                }
                
            }
            if (carry == 1 && arr[0] == 0)
            {
                int[] newDigits = new int[arr.Length - 1];
                for (int j = 1; j < arr.Length; j++)
                {
                    newDigits[j + 1] = arr[j];
                    newDigits[0] = 1;
                    return newDigits;
                }
            }
            return arr;

        }
    }
}
