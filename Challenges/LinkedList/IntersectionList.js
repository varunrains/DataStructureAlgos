var getIntersectionNode = function (headA, headB) {
    let listA = findLength(headA);
    let listB = findLength(headB);
    let distanceToMove = listB - listA;
    if (distanceToMove < 0) {
     
         for (let i = 0; i < Math.abs(distanceToMove); i++) {
          headA = headA.next;
        }
    } else {
      
          for (let i = 0; i < Math.abs(distanceToMove); i++) {
          headB = headB.next;
        }
    }

  while ((headA != null) && (headB != null)) {
    if (headA === headB) {
      return headA;
    }

    headA = headA.next;
    headB = headB.next;
  }

  return null;
};

//The below code didn't work because the value is not passed by reference for some reason in leet code example

// var distanceToNavigate = function (list, len) {
//   for (let i = 0; i < len; i++) {
//     list = list.next;
//   }
// };

var findLength = function (list) {
  let count = 0;
  while (list != null) {
    count++;
    list = list.next;
  }

  return count;
};

//Note:
//This problem can only be solved through leet code and cannot be executed individually as this
//has the reference to Node class
//If you need to run this locally then you need to create the Node class to run this.

/*
Source: https://leetcode.com/problems/intersection-of-two-linked-lists/description/

Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,6,1,8,4,5], skipA = 2, skipB = 3
Output: Intersected at '8'
Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect).
From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,6,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.
- Note that the intersected node's value is not 1 because the nodes with value 1 in A and B (2nd node in A and 3rd node in B) are different node references. In other words, they point to two different locations in memory, while the nodes with value 8 in A and B (3rd node in A and 4th node in B) point to the same location in memory.

*/
