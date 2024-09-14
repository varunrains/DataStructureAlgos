﻿using System;
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
