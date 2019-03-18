using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class TreeNode
    {
        public int val;
        public TreeNode left,right;
        public TreeNode(int val)
        {
            this.val = val;
        }

    }
    class CatlanExpansion
    {
        public List<TreeNode> GenerateTrees(int n)
        {
            if(n==0)
            {
                return new List<TreeNode>();
            }
            return Generate_trees(1, n);
        }
        public List<TreeNode>Generate_trees(int start,int end )
        {
            List<TreeNode> all_trees = new List<TreeNode>();
            if(start >end)
            {
                all_trees.Add(null);
                return all_trees;
            }
            for(int i=start; i<end;i++)
            {
                List<TreeNode> left_trees = Generate_trees(start, i - 1);
                List<TreeNode> right_trees = Generate_trees(i + 1, end);
                foreach(TreeNode l in left_trees)
                {
                    foreach(TreeNode r in right_trees)
                    {
                        TreeNode current = new TreeNode(i);
                        current.left = l;
                        current.right = r;
                        all_trees.Add(current);
                    }
                }

            }
            return all_trees;
        }
    }
}
