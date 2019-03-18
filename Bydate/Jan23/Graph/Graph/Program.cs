using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Problem7 p = new Problem7();
            //    p.Prime(10);
            //Problem7 g = new Problem7(4);
            //g.addEdge(0, 1);
            //g.addEdge(0, 2);
            //g.addEdge(0, 3);
            //g.addEdge(2, 0);
            //g.addEdge(2, 1);
            //g.addEdge(1, 3);
            //g.BFS();


            //Problem4 p = new Problem4(2);
            //int res=p.ShortestPath(1033, 8197);

            //int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            //                          { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            //                          { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            //                          { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            //                          { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            //                          { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            //                          { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            //                          { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            //                          { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            //GFG t = new GFG();
            //t.dijkstra(graph, 0);
            //Problem9 graph = new Problem9(4);
            //graph.addEdge(0, 1);
            //graph.addEdge(0, 2);
            //graph.addEdge(1, 2);
            //graph.addEdge(2, 0);
            //graph.addEdge(2, 3);
            //graph.addEdge(3, 3);
            //bool res=graph.IsCyclic();

            Problem10 p = new Problem10();
            int[] arr = { 1, 0, 2, 1, 0, 2 };
            p.Dutch(arr);


        }
    }
}
