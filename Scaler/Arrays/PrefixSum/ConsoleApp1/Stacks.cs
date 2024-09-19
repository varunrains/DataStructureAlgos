using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{
    public static class Stacks
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/236118/assignment/problems/46?navref=cl_tt_lst_nm
        public static int EvalReversePolishNotation(List<string> A){
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == "+" || A[i] == "-" || A[i] == "*" || A[i] == "/")
                {
                    var op2 = int.Parse(stack.Pop());
                    var op1 = int.Parse(stack.Pop());
                    var res = EvaluateTheExpression(op1, op2, A[i]);
                    stack.Push(res.ToString());
                }
                else
                {
                    stack.Push(A[i]);
                }
            }

            return int.Parse(stack.Pop());
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236118/assignment/problems/678?navref=cl_tt_nv
        public static int BalancedParenthesis(string A)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '(' || A[i] == '{' || A[i] == '[')
                {
                    stack.Push(A[i]);
                } 
                else if (stack.Count > 0 && ((A[i] == ')' && stack.Peek() == '(') || (A[i] == '}' && stack.Peek() == '{' )|| (A[i] == ']' && stack.Peek() == '[')))
                {
                    stack.Pop();
                }
                else
                {
                    return 0;
                }

            }

            if(stack.Count == 0)
            {
                return 1;
            }

            return 0;

        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236118/assignment/problems/968?navref=cl_tt_lst_nm
        public static string DoubleCharacterTrouble(string A)
        {
            Stack<char> stack = new Stack<char>();
            if (A.Length == 0) return string.Empty;

            stack.Push(A[0]);
            for(int i=1;i < A.Length; i++)
            {
                if (stack.Count >0 && stack.Peek() == A[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(A[i]);
                }
            }

            var result = new char[stack.Count];
            for (int i = stack.Count-1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return string.Concat(result);
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236120/assignment/problems/332
        public static List<int> NearestSmallestELement(List<int> A)
        {
            var res = new int[A.Count];
            Stack<int> stack = new Stack<int>();

            res[0] = -1;
            stack.Push(A[0]);

            for(int i = 1; i < A.Count; i++)
            {
                while(stack.Count > 0 && stack.Peek() >= A[i])
                {
                    stack.Pop();
                }

                if(stack.Count == 0)
                {
                    res[i] = -1;
                }
                else
                {
                    res[i] = stack.Peek();
                }

                stack.Push(A[i]);
            }

            return res.ToList();
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236120/assignment/problems/49
        public static int LargestRectangleArea(List<int> A)
        {
            if (A.Count == 1)
            {
                return A[0];
            }

            var nsl = new int[A.Count];
            var nsr = new int[A.Count];
            Stack<int> stack = new Stack<int> ();
            Stack<int> stack1 = new Stack<int>();

            nsl[0] = -1;
            nsr[A.Count - 1] = A.Count;

            stack.Push(0);
            stack1.Push(A.Count - 1);

            for (int i = 1;i< A.Count; i++)
            {
                while(stack.Count>0 && A[stack.Peek()] >= A[i])
                {
                    stack.Pop();
                }
                if(stack.Count == 0)
                {
                    nsl[i] = -1;
                }
                else
                {
                    nsl[i] = stack.Peek();
                }

                stack.Push(i);
            }

            for(int i = A.Count - 2; i >= 0; i--)
            {
                while (stack1.Count > 0 && A[stack1.Peek()] >= A[i])
                {
                    stack1.Pop();
                }
                if(stack1.Count == 0)
                {
                    nsr[i] = A.Count;
                }
                else
                {
                    nsr[i] = stack1.Peek(); 
                }

                stack1.Push(i);
            }

            int ans = 0;

            for(int i=0;i< A.Count; i++)
            {
                ans = Math.Max(ans, A[i] * (nsr[i] - nsl[i] - 1));
            }

            return ans;

        }


        //https://www.scaler.com/academy/mentee-dashboard/class/236120/assignment/problems/7042
        public static int MaxAndMinInSubarrays(List<int> A)
        {
            //First we need to find the nearest greater to left and right
            //nearest smaller to left and right
            //Apply contribution technique after that
            //You will get sum of all maximum elements and minimum
            //and then do max - min

            var nsl = new int[A.Count];
            var nsr = new int[A.Count];

            Stack<int> nsl_stack = new Stack<int>();
            Stack<int> nsr_stack = new Stack<int>();  

            nsl[0] = -1;
            nsr[A.Count - 1] = A.Count; //Index should be outside the array size

            nsl_stack.Push(0);
            nsr_stack.Push(A.Count-1);

            //nearest smallest in the left
            for (int i = 1; i < A.Count; i++)
            {
                while(nsl_stack.Count > 0 && A[nsl_stack.Peek()] >= A[i])
                {
                    nsl_stack.Pop();
                }

                if(nsl_stack.Count == 0)
                {
                    nsl[i] = -1;
                }
                else
                {
                    nsl[i] = nsl_stack.Peek();
                }

                nsl_stack.Push(i);

            }


            //nearest smallest from the right
            for (int i = A.Count - 2; i >= 0; i--)
            {
                while (nsr_stack.Count > 0 && A[nsr_stack.Peek()] >= A[i])
                {
                    nsr_stack.Pop();
                }

                if (nsr_stack.Count == 0)
                {
                    nsr[i] = A.Count;
                }
                else
                {
                    nsr[i] = nsr_stack.Peek();
                }

                nsr_stack.Push(i);
            }
            
            var ngl = new int[A.Count];
            var ngr = new int[A.Count];

            ngl[0] = -1;
            ngr[A.Count - 1] = A.Count;

            Stack<int> ngl_stack = new Stack<int>();
            Stack<int> ngr_stack = new Stack<int>();

            ngl_stack.Push(0);
            ngr_stack.Push(A.Count-1);

            //nearest greater in the left
            for (int i = 1; i < A.Count; i++)
            {
                while (ngl_stack.Count > 0 && A[ngl_stack.Peek()] <= A[i])
                {
                    ngl_stack.Pop();
                }

                if (ngl_stack.Count == 0)
                {
                    ngl[i] = -1;
                }
                else
                {
                    ngl[i] = ngl_stack.Peek();
                }

                ngl_stack.Push(i);

            }


            //nearest greater from the right
            for (int i = A.Count - 2; i >= 0; i--)
            {
                while (ngr_stack.Count > 0 && A[ngr_stack.Peek()] <= A[i])
                {
                    ngr_stack.Pop();
                }

                if (ngr_stack.Count == 0)
                {
                    ngr[i] = A.Count;
                }
                else
                {
                    ngr[i] = ngr_stack.Peek();
                }

                ngr_stack.Push(i);
            }

            //Sum of all sub-arrays where ith element is sub-array is maximum
            long f1 = 0;

            //sum of all sub-arrays where ith element is sub-array is minimum
            long f2 = 0;

            for (int i = 0; i < A.Count; i++)
            {
                f1 = (f1 + ((long)(i - ngl[i]) * (ngr[i] - i) % 1000000007) * A[i]) % 1000000007;
                f2 = (f2 + ((long)(i - nsl[i]) * (nsr[i] - i) % 1000000007) * A[i]) % 1000000007;
            }


            return (int)((f1 - f2) + 1000000007) % 1000000007;
        }

        private static int EvaluateTheExpression(int op1, int op2, string op)
        {
            if (op == "+")
            {
                return op1 + op2;
            }
            else if (op == "-")
            {
                return op1 - op2;
            }
            else if (op == "*")
            {
                return op1 * op2;
            }
            else if (op == "/")
            {
                return op1 / op2;
            }

            return 0;
        }
    }
}
