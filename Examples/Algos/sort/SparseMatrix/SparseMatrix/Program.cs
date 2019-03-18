using System;

namespace SparseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10,10];
            Console.WriteLine("rows");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("colums");
            int c = int.Parse(Console.ReadLine());
            int count = 0;
            Console.Write("Input elements in the first matrix :\n");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            if (count >( (r * c) / 2))
            {
                Console.WriteLine("sparse");
            }
            else
            {
                Console.WriteLine("not sparse");
            }

            Console.ReadKey();
        }
    }
}
