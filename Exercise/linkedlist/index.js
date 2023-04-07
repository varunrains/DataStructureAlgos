// --- Directions
// Implement classes Node and Linked Lists
// See 'directions' document

class Node {
  constructor(data, next = null) {
    this.data = data;
    this.next = next;
  }
}

class LinkedList {
  constructor() {
    this.head = null;
  }

  insertFirst(val) {
    const newNode = new Node(val, this.head);
    this.head = newNode;
  }

  size() {
    let count = 0;
    let node = this.head;
    while (node) {
      node = node.next;
      count++;
    }
    return count;
  }

  getFirst() {
    return this.head;
  }

  getLast() {
    if (!this.head) {
      return null;
    }
    let node = this.head;
    let lastNode;
    while (node) {
      if (!node.next) {
        lastNode = node;
      }
      node = node.next;
    }
    return lastNode;
  }

  clear() {
    this.head = null;
  }

  removeFirst() {
    if (!this.head) {
      return;
    }
    let node = this.head;
    this.head = this.head.next;
    return node;
  }

  removeLast() {
    let next;
    let previous;
    if (!this.head) return undefined;
    if (!this.head.next) {
      let temp = this.head;
      this.head = null;
      return temp;
    }
    next = this.head.next;
    previous = this.head;
    while (next) {
      if (!next.next) {
        previous.next = null;
        return previous;
      }
      previous = next;
      next = next.next;
    }
  }

  insertLast(data) {
    //if (!this.head) return;
    var lastNode = this.getLast();
    let newNode = new Node(data);
    if (lastNode) {
      lastNode.next = newNode;
    } else {
      this.head = newNode;
    }
  }

  getAt(index) {
    //if(index === 0) return this.head;
    let node = this.head;
    let counter = 0;
    while (node) {
      if (counter === index) {
        return node;
      }
      counter++;
      node = node.next;
    }
    return null;
  }

  removeAt(index) {
    if (!this.head) return;

    //let node = this.head.next;

    if (index === 0) {
      this.head = this.head.next;
    }

    let previous = this.getAt(index - 1);
    if (!previous || !previous.next) {
      return;
    }
    previous.next = previous.next.next;
  }

  insertAt(val, index) {
    const newNode = new Node(val);

    if (!this.head) {
      this.head = newNode;
      return;
    }
    if (index === 0) {
      let temp = this.head;
      this.head = newNode;
      newNode.next = temp;
      //this.head = this.head.next;
      return;
    }

    let previous = this.getAt(index - 1);

    if (!previous || !previous.next) {
      var lastNode = this.getLast();
      lastNode.next = newNode;
      return;
    }
    let temp = previous.next;
    previous.next = newNode;
    newNode.next = temp;
  }

  forEach(fn) {
    let node = this.head;
    let counter = 0;

    while (node) {
      fn(node, counter);
      node = node.next;
      counter++;
    }
  }

  *[Symbol.iterator]() {
    let node = this.head;
    while (node) {
      yield node;
      node = node.next;
    }
  }
}

// const l = new LinkedList();
//     l.insertLast('a');
//     l.insertLast('b');
//     l.insertLast('c');
//     l.insertLast('d');
//     l.insertAt('hi', 2);
//     var d = l.getAt(3);
// var ds = d.data;
module.exports = { Node, LinkedList };
