using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Problem6
    {
        public class TrieNode
        {
            public Dictionary<int, TrieNode> children;
            public bool isWord;
            public TrieNode()
            {
                children = new Dictionary<int, TrieNode>();
            }
        }
        public TrieNode root;
        public Problem6()
        {
            root = new TrieNode();
        }
        public void Insert(string word)
        {
            TrieNode current = root;
            foreach(char c in word)
            {
                var key = c - 'a';
                if(!current.children.ContainsKey(key))
                {
                    current.children.Add(key, new TrieNode());
                }
                current = current.children[key];

            }
            current.isWord = true;
        }
        public bool Search(string word)
        {
            TrieNode current = root;
            foreach(char c in word)
            {
                var key = c - 'a';
                if(!current.children.ContainsKey(key))
                {
                    return false;
                }
                current=current.children[key];
            }
            return current.isWord;
        }
    }
}
