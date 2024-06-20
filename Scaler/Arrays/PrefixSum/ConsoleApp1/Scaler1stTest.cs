using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Scaler1stTest
    {
        //First one was the string toggle

        //Given the window size find the minimum sub-array average
        //They had given the network engineer problem but it boils down to the window size
        public static int FindtheMinimumAverageSubArray(List<int> A, int B, int C)
        {
            int sum = 0;
            //Find the avg of first window of size B
            for (int i = 0; i < B; i++)
            {
                sum += A[i];
            }
            int minimumSum = sum;

            //Move the window
            for (int i = 1; i < A.Count - B; i++)
            {
                int l = i-1;
                int r = i + B -1;
                sum += A[r] - A[l];
                minimumSum = Math.Min(minimumSum, sum);
            }
            var avg = minimumSum / B;
            if(avg < C)
            {
                return 1;
            }
            return 0;
            //If result is less than C then return 1 else 0
        }

        //Positive In range problem with Q queries to find and return an output
        public static List<int> PositiveInRangeWithQQueries(List<int> A, List<List<int>> B)
        {
            var prefixSum = new List<int>();
            var outputArray = new List<int>();
            if (A[0] >= 0)
            {
                prefixSum.Add(1);
            }
            else
            {
                prefixSum.Add(0);
            }
            for (int i = 1; i < A.Count; i++)
            {
                var toAdd = A[i] >= 0 ? prefixSum[i-1]+1 : prefixSum[i - 1];
                prefixSum.Add(toAdd);
            }

            //The queries are in matrix so each row in a matrix is a range of days to find
            foreach (var item in B)
            {
                var l = item[0];
                var r = item[1];

                if (l == 0)
                {
                    outputArray.Add(prefixSum[r]);
                }
                else
                {
                    outputArray.Add(prefixSum[r] - prefixSum[l - 1]);
                }
            }

            return outputArray;

        }
    }
}
