using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class PathPresent2
    {
        List<List<int>> result = new List<List<int>>();
        public List<List<int>> PathPresent(Node start, int target)
        {
            List<int> l = new List<int>();
            Path(start, target, l);
            return result;

        }
        private void Path(Node start, int target, List<int> list)
        {
            if (start == null)
                return;
            var l = new List<int>();
            l.Add(start.val);
            if(start.left != null && start.right != null && start.val==target)
            {
                result.Add(new List<int> (l));
            }
            if (start.left != null)
                Path(start.left, target - start.val, l);
            if (start.right != null)
                Path(start.right, target - start.val, l);

        }
    }
}
