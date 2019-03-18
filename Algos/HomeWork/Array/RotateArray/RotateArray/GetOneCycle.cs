using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class GetOneCycle
    {
        public int[] OneCycle(int []arr)
        {
            int n = arr.Length;
            int temp = arr[0];
            int[] result = new int[arr.Length];
            for(int i=1;i<arr.Length;i++)
            {
                result[i-1] = arr[i];
            }
            int removeZero = arr[arr.Length-1];
            result[arr.Length-1] = temp;
            return result;
        }
    }
}
