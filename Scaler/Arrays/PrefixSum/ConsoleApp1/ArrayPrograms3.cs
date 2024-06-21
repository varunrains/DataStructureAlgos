using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class ArrayPrograms3
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/223199/assignment/problems/2/hints?navref=cl_pb_nv_tb
        //We can use HashMap to get the frequency of element which will take O(N) space to optimize it we can use
        //moore's formula where we can find it using the frequency and reset
        public static int MajorityElement(List<int> A)
        {
            int majorityElement = int.MinValue;
            int frequency = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if(frequency == 0)
                {
                    majorityElement = A[i];
                    frequency++;
                }else if (A[i] == majorityElement)
                {
                    frequency++;
                }
                else
                {
                    frequency--;
                }
            }

            frequency = 0;

            for(int i=0; i < A.Count; i++)
            {
                if (A[i] == majorityElement)
                {
                    frequency++;
                }
            }

            if (frequency > A.Count / 2)
            {
                return majorityElement;
            }
            else return 0;
        }
    }

}
