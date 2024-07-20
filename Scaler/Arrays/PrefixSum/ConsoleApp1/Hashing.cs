using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    internal static class Hashing
    {
        public static List<int> FrequenceOfElementQuery(List<int> A, List<int> B)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            var res = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (map.ContainsKey(A[i]))
                {
                    map[A[i]]++;
                }
                else
                {
                    map.Add(A[i], 1);
                }
            }

            for(int i=0;i < B.Count; i++)
            {
                var val = 0;
                map.TryGetValue(B[i], out val);
                res.Add(val);
            }

            return res;

        }
    }
}
