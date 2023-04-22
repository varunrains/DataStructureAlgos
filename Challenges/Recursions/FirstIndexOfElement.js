var firstIndex = function (a, ele, i = 0) {
  if (i === a.length) {
    return -1;
  }

  if (a[i] === ele) {
    return i;
  }

  return firstIndex(a, ele, i + 1);
};

firstIndex([1, 2, 2, 2, 3], 2);
