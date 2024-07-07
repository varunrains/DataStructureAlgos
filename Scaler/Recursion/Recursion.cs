using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal static class Recursion
    {
        public static void Print1toA(int A)
        {
            Print1toARec(A);
            Console.WriteLine();
        }

        public static int FindFactorialRec(int A)
        {
            if(A == 0)
            {
                return 1;
            }

            return FindFactorialRec(A - 1) * A;
        }

        public static int FindFibonacci(int A)
        {
            if (A == 1)
            {
                return 1;
            }else if (A <= 0)
            {
                return 0;
            }

            return FindFibonacci(A - 1) + FindFibonacci(A - 2);
        }

        private static void Print1toARec(int A)
        {
            if (A == 0)
            {
                return;
            }

            Print1toARec(A - 1);
            Console.Write(A + " ");
        }

        public static int Bar(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return x + Bar(x, y - 1);
        }

        public static int Foo(int x, int y)
        {
            if(y== 0) return 1;
            
            return Bar(x, Foo(x,y-1));
        }
    }
}
