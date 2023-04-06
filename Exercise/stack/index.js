// --- Directions
// Create a stack data structure.  The stack
// should be a class with methods 'push', 'pop', and
// 'peek'.  Adding an element to the stack should
// store it until it is removed.
// --- Examples
//   const s = new Stack();
//   s.push(1);
//   s.push(2);
//   s.pop(); // returns 2
//   s.pop(); // returns 1

class Stack {
  constructor() {
    this.data = [];
  }

  //If you use unshift to an array
  //then it will be O(N) because the indexes have
  //to be shifted
  //Better to use push and pop instead of shift and unshift for stacks
  //If you are adding or removing the value from the end of the array
  //Then it will be O(1) so it is better to do that way
  //Only in case of Linked list adding and removing at the begining is O(1)
  //And adding at the end is also O(1) but removing at the end in the linked list is O(N)
  push(val) {
    return this.data.push(val);
  }

  pop() {
    return this.data.pop();
  }

  peek() {
    return this.data[this.data.length-1];
  }
}

module.exports = Stack;
