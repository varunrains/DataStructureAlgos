using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class QuickSortWithComparator
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/235854/assignment/problems/64?navref=cl_tt_lst_nm
        public static string LargestNumber(List<int> A)
        {
            StringBuilder res = new StringBuilder(A.Count);
            var comp = new Compararer();
            int sum = 0;
            A.Sort((x, y) => { return comp.Compare(x, y); });
            for (int i = 0; i < A.Count; i++)
            {
                sum += A[i];
                res.Append(A[i]);
            }
           if(sum == 0) return 0.ToString();
            return res.ToString();
        }


        //https://www.scaler.com/academy/mentee-dashboard/class/235854/assignment/problems/27473?navref=cl_tt_lst_nm
        public static List<int> FactorsSort(List<int> A)
        {
            QuickSort(A, 0, A.Count - 1);
            return A;
        }

        public static List<int> FactorsSortUsingInbuilt(List<int> A)
        {
            var comparer = new CompararerForFactors();
            A.Sort((x, y) =>  comparer.Compare(x, y));
            return A;
        }

        private static int NumberOfFactors(int A)
        {
            int res = 0;
            for (int i = 1; i <= A; i++)
            {
                if (A % i == 0)
                {
                    res++;
                }
            }

            return res;
        }


        private static int PartitionIndex(List<int> A, int L, int R)
        {
            var pivot = L;
            L = L + 1;
            var factorOfL = NumberOfFactors(A[L]);
            var factorOfR = NumberOfFactors(A[R]);
            var factorOfPivot = NumberOfFactors(A[pivot]);

            while (L <= R)
            {
                if (factorOfL < factorOfPivot)
                {
                    L++;
                }
                else if (factorOfR > factorOfPivot) 
                {
                    R--;
                }else if (factorOfL == factorOfR)
                {
                    if (A[L] < A[pivot])
                    {
                        L++;
                    }
                    else if(A[R] > A[pivot])
                    {
                        R--;
                    }
                    else
                    {
                        var temp2 = A[L];
                        A[L] = A[R];
                        A[R] = temp2;
                        L++;
                        R--;
                    }
                }
                else
                {
                    var temp = A[L];
                    A[L] = A[R]; 
                    A[R] = temp;
                    L++;
                    R--;
                }
            }

            var temp1 = A[pivot];
            A[pivot] = A[R];
            A[R] = temp1;

            return R;
        }

        private static void QuickSort(List<int> A, int L, int R)
        {
            if (L >= R) return;
            var pivot = PartitionIndex(A, L, R);
            QuickSort(A, L, pivot-1);
            QuickSort(A, pivot+1, R);
        }


    }

    public  class Compararer : System.Collections.IComparer
    {
        public int Compare(object a, object b)
        {
            var x = a.ToString() + b.ToString();
            var y = b.ToString() + a.ToString();

            if (long.Parse(x) > long.Parse(y)) return -1;
            else if (long.Parse(x) < long.Parse(y)) return 1;
            else return 0;
        }

    }

    public class CompararerForFactors : System.Collections.Generic.IComparer<int>
    {
        public int Compare(int a, int b)
        {
            var x = NumberOfFactors(a);
            var y = NumberOfFactors(b);

            if (x < y) return -1;
            else if (x > y) return 1;
            else if(x == y)
            {
                return a - b;
            }
            else
            {
                return 0;
            }
        }

        private static int NumberOfFactors(int A)
        {
            int res = 0;
            int sqrt = (int)Math.Sqrt(A);

            for (int i = 1; i <= sqrt; i++)
            {
                if (A % i == 0)
                {
                    res++;
                    if (i != A / i)
                    {
                        res++;
                    }
                }
            }
            return res;
        }

    }
}
