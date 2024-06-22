using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class ArrayPrograms
    {
        //Range sums
        public static List<long> rangeSum(List<int> A, List<List<int>> B)
        {
            //var arr = A.ToArray();
            var prefixSum = new List<long>();
            var output = new List<long>();
            prefixSum.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {
                var toAdd = prefixSum[i - 1] + A[i];
                prefixSum.Add(toAdd);
            }

            foreach (var col in B)
            {
                var L = col[0];
                var R = col[1];

                if (L == 0) { output.Add(prefixSum[R]); }
                else
                {
                    var toAdd = prefixSum[R] - prefixSum[L - 1];
                    output.Add(toAdd);
                }
            }
            return output;
        }

        public static List<int> prefixSumInPlace(List<int> A)
        {

            for(int i = 1; i < A.Count; i++)
            {
                A[i] = A[i - 1] + A[i];
            }
            return A;
        }

        public static int calculateSpecialIndex(List<int> A)
        {
            var prefixEvenSumArray = new int[A.Count];
            var prefixOddSumArray = new int[A.Count];

            prefixEvenSumArray[0] = A[0];
            prefixOddSumArray[0] = 0;

            for (int i = 1; i < A.Count; i++)
            {
                if (i % 2 == 0) 
                {
                    prefixEvenSumArray[i] = prefixEvenSumArray[i - 1] + A[i];
                }
                else
                {
                    prefixEvenSumArray[i] = prefixEvenSumArray[i - 1];
                }
                
            }

            for (int i = 1; i < A.Count; i++)
            {
                if (i % 2 == 1)
                {
                    prefixOddSumArray[i] = prefixOddSumArray[i - 1] + A[i];
                }
                else
                {
                    prefixOddSumArray[i] = prefixOddSumArray[i - 1];
                }
            }
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int evenIndexSum;
                int oddIndexSum;
                if (i == 0)
                {
                    evenIndexSum = prefixOddSumArray[A.Count - 1] - prefixOddSumArray[i];
                    oddIndexSum = prefixEvenSumArray[A.Count - 1] - prefixEvenSumArray[i];
                }
                else
                {
                    evenIndexSum = prefixEvenSumArray[i - 1] + (prefixOddSumArray[A.Count - 1] - prefixOddSumArray[i]);
                    oddIndexSum = prefixOddSumArray[i - 1] + (prefixEvenSumArray[A.Count - 1] - prefixEvenSumArray[i]);
                }
                if (evenIndexSum == oddIndexSum)
                {
                    count++;
                }
            }

                return count;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223209/homework/problems/9900?navref=cl_tt_lst_sl
        //Good Explanation in the below video
        //https://www.youtube.com/watch?v=XJZczN4wts0
        public static long PickFromBothSides(List<int> A, int B)
        {
            long totalSum = 0;
            long maximumSum = int.MinValue;

            List<int> prefixSum = new List<int>
            {
                A[0]
            };

            for (int i=0; i<A.Count; i++)
            {
                totalSum += A[i];
            }

            if (B == A.Count)
            {
                return totalSum;
            }


            for (int i = 1; i < A.Count; i++)
            {
                var toAdd = prefixSum[i-1] + A[i];
                prefixSum.Add(toAdd);
            }

            //We will pick the excluded items sum so that we will get 
            //the continuous elements in  a range to loop
            int startIndex = 0;
            int endIndex = A.Count - B - 1;
            while (endIndex < A.Count)
            {
                int rangeSum = 0;
                if (startIndex == 0)
                {
                    rangeSum = prefixSum[endIndex];
                }
                else {

                    rangeSum = prefixSum[endIndex] - prefixSum[startIndex - 1];
                }
                
                if(maximumSum < (totalSum - rangeSum))
                {
                    maximumSum = totalSum - rangeSum;
                }

                startIndex++;
                endIndex++;
            }

            return maximumSum;

        }

        public static long calculateSpecialSequence(string A)
        {
            A = A.ToLower();
            long calculate = 0;
            long use = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'a')
                {
                    calculate++;
                }else if (A[i] == 'g')
                {
                    use += calculate;
                }
            }

            return use;
        }
    }
}
