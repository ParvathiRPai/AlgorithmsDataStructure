using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem863
    {
        public List<int> DistanceK(Node root, Node target, int k)
        {
           List<int> res = new List<int>();
           Dictionary<Node, Node> map = new Dictionary<Node, Node>();
           FindParent(root, null, map);
            HashSet<Node> visit = new HashSet<Node>();
           DFS(target, k, res, map, visit);
            return res;
        }
        public void FindParent(Node root, Node parent, Dictionary<Node,Node> map)
        {
            if(root==null)
            {
                return;
            }
            map.Add(root, parent);
            FindParent(root.left, root, map);
            FindParent(root.right, root, map);
        }
        public void DFS(Node target, int k, List<int> res, Dictionary<Node,Node> map, HashSet<Node> visit)
        {
            if(target==null || k < -1 || visit.Contains(target))
            {
                return;
            }
            if(k==0)
            {
                res.Add(target.val);
                return;
            }
            visit.Add(target);
            DFS(target.left, k - 1, res, map, visit);
            DFS(target.right, k - 1, res, map, visit);
            DFS(map[target], k - 1, res, map, visit);

        }
        
    }
}
