using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Scaler2ndTest
    {
        public static int RainWaterTrap(List<int> A)
        {
            var leftMinArray = new int[A.Count];
            var rightMaxArray = new int[A.Count];
            leftMinArray[0] = A[0];
            rightMaxArray[A.Count - 1] = A[A.Count - 1];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] > leftMinArray[i-1])
                {
                    leftMinArray[i] = A[i];
                }
                else
                {
                    leftMinArray[i] = leftMinArray[i-1];
                }
            }

            for (int i = A.Count - 2; i >= 0; i--)
            {
                if (A[i] > rightMaxArray[i+1])
                {
                    rightMaxArray[i] = A[i];
                }
                else
                {
                    rightMaxArray[i] = rightMaxArray[i+1];
                }
            }
            int ans = 0;
            for (int i = 0; i < A.Count; i++)
            {
                ans += Math.Min(leftMinArray[i], rightMaxArray[i]) - A[i];
            }

            return ans;

        }

        //This took me around 45 mins as i just blindly started implementing 
        //kadane's algorithm, please read the question and constraint carefully before answering
        //as that could lead to clue on how to find the answer.
        public static long MaxPossibleSumOfAnArray(List<int> A)
        {
            long ans = int.MinValue;
            long sum = A[0];

            for (int i = 1; i < A.Count; i++)
            {
               
                if (A[i] <= A[i - 1])
                {
                    if (ans < sum)
                    {
                        ans = sum;
                    }
                    sum = 0;
                }
                sum += A[i];

                if (ans < sum)
                {
                    ans = sum;
                }
            }

            return ans;
        }

        public static List<int> NumberofXORPairs(List<int> A, List<int> B)
        {
            var res = new List<int>();
            for(int i = 0; i < B.Count; i++)
            {
                int setBits = 0;
                int unSetBits = 0;
                for(int j=0;j<A.Count; j++)
                {
                    if ((A[j] & (1 << B[i])) != 0){
                        setBits++;
                    }
                    else
                    {
                        unSetBits++;
                    }
                }
                int contribution = setBits * unSetBits;
                res.Add(contribution);
            }

            return res;
        }
    }
}
