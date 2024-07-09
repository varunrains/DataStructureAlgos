using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
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
        public static int StrangeEquality(int A)
        {
            //To find greater number than A you need to find the number of bits in A and then left shifting it will
            //give the next possible greater value than A which will by Y
            int numberOfBits = 0;
            //find the number of bits in A
            for(int bit = 0; bit < 32; bit++)
            {
               if((A & (1 << bit)) != 0)
                {
                    numberOfBits = bit;
                }
            }
            //as bit start from 0
            numberOfBits++;
            //Value of the greater number than A will be 1 << numberOfbits
            int y = 1 << numberOfBits;
            //You need to find two values A and B such that the and operation will result in 0

            int x = A;
            //the value of x will be invert of A so that it will be less than A
            //For each set bit un-set that bit in A to get X

            for (int bit = 0; bit < numberOfBits; bit++)
            {
                if ((A & (1 << bit)) != 0)
                {
                    //Unset bit with XOR
                    //Remember
                    x =  x ^ (1<<bit);
                }
                else
                {
                    //Set bit with OR
                    //Remember
                    x = x | (1 << bit);
                }
            }

            return x + y;

        }
    }
}
