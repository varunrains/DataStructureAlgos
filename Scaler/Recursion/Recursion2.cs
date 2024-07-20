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

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/assignment/problems/15010?navref=cl_tt_lst_nm
        public static List<List<int>> TowerOfHanoi(int A)
        {
            var res = new List<List<int>>();
            TowerOfHanoiRec(A, 1,2,3, res);
            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/homework/problems/122826?navref=cl_tt_lst_nm
        public static int FirstIndex(List<int> A, int B)
        {
            var res = FirstIndexRec(A, B, 0);
            return res;
        }

        private static int FirstIndexRec(List<int> A, int B, int len)
        {
            if(len== A.Count)
            {
                return -1;
            }

            if (A[len] == B)
            {
                return len;
            }

            return FirstIndexRec(A, B, len+1);

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235826/homework/problems/122847?navref=cl_tt_lst_nm
        public static int FindLastIndex(List<int> A, int B)
        {
            var res = FindLastIndexRec(A, B, A.Count-1);
            return res;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/267764/homework/problems/5840?navref=cl_tt_lst_nm
        // A%M  = B%M
        public static int GreatestPossiblePositiveInteger(int A, int B)
        {
            return Math.Abs(A - B);
        }


        //https://www.scaler.com/academy/mentee-dashboard/class/267764/assignment/problems/9103?navref=cl_tt_lst_nm
        public static int DeleteOneToGetMaxiumGCD(List<int> A)
        {
            var suffixArrayGCD = new int[A.Count];
            var prefixArrayGCD = new int[A.Count];

            prefixArrayGCD[0] = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                prefixArrayGCD[i] = FindGcdRec(prefixArrayGCD[i - 1], A[i]);
            }

            suffixArrayGCD[A.Count-1] = A[A.Count-1];
            for(int i=A.Count-2; i >= 0; i--)
            {
                suffixArrayGCD[i] = FindGcdRec(suffixArrayGCD[i+1], A[i]);
            }
            int ans = suffixArrayGCD[1]; //let this be the excluding A[0]
            for(int i=1; i < A.Count-1; i++)
            {
                ans = Math.Max(ans, FindGcdRec(prefixArrayGCD[i-1], suffixArrayGCD[i+1]));
            }
            ans = Math.Max(ans, prefixArrayGCD[A.Count - 2]);//excluding A[n-1]

            return ans;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/267764/assignment/problems/4745/?navref=cl_pb_nv_tb
        public static int ModularSum(List<int> A)
        {
            //var frequencyArr = new int[1000];
            Dictionary<int,int> map = new Dictionary<int,int>();

            for (int i = 0; i < A.Count; i++)
            {
                if (map.ContainsKey(A[i]))
                {
                    map[A[i]]++;
                }
                else
                {
                    map.Add(A[i], 1);
                }
                
            }

            int ans = 0;
            int mod = 1000000007;
            for(int i = 1; i <= 1000; i++)
            {
                for(int j=1; j <= 1000; j++)
                {
                    var val = i % j;
                    var val1 = 0;
                    var val2 = 0;
                    _ =  map.TryGetValue(i, out val1);
                    _ = map.TryGetValue(j, out val2);
                    var temp = val1 * val2 * val;
                    ans = ((ans % mod) + (temp % mod)) % mod;
                }
            }

            return ans;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/267764/assignment/problems/4110?navref=cl_tt_lst_nm
        public static int PairSumDivisibleByM(List<int> A, int B)
        {
            int ans = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0; i<A.Count; i++)
            {
                int x = (A[i] % B) % 1000000007;
                int y = (B - x)%B;
                ans = (ans + map.GetValueOrDefault(y)) % 1000000007;
                if (map.ContainsKey(x))
                {
                    map[x]++;
                }
                else
                {
                    map.Add(x, 1);
                }
            }

            return ans;
        }
        public static int FindGcd(int A, int B)
        {
            var res = FindGcdRec(A, B);
            return res;
        }

        private static int FindGcdRec(int A, int B)
        {
            if(B==0)
            {
                return A;
            }
            //A%B will always be less than B-1, so swap it 
            return FindGcdRec(B, A % B);
        }

        private static int FindLastIndexRec(List<int> A, int B, int len)
        {
            if(len < 0)
            {
                return -1;
            }
            if (A[len] == B)
            {
                return len;
            }
            return FindLastIndexRec(A, B, len - 1);
        }

        private static void TowerOfHanoiRec(int D, int A, int B, int C, List<List<int>> res)
        {
            if(D == 1)
            {
                res.Add(new List<int>() {D,A,C});
                return;
            }

            TowerOfHanoiRec(D-1,A,C,B,res);
            res.Add(new List<int>() { D, A, C });
            TowerOfHanoiRec(D - 1, B, A, C, res);
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
