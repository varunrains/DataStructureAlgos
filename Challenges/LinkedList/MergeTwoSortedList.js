/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} list1
 * @param {ListNode} list2
 * @return {ListNode}
 */
var mergeTwoLists = function (list1, list2) {
  if (list1 === null && list2 !== null) return list2;
  if (list1 !== null && list2 === null) return list1;
  
  let head1 = list1;
  let head2 = list2;
  let list3 = new ListNode(-1);
  let head3 = list3;
  while (head1 !== null && head2 !== null) {
    if (head1.val <= head2.val) {
      let va = new ListNode(head1.val);
      list3.next = va;
      list3 = va;
      head1 = head1.next;
    } else {
      let va = new ListNode(head2.val);
      list3.next = va;
      list3 = va;
      head2 = head2.next;
    }
  }

  while (head1 !== null) {
    let va = new ListNode(head1.val);
    list3.next = va;
    list3 = va;
    head1 = head1.next;
  }

  while (head2 !== null) {
    let va = new ListNode(head2.val);
    list3.next = va;
    list3 = va;
    head2 = head2.next;
  }

  return head3.next;
};

/*
Source: https://leetcode.com/problems/merge-two-sorted-lists/

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]

*/
