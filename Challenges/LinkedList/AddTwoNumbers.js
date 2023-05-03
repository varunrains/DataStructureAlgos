/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function (l1, l2) {
  let carry = 0;
  let head = null;

  //If both the linked list is of same length
  while (l1 != null && l2 != null) {
    let sum = l1.val + l2.val + carry;
    let node = new ListNode(sum % 10);
    carry = Math.floor(sum / 10);

    //Insert a node
    node.next = head;
    head = node;

    l1 = l1.next;
    l2 = l2.next;
  }

  //If first list is higher length than the second
  while (l1 != null) {
    let sum = l1.val + carry;
    let node = new ListNode(sum % 10);
    carry = Math.floor(sum / 10);

    //Insert a node
    node.next = head;
    head = node;

    l1 = l1.next;
  }

  //If second list is higher length than the first linked list
  while (l2 != null) {
    let sum = l2.val + carry;
    let node = new ListNode(sum % 10);
    carry = Math.floor(sum / 10);

    //Insert a node
    node.next = head;
    head = node;

    l2 = l2.next;
  }

  if (carry > 0) {
    let node = new ListNode(carry);
    node.next = head;
    head = node;
  }

  //Now reverse the list that was created
  let curr, prev, nex;
  curr = head;
  prev = null;

  while (curr != null) {
    nex = curr.next;
    curr.next = prev;
    prev = curr;
    curr = nex;
  }
  head = prev;

  return head;
};

/*
Source: https://leetcode.com/problems/add-two-numbers/

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

*/
