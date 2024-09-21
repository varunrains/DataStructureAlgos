using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DequeNet;


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


    //https://www.scaler.com/academy/mentee-dashboard/class/236124/assignment/problems/50?navref=cl_tt_lst_nm
    //This needs review copied from chatgpt
    public static class QueueProblems
    {
        public static List<int> SlidingMaximum(List<int> A, int B)
        {
            int n = A.Count;
            if (B > n)
            {
                // If B is greater than the length of the array, return the maximum of the whole array
                int max = A[0];
                for (int i = 1; i < n; i++)
                {
                    if (A[i] > max)
                    {
                        max = A[i];
                    }
                }
                return new List<int>() { max};
            }

            // Result array to store the maximums for each window
            int[] result = new int[n - B + 1];
            // Deque to store indices of elements in the current window
            Deque<int> deque = new Deque<int>();

            for (int i = 0; i < n; i++)
            {
                // Remove elements that are out of this window
                if (!deque.IsEmpty && deque.PeekLeft() < i - B + 1)
                {
                    deque.PopLeft();
                }

                // Remove elements from the deque that are smaller than the current element
                // since they will not be the maximum in the current window
                while (!deque.IsEmpty && A[deque.PeekRight()] <= A[i])
                {
                    deque.PopRight();
                }

                // Add current element's index to the deque
                deque.PushRight(i);

                // Start adding to the result array once we've processed the first window
                if (i >= B - 1)
                {
                    result[i - B + 1] = A[deque.PeekRight()];
                }
            }

            return result.ToList();


        }
    }

    //Need to review the below code
    public class DoubleEndedQueue
    {
        private Stack<int> stack;
        private Queue<int> queue;
        public DoubleEndedQueue()
        {
              stack = new Stack<int>();
              queue = new Queue<int>();
        }


        public void InsertFront(int x)
        {
          queue.Enqueue(x);
        }

        public void InsertBack(int x)
        {
            stack.Push(x);
        }

        public int RemoveFromFront()
        {
            return queue.Dequeue();
        }

        public int RemoveFromBack()
        {
            return stack.Pop();
        }

        public bool IsFrontEmpty()
        {
            return queue.Count == 0;
        }

        public bool IsBackEmpty()
        {
            return stack.Count == 0;
        }

        public int PeekFront()
        {
            if (queue.Count == 0) throw new Exception("Queue Empty");
            return queue.Peek();
        }

        public int PeekBack()
        {
            if(stack.Count == 0) throw new Exception("Stack Empty");
            return stack.Peek();
        }

    }

}
