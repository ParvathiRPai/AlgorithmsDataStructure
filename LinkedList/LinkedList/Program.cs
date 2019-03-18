using System;

namespace LinkedList
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Node first = new Node { value = 5 };
            Node middle = new Node { value = 6 };
            first.next = middle;
            Node last = new Node { value = 8 };
            middle.next = last;
            Print(last);
        }
        public static void Print( Node node)
        {
            while(node!=null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
            Console.ReadKey();
        }
    }

}
