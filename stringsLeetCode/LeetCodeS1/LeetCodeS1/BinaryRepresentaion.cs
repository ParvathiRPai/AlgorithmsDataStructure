using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class BinaryRepresentaion
    {
        public int Binary(int num)
        {
            int[] arr = new int[4];
            int index = 0;
            int count = 0;
            while (num >= 1)
            {
                if (num % 2 == 1)
                {
                    count++;
                    arr[index++] = 1;
                    num = num / 2;
                }
                if (num % 2 == 0)
                {
                    arr[index++] = 0;
                    num = num / 2;
                }
              
            }
            return count;
        }
        public int[] ReturnCollection(int num)
        {
            int[] res = new int[num + 1];
            
            for(int i=1;i <=num;i++)
            {
                res[i] = Binary(i);  
            }
            return res;
        }
    }
}
