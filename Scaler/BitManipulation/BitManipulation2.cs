using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    internal static class BitManipulation2
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/235830/homework/problems/35183/hints?navref=cl_pb_nv_tb
        //This problem can be solved using a formula
        //Find the total set bits and un-set bits consider it to be X  and Y
        //In each bit find the value of X * Y *(1<<bit) and do this for all the bits (32) and then for all the
        //elements in the list and sum in each iteration 
        //The totalSum will be the final answer
        public static int SumOfAllXORPairs(List<int> A)
        {
            long totalSum = 0;
            for (int bit = 0; bit < 32; bit++)
            {
                long setBits = 0;
                long unSetbits = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    if ((A[i] & (1 << bit)) != 0)
                    {
                        setBits++;
                    }
                   
                }

                unSetbits = A.Count - setBits;
                //Its very important to add modulo for every step
                //Otherwise you will get incorrect answer
                long pairsWithDifferentBits = setBits * unSetbits;
                long contribution = pairsWithDifferentBits * (1 << bit);
                totalSum = (totalSum + contribution) % 1000000007;
            }
            //return it using 10 to the power 9 + 7
            return (int)(totalSum % 1000000007);
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235830/homework/problems/383/?navref=cl_pb_nv_tb
        //This was very easy as the question was to find the pairs (consecutive elements)
        //You might have to sort the array which will take N log N time complexity
        //And then with one for loop you can just
        public static int FindMinXorPair(List<int> A)
        {
            int n = A.Count;
            if (n < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            // Sort the array
            A = A.OrderBy(x => x).ToList();

            int minXOR = int.MaxValue;

            // Compare each pair of consecutive elements
            for (int i = 0; i < n - 1; i++)
            {
                int xorValue = A[i] ^ A[i + 1];
                if (xorValue < minXOR)
                {
                    minXOR = xorValue;
                }
            }

            return minXOR;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235830/homework/problems/936/hints?navref=cl_pb_nv_tb
        //Good BIT manipulation problem to solve
        //This goes with the formula where 
        // A + B = (A ^ B) * (2 * (A & B))
        //Find two numbers from the list which will satisfy the above condition
        public static int StrangeEquality(List<int> A)
        {

        }
    }
}
