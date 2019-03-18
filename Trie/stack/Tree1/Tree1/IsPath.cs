using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class IsPath
    {
        public Node LCA(Node root, Node n1, Node n2)
        {
            if(root==null)
            {
                return null;
            }
            if(n1==null || n2==null)
            {
                return null;
            }
            if(root==n1 || root==n2)
            {
                return root;
            }
            Node leftl = LCA(root.left, n1, n2);
            Node rightr = LCA(root.right, n1, n2);
            if(leftl!=null && rightr !=null)
            { return root; }
            if(leftl == null && rightr == null)
                {
                return null;
            }
           return  leftl != null ? leftl : rightr; 
        }
    }
}
