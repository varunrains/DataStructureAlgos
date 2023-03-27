class HashTable {
  constructor(size = 7) {
    this.dataMap = new Array(size);
  }

  //Underscore at the begining of the function tells other developers
  //that this function should not be called directly (kind of private)
  _hash(key) {
    let hash = 0;
    for (let i = 0; i < key.length; i++) {
        //23 because to make it look even more random (some constant value)
      hash = (hash + key.charCodeAt(i) * 23) % this.dataMap.length;
    }
    return hash;
  }

  set(key, value) {}
}
