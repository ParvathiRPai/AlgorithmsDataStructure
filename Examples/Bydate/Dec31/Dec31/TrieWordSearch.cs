using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    public class TrieNode
    {
        public TrieNode[] next = new TrieNode[26];
        public string word;
    }
    class TrieWordSearch
    {
        public List<string> FindWords(char[,]board, string []words)
        {
            List<string> res = new List<string>();
            bool[,] visited = new bool[board.GetLength(0), board.GetLength(1)];
             TrieNode root = BuildTrie(words);
            for(int i=0; i<board.GetLength(0);i++)
            {
                for(int j=0; j<board.GetLength(1);i++)
                {
                    Helper(board, i, j, visited, root, res);
                }
            }
            return res;
            

        }
        public void Helper(char[,]board, int row, int col, bool [,]visited,TrieNode node, List<string>res)
        {
            if(row >= board.GetLength(0) || col>= board.GetLength(1) || row <0 || col <0 )
            {
                return;
            }
            if (visited[row, col] == true)
                return;
            char c = board[row, col];
            node =node.next[c - 'a'];
            if (node == null)
                return;
            if (node.word != null)
            {
                res.Add(node.word);
                node.word = null;
            }

            visited[row, col] = true;

            Helper(board, row + 1, col, visited, node, res);
            Helper(board, row - 1, col, visited, node, res);
            Helper(board, row, col + 1, visited, node, res);
            Helper(board, row, col - 1, visited, node, res);

            visited[row, col] = false;

        }
        private TrieNode BuildTrie(string []words)
        {
            TrieNode root = new TrieNode();
            foreach(string word in words)
            {
                TrieNode current = root;
                foreach(char c in word)
                {
                    if(current.next[c-'a'] == null)
                    {
                        current.next[c - 'a'] = new TrieNode();
                    }
                    current = current.next[c - 'a'];
                }
                current.word = word;
            }
            return root;
        }
    }
}
