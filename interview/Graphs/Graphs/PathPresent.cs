using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class PathPresent
    {
        public bool IsPathPresent(Node root, int sum)
        {
            
            return Path(root, sum);
        }
        public bool Path(Node root, int sum)
        {
            if (root == null)
                return false;
            sum -= root.val;
            if(sum==0)
            {
                return true;
            }
            return Path(root.left, sum) || Path(root.right, sum);
        }
    }
}
