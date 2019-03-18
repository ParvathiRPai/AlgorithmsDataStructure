using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLinkedList
{
    class MergeSortLinkedList
    {
        public Node MergeSort(Node startNode)
        {
            Node oldNode = startNode;
            int mid = GetLength(startNode)/2;
            if(startNode.next == null)
            {
                return startNode;
            }
            while(mid-1>0)
            {
                oldNode = oldNode.next;
                mid--;
            }
            Node newNode = oldNode.next;
            oldNode.next = null;
            oldNode = startNode;
            Node index1 = MergeSort(oldNode);
            Node index2 = MergeSort(newNode);
            return MergeList(index1, index2);
        }
        public Node MergeList(Node a, Node b)
        {
            Node result = null;
            if(a==null)
            {
                return b;
            }
            if(b==null)
            {
                return a;
            }
            if(a.data >b.data)
            {
                result = b;
                result.next = MergeList(a, b.next);
            }
            else
            {
                result = a;
                result.next = MergeList(a.next, b);
            }
            return result;
        }

        public int GetLength(Node startNode)
        {
            int count = 0;
            Node head = startNode;
            while(head !=null)
            {
                count++;
                head = head.next;
            }
            return count;
        }

        public void display(Node head)
        {
            Node currNode = head;
            while (currNode != null)
            {
                Console.WriteLine("->" + currNode.data);
                currNode = currNode.next;
            }
        }
    }
}
