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


    
  //Definition for singly-linked list with a random pointer.
  public class RandomListNode {
      public int label;
      public RandomListNode? next, random;
      public RandomListNode(int x) { label = x; }
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

        //https://www.scaler.com/academy/mentee-dashboard/class/236106/assignment/problems/159?navref=cl_tt_lst_nm
        public RandomListNode CopyRandomListNode(RandomListNode head)
        {
            var temp = head;

            //clone the linked list without extra space
            while (temp != null)
            {
                var cn = new RandomListNode(temp.label);
                cn.next = temp.next;
                temp.next = cn;
                temp = temp?.next?.next;
            }

            temp = head;
            //set the random pointers of the copied node
            while(temp!= null)
            {
                temp.next.random = temp?.random?.next;
                temp = temp?.next?.next;
            }

            //separate original and copied linked list
            RandomListNode chead = head.next;

            RandomListNode t1 = head, t2 = chead;

            while(t2.next != null)
            {
                t1.next = t1.next.next;
                t2.next = t2.next.next;
                t1 = t1.next;
                t2 = t2.next;
            }

            t1.next = null;
            t2.next = null;

            return chead;

        }
    }
}
