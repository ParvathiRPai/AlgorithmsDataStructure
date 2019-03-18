using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem257
    {
        public List<string> PrintPaths(Node root)
        {
            var paths = new List<string>();
            if (root == null)
                return paths;
            var pathfound = new List<string>();
            Inorder(root, "", pathfound);
            return pathfound;
     
        }
        private void Inorder(Node root, string prefix, List<string>pathsfound)
        {
            var val = root.val;
            var next = prefix.Length == 0 ? val.ToString() : (prefix + ";" + val.ToString());
            if(root.left == null && root.right == null)
            {
                var split = next.Split(';');
                pathsfound.Add(string.Join("", split));
            }
            if (root.left != null)
                Inorder(root.left, next, pathsfound);
            if (root.right != null)
                Inorder(root.right, next, pathsfound);


        }
    }
}
