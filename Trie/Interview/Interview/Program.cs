using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse r = new Reverse();
            string str = "There is sun again";
            r.reverseSentence(str);
            Console.ReadKey();
        }
    }
}
