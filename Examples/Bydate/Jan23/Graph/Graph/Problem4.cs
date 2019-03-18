using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Problem4
    {
        public int vertices;
        public List<int>[] adj;
        public Problem4(int v)
        {
            vertices = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdge(int u, int w)
        {
            adj[u].Add(w);
        }
        public HashSet<int> Prime(int n)
        {

            var set = new HashSet<int>();
            bool[] isPrime = new bool[n + 1];
            for (int i = 0; i < n; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i] == true)
                {
                    for (int p = i * i; p <= n; p += i)
                    {
                        isPrime[p] = false;
                    }
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (isPrime[i] == true)
                    set.Add(i);
            }
            return set;
        }
        public bool Compare(int num1, int num2)
        {
            string s1 = num1.ToString();
            string s2 = num2.ToString();
            int count = 0;
            if (s1[0] != s2[0])
                count++;
            if (s1[1] != s2[1])
                count++;
            if (s1[2] != s2[2])
                count++;
            if (s1[3] != s2[3])
                count++;
            if (count == 1)
                return true;
            else
                return false;
        }
        public int ShortestPath(int num1, int num2)
        {
            HashSet<int> set = Prime(9999);
            int n = set.Count;
            int index1 = 0, index2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Compare(set.ElementAt(i), set.ElementAt(j)))
                    {
                        AddEdge(i, j);
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                if (set.ElementAt(j) == num1)
                    index1 = j;
            }
            for (int i = 0; i < n; i++)
            {
                if (set.ElementAt(i) == num2)
                    index2 = i;
            }
            int res = BFS(index1, index2);
            return res;
        }
        public int BFS(int index1, int index2)
        {
            int[] visited = new int[vertices];
            for (int i = 0; i < vertices; i++)
            {
                visited[i] = 0;
            }
            var Q = new Queue<int>();
            visited[index1] = 1;
            Q.Enqueue(index1);
            while (Q.Count > 0)
            {
                int temp = Q.Peek();
                Q.Dequeue();
                foreach(int i in adj[temp])
                {
                    if(visited[i] != 1)
                    {
                        visited[i] = visited[temp] + 1;
                        Q.Enqueue(i);
                    }
                    if(i == index2)
                    {
                        return visited[i] - 1;
                    }
                }
            }
            return -1;

        }
    }
}
