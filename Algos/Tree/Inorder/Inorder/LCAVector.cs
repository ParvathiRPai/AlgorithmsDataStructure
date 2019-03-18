using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inorder
{
    class LCAVector
    {
        private List<int> path1 = new List<int>();
        private List<int> path2 = new List<int>();

        public int GetNode(Node root, int n1, int n2)
        {
            if(!FindPath(root, n1) && !FindPath(root,n2))
            {
                return -1;
            }
            int i;
            for (i = 0; i < path1.Count&& i < path2.Count; i++)
            { 
            if(path1.Contains(i)==path2.Contains(i))
                {
                    break;
                }
                return path1.Remove(i);
        }
        public bool FindPath(Node root, int n)
        {
            List<int> path = new List<int>();
            if(root== null)
            {
                return false;
            }
            path.Add(root.data);
            if(root.data==n)
            {
                return true;
            }
            if(root.left !=null && FindPath(root.left,n))
            {
                return true;
            }
            if(root.right !=null && FindPath(root.right,n) )
            {
                return true;
            }
            path.Remove(path.Count - 1);
            return false;
        }
    }
}
