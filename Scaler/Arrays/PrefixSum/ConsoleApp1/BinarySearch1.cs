using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class BinarySearch1
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/235864/assignment/problems/4131?navref=cl_tt_lst_nm
        public static int SingleElementInSortedArray(List<int> A)
        {

            int L = 0;
            int R = A.Count - 1;
            while (L <= R)
            {
                var mid = (L + R) / 2;

                if ((mid == A.Count - 1 || A[mid] != A[mid + 1]) && (mid == 0 || A[mid] != A[mid - 1]))
                {
                    return A[mid];
                }
                if (mid != 0 && A[mid] == A[mid - 1])
                {
                    //odd even scenario
                    if (mid % 2 == 0)
                    {
                        R = mid - 2;
                    }
                    else
                    {
                        L = mid + 1;
                    }
                }
                else
                {
                    if (mid % 2 == 1)
                    {
                        R = mid - 1;
                    }
                    else
                    {
                        L = mid + 2;
                    }
                }

               
            }
            return -1;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235864/assignment/problems/199?navref=cl_tt_lst_nm
        public static List<int> SearchForARange(List<int> A, int B)
        {
            int leftOccurence = FindLeftMostOccurence(A, B);
            int rightOccurence = FindRightMostOccurence(A, B);
            return new List<int> { leftOccurence, rightOccurence };
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235864/assignment/problems/204?navref=cl_tt_lst_nm
        public static int SortedInsertPosition(List<int> A, int B)
        {
            int L = 0;
            int R = A.Count - 1;

            while (L <= R)
            {
                var mid = (L + R) / 2;

                if (A[mid] == B)
                {
                    return mid;
                }

                else if (A[mid] > B)
                {
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }

            return L;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235864/assignment/problems/4132?navref=cl_tt_lst_nm
        public static int FindPeakElement(List<int> A)
        {
            int L = 0;
            int R = A.Count - 1;

            while (L <= R)
            {
                var mid = (L + R) / 2;

                if ((mid == 0 || A[mid] >= A[mid-1]) && (mid == A.Count-1 || A[mid] >= A[mid + 1]))
                {
                    return A[mid];
                }
                else if (mid == A.Count-1 || A[mid] > A[mid + 1])
                {
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }

            return -1;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235864/assignment/problems/196?navref=cl_tt_nv
        public static int MatrixSearch(List<List<int>> A, int B)
        {
            var cornerElement = A[0][A.Count-1];
            int row = 0;
            int col = A[0].Count-1;
            while (row < A.Count && col >= 0)
            {
                if (A[row][col] == B)
                {
                    return 1;
                }
                //We can use binary search to make this NlogN time complexity 
                else if(A[row][col] < B)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }
            return 0;
        }

        private static int FindLeftMostOccurence(List<int> A, int B)
        {
            int L = 0;
            int R = A.Count - 1;
            int res = -1;

            while (L <= R)
            {
                var mid = (L + R) / 2;

                if (A[mid] == B)
                {
                    R = mid - 1;
                    res =  mid;
                }

                else if(A[mid] > B)
                {
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }

            return res;
        }

        private static int SquareRootOfANumber(int A)
        {
            int L = 1;
            int R = A;
            long mid = 0;
            while(L <= R)
            {
                mid = L + (R-L)/2;
                if ((mid * mid) <= A && (mid + 1) * (mid + 1) > A)
                {
                    return (int)mid;
                }
                else if (mid * mid > A)
                {
                    R = (int)mid - 1;
                }
                else
                {
                    L = (int)mid + 1;
                }
            }

            return (int)mid;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235860/assignment/problems/203?navref=cl_tt_lst_nm
        public static int RotatedSortedArraySearch(List<int> A, int B)
        {
            //BInary search steps
            //1 - Define the search space
            //2 - Find the mid element if the target
            //3 - If the mid is not the target then decide to move left or right
           
            int L = 0;
            int R = A.Count - 1;

            int mid = 0;

            while (L <= R)
            {
                mid = (L + R) / 2;
                if (A[mid] == B)
                {
                    return mid;
                }

                if (B >= A[0]) //Search in part 1 of a sorted array
                {
                    //Check where is mid
                    if (A[mid] > A[0]) //part 1 then apply binary search
                    {
                        if (A[mid] > B)
                        {
                            R = mid - 1;
                        }
                        else
                        {
                            L = mid + 1;
                        }
                    }
                    else
                    {  
                        R = mid - 1; //Pull the search space to part 1;
                    }
                }
                else //Search in the part 2 of the sorted array
                {
                    //Check if the mid is in part 2 itself to apply binary search
                    if (A[mid] < A[0])
                    {
                        if (A[mid] > B)
                        {
                            R = mid - 1;
                        }
                        else
                        {
                            L = mid + 1;
                        }
                    }
                    else
                    {
                        L = mid + 1; // pull the search space to part 2
                    }
                }
            }

            return -1;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235860/assignment/problems/5697?navref=cl_tt_lst_nm
        public static int AthMagicalNumber(int A, int B, int C)
        {
            int mod = 1000000007;
            long L = Math.Min(B, C);
            long R = (long)A * L;
            long LCM = (long)(B / FindGcdRec(B, C)) * C;  // Use long to avoid overflow
            long mid = 0;
            while (L <= R)
            {
                mid = L + (R - L) / 2;
                var count = (mid / B) + (mid / C) - (mid / LCM);
                if (count == A)
                {
                    // Check if mid is exactly the A-th magical number
                    if (mid % B == 0 || mid % C == 0)
                    {
                        return (int)(mid % mod);
                    }
                    R = mid - 1; // Continue searching in the left half
                }
                else if (count < A)
                {
                    L = mid + 1;
                }
                else
                {
                    R = mid - 1;
                }
            }

           return (int)(L % mod);
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/235860/assignment/problems
        public static int MedianOfAnArray(List<int> A)
        {
            int L = A[0]; //min from array
            int R = A[0]; //max from array
            for(int i = 1; i < A.Count; i++)
            {
                L = Math.Min(L, A[i-1]);
                R = Math.Max(R, A[i - 1]);
            }

            var half = (A.Count + 1) / 2;
            while(L <= R)
            {
                var mid = L + (R - L) / 2;
                int count = CountOfElements(A, mid);
                int lessCounter = CountOfElements(A, mid - 1);
                if(count == half && lessCounter < half)
                {
                    return mid;
                }
                if(count < half)
                {
                    L = mid + 1;
                }
                else
                {
                    R= mid - 1;
                }

            }

            return 0;
        }

        // //https://www.scaler.com/academy/mentee-dashboard/class/235860/assignment/problems
        //This solution was copied from ChatGPT
        //Go through it one more time
        public static double MedianOfTwoSortedArray(List<int> A, List<int> B)
        {
            if (A.Count > B.Count)
            {
                return MedianOfTwoSortedArray(B, A);
            }

            int m = A.Count;
            int n = B.Count;

            int low = 0, high = m;
            while (low <= high)
            {
                int partitionA = (low + high) / 2;
                int partitionB = (m + n + 1) / 2 - partitionA;

                int maxLeftA = (partitionA == 0) ? int.MinValue : A[partitionA - 1];
                int minRightA = (partitionA == m) ? int.MaxValue : A[partitionA];

                int maxLeftB = (partitionB == 0) ? int.MinValue : B[partitionB - 1];
                int minRightB = (partitionB == n) ? int.MaxValue : B[partitionB];

                if (maxLeftA <= minRightB && maxLeftB <= minRightA)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(maxLeftA, maxLeftB) + Math.Min(minRightA, minRightB)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxLeftA, maxLeftB);
                    }
                }
                else if (maxLeftA > minRightB)
                {
                    high = partitionA - 1;
                }
                else
                {
                    low = partitionA + 1;
                }
            }

            throw new ArgumentException("Input arrays are not sorted.");
        }

        private static int CountOfElements(List<int> A, int B)
        {
            int counter = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] < B)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static int FindGcdRec(int A, int B)
        {
            if (B == 0)
            {
                return A;
            }
            //A%B will always be less than B-1, so swap it 
            return FindGcdRec(B, A % B);
        }


        private static int FindRightMostOccurence(List<int> A, int B)
        {
            int L = 0;
            int R = A.Count - 1;
            int res = -1;

            while (L <= R)
            {
                var mid = (L + R) / 2;

                if (A[mid] == B)
                {
                    L = mid + 1;
                    res = mid;
                }

                else if (A[mid] > B)
                {
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }

            return res;
        }
    }
}
