// --- Directions
// 1) Create a node class.  The constructor
// should accept an argument that gets assigned
// to the data property and initialize an
// empty array for storing children. The node
// class should have methods 'add' and 'remove'.
// 2) Create a tree class. The tree constructor
// should initialize a 'root' property to null.
// 3) Implement 'traverseBF' and 'traverseDF'
// on the tree class.  Each method should accept a
// function that gets called with each element in the tree

class Node {
  constructor(data) {
    this.data = data;
    this.children = [];
  }

  add(data) {
    const node = new Node(data);
    this.children.push(node);
  }

  remove(data) {
    this.children = this.children.filter((node) => {
      return node.data !== data;
    });
  }
}

class Tree {
  constructor() {
    this.root = null;
  }

  traverseBF(fn) {
    let temp = [];
    let results = [];
    temp.push(this.root);
    while (temp.length > 0) {
      let item = temp.shift();
      fn(item);
      results.push(item);

      temp.push(...item.children);
    }
    return results;
  }

  traverseDF(fn) {
    let temp = [];
    let results = [];
    temp.push(this.root);
    while (temp.length > 0) {
      let item = temp.shift();
      fn(item);
      results.push(item);

      temp.unshift(...item.children);
    }
    return results;
  }
}

module.exports = { Tree, Node };
