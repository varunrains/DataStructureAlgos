using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSA
{

    // Definition for singly-linked list.
    class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x) { val = x; next = null; }
    }
 
    internal class LinkedList
    {
        //https://www.scaler.com/academy/mentee-dashboard/class/236106/assignment/problems/30536

        public ListNode InsertIntoLinkedList(ListNode A, int B, int C)
        {
            var newNode = new ListNode(B);
            if (A == null)
            {
                return newNode;
            }

            if (C == 0)
            {
                newNode.next = A;
                A = newNode;
            }

            var temp = A;
            for (int i = 1; i <= C - 1; i++)
            {
                if (temp.next != null)
                {
                    temp = temp.next;
                }
            }
            newNode.next = temp.next;
            temp.next = newNode;


            return A;
        }


        //https://www.scaler.com/academy/mentee-dashboard/class/236106/assignment/problems/30667
        public ListNode DeleteTheNodeBasedOnIndex(ListNode A, int B)
        {
            var temp = A;

            if (B == 0)
            {
                A = temp.next;
                return A;
            }


            for(int i = 1; i <= B - 1; i++)
            {
                if (temp.next?.next != null)
                {
                    temp = temp.next;
                }
                else
                {
                    temp.next = null;
                    return A;
                }
            }

            var toConnect = temp.next?.next;
            temp.next = toConnect;
            return A;
        }

        //https://www.scaler.com/academy/mentee-dashboard/class/236106/assignment/problems/40?navref=cl_tt_lst_nm
        public ListNode ReverseLinkedList(ListNode A)
        {
            var curr = A;
            ListNode prev = null;

            if(curr.next == null)
            {
                return A;
            }

            //curr = curr.next;
            while (curr != null)
            {
                var nextNode = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextNode;
            }
            A = prev;
            return A;

        }
    }
}
