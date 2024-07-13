using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal static class Recursion2
    {
        
        //https://www.scaler.com/academy/mentee-dashboard/class/235826/assignment/problems/122782?navref=cl_tt_lst_nm
        public static void PrintArrayRec(List<int> A)
        {
            int len = 0;
            PrintArrayUsingRecursion(A, len);
            Console.WriteLine();
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/assignment/problems/201?navref=cl_tt_nv
        public static int Power(int A, int B, int C)
        {
            long res = PowerRec(A, B,C);
          
            //res = res % C;
            return (int)res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/assignment/problems/122783?navref=cl_tt_lst_sl
        public static int MaxInArray(List<int> A)
        {
            var greatestValue = A[0];
            var res = MaxInArrayRec(A,greatestValue,1);
            return res;
        }

        public static int MaxInArrayRec(List<int> A,int value, int len)
        {
            if (len == A.Count)
            {
                return value;
            }
            else if (A[len] > value)
            {
                value = A[len];
            }

            return MaxInArrayRec(A,value,len+1);
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/assignment/problems/10764?navref=cl_tt_lst_nm
        public static int CheckPalindrome(string A)
        {
            int right = A.Length - 1;
            int left = 0;
            var res = CheckPalindromeRec(A, right, left);
            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/assignment/problems/101467?navref=cl_tt_lst_nm
        public static List<int> AllTheIndices(List<int> A, int B)
        {
            var res = new List<int>();
            res = AllTheIndicesRec(A,res, B, 0);
            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/homework/problems/10359?navref=cl_tt_lst_nm
        public static int MagicNumber(int A)
        {
            var res = MagicNumberRec(A, 0);
            return res;
        }

        private static int MagicNumberRec(int A, int res)
        {
            if(A != 1 && A < 10 && res ==0)
            {
                return 0;
            }else if(A == 1 && A < 10 && res == 0) 
            { return 1; }

            res += A % 10;
            A = A / 10;

            if (A == 0)
            {
                A = res;
                res = 0;
            }

            return MagicNumberRec(A, res);
        }
        private static List<int> AllTheIndicesRec(List<int> A, List<int> res, int B, int len)
        {
            if (len == A.Count)
            {
                return res;
            }

            if(A[len] == B)
            {   
                res.Add(len);
            }

            return AllTheIndicesRec(A, res, B, len + 1);
        }

        private static int CheckPalindromeRec(string A,int right, int left)
        {
            if (A[left] != A[right])
            {
                return 0;
            }
            else if (left >= right )
            {
                return 1;
            }

             return CheckPalindromeRec(A, right - 1, left + 1); ;
        }

        private static long PowerRec(int A, int B, int C)
        {
            if (B == 0)
            {
                return 1 %C;
            }

            long cache = PowerRec(A, B / 2,C) % C;
            cache = (cache * cache) % C;

            if (B % 2 == 1)
            {
               cache = (cache * A) % C;
            }

            //To handle negative values
            //Only in phython this is handled well in other languages the value for 
            //negative mod is negative which is not correct
            //To make it positive you need to add C
            cache = (cache + C) % C;

            return cache;

        }


        private static void PrintArrayUsingRecursion(List<int> A, int len)
        {
            if (len == A.Count)
            {
                return;
            }

            Console.Write(A[len]+" ");
            PrintArrayUsingRecursion(A, ++len);
        }
    }
}
