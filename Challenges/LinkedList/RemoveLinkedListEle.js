// Definition for singly-linked list.
function ListNode(val, next) {
  this.val = val === undefined ? 0 : val;
  this.next = next === undefined ? null : next;
}

/**
 * @param {ListNode} head
 * @param {number} val
 * @return {ListNode}
 */
var removeElements = function (head, val) {
  if (head === null) return null;
  let cur = head;
  let prev = new ListNode(-1);
  prev.next = head;
  let dummy = prev;
  while (cur !== null) {
    if (cur.val === val) {
      prev.next = cur.next;
    } else {
      prev = prev.next;
    }
    cur = cur.next;
  }
  return dummy.next;
};

/*
Source: https://leetcode.com/problems/remove-linked-list-elements/

Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]

*/
