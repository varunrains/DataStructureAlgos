var printAllPositions = function (a, ele, i = 0) {
  if (i === a.length) {
    //console.log("Element Not found!!");
    return;
  }

  if (a[i] === ele) {
    console.log(i);
    //return;
    //return i;
  }

  return printAllPositions(a, ele, i + 1);
};

printAllPositions([1, 2, 2, 2, 2, 3], 2);
