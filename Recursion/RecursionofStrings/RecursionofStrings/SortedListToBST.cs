using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    public class ListNode
    {
        public ListNode next;
        public int val;
        public ListNode(int val)
        {
            this.val = val;
        }
    }
    public class TreeNode
    {
        public TreeNode left, right;
        public int val;
        public TreeNode(int val)
        {
            this.val = val;
        }
    }
    class Solution
    {
        private List<int> val;
        public Solution()
        {
            this.val = new List<int>();
        }
        private void mapListToVAlues(ListNode head)
        {
            while(head != null)
            {
                val.Add(head.val);
                head = head.next;
            }
        }
        private TreeNode ConvertToBST(int left, int right)
        {
            if(left >right)
            {
                return null;
            }
            int middle = (left + right) / 2;
            TreeNode node = new TreeNode((middle));
            
            if(left==right)
            {
                return node;
            }
            node.left = ConvertToBST(left, middle - 1);
            node.right = ConvertToBST(middle + 1, right);
            return node;

        }
        public TreeNode SortedListtoBST(ListNode head)
        {
            this.mapListToVAlues(head);
            return ConvertToBST(0, this.val.Count - 1);
        }
    }
}
