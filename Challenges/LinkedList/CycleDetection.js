/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} head
 * @return {boolean}
 */
var hasCycle = function (head) {
  let slow = head;
  let fast = head;

  while (fast != null && fast.next != null) {
    fast = fast.next.next;
    slow = slow?.next;

    if (slow === fast) {
      return true;
    }
  }

  return false;
};

/*
Source: https://leetcode.com/problems/linked-list-cycle/

Input: head = [3,2,0,-4], pos = 1 (Please refer the diagram from the above link)
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).

*/
