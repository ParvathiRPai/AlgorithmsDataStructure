using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    class MS1
    {

        public int[] GetTarget(int []arr, int target)
        {
            List<int> l = new List<int>();
            int[] res=new int[2];
            int index = 0;
            for(int i=0; i<arr.Length;i++)
            {
                int temp = target - arr[i];
                if(!l.Contains(temp))
                {
                    l.Add(arr[i]);
                }
                else
                {
                    res[index] = i;
                    index++;
                    int tempI=GetIndex(arr, temp);
                    res[index] = tempI;
                }
            }

            return res;
        }
        public int GetIndex(int []arr, int temp)
        {
            for(int i=0; i<arr.Length;i++)
            {
                if(arr[i]==temp)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
