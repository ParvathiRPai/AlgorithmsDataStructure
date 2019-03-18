using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(1);
            n.next = new Node(2);
            n.next.next = new Node(3);
            n.next.next.next = new Node(4);
            n.next.next.next.next = new Node(5);
            n.next.next.next.next.next = new Node(6);
            //n.next.next.next.next.next.next = new Node(1);
            int k = 3; 
            SortKthElement s = new SortKthElement();
            //s.SortKth(n, k);

            //RemoveDuplicates r = new RemoveDuplicates();
            //r.DeleteMiddle(n);
            //int[] arr = { 10, 16, 8, 12, 6, 3, 9, 5 };
            //QuickSort q = new QuickSort();
            //q.Quick(arr, 0, arr.Length - 1);
            //for(int i=0; i<arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}
            //Console.ReadKey();
            QuickSort q = new QuickSort();
            int a = 2;
             int m = 3;
            int res=q.Power(a, m);
            Console.WriteLine(res);




        }
    }
}
