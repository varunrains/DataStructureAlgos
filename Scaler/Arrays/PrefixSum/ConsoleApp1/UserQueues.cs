using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{

    //https://www.scaler.com/academy/mentee-dashboard/class/236124/assignment/problems/11439?navref=cl_tt_lst_nm
    //Implement Queues using stacks
    public class UserQueue
    {

        Stack<int> stack1 = null;
        Stack<int> stack2 = null;
        /** Initialize your data structure here. */
        public UserQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        /** Push element X to the back of queue. */
        public void Push(int X)
        {
            stack1.Push(X);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }

            }
            return stack2.Pop();
        }

        /** Get the front element of the queue. */
        public int Peek()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }

            }
            return stack2.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                return true;

            return false;
        }
    }

    /**
     * Your UserQueue object will be instantiated and called as such:
     * UserQueue obj = new UserQueue();
     * obj.push(X);
     * int param2 = obj.pop();
     * int param3 = obj.peek();
     * boolean param4 = obj.empty();
     */
}
