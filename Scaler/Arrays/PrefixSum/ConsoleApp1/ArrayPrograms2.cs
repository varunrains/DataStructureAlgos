using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class ArrayPrograms2
    {
        public static List<List<int>> GenerateSubArrays(List<int> A)
        {
            var result = new List<List<int>>();

            for (int start = 0; start < A.Count; start++)
            {
                for (int end = start; end < A.Count; end++)
                {
                    var subArray = new List<int>();

                    for (int printer = start; printer <= end; printer++)
                    {
                        subArray.Add(A[printer]);
                    }
                    result.Add(subArray);
                }
            }
            return result;
        }

        public static List<int> GenerateSubArraysInRange(List<int> A, int B, int C)
        {
            var result = new List<int>();

            for (int start = B; start <= C; start++)
            {
                result.Add(A[start]);

                
            }
            return result;
        }

        public static int CountUniqueSubarrays(List<int> A)
        {
            var result = new List<List<int>>();
            int count = result.Count;
            for (int start = 0; start < A.Count; start++)
            {
                for (int end = start; end < A.Count; end++)
                {
                    var subArray = new List<int>();

                    for (int printer = start; printer <= end; printer++)
                    {
                        subArray.Add(A[printer]);
                    }
                    result.Add(subArray);
                }
            }
            Dictionary<string, int> counterMap = new Dictionary<string, int>();
            for (int i= 0; i < result.Count; i++)
            {

                for (int j = 0; j < result[i].Count; j++)
                {
                    if (!counterMap.ContainsKey(result[i][j].ToString()))
                    {
                        counterMap.Add(result[i][j].ToString(), 1);
                    }
                    else
                    {
                        counterMap[result[i][j].ToString()]++;
                        break;
                    }    
                   if(j== result[i].Count - 1)
                    {
                        count++;
                    }
                    
                }

                counterMap.Clear();
                
            }
            return count;
        }

        public static int CountingSubArrays(List<int> A, int B)
        {
            int subArrayCount = 0;
            for (int l = 0; l < A.Count; l++)
            {
                int sum = 0;

                for (int r = l; r < A.Count; r++)
                {
                    sum += A[r];
                    if (sum < B)
                    {
                        subArrayCount++;

                    }
                }
            }
            return subArrayCount;
        }

        public static int MinimumSwaps(List<int> A, int B)
        {
            int swaps = 0;
            int counter = 0;
            for(int l=0;l<A.Count;l++)
            {
                if (A[l] <= B && counter != l)
                {
                    var temp = A[l];
                    A[l] = A[counter];
                    A[counter] = temp;
                    swaps++;
                    counter++;
                }
            }

            return swaps;

        }

        public static int SubArrayWithGivenSumAndLength(List<int> A, int B, int C)
        {
            //This can be solved by sliding window as the size of the sub-array is given to us

            //First find the first subarray sum
            if (A.Count == 1 && A[0] == C)
                return 1;

            int sum = 0;
            for (int i = 0; i < B; i++)
            {
                sum += A[i];

            }
            if (sum == C) return 1;

            //Actual sliding window starts

            for (int l = B; l < A.Count - 1; l++)
            {
                int r = l - B;
                sum = sum + (A[l] - A[r]);
                if (sum == C)
                {
                    return 1;
                }
            }
            return 0;
        }

    }
}


