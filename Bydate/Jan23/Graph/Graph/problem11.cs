using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Node
    {
        public int key;
        public int val;
        public Node next;
        public Node prev;
        public Node(int key, int val)
        {
            this.key = key;
            this.val = val;
        }

    }
    class LRUCache
    {
        private int capacity,count;
        private Dictionary<int, Node> dic;
        private Node head, tail; 
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            dic = new Dictionary<int, Node>();
            head = new Node(0, 0);
            tail = new Node(0, 0);
            head.next = tail;
            tail.prev = head;
            head.prev = null;
            tail.next = null;
            count = 0;
        }
        public void DeleteNode(Node node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }
        public void AddHead(Node node)
        {
            node.next = head.next;
            node.next.prev = node;
            node.prev = head;
            head.next = node;
        }
        public int Get(int key)
        {
            if(dic.ContainsKey(key))
            {
                Node node = dic[key];
                int result = node.val;
                DeleteNode(node);
                AddHead(node);
                return result;
            }
            return -1;
        }
        public void Set(int key, int val)
        {
            if(dic.ContainsKey(key))
            {
                Node node = dic[key];
                node.val = val;
                DeleteNode(node);
                AddHead(node);
            }
            else
            {
                Node node = new Node(key, val);
                dic.Add(key, node);
                if(count <capacity)
                {
                    count++;
                    AddHead(node);
                }
                else
                {
                    dic.Remove(tail.prev.key);
                    DeleteNode(tail.prev);
                    AddHead(node);
                }
            }
        }
    }
}
