using System;
using System.Collections.Generic;
using System.Text;

namespace PrimsAlgorithm
{
    class minkey
    {
        public int Minkey(int []key,bool[]set, int verticescount)
        {
            int min = int.MaxValue, minIndex = 0;
            for(int v=0; v<verticescount;v++)
            {
                if( key[v]<min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }
        public void print( int []parent, int[, ]g, int verticescount)
        {
            Console.WriteLine("edge and weight");
            for (int i = 1; i < verticescount; i++)
                Console.Write("{0}-{1} {2}"parent[i],i, g[i, parent[i]]);
                }

    }
}
