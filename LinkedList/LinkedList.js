class Node {
  constructor(value) {
    this.value = value;
    this.next = null;
  }
}

class LinkedList {
  constructor(value) {
    const newNode = new Node(value);
    this.head = newNode;
    this.tail = this.head;
    this.length = 1;
  }

  //Time complexity of push is O(1) as we can
  //directly move to the last node and can remove it
  //without any iteration
  push(value) {
    const newNode = new Node(value);
    if (!this.head) {
      this.head = newNode;
      this.tail = this.head;
    } else {
      this.tail.next = newNode;
      this.tail = newNode;
    }
    this.length++;
    return this;
  }

  //Pop has O(n) complexity because
  //we need to traverse the linked list from head to get to the
  //node which is behind tail to remove the node.
  pop() {
    if (!this.head) return undefined;

    let temp = this.head;
    let pre = this.head;

    while (temp.next) {
      pre = temp;
      temp = temp.next;
    }
    this.tail = pre;
    this.tail.next = null;
    this.length--;
    if (this.length == 0) {
      this.head = null;
      this.tail = null;
    }
    return temp;
  }

  unshift(value) {
    const newNode = new Node(value);
    if (!this.head) {
      this.head = newNode;
      this.tail = newNode;
    } else {
      let temp = this.head;
      this.head = newNode;
      this.head.next = temp;
    }
    this.length++;
    return this;
  }

  shift() {
    if (!this.head) return undefined;

    let temp = this.head;

    this.head = this.head.next;
    temp.next = null;
    this.length--;
    if (this.length === 0) {
      this.tail = null;
    }

    return temp;
  }

  get(index) {
    if (index < 0 || index >= this.length) {
      return undefined;
    }
    let temp = this.head;
    for (let i = 0; i < index; i++) {
      temp = temp.next;
    }
    //temp.next = null;
    return temp;
  }

  set(index, value) {
    var temp = this.get(index);
    if (temp) {
      temp.value = value;
      return true;
    }
    return false;
  }

  insert(index, value) {
    if (index === 0) return this.unshift(value);
    if (index === this.length) return this.push(value);
    if (index < 0 || index > this.length) return false;

    let temp = this.get(index - 1);
    const newNode = new Node(value);
    newNode.next = temp.next;
    temp.next = newNode;
    this.length++;
    return true;
  }

  remove(index) {
    if (index < 0 || index >= this.length) return undefined;
    if (index === 0) return this.shift();
    if (index === this.length - 1) return this.pop();

    const before = this.get(index - 1);
    let temp = before.next;
    before.next = temp.next;
    temp.next = null;

    this.length--;
    return temp;
  }

  reverse() {
    let curr = this.head;
    this.head = this.tail;
    this.tail = curr;

    let prev = null;
    let next = curr.next;

    for (let i = 0; i < this.length; i++) {
      next = curr.next;
      curr.next = prev;
      prev = curr;
      curr = next;
    }
    return this;
  }
}

var myLinkedList = new LinkedList(4);
//myLinkedList.push(3);
//myLinkedList.pop();
myLinkedList.unshift(3);
myLinkedList.unshift(2);
myLinkedList.unshift(1);
//var d = myLinkedList.get(0);
//myLinkedList.shift();
//  myLinkedList.shift();
//  myLinkedList.shift();
myLinkedList.reverse();
console.log(myLinkedList);
