/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} n
 * @return {ListNode}
 */
var removeNthFromEnd = function (head, n) {
  let slow, fast;
  slow = head;
  fast = head;

  for (let i = 0; i < n; i++) {
    fast = fast.next;
  }

  if (fast === null) {
    return slow.next;
  }

  while (fast != null && fast.next != null) {
    slow = slow.next;
    fast = fast.next;
  }

  slow.next = !!slow.next ? slow.next.next : null;

  return head;
};

/*
You can solve this problem by slow and fast pointer approach
Source: https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/

Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]

Input: head = [1,2], n = 1
Output: [1]

*/