using System;
using System.Collections.Generic;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v0 = new Vertex(0);
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            v2.outedges.Add(v3);
            v3.outedges.Add(v3);
            v2.outedges.Add(v0);
            v0.outedges.Add(v2);
            v0.outedges.Add(v1);
            v1.outedges.Add(v2);
            Vertex star = v2;
            Vertex end = v3;
            HashSet<Vertex> v = new HashSet<Vertex>();
            Graph g = new Graph();
            bool res = g.BFS(star, end,v);


            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
