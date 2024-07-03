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
        }
    }
}
