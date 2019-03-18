using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class BitwiseXor
    {
        public int Xor(int []arr)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> pre = new HashSet<int>();
            HashSet<int> current;
            foreach(int i in arr)
            {
                current = new HashSet<int>();
                current.Add(i);
                foreach( int j in pre)
                {
                    current.Add(i | j);
                    set.Add(i | j);
                }
                pre = current;
            }
            return set.Count();
        }
    }
}
