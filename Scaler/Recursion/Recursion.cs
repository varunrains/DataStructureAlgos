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

        public static void DecAndThenInc(int A)
        {
            DecRec(A);
            IncRec(A);
            Console.WriteLine();
        }

        public static int BarTest(int x,int y)
        {
            if(y == 0)
                return 0;
            return x + BarTest(x, y-1);
        }

        public static int FooTest(int x, int y)
        {
            if(y == 0)
            {
                return 1;

            }
            return BarTest(x , FooTest(x,y-1));
        }

        private static void DecRec(int A)
        {
            if (A == 0)
            {
                return;
            }
            Console.Write(A + " ");
            DecRec(A - 1);
        }

        private static void IncRec(int A)
        {
            if (A == 0)
            {
                return;
            }
            IncRec(A - 1);
            Console.Write(A + " ");
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235828/homework/problems/10754?navref=cl_tt_lst_nm
        public static int SumOfDigits(int A)
        {
            int sum = 0;
            var res = SumOfDigitsRec(A, sum);
            return res;
        }

        private static int SumOfDigitsRec(int A, int sum)
        {
            if (A == 0)
            {
                return sum;
            }
            var unitPlace = A % 10;
            sum += unitPlace;

            //if(A/10 == 0)
            //{
            //    sum += A;
            //}

            return SumOfDigitsRec(A/10,sum);
           // return sum;
        }



    }
}
