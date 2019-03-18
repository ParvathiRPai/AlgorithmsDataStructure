using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Problem4
    {
        public Node Tree(int []inOrder, int []PostOrder)
        {
            int pre = 0;
            int post = 0;
            int preEnd = inOrder.Length;
            int postEnd = PostOrder.Length;
            return TreeTraversal(inOrder, PostOrder, pre, post,preEnd,postEnd);
        }
        private Node TreeTraversal(int []inOrder, int []PostOrder, int pre, int post, int preEnd, int postEnd)
        {
            if (pre > preEnd && post > postEnd)
                return null;

            Node n = new Node(PostOrder[postEnd-1]);
            int k = 0;
            for(int i=0; i<inOrder.Length;i++)
            {
                if(inOrder[i]==n.val)
                {
                    k = i;
                    break;
                }
            }
            n.left = TreeTraversal(inOrder, PostOrder, k - 1, post, preEnd, postEnd);
                return n; 

            
        }
    }
}
