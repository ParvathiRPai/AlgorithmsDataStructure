using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class MS4
    {
        public List<List<int>> ThreeSum(int []arr)
        {
            List<List<int>> l = new List<List<int>>();
            List<int> l1 = new List<int>();
            for(int i=0; i<arr.Length;i++)
            {
                for(int j=i+1; j<arr.Length-1;j--)
                {
                    int res = -(arr[i] + arr[i + 1]);
                    bool found = IsFound(arr, res);
                    l1.Add(arr[i]);
                    l1.Add(arr[i + 1]);
                    l1.Add(res);
                    if (found == true && !l.Contains(l1))
                    {
                        l.Add(new List<int>(new int[] { res, arr[i], arr[i + 1] }));
                    }
                    l1.Clear();
                }
            }
            return l;
        }
        public bool IsFound(int []arr,int res)
        {
            for(int i=0; i< arr.Length;i++)
            {
                if(arr[i]==res)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
