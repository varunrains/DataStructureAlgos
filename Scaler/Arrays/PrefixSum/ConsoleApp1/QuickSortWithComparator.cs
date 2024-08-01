using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class QuickSortWithComparator
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/235854/assignment/problems/64?navref=cl_tt_lst_nm
        public static string LargestNumber(List<int> A)
        {
            StringBuilder res = new StringBuilder(A.Count);
            var comp = new Compararer();
            int sum = 0;
            A.Sort((x, y) => { return comp.Compare(x, y); });
            for (int i = 0; i < A.Count; i++)
            {
                sum += A[i];
                res.Append(A[i]);
            }
           // var intRes = int.Parse(res.ToString());
           if(sum == 0) return 0.ToString();
            return res.ToString();
        }

        
    }

    public  class Compararer : System.Collections.IComparer
    {
        public int Compare(object a, object b)
        {
            var x = a.ToString() + b.ToString();
            var y = b.ToString() + a.ToString();

            if (long.Parse(x) > long.Parse(y)) return -1;
            else if (long.Parse(x) < long.Parse(y)) return 1;
            else return 0;
        }

    }
}
