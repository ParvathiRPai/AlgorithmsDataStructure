using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class SortLinkedList
    {
        public Node Merge(Node start1, Node start2)
        {
            Node result = null;
            if (start1 == null)
                return start2;

            if (start2 == null)
                return start1;
            if (start1.data > start2.data)
            {
                result = start2;
                result.next = Merge(start1.next, start2);

            }
            else if (start2.data > start1.data)
            {
                result = start1;
                result.next = Merge(start1, start2.next);
            }
            return result;

        }
        public Node MergeSort(Node start)
        {
            Node oldHead = start;
            int mid = Length(start) / 2;
            while (mid - 1 > 0)
            {
                oldHead = oldHead.next;
                mid--;
            }
            Node newHead = oldHead.next;
            oldHead.next = null;
            oldHead = start;
            Node t1 = MergeSort(oldHead);
            Node t2 = MergeSort(newHead);
            return Merge(t1, t2);

        }
        public int Length(Node start)
        {
            int count = 0;
            while (start != null)
            {
                start = start.next;
                count++;
            }
            return count;
        }

        public bool IsUnique(string str)
        {
            HashSet<char> map = new HashSet<char>();
            foreach (char c in str)
            {
                if (map.Contains(c))
                {
                    return false;
                }
                else
                {
                    map.Add(c);
                }
            }
            return true;

        }

        public void MostFrequent(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    dic[arr[i]] = 1;
                }
            }
           
        }
        public void GetSymmetricPairs(int [][]arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0; i< arr.Length; i++)
            {
                int first = arr[i][0];
                int second = arr[0][i];
                int val = map.ContainsKey(second);
            }
        }
    }


}
