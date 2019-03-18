using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class BSTcs
    {
        public bool BST(Node start, int Num)
        {
            if(start.data==Num)
            {
                return true;
                
            }

                if (start.data < Num)
                   return  BST(start.left, Num);
                if (start.data > Num)
                   return   BST(start.right, Num);
            
            return false;
        }
    }
}
