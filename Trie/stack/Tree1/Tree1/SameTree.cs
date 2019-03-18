using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class SameTree
    {
        public bool SameTrees(Node start1, Node start2)
        {
           if(start1==null && start2==null)
            {
                return true;
            }
            if (start1 == null || start2 == null)
            {
                return false;
            }
            if(start1.data==start2.data)
            {
                return SameTrees(start1.left, start2.left) && SameTrees(start1.right, start2.right);
            }
            else
            {
                return false;
            }
        }
    }
}
