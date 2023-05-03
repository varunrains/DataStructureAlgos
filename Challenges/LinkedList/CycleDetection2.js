/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var detectCycle = function (head) {
  let slow = head;
  let fast = head;

  while (fast != null && fast.next != null) {
    fast = fast.next.next;
    slow = slow?.next;

    if (slow === fast) {
      break; //This mean there is a cycle present
    }
  }

  if (slow !== fast || fast === null || fast.next === null) {
    return null;
  }

  //Now move the slow pointer to head and then move both the slow and fast pointers by one
  slow = head;

  while (slow !== fast) {
    slow = slow.next;
    fast = fast.next;
  }

  return slow;
};

/*
Source: https://leetcode.com/problems/linked-list-cycle-ii/

Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.

Input: head = [3,2,0,-4], pos = 1
Output: tail connects to node index 1
Explanation: There is a cycle in the linked list, where tail connects to the second node.

*/
