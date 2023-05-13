/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {boolean}
 */
var isPalindrome = function (head) {
  let slow = head;
  let fast = head;

  while (fast !== null && fast.next !== null) {
    slow = slow.next;
    fast = fast.next.next;
  }

  //Now slow pointer is our middle node
  //Reverse the list from the slow pointer

  let prev = null;
  let curr = slow;
  let next = null;
  while (curr !== null) {
    next = curr.next;
    curr.next = prev;
    prev = curr;
    curr = next;
  }

  let start = head;
  while (start !== null && prev !== null) {
    if (start.val !== prev.val) {
      return false;
    }
    start = start.next;
    prev = prev.next;
  }
  return true;
};

/*
Source: https://leetcode.com/problems/palindrome-linked-list/

Input: head = [1,2,2,1]
Output: true

*/
