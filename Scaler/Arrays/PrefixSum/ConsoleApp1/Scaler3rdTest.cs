using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static ArraysDSA.Scaler3rdTest;

namespace ArraysDSA
{
    public static class Scaler3rdTest
    {
        public static List<string> IncreasingOrder(List<string> A)
        {
            var comp = new Compararer();
            A.Sort((x, y) => { return comp.Compare(x, y); });
            return A;
        }

        public static List<string> IncreasingOrderDiff(List<string> A)
        {
            return A.OrderBy(x => x.Length).ToList();
        }

        public static int CheckIfStringCanBeConvertedToPalidrome(string A)
        {
            var hashMap = new Dictionary<string, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (hashMap.ContainsKey(A[i].ToString()))
                {
                    hashMap[A[i].ToString()]++;
                }
                else
                {
                    hashMap.Add(A[i].ToString(), 1);
                }
            }

            int counter = 0;
            foreach (var key in hashMap)
            {
                if (key.Value % 2 != 0)
                {
                    counter++;
                }
            }

            if (A.Length % 2 == 0 && counter == 0)
            {
                return 1;
            }
            else if (A.Length % 2 != 0 && counter <= 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public static List<List<int>> ClosesPointFromOrigin(List<List<int>> A, int B)
        {
            var comp = new CompararerForPointOrigin();
            A.Sort(comp);
            return A.Take(B).ToList();
        }

        public static int PairSum(int A, List<int> B)
        {
            var hashSet = new HashSet<int>();

            for (int i = 0; i < B.Count; i++)
            {
                if (hashSet.Contains(A - B[i]))
                {
                    return 1;
                }

                if (!hashSet.Contains(B[i]))
                {
                    hashSet.Add(B[i]);
                }

            }

            return 0;

        }

        public static int CheckIfStringCanBeConvertedToPalindromeAfterMultipleSwaps(string A)
        {
            var hashMap = new Dictionary<char, int>();

            foreach (var str in A)
            {

                if (hashMap.ContainsKey(str))
                {
                    hashMap[str]++;
                }
                else
                {
                    hashMap[str] = 1;
                }
            }

            var isOddLength = A.Length % 2 == 1;
            var alreadyOneOdd = false;
            foreach (var hash in hashMap)
            {
                //one odd number count is allowed
                if (isOddLength)
                {
                    var isOdd = hash.Value % 2 == 1;
                    if (isOdd && !alreadyOneOdd)
                    {
                        alreadyOneOdd = true;
                    }
                    //No more than 1 odd is allowed as it is even string
                    else if(isOdd && alreadyOneOdd)
                    {
                        return 0;
                    }
                }
                else
                {
                    var isOdd = hash.Value % 2 == 1;
                    if (isOdd)
                    {
                        return 0;
                    }
                }

            }

            return 1;
        }

        //public static string LargestNumber(List<int> A)
        //{

        //}


        public class Comparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                var a = x.Length;
                var b = y.Length;

                //When a -b is 0, the array might still get reordered internally
                //    because this method doesn’t explicitly maintain the original order for strings of the same length.
                //Instead, you should use the CompareTo method, which ensures a safe and clear comparison.
                //    Here's the correct implementation:
                return a - b;
            }
        }


        public class ComparerForEuclid : IComparer<List<int>>
        {
            public int Compare(List<int> x, List<int> y)
            {
                int a = x[0] * x[0] + x[1] * x[1];
                int b = y[0] * y[0] + y[1] * y[1];

                return a - b;
            }
        }
    }
}
