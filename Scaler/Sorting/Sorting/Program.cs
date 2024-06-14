namespace sorting
{

    class Sorting
    {

        public static void Main(string[] args)
        {
            CheckForArithmeticProgression(new List<int>() { -113, -70, -14, -8, -29, 5, -94, -44, 23, 9, 13, -132, -14 });
            AddBinary("110", "10");
        }

        public class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
               if(x == y) return 0;
                if (x < y) return 1;
                else return -1;
            }
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223201/assignment/problems/372?navref=cl_tt_lst_sl
        public static int ReturnNobleIntegers(List<int> A)
        {
            Comparer comparer = new Comparer();
            A.Sort(comparer);
            int numberOfIntegersGreater = 0;
            if (A[0] == 0) { numberOfIntegersGreater++; }
            for(int i=1; i<A.Count; i++)
            {
                 if(A[i] == i && A[i] != A[i - 1])
                {
                    numberOfIntegersGreater++;
                }
            }
            return numberOfIntegersGreater > 0 ? 1 : -1;
        }

        //This can be done by selection sort
        //https://www.scaler.com/academy/mentee-dashboard/class/223201/assignment/problems/260?navref=cl_tt_nv
        public static int KthSmallestElement(List<int> A, int B)
        {
            int result = 0;
            for(int i = 0; i < A.Count; i++)
            {
                for(int j=i+1; j<A.Count; j++)
                {
                    if (A[i] > A[j])
                    {
                        var temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
                if (B - 1 == i)
                {
                    result = A[i];
                    //Important to return or else your loop will continue to sort
                    //for all the array elements
                    return result;
                }
            }
            return result;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/223201/homework/problems/10208?navref=cl_tt_lst_sl
        public static int CheckForArithmeticProgression(List<int> A)
        {
            A.Sort();
            if (A.Count <= 2) return 1;
            int commonDifference = A[1] - A[0];
            

            for(int i=1; i<A.Count-1; i++)
            {
                if (A[i+1] - A[i] != commonDifference)
                {
                    return 0;
                }
            }
            return 1;
        }

        //Add binary 
        //https://www.scaler.com/academy/mentee-dashboard/class/223213/assignment/problems/189?navref=cl_tt_lst_sl
        public static string AddBinary(string A, string B)
        {
            string result = string.Empty;
            int carry  = 0;
            int j = B.Length - 1;
            for (int i = A.Length-1; i>=0; i--)
            {
                int second = 0;
                if(j < 0)
                {
                    second = 0;
                }
                else
                {
                    second = int.Parse(B[j].ToString());
                }
                int sum = int.Parse(A[i].ToString()) + second + carry;
                if (sum == 2)
                {
                    result += "0";
                    carry = 1;
                }
                else if (sum == 3)
                {
                    result += "1";
                    carry = 1;
                }
                else
                {
                    result += sum.ToString();
                    carry = 0;
                }

                if(carry == 1 && i == 0)
                {
                    result += carry;
                }
                j--;
            }
            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            //return result.Reverse().ToString();
        }



    }
}