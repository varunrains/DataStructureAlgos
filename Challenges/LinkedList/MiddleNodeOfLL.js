/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var middleNode = function (head) {
  let slow, fast;
  slow = head;
  fast = !!head.next ? head.next : null;
  while (fast != null) {
    slow = slow.next;
    fast = !!fast.next ? fast.next.next : null;
  }
  return slow;
};


/*
Source: https://leetcode.com/problems/middle-of-the-linked-list/
Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.


*/