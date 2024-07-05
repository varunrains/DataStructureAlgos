using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    internal static class BitManipulation1
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/235832/assignment/problems/27344?navref=cl_tt_lst_nm
        public static int SetAthAndBthBit(int A, int B)
        {

            var n = (1 << A) + (1 << B);
            if (A == B)
            {
                n = n / 2;
            }
            return n;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235832/assignment/problems/192?navref=cl_tt_nv
        public static int NumberOfOneBits(int A)
        {
            int ans = 0;
            var n = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((A & (1 << i)) != 0)
                {
                    ans++;
                }
            }

            return ans;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235832/assignment/problems/26950?navref=cl_tt_lst_nm
        public static int ToggleIthBit(int A, int B)
        {
            var n = (1 << B ^ A);
            return n;
        }


        //https://www.scaler.com/academy/mentee-dashboard/class/235832/assignment/problems/27343?navref=cl_tt_lst_nm
        public static int CheckBit(int A, int B)
        {
            var n = A & (1 << B);
            if (n == 0) return 0;

            return 1;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235832/assignment/problems/26930?navref=cl_tt_lst_nm
        public static int UnsetIthBit(int A, int B)
        {
            var n = A & (1 << B);
            if (n == 0) {
                return A;
            }
            else
            {
                n = (1 << B) ^ A;
                return n;
            }
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235832/assignment/problems/4531?navref=cl_tt_lst_nm
        public static int HelpFromSam(int A)
        {
            var minimumNumberOfTimesSamTakesHelp = 0;

            for (int i = 0; i < 32; i++)
            {
                if (((1 << i) & A) != 0)
                {
                    minimumNumberOfTimesSamTakesHelp++;
                }
            }

            return minimumNumberOfTimesSamTakesHelp;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235830/assignment/problems/193?navref=cl_tt_lst_nm
        public static int SingleNumber(List<int> A)
        {
            //Using XOR operator and using the property A^A = 0 then it can be easily done 
            int ans = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                ans ^= A[i];
            }

            return ans;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235830/assignment/problems/195?navref=cl_tt_lst_nm
        public static int SingleNumberOutOfThree(List<int> A)
        {
            //This can be done using the formula Kx + 1
            //THere could be x of K elements but with one unique element which 
            //we need to find with linear time complexity
            int countOfSetBits = 0;
            int ans = 0;
            for(int bit  = 0; bit < 32; bit++)
            {
                countOfSetBits = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    if ((A[i] & (1 << bit)) != 0)
                    {
                        countOfSetBits++;
                    }
                }
                //Based on the 3x formula
                if(countOfSetBits % 3 == 1)
                {
                    ans = ans | (1 << bit);
                }
            }

            return ans;
            
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235830/assignment/problems/9184?navref=cl_tt_lst_nm
        public static List<int> TwoIntegersOutOfDuplicates(List<int> A)
        {
            //Using XOR operator and using the property A^A = 0 then it can be easily done 
            //for all the elements except the answer as there will be two elements
            int xor = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                xor ^= A[i];
            }

            var result = new List<int>();
            int firstSetBitPosition = 0;
            //Find the first set bit in the anwser so that we can
            //bucket it to two separate collection and find out two individual numbers
            for(int bit = 0;bit < 32; bit++)
            {
                if((xor & (1 << bit)) != 0)
                {
                    firstSetBitPosition = bit;
                    break;
                }
            }
            //There will be two unique elements
            int x = 0;int y= 0;
            //Now differntiate using the set bit 

            for (int i = 0; i < A.Count; i++)
            {
                //Put the numbers which has set bit in one bucket for example [5,1,5]
                if ((A[i] & (1 << firstSetBitPosition)) != 0)
                {
                    x ^= A[i];
                }
                //Put the numbers which has not set bit in other bucket for example [6,3,6]
                //If we do XOR for both the array's we can get the unique element [1,3]
                else
                {
                    y ^= A[i];
                }
            }
            
            result.Add(x);
            result.Add(y);

            //Answer was expecting in order so sorted it in ascending
            return result.OrderBy(x =>x).ToList();

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235830/assignment/problems/35182?navref=cl_tt_lst_nm
        public static List<int> FindTwoMissingNumbers(List<int> A)
        {

        }
    }
}
