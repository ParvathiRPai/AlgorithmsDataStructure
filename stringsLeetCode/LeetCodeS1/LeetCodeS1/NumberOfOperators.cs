using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LeetCodeS1
//{
//    class NumberOfOperators
//    {
//        public int MakeTargetNumberDivisible(int x, int target)
//        {
//            while(target % x!=0)
//            {
//                target = target - 1;
//            }
//            return target;
//        }
//        public int GetNumberOfOperators(int N, int target)
//        {
//            int count = 0;
//            int res = 0;
//           while(N != target)
//            {
//                res = res + N * N;
//                N = target - N * N;
//            }
//        }
//    }
//}
