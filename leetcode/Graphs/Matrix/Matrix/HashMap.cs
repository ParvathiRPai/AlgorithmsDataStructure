using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Hashset
    {
        private int size = 100;
        private int[] hashmap { get; set; }
        public Hashset()
        {
            hashmap = new int[size];
            for(int i=0; i<size;i++)
            {
                hashmap[i] = -1;
            }
        }
        public void Put(int key , int value)
        {
            if(key < 0|| key>size || value<0 || value>size )
            {
                return;
            }
            hashmap[key] = value;
        }
        public int Search(int key, int value)
        {
            if(key <0 || key>size)
            {
                return -1; 
            }
            return hashmap[key];
        }
        public void Delete(int key)
        {
            hashmap[key] = -1;
        }

    }
}
