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
