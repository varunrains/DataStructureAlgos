class Node {
  constructor(value) {
    this.value = value;
    this.right = null;
    this.left = null;
  }
}

class BinarySearchTree {
  constructor() {
    this.root = null;
  }

  //Write down the simple steps in the book
  //Then it will be easy to code and also
  //to navigate between the right and left nodes of a tree.
  insert(value) {
    const newNode = new Node(value);
    if (this.root == null) {
      this.root = newNode;
      return this;
    }
    let temp = this.root;
    while (true) {
      if (this.root.value == newNode.value) return undefined;
      if (newNode.value < temp.value) {
        if (temp.left == null) {
          temp.left = newNode;
          return this;
        } else {
          temp = temp.left;
        }
      } else if (newNode.value > temp.value) {
        if (temp.right == null) {
          temp.right = newNode;
          return this;
        } else {
          temp = temp.right;
        }
      }
    }
  }

  contains(value){
    if(this.root == null) return false;
    let temp = this.root;
    while(temp){
      if(value < temp.value){
        temp = temp.left;
      }
      else if(value > temp.value){
        temp = temp.right;
      }
      else{
        return true;
      }
    }
    return false;
  }

  //written the current node
  minNodeValue(node){
    //The below check is not required as we are passing the node
    //to this function. No need to check for the root node.
    //if(this.root == null) return undefined;

    let temp = node;
    while(temp.left != null){
      temp = temp.left;
    }
    return temp;
  }
}

var myBst = new BinarySearchTree();
myBst.insert(20);
myBst.insert(10);
myBst.insert(30);
myBst.insert(5);
myBst.insert(11);
myBst.insert(27);
myBst.insert(33);
var containsValue = myBst.contains(5);
var minValue = myBst.minNodeValue(myBst.root.right);
console.log(containsValue);
console.log(minValue);
console.log(myBst);
