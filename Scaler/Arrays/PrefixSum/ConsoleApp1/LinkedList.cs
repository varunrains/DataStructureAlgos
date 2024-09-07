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
    }
}
