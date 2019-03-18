using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 3, E = 3;
            Graph g = new Graph(v, E);
            g.edge[0].src = 0;
            g.edge[0].dst = 1;

            g.edge[1].src = 1;
            g.edge[1].src = 2;

            g.edge[2].src = 0;
            g.edge[2].dst = 2;


            if (g.Iscycle(g) == 1)
            {
                Console.WriteLine("cycle");
            }
            else
            { 
                Console.WriteLine("no cycle");
            }

        }
    }
}
